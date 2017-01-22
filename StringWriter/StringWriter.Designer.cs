namespace StringWriter
{
    partial class StringWriteForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StringWriteForm));
            this.addrLabel = new System.Windows.Forms.Label();
            this.addrNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.stringLabel = new System.Windows.Forms.Label();
            this.writerButton = new System.Windows.Forms.Button();
            this.msgTimer = new System.Windows.Forms.Timer(this.components);
            this.readSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.readButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.endNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.readRadioButton = new System.Windows.Forms.RadioButton();
            this.endRadioButton = new System.Windows.Forms.RadioButton();
            this.zeroButton = new System.Windows.Forms.Button();
            this.ASCIIRTB = new System.Windows.Forms.RichTextBox();
            this.byteRTB = new System.Windows.Forms.RichTextBox();
            this.byteLabel = new System.Windows.Forms.Label();
            this.byte2ASCIIButton = new System.Windows.Forms.Button();
            this.ASCII2byteButton = new System.Windows.Forms.Button();
            this.ASCIIAutoCheck = new System.Windows.Forms.CheckBox();
            this.byteAutoCheck = new System.Windows.Forms.CheckBox();
            this.unicodeLabel = new System.Windows.Forms.Label();
            this.unicodeRTB = new System.Windows.Forms.RichTextBox();
            this.unicode2byteButton = new System.Windows.Forms.Button();
            this.byte2unicodeButton = new System.Windows.Forms.Button();
            this.unicodeAutoCheck = new System.Windows.Forms.CheckBox();
            this.unicodeErrorTimer = new System.Windows.Forms.Timer(this.components);
            this.TCPBox = new System.Windows.Forms.GroupBox();
            this.DisconnButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.readASCIILabel = new System.Windows.Forms.Label();
            this.readASCIILengthLabel = new System.Windows.Forms.Label();
            this.currentASCIILengthLabel = new System.Windows.Forms.Label();
            this.currentByteLengthLabel = new System.Windows.Forms.Label();
            this.readByteLengthLabel = new System.Windows.Forms.Label();
            this.readByteLabel = new System.Windows.Forms.Label();
            this.readUnicodeLengthLabel = new System.Windows.Forms.Label();
            this.currentUnicodeLengthLabel = new System.Windows.Forms.Label();
            this.readUnicodeLabel = new System.Windows.Forms.Label();
            this.aboutButton = new System.Windows.Forms.Button();
            this.tipLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addrNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readSizeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endNumericUpDown)).BeginInit();
            this.TCPBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addrLabel
            // 
            this.addrLabel.AutoSize = true;
            this.addrLabel.Location = new System.Drawing.Point(24, 75);
            this.addrLabel.Name = "addrLabel";
            this.addrLabel.Size = new System.Drawing.Size(70, 13);
            this.addrLabel.TabIndex = 0;
            this.addrLabel.Text = "Hex Address:";
            // 
            // addrNumericUpDown
            // 
            this.addrNumericUpDown.Hexadecimal = true;
            this.addrNumericUpDown.Location = new System.Drawing.Point(27, 91);
            this.addrNumericUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.addrNumericUpDown.Name = "addrNumericUpDown";
            this.addrNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.addrNumericUpDown.TabIndex = 1;
            this.addrNumericUpDown.Value = new decimal(new int[] {
            268435456,
            0,
            0,
            0});
            this.addrNumericUpDown.ValueChanged += new System.EventHandler(this.addrnumericUpDown_ValueChanged);
            // 
            // stringLabel
            // 
            this.stringLabel.AutoSize = true;
            this.stringLabel.Location = new System.Drawing.Point(109, 75);
            this.stringLabel.Name = "stringLabel";
            this.stringLabel.Size = new System.Drawing.Size(37, 13);
            this.stringLabel.TabIndex = 0;
            this.stringLabel.Text = "ASCII:";
            // 
            // writerButton
            // 
            this.writerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writerButton.Location = new System.Drawing.Point(16, 244);
            this.writerButton.Name = "writerButton";
            this.writerButton.Size = new System.Drawing.Size(86, 23);
            this.writerButton.TabIndex = 7;
            this.writerButton.Text = "Apply";
            this.writerButton.UseVisualStyleBackColor = true;
            this.writerButton.Click += new System.EventHandler(this.writerButton_Click);
            // 
            // msgTimer
            // 
            this.msgTimer.Interval = 1000;
            this.msgTimer.Tick += new System.EventHandler(this.msgTimer_Tick);
            // 
            // readSizeNumericUpDown
            // 
            this.readSizeNumericUpDown.Hexadecimal = true;
            this.readSizeNumericUpDown.Location = new System.Drawing.Point(47, 136);
            this.readSizeNumericUpDown.Maximum = new decimal(new int[] {
            629145,
            0,
            0,
            0});
            this.readSizeNumericUpDown.Name = "readSizeNumericUpDown";
            this.readSizeNumericUpDown.Size = new System.Drawing.Size(55, 20);
            this.readSizeNumericUpDown.TabIndex = 3;
            this.readSizeNumericUpDown.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(16, 215);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(86, 23);
            this.readButton.TabIndex = 6;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel.Location = new System.Drawing.Point(13, 383);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(430, 52);
            this.infoLabel.TabIndex = 4;
            this.infoLabel.Text = "Byte Presentation:\r\n\r\nPeriod: \\00\r\nPilcrow Sign: from \\01 to \\1F (replaced with \\" +
    "00 when converted to byte, pure data is lost)\r\n";
            // 
            // endNumericUpDown
            // 
            this.endNumericUpDown.Hexadecimal = true;
            this.endNumericUpDown.Location = new System.Drawing.Point(27, 177);
            this.endNumericUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.endNumericUpDown.Name = "endNumericUpDown";
            this.endNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.endNumericUpDown.TabIndex = 5;
            this.endNumericUpDown.Value = new decimal(new int[] {
            268435968,
            0,
            0,
            0});
            this.endNumericUpDown.ValueChanged += new System.EventHandler(this.endNumericUpDown_ValueChanged);
            // 
            // readRadioButton
            // 
            this.readRadioButton.AutoSize = true;
            this.readRadioButton.Checked = true;
            this.readRadioButton.Location = new System.Drawing.Point(9, 118);
            this.readRadioButton.Name = "readRadioButton";
            this.readRadioButton.Size = new System.Drawing.Size(90, 17);
            this.readRadioButton.TabIndex = 2;
            this.readRadioButton.TabStop = true;
            this.readRadioButton.Text = "Bytes Length:";
            this.readRadioButton.UseVisualStyleBackColor = true;
            // 
            // endRadioButton
            // 
            this.endRadioButton.AutoSize = true;
            this.endRadioButton.Location = new System.Drawing.Point(9, 159);
            this.endRadioButton.Name = "endRadioButton";
            this.endRadioButton.Size = new System.Drawing.Size(88, 17);
            this.endRadioButton.TabIndex = 4;
            this.endRadioButton.Text = "End Address:";
            this.endRadioButton.UseVisualStyleBackColor = true;
            // 
            // zeroButton
            // 
            this.zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroButton.Location = new System.Drawing.Point(16, 273);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(86, 43);
            this.zeroButton.TabIndex = 8;
            this.zeroButton.Text = "Apply 0s within range";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // ASCIIRTB
            // 
            this.ASCIIRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ASCIIRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ASCIIRTB.Location = new System.Drawing.Point(113, 91);
            this.ASCIIRTB.Name = "ASCIIRTB";
            this.ASCIIRTB.Size = new System.Drawing.Size(465, 83);
            this.ASCIIRTB.TabIndex = 9;
            this.ASCIIRTB.Text = "";
            this.ASCIIRTB.TextChanged += new System.EventHandler(this.ASCIIRTB_TextChanged);
            this.ASCIIRTB.Leave += new System.EventHandler(this.ASCIIRTB_Leave);
            // 
            // byteRTB
            // 
            this.byteRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.byteRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.byteRTB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.byteRTB.Location = new System.Drawing.Point(112, 199);
            this.byteRTB.Name = "byteRTB";
            this.byteRTB.Size = new System.Drawing.Size(465, 83);
            this.byteRTB.TabIndex = 10;
            this.byteRTB.Text = "";
            this.byteRTB.TextChanged += new System.EventHandler(this.byteRTB_TextChanged);
            this.byteRTB.Leave += new System.EventHandler(this.byteRTB_Leave);
            // 
            // byteLabel
            // 
            this.byteLabel.AutoSize = true;
            this.byteLabel.Location = new System.Drawing.Point(110, 184);
            this.byteLabel.Name = "byteLabel";
            this.byteLabel.Size = new System.Drawing.Size(74, 13);
            this.byteLabel.TabIndex = 0;
            this.byteLabel.Text = "Byte (applied):";
            // 
            // byte2ASCIIButton
            // 
            this.byte2ASCIIButton.Location = new System.Drawing.Point(348, 175);
            this.byte2ASCIIButton.Name = "byte2ASCIIButton";
            this.byte2ASCIIButton.Size = new System.Drawing.Size(44, 23);
            this.byte2ASCIIButton.TabIndex = 13;
            this.byte2ASCIIButton.Text = "↑";
            this.byte2ASCIIButton.UseVisualStyleBackColor = true;
            this.byte2ASCIIButton.Click += new System.EventHandler(this.byte2ASCIIButton_Click);
            // 
            // ASCII2byteButton
            // 
            this.ASCII2byteButton.Location = new System.Drawing.Point(289, 175);
            this.ASCII2byteButton.Name = "ASCII2byteButton";
            this.ASCII2byteButton.Size = new System.Drawing.Size(44, 23);
            this.ASCII2byteButton.TabIndex = 12;
            this.ASCII2byteButton.Text = "↓";
            this.ASCII2byteButton.UseVisualStyleBackColor = true;
            this.ASCII2byteButton.Click += new System.EventHandler(this.ASCII2byteButton_Click);
            // 
            // ASCIIAutoCheck
            // 
            this.ASCIIAutoCheck.AutoSize = true;
            this.ASCIIAutoCheck.Location = new System.Drawing.Point(491, 74);
            this.ASCIIAutoCheck.Name = "ASCIIAutoCheck";
            this.ASCIIAutoCheck.Size = new System.Drawing.Size(86, 17);
            this.ASCIIAutoCheck.TabIndex = 16;
            this.ASCIIAutoCheck.Text = "Auto Update";
            this.ASCIIAutoCheck.UseVisualStyleBackColor = true;
            this.ASCIIAutoCheck.CheckedChanged += new System.EventHandler(this.stringAutoCheck_CheckedChanged);
            // 
            // byteAutoCheck
            // 
            this.byteAutoCheck.AutoSize = true;
            this.byteAutoCheck.Location = new System.Drawing.Point(491, 182);
            this.byteAutoCheck.Name = "byteAutoCheck";
            this.byteAutoCheck.Size = new System.Drawing.Size(86, 17);
            this.byteAutoCheck.TabIndex = 17;
            this.byteAutoCheck.Text = "Auto Update";
            this.byteAutoCheck.UseVisualStyleBackColor = true;
            this.byteAutoCheck.CheckedChanged += new System.EventHandler(this.byteAutoCheck_CheckedChanged);
            // 
            // unicodeLabel
            // 
            this.unicodeLabel.AutoSize = true;
            this.unicodeLabel.Location = new System.Drawing.Point(110, 292);
            this.unicodeLabel.Name = "unicodeLabel";
            this.unicodeLabel.Size = new System.Drawing.Size(50, 13);
            this.unicodeLabel.TabIndex = 0;
            this.unicodeLabel.Text = "Unicode:";
            // 
            // unicodeRTB
            // 
            this.unicodeRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unicodeRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.unicodeRTB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.unicodeRTB.Location = new System.Drawing.Point(112, 307);
            this.unicodeRTB.Name = "unicodeRTB";
            this.unicodeRTB.Size = new System.Drawing.Size(465, 72);
            this.unicodeRTB.TabIndex = 11;
            this.unicodeRTB.Text = "";
            this.unicodeRTB.TextChanged += new System.EventHandler(this.unicodeRTB_TextChanged);
            this.unicodeRTB.Leave += new System.EventHandler(this.byteRTB_Leave);
            // 
            // unicode2byteButton
            // 
            this.unicode2byteButton.Location = new System.Drawing.Point(348, 283);
            this.unicode2byteButton.Name = "unicode2byteButton";
            this.unicode2byteButton.Size = new System.Drawing.Size(44, 23);
            this.unicode2byteButton.TabIndex = 15;
            this.unicode2byteButton.Text = "↑";
            this.unicode2byteButton.UseVisualStyleBackColor = true;
            this.unicode2byteButton.Click += new System.EventHandler(this.unicode2byteButton_Click);
            // 
            // byte2unicodeButton
            // 
            this.byte2unicodeButton.Location = new System.Drawing.Point(289, 283);
            this.byte2unicodeButton.Name = "byte2unicodeButton";
            this.byte2unicodeButton.Size = new System.Drawing.Size(44, 23);
            this.byte2unicodeButton.TabIndex = 14;
            this.byte2unicodeButton.Text = "↓";
            this.byte2unicodeButton.UseVisualStyleBackColor = true;
            this.byte2unicodeButton.Click += new System.EventHandler(this.byte2unicodeButton_Click);
            // 
            // unicodeAutoCheck
            // 
            this.unicodeAutoCheck.AutoSize = true;
            this.unicodeAutoCheck.Location = new System.Drawing.Point(491, 290);
            this.unicodeAutoCheck.Name = "unicodeAutoCheck";
            this.unicodeAutoCheck.Size = new System.Drawing.Size(86, 17);
            this.unicodeAutoCheck.TabIndex = 18;
            this.unicodeAutoCheck.Text = "Auto Update";
            this.unicodeAutoCheck.UseVisualStyleBackColor = true;
            this.unicodeAutoCheck.CheckedChanged += new System.EventHandler(this.unicodeAutoCheck_CheckedChanged);
            // 
            // unicodeErrorTimer
            // 
            this.unicodeErrorTimer.Interval = 3000;
            // 
            // TCPBox
            // 
            this.TCPBox.Controls.Add(this.DisconnButton);
            this.TCPBox.Controls.Add(this.ConnectButton);
            this.TCPBox.Controls.Add(this.IPBox);
            this.TCPBox.Location = new System.Drawing.Point(11, 6);
            this.TCPBox.Name = "TCPBox";
            this.TCPBox.Size = new System.Drawing.Size(355, 48);
            this.TCPBox.TabIndex = 0;
            this.TCPBox.TabStop = false;
            this.TCPBox.Text = "TCPGecko Connection";
            // 
            // DisconnButton
            // 
            this.DisconnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.DisconnButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DisconnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisconnButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DisconnButton.Location = new System.Drawing.Point(244, 16);
            this.DisconnButton.Name = "DisconnButton";
            this.DisconnButton.Size = new System.Drawing.Size(100, 22);
            this.DisconnButton.TabIndex = 2;
            this.DisconnButton.Text = "Disconnect";
            this.DisconnButton.UseVisualStyleBackColor = false;
            this.DisconnButton.Click += new System.EventHandler(this.DisconnButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(200)))), ((int)(((byte)(92)))));
            this.ConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConnectButton.Location = new System.Drawing.Point(131, 16);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(100, 22);
            this.ConnectButton.TabIndex = 1;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = false;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // IPBox
            // 
            this.IPBox.Location = new System.Drawing.Point(10, 18);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(110, 20);
            this.IPBox.TabIndex = 0;
            this.IPBox.Text = "192.168.2.4";
            this.IPBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IPBox_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.readASCIILabel);
            this.groupBox1.Controls.Add(this.readASCIILengthLabel);
            this.groupBox1.Controls.Add(this.currentASCIILengthLabel);
            this.groupBox1.Controls.Add(this.currentByteLengthLabel);
            this.groupBox1.Controls.Add(this.readByteLengthLabel);
            this.groupBox1.Controls.Add(this.readByteLabel);
            this.groupBox1.Controls.Add(this.readUnicodeLengthLabel);
            this.groupBox1.Controls.Add(this.currentUnicodeLengthLabel);
            this.groupBox1.Controls.Add(this.readUnicodeLabel);
            this.groupBox1.Location = new System.Drawing.Point(381, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 62);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Read/Current Length";
            // 
            // readASCIILabel
            // 
            this.readASCIILabel.AutoSize = true;
            this.readASCIILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.readASCIILabel.Location = new System.Drawing.Point(13, 15);
            this.readASCIILabel.Name = "readASCIILabel";
            this.readASCIILabel.Size = new System.Drawing.Size(37, 13);
            this.readASCIILabel.TabIndex = 0;
            this.readASCIILabel.Text = "ASCII:";
            // 
            // readASCIILengthLabel
            // 
            this.readASCIILengthLabel.AutoSize = true;
            this.readASCIILengthLabel.BackColor = System.Drawing.Color.Transparent;
            this.readASCIILengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.readASCIILengthLabel.Location = new System.Drawing.Point(60, 15);
            this.readASCIILengthLabel.Name = "readASCIILengthLabel";
            this.readASCIILengthLabel.Size = new System.Drawing.Size(24, 13);
            this.readASCIILengthLabel.TabIndex = 0;
            this.readASCIILengthLabel.Text = "0x0";
            this.readASCIILengthLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // currentASCIILengthLabel
            // 
            this.currentASCIILengthLabel.AutoSize = true;
            this.currentASCIILengthLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentASCIILengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.currentASCIILengthLabel.Location = new System.Drawing.Point(116, 15);
            this.currentASCIILengthLabel.Name = "currentASCIILengthLabel";
            this.currentASCIILengthLabel.Size = new System.Drawing.Size(24, 13);
            this.currentASCIILengthLabel.TabIndex = 0;
            this.currentASCIILengthLabel.Text = "0x0";
            this.currentASCIILengthLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // currentByteLengthLabel
            // 
            this.currentByteLengthLabel.AutoSize = true;
            this.currentByteLengthLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentByteLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.currentByteLengthLabel.Location = new System.Drawing.Point(116, 29);
            this.currentByteLengthLabel.Name = "currentByteLengthLabel";
            this.currentByteLengthLabel.Size = new System.Drawing.Size(24, 13);
            this.currentByteLengthLabel.TabIndex = 0;
            this.currentByteLengthLabel.Text = "0x0";
            this.currentByteLengthLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // readByteLengthLabel
            // 
            this.readByteLengthLabel.AutoSize = true;
            this.readByteLengthLabel.BackColor = System.Drawing.Color.Transparent;
            this.readByteLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.readByteLengthLabel.Location = new System.Drawing.Point(60, 29);
            this.readByteLengthLabel.Name = "readByteLengthLabel";
            this.readByteLengthLabel.Size = new System.Drawing.Size(24, 13);
            this.readByteLengthLabel.TabIndex = 0;
            this.readByteLengthLabel.Text = "0x0";
            this.readByteLengthLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // readByteLabel
            // 
            this.readByteLabel.AutoSize = true;
            this.readByteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.readByteLabel.Location = new System.Drawing.Point(13, 29);
            this.readByteLabel.Name = "readByteLabel";
            this.readByteLabel.Size = new System.Drawing.Size(31, 13);
            this.readByteLabel.TabIndex = 0;
            this.readByteLabel.Text = "Byte:";
            // 
            // readUnicodeLengthLabel
            // 
            this.readUnicodeLengthLabel.AutoSize = true;
            this.readUnicodeLengthLabel.BackColor = System.Drawing.Color.Transparent;
            this.readUnicodeLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.readUnicodeLengthLabel.Location = new System.Drawing.Point(60, 43);
            this.readUnicodeLengthLabel.Name = "readUnicodeLengthLabel";
            this.readUnicodeLengthLabel.Size = new System.Drawing.Size(24, 13);
            this.readUnicodeLengthLabel.TabIndex = 0;
            this.readUnicodeLengthLabel.Text = "0x0";
            this.readUnicodeLengthLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // currentUnicodeLengthLabel
            // 
            this.currentUnicodeLengthLabel.AutoSize = true;
            this.currentUnicodeLengthLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentUnicodeLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.currentUnicodeLengthLabel.Location = new System.Drawing.Point(116, 43);
            this.currentUnicodeLengthLabel.Name = "currentUnicodeLengthLabel";
            this.currentUnicodeLengthLabel.Size = new System.Drawing.Size(24, 13);
            this.currentUnicodeLengthLabel.TabIndex = 0;
            this.currentUnicodeLengthLabel.Text = "0x0";
            this.currentUnicodeLengthLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // readUnicodeLabel
            // 
            this.readUnicodeLabel.AutoSize = true;
            this.readUnicodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.readUnicodeLabel.Location = new System.Drawing.Point(13, 43);
            this.readUnicodeLabel.Name = "readUnicodeLabel";
            this.readUnicodeLabel.Size = new System.Drawing.Size(48, 13);
            this.readUnicodeLabel.TabIndex = 0;
            this.readUnicodeLabel.Text = "Unicode:";
            // 
            // aboutButton
            // 
            this.aboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.aboutButton.Location = new System.Drawing.Point(31, 331);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(54, 22);
            this.aboutButton.TabIndex = 6;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // tipLabel
            // 
            this.tipLabel.AutoSize = true;
            this.tipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.tipLabel.ForeColor = System.Drawing.Color.Gray;
            this.tipLabel.Location = new System.Drawing.Point(457, 401);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(110, 24);
            this.tipLabel.TabIndex = 19;
            this.tipLabel.Text = "Tip: Try using the INSERT\r\nkey while editing text.";
            // 
            // StringWriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.byteAutoCheck);
            this.Controls.Add(this.TCPBox);
            this.Controls.Add(this.unicodeAutoCheck);
            this.Controls.Add(this.ASCIIAutoCheck);
            this.Controls.Add(this.byte2unicodeButton);
            this.Controls.Add(this.ASCII2byteButton);
            this.Controls.Add(this.unicode2byteButton);
            this.Controls.Add(this.byte2ASCIIButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.writerButton);
            this.Controls.Add(this.unicodeRTB);
            this.Controls.Add(this.byteRTB);
            this.Controls.Add(this.ASCIIRTB);
            this.Controls.Add(this.endRadioButton);
            this.Controls.Add(this.readRadioButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.readSizeNumericUpDown);
            this.Controls.Add(this.endNumericUpDown);
            this.Controls.Add(this.unicodeLabel);
            this.Controls.Add(this.addrNumericUpDown);
            this.Controls.Add(this.byteLabel);
            this.Controls.Add(this.stringLabel);
            this.Controls.Add(this.addrLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(585, 475);
            this.Name = "StringWriteForm";
            this.Text = "StringWriter for TCPGecko";
            this.Load += new System.EventHandler(this.StringWriteForm_Load);
            this.SizeChanged += new System.EventHandler(this.StringWriteForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.addrNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readSizeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endNumericUpDown)).EndInit();
            this.TCPBox.ResumeLayout(false);
            this.TCPBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addrLabel;
        private System.Windows.Forms.NumericUpDown addrNumericUpDown;
        private System.Windows.Forms.Label stringLabel;
        private System.Windows.Forms.Button writerButton;
        private System.Windows.Forms.Timer msgTimer;
        private System.Windows.Forms.NumericUpDown readSizeNumericUpDown;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.NumericUpDown endNumericUpDown;
        private System.Windows.Forms.RadioButton readRadioButton;
        private System.Windows.Forms.RadioButton endRadioButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.RichTextBox ASCIIRTB;
        private System.Windows.Forms.RichTextBox byteRTB;
        private System.Windows.Forms.Label byteLabel;
        private System.Windows.Forms.Button byte2ASCIIButton;
        private System.Windows.Forms.Button ASCII2byteButton;
        private System.Windows.Forms.CheckBox ASCIIAutoCheck;
        private System.Windows.Forms.CheckBox byteAutoCheck;
        private System.Windows.Forms.Label unicodeLabel;
        private System.Windows.Forms.RichTextBox unicodeRTB;
        private System.Windows.Forms.Button unicode2byteButton;
        private System.Windows.Forms.Button byte2unicodeButton;
        private System.Windows.Forms.CheckBox unicodeAutoCheck;
        private System.Windows.Forms.Timer unicodeErrorTimer;
        private System.Windows.Forms.GroupBox TCPBox;
        private System.Windows.Forms.Button DisconnButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label readASCIILabel;
        private System.Windows.Forms.Label readASCIILengthLabel;
        private System.Windows.Forms.Label currentASCIILengthLabel;
        private System.Windows.Forms.Label currentByteLengthLabel;
        private System.Windows.Forms.Label readByteLengthLabel;
        private System.Windows.Forms.Label readByteLabel;
        private System.Windows.Forms.Label readUnicodeLengthLabel;
        private System.Windows.Forms.Label currentUnicodeLengthLabel;
        private System.Windows.Forms.Label readUnicodeLabel;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Label tipLabel;
    }
}