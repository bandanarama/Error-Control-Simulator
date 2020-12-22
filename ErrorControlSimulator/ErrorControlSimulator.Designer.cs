using MaterialSkin.Controls;

namespace ErrorControlSimulator
{
    partial class ErrorControlSimulator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtServerSaveAs = new MaterialSkin.Controls.MaterialTextBox();
            this.lblSaveAs = new MaterialSkin.Controls.MaterialLabel();
            this.gbFileProperties = new System.Windows.Forms.GroupBox();
            this.lblFileBytes = new MaterialSkin.Controls.MaterialLabel();
            this.label6 = new MaterialSkin.Controls.MaterialLabel();
            this.lblFileName = new MaterialSkin.Controls.MaterialLabel();
            this.label4 = new MaterialSkin.Controls.MaterialLabel();
            this.btnFileSelector = new MaterialSkin.Controls.MaterialButton();
            this.txtPort = new MaterialSkin.Controls.MaterialTextBox();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtIpAddress = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.rbClient = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbServer = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnInitiate = new MaterialSkin.Controls.MaterialButton();
            this.btnSend = new MaterialSkin.Controls.MaterialButton();
            this.ofdInput = new System.Windows.Forms.OpenFileDialog();
            this.gbProtocol = new System.Windows.Forms.GroupBox();
            this.rbGBN = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbSaw = new MaterialSkin.Controls.MaterialRadioButton();
            this.sfDialog = new System.Windows.Forms.SaveFileDialog();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.lblMinFrames = new MaterialSkin.Controls.MaterialLabel();
            this.label16 = new MaterialSkin.Controls.MaterialLabel();
            this.lblWindowSizeUom = new MaterialSkin.Controls.MaterialLabel();
            this.lblMaxPayloadSize = new MaterialSkin.Controls.MaterialLabel();
            this.label11 = new MaterialSkin.Controls.MaterialLabel();
            this.numWindowSize = new System.Windows.Forms.NumericUpDown();
            this.label10 = new MaterialSkin.Controls.MaterialLabel();
            this.label9 = new MaterialSkin.Controls.MaterialLabel();
            this.lblWindowSize = new MaterialSkin.Controls.MaterialLabel();
            this.numMaxDataSize = new System.Windows.Forms.NumericUpDown();
            this.label8 = new MaterialSkin.Controls.MaterialLabel();
            this.label5 = new MaterialSkin.Controls.MaterialLabel();
            this.numPacketLoss = new System.Windows.Forms.NumericUpDown();
            this.btnClear = new MaterialSkin.Controls.MaterialButton();
            this.btnSaveLog = new MaterialSkin.Controls.MaterialButton();
            this.gbStatistics = new System.Windows.Forms.GroupBox();
            this.lblFileSize = new MaterialSkin.Controls.MaterialLabel();
            this.label17 = new MaterialSkin.Controls.MaterialLabel();
            this.lblTransferTime = new MaterialSkin.Controls.MaterialLabel();
            this.lblLossPercentage = new MaterialSkin.Controls.MaterialLabel();
            this.lblLossLabel = new MaterialSkin.Controls.MaterialLabel();
            this.label15 = new MaterialSkin.Controls.MaterialLabel();
            this.lblErrorFrames = new MaterialSkin.Controls.MaterialLabel();
            this.lblErrorLabel = new MaterialSkin.Controls.MaterialLabel();
            this.lblSuccessFrames = new MaterialSkin.Controls.MaterialLabel();
            this.lblSuccessLabel = new MaterialSkin.Controls.MaterialLabel();
            this.lblTotalFrames = new MaterialSkin.Controls.MaterialLabel();
            this.label7 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxContextMenuStrip1 = new MaterialSkin.Controls.TextBoxContextMenuStrip();
            this.txtLog = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.textBoxContextMenuStrip2 = new MaterialSkin.Controls.TextBoxContextMenuStrip();
            this.btnFooter = new MaterialSkin.Controls.MaterialButton();
            this.pbProgress = new MaterialSkin.Controls.MaterialProgressBar();
            this.groupBox1.SuspendLayout();
            this.gbFileProperties.SuspendLayout();
            this.gbProtocol.SuspendLayout();
            this.gbOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxDataSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPacketLoss)).BeginInit();
            this.gbStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(12, 508);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Log:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtServerSaveAs);
            this.groupBox1.Controls.Add(this.lblSaveAs);
            this.groupBox1.Controls.Add(this.gbFileProperties);
            this.groupBox1.Controls.Add(this.btnFileSelector);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIpAddress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbClient);
            this.groupBox1.Controls.Add(this.rbServer);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(998, 177);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode Selection";
            // 
            // txtServerSaveAs
            // 
            this.txtServerSaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServerSaveAs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServerSaveAs.Depth = 0;
            this.txtServerSaveAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtServerSaveAs.Location = new System.Drawing.Point(265, 86);
            this.txtServerSaveAs.MaxLength = 500;
            this.txtServerSaveAs.MouseState = MaterialSkin.MouseState.OUT;
            this.txtServerSaveAs.Multiline = false;
            this.txtServerSaveAs.Name = "txtServerSaveAs";
            this.txtServerSaveAs.Size = new System.Drawing.Size(727, 50);
            this.txtServerSaveAs.TabIndex = 10;
            this.txtServerSaveAs.Text = "C:\\Temp\\COSC635_P2_DataRecieved.txt";
            // 
            // lblSaveAs
            // 
            this.lblSaveAs.AutoSize = true;
            this.lblSaveAs.Depth = 0;
            this.lblSaveAs.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSaveAs.Location = new System.Drawing.Point(262, 64);
            this.lblSaveAs.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSaveAs.Name = "lblSaveAs";
            this.lblSaveAs.Size = new System.Drawing.Size(58, 19);
            this.lblSaveAs.TabIndex = 10;
            this.lblSaveAs.Text = "Save As";
            // 
            // gbFileProperties
            // 
            this.gbFileProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFileProperties.Controls.Add(this.lblFileBytes);
            this.gbFileProperties.Controls.Add(this.label6);
            this.gbFileProperties.Controls.Add(this.lblFileName);
            this.gbFileProperties.Controls.Add(this.label4);
            this.gbFileProperties.Location = new System.Drawing.Point(390, 13);
            this.gbFileProperties.Name = "gbFileProperties";
            this.gbFileProperties.Size = new System.Drawing.Size(602, 75);
            this.gbFileProperties.TabIndex = 7;
            this.gbFileProperties.TabStop = false;
            this.gbFileProperties.Text = "File Properties";
            this.gbFileProperties.Visible = false;
            // 
            // lblFileBytes
            // 
            this.lblFileBytes.AutoSize = true;
            this.lblFileBytes.Depth = 0;
            this.lblFileBytes.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFileBytes.Location = new System.Drawing.Point(86, 50);
            this.lblFileBytes.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFileBytes.Name = "lblFileBytes";
            this.lblFileBytes.Size = new System.Drawing.Size(65, 19);
            this.lblFileBytes.TabIndex = 3;
            this.lblFileBytes.Text = "                ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Depth = 0;
            this.label6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.Location = new System.Drawing.Point(6, 50);
            this.label6.MouseState = MaterialSkin.MouseState.HOVER;
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "File Size: ";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Depth = 0;
            this.lblFileName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFileName.Location = new System.Drawing.Point(86, 16);
            this.lblFileName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(65, 19);
            this.lblFileName.TabIndex = 1;
            this.lblFileName.Text = "                ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Depth = 0;
            this.label4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.MouseState = MaterialSkin.MouseState.HOVER;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "File Name: ";
            // 
            // btnFileSelector
            // 
            this.btnFileSelector.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFileSelector.Depth = 0;
            this.btnFileSelector.DrawShadows = true;
            this.btnFileSelector.HighEmphasis = true;
            this.btnFileSelector.Icon = null;
            this.btnFileSelector.Location = new System.Drawing.Point(265, 19);
            this.btnFileSelector.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFileSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFileSelector.Name = "btnFileSelector";
            this.btnFileSelector.Size = new System.Drawing.Size(118, 36);
            this.btnFileSelector.TabIndex = 6;
            this.btnFileSelector.Text = "Select File...";
            this.btnFileSelector.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFileSelector.UseAccentColor = false;
            this.btnFileSelector.UseVisualStyleBackColor = true;
            this.btnFileSelector.Visible = false;
            this.btnFileSelector.Click += new System.EventHandler(this.btnFileSelector_Click);
            // 
            // txtPort
            // 
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPort.Depth = 0;
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPort.Location = new System.Drawing.Point(174, 85);
            this.txtPort.MaxLength = 50;
            this.txtPort.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPort.Multiline = false;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(85, 50);
            this.txtPort.TabIndex = 5;
            this.txtPort.Text = "27600";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(174, 63);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Port";
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIpAddress.Depth = 0;
            this.txtIpAddress.Enabled = false;
            this.txtIpAddress.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtIpAddress.Location = new System.Drawing.Point(6, 86);
            this.txtIpAddress.MaxLength = 50;
            this.txtIpAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIpAddress.Multiline = false;
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(162, 50);
            this.txtIpAddress.TabIndex = 3;
            this.txtIpAddress.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP Address";
            // 
            // rbClient
            // 
            this.rbClient.AutoSize = true;
            this.rbClient.Depth = 0;
            this.rbClient.Location = new System.Drawing.Point(116, 19);
            this.rbClient.Margin = new System.Windows.Forms.Padding(0);
            this.rbClient.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbClient.Name = "rbClient";
            this.rbClient.Ripple = true;
            this.rbClient.Size = new System.Drawing.Size(75, 37);
            this.rbClient.TabIndex = 1;
            this.rbClient.TabStop = true;
            this.rbClient.Text = "Client";
            this.rbClient.UseVisualStyleBackColor = true;
            this.rbClient.CheckedChanged += new System.EventHandler(this.rbClient_CheckedChanged);
            // 
            // rbServer
            // 
            this.rbServer.AutoSize = true;
            this.rbServer.Checked = true;
            this.rbServer.Depth = 0;
            this.rbServer.Location = new System.Drawing.Point(6, 19);
            this.rbServer.Margin = new System.Windows.Forms.Padding(0);
            this.rbServer.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbServer.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbServer.Name = "rbServer";
            this.rbServer.Ripple = true;
            this.rbServer.Size = new System.Drawing.Size(79, 37);
            this.rbServer.TabIndex = 0;
            this.rbServer.TabStop = true;
            this.rbServer.Text = "Server";
            this.rbServer.UseVisualStyleBackColor = true;
            this.rbServer.CheckedChanged += new System.EventHandler(this.rbServer_CheckedChanged);
            // 
            // btnInitiate
            // 
            this.btnInitiate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInitiate.Depth = 0;
            this.btnInitiate.DrawShadows = true;
            this.btnInitiate.HighEmphasis = true;
            this.btnInitiate.Icon = null;
            this.btnInitiate.Location = new System.Drawing.Point(643, 256);
            this.btnInitiate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInitiate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInitiate.Name = "btnInitiate";
            this.btnInitiate.Size = new System.Drawing.Size(70, 36);
            this.btnInitiate.TabIndex = 4;
            this.btnInitiate.Text = "Listen";
            this.btnInitiate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInitiate.UseAccentColor = false;
            this.btnInitiate.UseVisualStyleBackColor = true;
            this.btnInitiate.Click += new System.EventHandler(this.btnInitiate_Click);
            // 
            // btnSend
            // 
            this.btnSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSend.Depth = 0;
            this.btnSend.DrawShadows = true;
            this.btnSend.HighEmphasis = true;
            this.btnSend.Icon = null;
            this.btnSend.Location = new System.Drawing.Point(643, 304);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSend.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(59, 36);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSend.UseAccentColor = false;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Visible = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // gbProtocol
            // 
            this.gbProtocol.Controls.Add(this.rbGBN);
            this.gbProtocol.Controls.Add(this.rbSaw);
            this.gbProtocol.Location = new System.Drawing.Point(12, 256);
            this.gbProtocol.Name = "gbProtocol";
            this.gbProtocol.Size = new System.Drawing.Size(200, 201);
            this.gbProtocol.TabIndex = 6;
            this.gbProtocol.TabStop = false;
            this.gbProtocol.Text = "Protocol";
            this.gbProtocol.Visible = false;
            // 
            // rbGBN
            // 
            this.rbGBN.AutoSize = true;
            this.rbGBN.Depth = 0;
            this.rbGBN.Location = new System.Drawing.Point(6, 56);
            this.rbGBN.Margin = new System.Windows.Forms.Padding(0);
            this.rbGBN.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbGBN.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbGBN.Name = "rbGBN";
            this.rbGBN.Ripple = true;
            this.rbGBN.Size = new System.Drawing.Size(156, 37);
            this.rbGBN.TabIndex = 8;
            this.rbGBN.Text = "Go-Back-N (GBN)";
            this.rbGBN.UseVisualStyleBackColor = true;
            this.rbGBN.CheckedChanged += new System.EventHandler(this.rbGBN_CheckedChanged);
            // 
            // rbSaw
            // 
            this.rbSaw.AutoSize = true;
            this.rbSaw.Checked = true;
            this.rbSaw.Depth = 0;
            this.rbSaw.Location = new System.Drawing.Point(6, 19);
            this.rbSaw.Margin = new System.Windows.Forms.Padding(0);
            this.rbSaw.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbSaw.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbSaw.Name = "rbSaw";
            this.rbSaw.Ripple = true;
            this.rbSaw.Size = new System.Drawing.Size(185, 37);
            this.rbSaw.TabIndex = 7;
            this.rbSaw.TabStop = true;
            this.rbSaw.Text = "Stop-And-Wait (SAW)";
            this.rbSaw.UseVisualStyleBackColor = true;
            this.rbSaw.CheckedChanged += new System.EventHandler(this.rbSaw_CheckedChanged);
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.lblMinFrames);
            this.gbOptions.Controls.Add(this.label16);
            this.gbOptions.Controls.Add(this.lblWindowSizeUom);
            this.gbOptions.Controls.Add(this.lblMaxPayloadSize);
            this.gbOptions.Controls.Add(this.label11);
            this.gbOptions.Controls.Add(this.numWindowSize);
            this.gbOptions.Controls.Add(this.label10);
            this.gbOptions.Controls.Add(this.label9);
            this.gbOptions.Controls.Add(this.lblWindowSize);
            this.gbOptions.Controls.Add(this.numMaxDataSize);
            this.gbOptions.Controls.Add(this.label8);
            this.gbOptions.Controls.Add(this.label5);
            this.gbOptions.Controls.Add(this.numPacketLoss);
            this.gbOptions.Location = new System.Drawing.Point(218, 256);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(418, 201);
            this.gbOptions.TabIndex = 7;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            this.gbOptions.Visible = false;
            // 
            // lblMinFrames
            // 
            this.lblMinFrames.AutoSize = true;
            this.lblMinFrames.Depth = 0;
            this.lblMinFrames.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMinFrames.Location = new System.Drawing.Point(270, 121);
            this.lblMinFrames.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMinFrames.Name = "lblMinFrames";
            this.lblMinFrames.Size = new System.Drawing.Size(67, 19);
            this.lblMinFrames.TabIndex = 12;
            this.lblMinFrames.Text = "0 Frames";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Depth = 0;
            this.label16.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label16.Location = new System.Drawing.Point(6, 121);
            this.label16.MouseState = MaterialSkin.MouseState.HOVER;
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(249, 19);
            this.label16.TabIndex = 11;
            this.label16.Text = "Min Frames to Transfer (Error Free)";
            // 
            // lblWindowSizeUom
            // 
            this.lblWindowSizeUom.AutoSize = true;
            this.lblWindowSizeUom.Depth = 0;
            this.lblWindowSizeUom.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblWindowSizeUom.Location = new System.Drawing.Point(352, 155);
            this.lblWindowSizeUom.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWindowSizeUom.Name = "lblWindowSizeUom";
            this.lblWindowSizeUom.Size = new System.Drawing.Size(51, 19);
            this.lblWindowSizeUom.TabIndex = 10;
            this.lblWindowSizeUom.Text = "frames";
            this.lblWindowSizeUom.Visible = false;
            // 
            // lblMaxPayloadSize
            // 
            this.lblMaxPayloadSize.AutoSize = true;
            this.lblMaxPayloadSize.Depth = 0;
            this.lblMaxPayloadSize.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMaxPayloadSize.Location = new System.Drawing.Point(270, 90);
            this.lblMaxPayloadSize.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMaxPayloadSize.Name = "lblMaxPayloadSize";
            this.lblMaxPayloadSize.Size = new System.Drawing.Size(79, 19);
            this.lblMaxPayloadSize.TabIndex = 7;
            this.lblMaxPayloadSize.Text = "1000 bytes";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Depth = 0;
            this.label11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label11.Location = new System.Drawing.Point(352, 25);
            this.label11.MouseState = MaterialSkin.MouseState.HOVER;
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 19);
            this.label11.TabIndex = 6;
            this.label11.Text = "%";
            // 
            // numWindowSize
            // 
            this.numWindowSize.Location = new System.Drawing.Point(270, 154);
            this.numWindowSize.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numWindowSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWindowSize.Name = "numWindowSize";
            this.numWindowSize.Size = new System.Drawing.Size(76, 20);
            this.numWindowSize.TabIndex = 9;
            this.numWindowSize.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numWindowSize.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Depth = 0;
            this.label10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label10.Location = new System.Drawing.Point(352, 56);
            this.label10.MouseState = MaterialSkin.MouseState.HOVER;
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 19);
            this.label10.TabIndex = 5;
            this.label10.Text = "bytes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Depth = 0;
            this.label9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label9.Location = new System.Drawing.Point(6, 90);
            this.label9.MouseState = MaterialSkin.MouseState.HOVER;
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(244, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "Max Payload Size (Data + Header)";
            // 
            // lblWindowSize
            // 
            this.lblWindowSize.AutoSize = true;
            this.lblWindowSize.Depth = 0;
            this.lblWindowSize.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblWindowSize.Location = new System.Drawing.Point(6, 156);
            this.lblWindowSize.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWindowSize.Name = "lblWindowSize";
            this.lblWindowSize.Size = new System.Drawing.Size(92, 19);
            this.lblWindowSize.TabIndex = 8;
            this.lblWindowSize.Text = "Window Size";
            this.lblWindowSize.Visible = false;
            // 
            // numMaxDataSize
            // 
            this.numMaxDataSize.Location = new System.Drawing.Point(270, 55);
            this.numMaxDataSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMaxDataSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxDataSize.Name = "numMaxDataSize";
            this.numMaxDataSize.Size = new System.Drawing.Size(76, 20);
            this.numMaxDataSize.TabIndex = 3;
            this.numMaxDataSize.Value = new decimal(new int[] {
            996,
            0,
            0,
            0});
            this.numMaxDataSize.ValueChanged += new System.EventHandler(this.numMaxDataSize_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Depth = 0;
            this.label8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label8.Location = new System.Drawing.Point(6, 57);
            this.label8.MouseState = MaterialSkin.MouseState.HOVER;
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Max Data Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Depth = 0;
            this.label5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.MouseState = MaterialSkin.MouseState.HOVER;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Packet Loss";
            // 
            // numPacketLoss
            // 
            this.numPacketLoss.Location = new System.Drawing.Point(270, 23);
            this.numPacketLoss.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numPacketLoss.Name = "numPacketLoss";
            this.numPacketLoss.Size = new System.Drawing.Size(76, 20);
            this.numPacketLoss.TabIndex = 0;
            this.numPacketLoss.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Depth = 0;
            this.btnClear.DrawShadows = true;
            this.btnClear.HighEmphasis = true;
            this.btnClear.Icon = null;
            this.btnClear.Location = new System.Drawing.Point(878, 491);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(66, 36);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClear.UseAccentColor = false;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveLog
            // 
            this.btnSaveLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveLog.Depth = 0;
            this.btnSaveLog.DrawShadows = true;
            this.btnSaveLog.HighEmphasis = true;
            this.btnSaveLog.Icon = null;
            this.btnSaveLog.Location = new System.Drawing.Point(952, 491);
            this.btnSaveLog.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveLog.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveLog.Name = "btnSaveLog";
            this.btnSaveLog.Size = new System.Drawing.Size(58, 36);
            this.btnSaveLog.TabIndex = 9;
            this.btnSaveLog.Text = "Save";
            this.btnSaveLog.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveLog.UseAccentColor = false;
            this.btnSaveLog.UseVisualStyleBackColor = true;
            this.btnSaveLog.Click += new System.EventHandler(this.btnSaveLog_Click);
            // 
            // gbStatistics
            // 
            this.gbStatistics.Controls.Add(this.lblFileSize);
            this.gbStatistics.Controls.Add(this.label17);
            this.gbStatistics.Controls.Add(this.lblTransferTime);
            this.gbStatistics.Controls.Add(this.lblLossPercentage);
            this.gbStatistics.Controls.Add(this.lblLossLabel);
            this.gbStatistics.Controls.Add(this.label15);
            this.gbStatistics.Controls.Add(this.lblErrorFrames);
            this.gbStatistics.Controls.Add(this.lblErrorLabel);
            this.gbStatistics.Controls.Add(this.lblSuccessFrames);
            this.gbStatistics.Controls.Add(this.lblSuccessLabel);
            this.gbStatistics.Controls.Add(this.lblTotalFrames);
            this.gbStatistics.Controls.Add(this.label7);
            this.gbStatistics.Location = new System.Drawing.Point(738, 256);
            this.gbStatistics.Name = "gbStatistics";
            this.gbStatistics.Size = new System.Drawing.Size(272, 201);
            this.gbStatistics.TabIndex = 10;
            this.gbStatistics.TabStop = false;
            this.gbStatistics.Text = "Transfer Statistics";
            this.gbStatistics.Visible = false;
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Depth = 0;
            this.lblFileSize.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFileSize.Location = new System.Drawing.Point(166, 25);
            this.lblFileSize.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(93, 19);
            this.lblFileSize.TabIndex = 11;
            this.lblFileSize.Text = "                       ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Depth = 0;
            this.label17.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label17.Location = new System.Drawing.Point(6, 25);
            this.label17.MouseState = MaterialSkin.MouseState.HOVER;
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 19);
            this.label17.TabIndex = 10;
            this.label17.Text = "File Size: ";
            // 
            // lblTransferTime
            // 
            this.lblTransferTime.AutoSize = true;
            this.lblTransferTime.Depth = 0;
            this.lblTransferTime.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTransferTime.Location = new System.Drawing.Point(166, 54);
            this.lblTransferTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTransferTime.Name = "lblTransferTime";
            this.lblTransferTime.Size = new System.Drawing.Size(93, 19);
            this.lblTransferTime.TabIndex = 9;
            this.lblTransferTime.Text = "                       ";
            // 
            // lblLossPercentage
            // 
            this.lblLossPercentage.AutoSize = true;
            this.lblLossPercentage.Depth = 0;
            this.lblLossPercentage.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLossPercentage.Location = new System.Drawing.Point(166, 162);
            this.lblLossPercentage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLossPercentage.Name = "lblLossPercentage";
            this.lblLossPercentage.Size = new System.Drawing.Size(93, 19);
            this.lblLossPercentage.TabIndex = 7;
            this.lblLossPercentage.Text = "                       ";
            // 
            // lblLossLabel
            // 
            this.lblLossLabel.AutoSize = true;
            this.lblLossLabel.Depth = 0;
            this.lblLossLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLossLabel.Location = new System.Drawing.Point(6, 162);
            this.lblLossLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLossLabel.Name = "lblLossLabel";
            this.lblLossLabel.Size = new System.Drawing.Size(126, 19);
            this.lblLossLabel.TabIndex = 6;
            this.lblLossLabel.Text = "Loss Percentage: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Depth = 0;
            this.label15.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label15.Location = new System.Drawing.Point(6, 54);
            this.label15.MouseState = MaterialSkin.MouseState.HOVER;
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 19);
            this.label15.TabIndex = 8;
            this.label15.Text = "Transfer Time: ";
            // 
            // lblErrorFrames
            // 
            this.lblErrorFrames.AutoSize = true;
            this.lblErrorFrames.Depth = 0;
            this.lblErrorFrames.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblErrorFrames.Location = new System.Drawing.Point(166, 134);
            this.lblErrorFrames.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblErrorFrames.Name = "lblErrorFrames";
            this.lblErrorFrames.Size = new System.Drawing.Size(93, 19);
            this.lblErrorFrames.TabIndex = 5;
            this.lblErrorFrames.Text = "                       ";
            // 
            // lblErrorLabel
            // 
            this.lblErrorLabel.AutoSize = true;
            this.lblErrorLabel.Depth = 0;
            this.lblErrorLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblErrorLabel.Location = new System.Drawing.Point(6, 134);
            this.lblErrorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblErrorLabel.Name = "lblErrorLabel";
            this.lblErrorLabel.Size = new System.Drawing.Size(99, 19);
            this.lblErrorLabel.TabIndex = 4;
            this.lblErrorLabel.Text = "Error Frames: ";
            // 
            // lblSuccessFrames
            // 
            this.lblSuccessFrames.AutoSize = true;
            this.lblSuccessFrames.Depth = 0;
            this.lblSuccessFrames.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSuccessFrames.Location = new System.Drawing.Point(166, 109);
            this.lblSuccessFrames.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSuccessFrames.Name = "lblSuccessFrames";
            this.lblSuccessFrames.Size = new System.Drawing.Size(93, 19);
            this.lblSuccessFrames.TabIndex = 3;
            this.lblSuccessFrames.Text = "                       ";
            // 
            // lblSuccessLabel
            // 
            this.lblSuccessLabel.AutoSize = true;
            this.lblSuccessLabel.Depth = 0;
            this.lblSuccessLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSuccessLabel.Location = new System.Drawing.Point(6, 109);
            this.lblSuccessLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSuccessLabel.Name = "lblSuccessLabel";
            this.lblSuccessLabel.Size = new System.Drawing.Size(140, 19);
            this.lblSuccessLabel.TabIndex = 2;
            this.lblSuccessLabel.Text = "Successful Frames:";
            // 
            // lblTotalFrames
            // 
            this.lblTotalFrames.AutoSize = true;
            this.lblTotalFrames.Depth = 0;
            this.lblTotalFrames.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotalFrames.Location = new System.Drawing.Point(166, 83);
            this.lblTotalFrames.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalFrames.Name = "lblTotalFrames";
            this.lblTotalFrames.Size = new System.Drawing.Size(93, 19);
            this.lblTotalFrames.TabIndex = 1;
            this.lblTotalFrames.Text = "                       ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Depth = 0;
            this.label7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.Location = new System.Drawing.Point(6, 83);
            this.label7.MouseState = MaterialSkin.MouseState.HOVER;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total Frames: ";
            // 
            // textBoxContextMenuStrip1
            // 
            this.textBoxContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.textBoxContextMenuStrip1.Depth = 0;
            this.textBoxContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxContextMenuStrip1.Name = "textBoxContextMenuStrip1";
            this.textBoxContextMenuStrip1.Size = new System.Drawing.Size(123, 160);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Depth = 0;
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtLog.Hint = "";
            this.txtLog.Location = new System.Drawing.Point(12, 536);
            this.txtLog.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(998, 188);
            this.txtLog.TabIndex = 11;
            this.txtLog.Text = "";
            // 
            // textBoxContextMenuStrip2
            // 
            this.textBoxContextMenuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.textBoxContextMenuStrip2.Depth = 0;
            this.textBoxContextMenuStrip2.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxContextMenuStrip2.Name = "textBoxContextMenuStrip2";
            this.textBoxContextMenuStrip2.Size = new System.Drawing.Size(123, 160);
            // 
            // btnFooter
            // 
            this.btnFooter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFooter.Depth = 0;
            this.btnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFooter.DrawShadows = true;
            this.btnFooter.HighEmphasis = true;
            this.btnFooter.Icon = null;
            this.btnFooter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFooter.Location = new System.Drawing.Point(0, 733);
            this.btnFooter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFooter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFooter.Name = "btnFooter";
            this.btnFooter.Size = new System.Drawing.Size(1022, 36);
            this.btnFooter.TabIndex = 13;
            this.btnFooter.Text = "COSC 635 - P2T2 - John Fore, Brenton Kinney, Kyle Voon, Asif Mehboob";
            this.btnFooter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFooter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFooter.UseAccentColor = false;
            this.btnFooter.UseVisualStyleBackColor = true;
            // 
            // pbProgress
            // 
            this.pbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProgress.Depth = 0;
            this.pbProgress.Location = new System.Drawing.Point(12, 477);
            this.pbProgress.MouseState = MaterialSkin.MouseState.HOVER;
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(998, 5);
            this.pbProgress.Step = 1;
            this.pbProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbProgress.TabIndex = 14;
            this.pbProgress.Visible = false;
            // 
            // ErrorControlSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 769);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.btnFooter);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.gbStatistics);
            this.Controls.Add(this.btnSaveLog);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.gbProtocol);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnInitiate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ErrorControlSimulator";
            this.Text = "ERROR CONTROL SIMULATOR";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbFileProperties.ResumeLayout(false);
            this.gbFileProperties.PerformLayout();
            this.gbProtocol.ResumeLayout(false);
            this.gbProtocol.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWindowSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxDataSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPacketLoss)).EndInit();
            this.gbStatistics.ResumeLayout(false);
            this.gbStatistics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialLabel label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialRadioButton rbClient;
        private MaterialRadioButton rbServer;
        private MaterialTextBox txtPort;
        private MaterialLabel label3;
        private MaterialTextBox txtIpAddress;
        private MaterialLabel label2;
        private MaterialButton btnInitiate;
        private MaterialButton btnSend;
        private MaterialButton btnFileSelector;
        private System.Windows.Forms.OpenFileDialog ofdInput;
        private System.Windows.Forms.GroupBox gbFileProperties;
        private MaterialLabel lblFileBytes;
        private MaterialLabel label6;
        private MaterialLabel lblFileName;
        private MaterialLabel label4;
        private System.Windows.Forms.GroupBox gbProtocol;
        private MaterialRadioButton rbGBN;
        private MaterialRadioButton rbSaw;
        private System.Windows.Forms.SaveFileDialog sfDialog;
        private System.Windows.Forms.GroupBox gbOptions;
        private MaterialLabel label5;
        private System.Windows.Forms.NumericUpDown numPacketLoss;
        private MaterialButton btnClear;
        private MaterialButton btnSaveLog;
        private MaterialTextBox txtServerSaveAs;
        private MaterialLabel lblSaveAs;
        private System.Windows.Forms.GroupBox gbStatistics;
        private MaterialLabel label7;
        private MaterialLabel lblTotalFrames;
        private MaterialLabel lblTransferTime;
        private MaterialLabel label15;
        private MaterialLabel lblLossPercentage;
        private MaterialLabel lblLossLabel;
        private MaterialLabel lblErrorFrames;
        private MaterialLabel lblErrorLabel;
        private MaterialLabel lblSuccessFrames;
        private MaterialLabel lblSuccessLabel;
        private MaterialLabel lblWindowSizeUom;
        private System.Windows.Forms.NumericUpDown numWindowSize;
        private MaterialLabel lblWindowSize;
        private MaterialLabel lblMaxPayloadSize;
        private MaterialLabel label11;
        private MaterialLabel label10;
        private MaterialLabel label9;
        private System.Windows.Forms.NumericUpDown numMaxDataSize;
        private MaterialLabel label8;
        private MaterialLabel lblMinFrames;
        private MaterialLabel label16;
        private MaterialLabel lblFileSize;
        private MaterialLabel label17;
        private MaterialSkin.Controls.TextBoxContextMenuStrip textBoxContextMenuStrip1;
        private MaterialMultiLineTextBox txtLog;
        private TextBoxContextMenuStrip textBoxContextMenuStrip2;
        private MaterialButton btnFooter;
        private MaterialProgressBar pbProgress;
    }
}

