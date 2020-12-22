using ErrorControlSimulator.DTO;
using ErrorControlSimulator.Provider;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using static ErrorControlSimulator.Enumerations.Enumerations;

namespace ErrorControlSimulator
{
    public partial class ErrorControlSimulator : MaterialForm
    {
        private string machineIpAddress = string.Empty;
        private bool isServerMode = true;
        private string textToSend = string.Empty;
        private Server server;
        private Client client;
        private int _maxDataSize = 988;

        #region Initialize

        public ErrorControlSimulator()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            Initialize();
        }

        private void Initialize()
        {
            var hostname = Dns.GetHostName();
            var ipEntry = Dns.GetHostEntry(hostname);
            var internetIpEntry = ipEntry.AddressList.FirstOrDefault(a => a.AddressFamily == AddressFamily.InterNetwork);
            if (internetIpEntry == null)
            {
                LogError("Internet IP Address could not be resolved.");
            }
            machineIpAddress = internetIpEntry.ToString();
            txtIpAddress.Text = machineIpAddress;
            LogInfo($"Current Machine IP Address: {txtIpAddress.Text}");
        }

        #endregion

        #region Private Methods

        private void Client_Progress(int current, int total)
        {
            pbProgress.SetPropertyThreadSafe(() => pbProgress.Value, current * 100 / total);
            Application.DoEvents();
        }

        private void Socket_Log(string response)
        {
            LogInfo(response);
        }

        private void Server_Clear()
        {
            gbStatistics.SetPropertyThreadSafe(() => gbStatistics.Visible, false);
            txtLog.SetPropertyThreadSafe(() => txtLog.Text, string.Empty);
        }

        private void Socket_Stats(TransferStatistics stats)
        {
            gbStatistics.SetPropertyThreadSafe(() => gbStatistics.Visible, true);
            lblTotalFrames.SetPropertyThreadSafe(() => lblTotalFrames.Text, stats.TotalFrames.ToString());
            if (!isServerMode)
            {
                lblSuccessLabel.SetPropertyThreadSafe(() => lblSuccessLabel.Visible, true);
                lblSuccessFrames.SetPropertyThreadSafe(() => lblSuccessFrames.Visible, true);
                lblErrorLabel.SetPropertyThreadSafe(() => lblErrorLabel.Visible, true);
                lblErrorFrames.SetPropertyThreadSafe(() => lblErrorFrames.Visible, true);
                lblLossLabel.SetPropertyThreadSafe(() => lblLossLabel.Visible, true);
                lblLossPercentage.SetPropertyThreadSafe(() => lblLossPercentage.Visible, true);

                lblSuccessFrames.SetPropertyThreadSafe(() => lblSuccessFrames.Text, stats.SuccessFrames.Value.ToString());
                lblErrorFrames.SetPropertyThreadSafe(() => lblErrorFrames.Text, stats.ErrorFrames.Value.ToString());
                lblLossPercentage.SetPropertyThreadSafe(() => lblLossPercentage.Text, stats.LossPercentage.Value.ToString("0.00%"));
            }
            else
            {
                lblSuccessLabel.SetPropertyThreadSafe(() => lblSuccessLabel.Visible, false);
                lblSuccessFrames.SetPropertyThreadSafe(() => lblSuccessFrames.Visible, false);
                lblErrorLabel.SetPropertyThreadSafe(() => lblErrorLabel.Visible, false);
                lblErrorFrames.SetPropertyThreadSafe(() => lblErrorFrames.Visible, false);
                lblLossLabel.SetPropertyThreadSafe(() => lblLossLabel.Visible, false);
                lblLossPercentage.SetPropertyThreadSafe(() => lblLossPercentage.Visible, false);
            }
            lblTransferTime.SetPropertyThreadSafe(() => lblTransferTime.Text, stats.TotalTime.ToString("0.00") + " seconds");
            lblFileSize.SetPropertyThreadSafe(() => lblFileSize.Text, stats.FileSize.ToString() + " bytes");
        }

        private void UpdateFileProperties()
        {
            gbFileProperties.Visible = true;
            lblFileName.Text = ofdInput.FileName;
            lblFileBytes.Text = $"{Encoding.ASCII.GetBytes(textToSend).Length.ToString()} bytes";
            lblMinFrames.Text = $"{Math.Ceiling(decimal.Divide(textToSend.Length, numMaxDataSize.Value))} Frames";

            LogInfo($"Selected Input File: {lblFileName.Text} ({lblFileBytes.Text} bytes)");
        }

        #endregion

        #region Logger

        private void LogError(string message)
        {
            Log(message, LogType.Error);
        }

        private void LogInfo(string message)
        {
            Log(message, LogType.Info);
        }

        private string _txtLogText;
        private void Log(string message, LogType type)
        {
            var resolvedMessage = message;
            if (type == LogType.Error)
            {
                resolvedMessage = $"ERROR: {resolvedMessage}";
            }
            resolvedMessage = $"{DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss.fff")}    {resolvedMessage}{Environment.NewLine}";
            GetLogControlText();
            LogToLogControl($"{resolvedMessage}{_txtLogText}");
        }

        private void GetLogControlText()
        {
            if (txtLog.InvokeRequired)
            {
                Invoke(new Action(GetLogControlText));
            }
            else
            {
                _txtLogText = txtLog.Text;
            }
        }

        private void LogToLogControl(string message)
        {
            if (txtLog.InvokeRequired)
            {
                Invoke(new Action<string>(LogToLogControl), message);
            }
            else
            {
                txtLog.Text = message;
                Application.DoEvents();
            }
        }

        #endregion

        #region Event Handlers

        private void rbServer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbServer.Checked)
            {
                isServerMode = true;
                txtIpAddress.Text = machineIpAddress;
                txtIpAddress.Enabled = false;
                btnInitiate.Text = "Listen";
                btnInitiate.Enabled = true;
                btnFileSelector.Visible = false;
                gbProtocol.Visible = false;
                gbOptions.Visible = false;
                lblSaveAs.Visible = true;
                txtServerSaveAs.Visible = true;
                pbProgress.Visible = false;
            }
        }

        private void rbClient_CheckedChanged(object sender, EventArgs e)
        {
            if (rbClient.Checked)
            {
                isServerMode = false;
                txtIpAddress.Text = string.Empty;
                txtIpAddress.Enabled = true;
                btnInitiate.Text = "Connect";
                //btnInitiate.Enabled = false;
                btnFileSelector.Visible = true;
                gbProtocol.Visible = true;
                gbOptions.Visible = true;
                lblSaveAs.Visible = false;
                txtServerSaveAs.Visible = false;
                pbProgress.Visible = true;
            }
        }

        private void btnInitiate_Click(object sender, EventArgs e)
        {
            if (isServerMode)
            {
                server = new Server(machineIpAddress, int.Parse(txtPort.Text), txtServerSaveAs.Text);
                server.Log += Socket_Log;
                server.Stats += Socket_Stats;
                server.Clear += Server_Clear;
                server.Listen();
                btnInitiate.Enabled = false;
            }
            else
            {
                client = new Client(txtIpAddress.Text, int.Parse(txtPort.Text));
                client.Log += Socket_Log;
                client.Stats += Socket_Stats;
                client.Progress += Client_Progress;
                client.Connect();
                btnInitiate.Enabled = false;
                btnSend.Visible = true;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textToSend))
            {
                LogError("No data to send. Please make sure you have selected a file.");
                return;
            }
            gbStatistics.Visible = false;
            txtLog.Text = string.Empty;
            _maxDataSize = (int)numMaxDataSize.Value;
            var fileParts = Enumerable.Range(0, textToSend.Length / _maxDataSize).Select(i => textToSend.Substring(i * _maxDataSize, _maxDataSize)).ToList();
            gbStatistics.Visible = false;
            if (textToSend.Length > (textToSend.Length / _maxDataSize * _maxDataSize))
            {
                fileParts.Add(textToSend.Substring(textToSend.Length / _maxDataSize * _maxDataSize));
            }
            if (rbSaw.Checked)
            {
                client.CurrentProtocol = Protocol.SAW;
                client.InitiateSAWSend(fileParts.ToArray(), (int)numPacketLoss.Value);
            }
            if (rbGBN.Checked)
            {
                client.CurrentProtocol = Protocol.GBN;
                client.InitiateGBNSend(fileParts.ToArray(), (int)numPacketLoss.Value, (int)numWindowSize.Value);
            }
        }

        private void btnFileSelector_Click(object sender, EventArgs e)
        {
            if (ofdInput.ShowDialog() == DialogResult.OK)
            {
                textToSend = File.ReadAllText(ofdInput.FileName);
                UpdateFileProperties();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLog.Text = string.Empty;
        }
        private void btnSaveLog_Click(object sender, EventArgs e)
        {
            if (sfDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfDialog.FileName, txtLog.Text);
            }
        }

        private void numMaxDataSize_ValueChanged(object sender, EventArgs e)
        {
            lblMaxPayloadSize.Text = $"{numMaxDataSize.Value + 4} bytes";
            lblMinFrames.Text = $"{Math.Ceiling(decimal.Divide(textToSend.Length, numMaxDataSize.Value))} Frames";
        }

        private void rbSaw_CheckedChanged(object sender, EventArgs e)
        {
            lblWindowSize.Visible = false;
            numWindowSize.Visible = false;
            lblWindowSizeUom.Visible = false;
        }

        private void rbGBN_CheckedChanged(object sender, EventArgs e)
        {
            lblWindowSize.Visible = true;
            numWindowSize.Visible = true;
            lblWindowSizeUom.Visible = true;
        }

        #endregion
    }
}
