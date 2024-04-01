namespace UNI_T_UTL8212
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BaudList = new System.Windows.Forms.ComboBox();
            this.Connect_Button = new System.Windows.Forms.Button();
            this.ComPortList = new System.Windows.Forms.ComboBox();
            this.disConnect_Button = new System.Windows.Forms.Button();
            this.GraphicSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.Symb_Select = new System.Windows.Forms.CheckBox();
            this.Y2_Gain_Select = new System.Windows.Forms.ComboBox();
            this.Y1_Gain_Select = new System.Windows.Forms.ComboBox();
            this.X_Gain_Select = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Y2_Axis_Select = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Y1_Axis_Select = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.X_Axis_Select = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Grid_Select = new System.Windows.Forms.CheckBox();
            this.Thickness_Select = new System.Windows.Forms.ComboBox();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Ch1Measurements = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Ch2Measurements = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Ch1ClassicalGroupBox = new System.Windows.Forms.GroupBox();
            this.Ch1DummyLoadGroupBox = new System.Windows.Forms.GroupBox();
            this.Ch1ShortSec = new System.Windows.Forms.RadioButton();
            this.label25 = new System.Windows.Forms.Label();
            this.Ch1LoadModel = new System.Windows.Forms.ComboBox();
            this.label48 = new System.Windows.Forms.Label();
            this.Ch1StepSize = new System.Windows.Forms.NumericUpDown();
            this.label49 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.Ch1CutoffRef = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.Ch1LoadingTestValue = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.Ch1LoadingSec = new System.Windows.Forms.RadioButton();
            this.Ch1ConstantSec = new System.Windows.Forms.RadioButton();
            this.Ch1RefValue = new System.Windows.Forms.NumericUpDown();
            this.Ch1DummyLoadStartButton = new System.Windows.Forms.Button();
            this.Ch1DummyLoadStopButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Ch2ClassicalGroupBox = new System.Windows.Forms.GroupBox();
            this.Ch2DummyLoadGroupBox = new System.Windows.Forms.GroupBox();
            this.Ch2ShortSec = new System.Windows.Forms.RadioButton();
            this.label51 = new System.Windows.Forms.Label();
            this.Ch2LoadModel = new System.Windows.Forms.ComboBox();
            this.label52 = new System.Windows.Forms.Label();
            this.Ch2StepSize = new System.Windows.Forms.NumericUpDown();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.Ch2CutoffRef = new System.Windows.Forms.NumericUpDown();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.Ch2LoadingTestValue = new System.Windows.Forms.NumericUpDown();
            this.label57 = new System.Windows.Forms.Label();
            this.Ch2LoadingSec = new System.Windows.Forms.RadioButton();
            this.Ch2ConstantSec = new System.Windows.Forms.RadioButton();
            this.Ch2RefValue = new System.Windows.Forms.NumericUpDown();
            this.Ch2DummyLoadStartButton = new System.Windows.Forms.Button();
            this.Ch2DummyLoadStopButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.ledBulb2 = new UNI_T_UTL8212.LedBulb();
            this.Ch2_ResSegment = new UNI_T_UTL8212.SevenSegmentArray();
            this.Ch2_PowSegment = new UNI_T_UTL8212.SevenSegmentArray();
            this.Ch2_AmpSegment = new UNI_T_UTL8212.SevenSegmentArray();
            this.Ch2_VoltSegment = new UNI_T_UTL8212.SevenSegmentArray();
            this.ledBulb1 = new UNI_T_UTL8212.LedBulb();
            this.Ch1_ResSegment = new UNI_T_UTL8212.SevenSegmentArray();
            this.Ch1_PowSegment = new UNI_T_UTL8212.SevenSegmentArray();
            this.Ch1_AmpSegment = new UNI_T_UTL8212.SevenSegmentArray();
            this.Ch1_VoltSegment = new UNI_T_UTL8212.SevenSegmentArray();
            this.groupBox1.SuspendLayout();
            this.GraphicSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Ch1Measurements.SuspendLayout();
            this.Ch2Measurements.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.Ch1ClassicalGroupBox.SuspendLayout();
            this.Ch1DummyLoadGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ch1StepSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ch1CutoffRef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ch1LoadingTestValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ch1RefValue)).BeginInit();
            this.Ch2ClassicalGroupBox.SuspendLayout();
            this.Ch2DummyLoadGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ch2StepSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ch2CutoffRef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ch2LoadingTestValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ch2RefValue)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BaudList);
            this.groupBox1.Controls.Add(this.Connect_Button);
            this.groupBox1.Controls.Add(this.ComPortList);
            this.groupBox1.Controls.Add(this.disConnect_Button);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 69);
            this.groupBox1.TabIndex = 1120;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Settings";
            // 
            // BaudList
            // 
            this.BaudList.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BaudList.FormattingEnabled = true;
            this.BaudList.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.BaudList.Location = new System.Drawing.Point(112, 43);
            this.BaudList.Name = "BaudList";
            this.BaudList.Size = new System.Drawing.Size(65, 22);
            this.BaudList.TabIndex = 4;
            this.BaudList.Text = "115200";
            this.BaudList.SelectedIndexChanged += new System.EventHandler(this.BaudList_SelectedIndexChanged);
            // 
            // Connect_Button
            // 
            this.Connect_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Connect_Button.ForeColor = System.Drawing.Color.Green;
            this.Connect_Button.Image = ((System.Drawing.Image)(resources.GetObject("Connect_Button.Image")));
            this.Connect_Button.Location = new System.Drawing.Point(6, 16);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.Size = new System.Drawing.Size(50, 50);
            this.Connect_Button.TabIndex = 1;
            this.Connect_Button.UseVisualStyleBackColor = true;
            this.Connect_Button.Click += new System.EventHandler(this.Connect_Button_Click);
            // 
            // ComPortList
            // 
            this.ComPortList.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ComPortList.FormattingEnabled = true;
            this.ComPortList.Items.AddRange(new object[] {
            "COM1"});
            this.ComPortList.Location = new System.Drawing.Point(112, 16);
            this.ComPortList.Name = "ComPortList";
            this.ComPortList.Size = new System.Drawing.Size(65, 22);
            this.ComPortList.TabIndex = 3;
            this.ComPortList.Text = "COM1";
            this.ComPortList.SelectedIndexChanged += new System.EventHandler(this.ComPortList_SelectedIndexChanged);
            // 
            // disConnect_Button
            // 
            this.disConnect_Button.Enabled = false;
            this.disConnect_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.disConnect_Button.Image = ((System.Drawing.Image)(resources.GetObject("disConnect_Button.Image")));
            this.disConnect_Button.Location = new System.Drawing.Point(59, 16);
            this.disConnect_Button.Name = "disConnect_Button";
            this.disConnect_Button.Size = new System.Drawing.Size(50, 50);
            this.disConnect_Button.TabIndex = 2;
            this.disConnect_Button.UseVisualStyleBackColor = true;
            this.disConnect_Button.Click += new System.EventHandler(this.disConnect_Button_Click);
            // 
            // GraphicSettingsGroupBox
            // 
            this.GraphicSettingsGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.GraphicSettingsGroupBox.Controls.Add(this.Symb_Select);
            this.GraphicSettingsGroupBox.Controls.Add(this.Y2_Gain_Select);
            this.GraphicSettingsGroupBox.Controls.Add(this.Y1_Gain_Select);
            this.GraphicSettingsGroupBox.Controls.Add(this.X_Gain_Select);
            this.GraphicSettingsGroupBox.Controls.Add(this.label17);
            this.GraphicSettingsGroupBox.Controls.Add(this.Y2_Axis_Select);
            this.GraphicSettingsGroupBox.Controls.Add(this.label7);
            this.GraphicSettingsGroupBox.Controls.Add(this.Y1_Axis_Select);
            this.GraphicSettingsGroupBox.Controls.Add(this.label6);
            this.GraphicSettingsGroupBox.Controls.Add(this.X_Axis_Select);
            this.GraphicSettingsGroupBox.Controls.Add(this.button3);
            this.GraphicSettingsGroupBox.Controls.Add(this.Grid_Select);
            this.GraphicSettingsGroupBox.Controls.Add(this.Thickness_Select);
            this.GraphicSettingsGroupBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GraphicSettingsGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GraphicSettingsGroupBox.Location = new System.Drawing.Point(191, 5);
            this.GraphicSettingsGroupBox.Name = "GraphicSettingsGroupBox";
            this.GraphicSettingsGroupBox.Size = new System.Drawing.Size(421, 69);
            this.GraphicSettingsGroupBox.TabIndex = 1121;
            this.GraphicSettingsGroupBox.TabStop = false;
            this.GraphicSettingsGroupBox.Text = "Graphic Settings";
            // 
            // Symb_Select
            // 
            this.Symb_Select.AutoSize = true;
            this.Symb_Select.Checked = true;
            this.Symb_Select.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Symb_Select.Location = new System.Drawing.Point(53, 47);
            this.Symb_Select.Name = "Symb_Select";
            this.Symb_Select.Size = new System.Drawing.Size(60, 18);
            this.Symb_Select.TabIndex = 7;
            this.Symb_Select.Text = "Symb.";
            this.Symb_Select.UseVisualStyleBackColor = true;
            this.Symb_Select.CheckedChanged += new System.EventHandler(this.Symb_Select_CheckedChanged);
            // 
            // Y2_Gain_Select
            // 
            this.Y2_Gain_Select.FormattingEnabled = true;
            this.Y2_Gain_Select.Items.AddRange(new object[] {
            "/1000",
            "/100",
            "/10",
            "x1",
            "x10",
            "x100",
            "x1000"});
            this.Y2_Gain_Select.Location = new System.Drawing.Point(351, 43);
            this.Y2_Gain_Select.Name = "Y2_Gain_Select";
            this.Y2_Gain_Select.Size = new System.Drawing.Size(63, 22);
            this.Y2_Gain_Select.TabIndex = 14;
            this.Y2_Gain_Select.Text = "x1";
            this.Y2_Gain_Select.SelectedIndexChanged += new System.EventHandler(this.Y2_Gain_Select_SelectedIndexChanged);
            // 
            // Y1_Gain_Select
            // 
            this.Y1_Gain_Select.FormattingEnabled = true;
            this.Y1_Gain_Select.Items.AddRange(new object[] {
            "/1000",
            "/100",
            "/10",
            "x1",
            "x10",
            "x100",
            "x1000"});
            this.Y1_Gain_Select.Location = new System.Drawing.Point(351, 19);
            this.Y1_Gain_Select.Name = "Y1_Gain_Select";
            this.Y1_Gain_Select.Size = new System.Drawing.Size(63, 22);
            this.Y1_Gain_Select.TabIndex = 12;
            this.Y1_Gain_Select.Text = "x1";
            this.Y1_Gain_Select.SelectedIndexChanged += new System.EventHandler(this.Y1_Gain_Select_SelectedIndexChanged);
            // 
            // X_Gain_Select
            // 
            this.X_Gain_Select.CausesValidation = false;
            this.X_Gain_Select.FormattingEnabled = true;
            this.X_Gain_Select.Items.AddRange(new object[] {
            "/1000",
            "/100",
            "/10",
            "x1",
            "x10",
            "x100",
            "x1000"});
            this.X_Gain_Select.Location = new System.Drawing.Point(161, 43);
            this.X_Gain_Select.Name = "X_Gain_Select";
            this.X_Gain_Select.Size = new System.Drawing.Size(68, 22);
            this.X_Gain_Select.TabIndex = 10;
            this.X_Gain_Select.Text = "x1";
            this.X_Gain_Select.SelectedIndexChanged += new System.EventHandler(this.X_Gain_Select_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(230, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 14);
            this.label17.TabIndex = 1081;
            this.label17.Text = "Y2 Axis:";
            // 
            // Y2_Axis_Select
            // 
            this.Y2_Axis_Select.FormattingEnabled = true;
            this.Y2_Axis_Select.Items.AddRange(new object[] {
            "None",
            "Voltage",
            "Current",
            "Power",
            "Resist."});
            this.Y2_Axis_Select.Location = new System.Drawing.Point(280, 43);
            this.Y2_Axis_Select.Name = "Y2_Axis_Select";
            this.Y2_Axis_Select.Size = new System.Drawing.Size(68, 22);
            this.Y2_Axis_Select.TabIndex = 13;
            this.Y2_Axis_Select.Text = "None";
            this.Y2_Axis_Select.SelectedIndexChanged += new System.EventHandler(this.Y2_Axis_Select_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(230, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 14);
            this.label7.TabIndex = 1079;
            this.label7.Text = "Y1 Axis:";
            // 
            // Y1_Axis_Select
            // 
            this.Y1_Axis_Select.FormattingEnabled = true;
            this.Y1_Axis_Select.Items.AddRange(new object[] {
            "Voltage",
            "Current",
            "Power",
            "Resist."});
            this.Y1_Axis_Select.Location = new System.Drawing.Point(280, 19);
            this.Y1_Axis_Select.Name = "Y1_Axis_Select";
            this.Y1_Axis_Select.Size = new System.Drawing.Size(68, 22);
            this.Y1_Axis_Select.TabIndex = 11;
            this.Y1_Axis_Select.Text = "Voltage";
            this.Y1_Axis_Select.SelectedIndexChanged += new System.EventHandler(this.Y1_Axis_Select_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(114, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 14);
            this.label6.TabIndex = 1077;
            this.label6.Text = "X Axis:";
            // 
            // X_Axis_Select
            // 
            this.X_Axis_Select.FormattingEnabled = true;
            this.X_Axis_Select.Items.AddRange(new object[] {
            "Voltage",
            "Current",
            "Power",
            "Resist."});
            this.X_Axis_Select.Location = new System.Drawing.Point(161, 19);
            this.X_Axis_Select.Name = "X_Axis_Select";
            this.X_Axis_Select.Size = new System.Drawing.Size(68, 22);
            this.X_Axis_Select.TabIndex = 9;
            this.X_Axis_Select.Text = "Current";
            this.X_Axis_Select.SelectedIndexChanged += new System.EventHandler(this.X_Axis_Select_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(116, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 21);
            this.button3.TabIndex = 8;
            this.button3.Text = "Res.";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Grid_Select
            // 
            this.Grid_Select.AutoSize = true;
            this.Grid_Select.Checked = true;
            this.Grid_Select.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Grid_Select.Location = new System.Drawing.Point(6, 47);
            this.Grid_Select.Name = "Grid_Select";
            this.Grid_Select.Size = new System.Drawing.Size(49, 18);
            this.Grid_Select.TabIndex = 6;
            this.Grid_Select.Text = "Grid";
            this.Grid_Select.UseVisualStyleBackColor = true;
            this.Grid_Select.CheckedChanged += new System.EventHandler(this.Grid_Select_CheckedChanged);
            // 
            // Thickness_Select
            // 
            this.Thickness_Select.FormattingEnabled = true;
            this.Thickness_Select.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Thickness_Select.Location = new System.Drawing.Point(5, 19);
            this.Thickness_Select.Name = "Thickness_Select";
            this.Thickness_Select.Size = new System.Drawing.Size(107, 22);
            this.Thickness_Select.TabIndex = 5;
            this.Thickness_Select.Text = "Thickness";
            this.Thickness_Select.SelectedIndexChanged += new System.EventHandler(this.Thickness_Select_SelectedIndexChanged);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphControl1.AutoScroll = true;
            this.zedGraphControl1.BackColor = System.Drawing.SystemColors.Control;
            this.zedGraphControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.zedGraphControl1.Enabled = false;
            this.zedGraphControl1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zedGraphControl1.IsAntiAlias = true;
            this.zedGraphControl1.IsEnableSelection = true;
            this.zedGraphControl1.IsShowPointValues = true;
            this.zedGraphControl1.Location = new System.Drawing.Point(5, 76);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(657, 363);
            this.zedGraphControl1.TabIndex = 1122;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::UNI_T_UTL8212.Properties.Resources.Logo11;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(618, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1124;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Ch1Measurements
            // 
            this.Ch1Measurements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Ch1Measurements.BackColor = System.Drawing.SystemColors.Control;
            this.Ch1Measurements.Controls.Add(this.ledBulb1);
            this.Ch1Measurements.Controls.Add(this.label4);
            this.Ch1Measurements.Controls.Add(this.Ch1_ResSegment);
            this.Ch1Measurements.Controls.Add(this.label3);
            this.Ch1Measurements.Controls.Add(this.label2);
            this.Ch1Measurements.Controls.Add(this.label1);
            this.Ch1Measurements.Controls.Add(this.Ch1_PowSegment);
            this.Ch1Measurements.Controls.Add(this.Ch1_AmpSegment);
            this.Ch1Measurements.Controls.Add(this.Ch1_VoltSegment);
            this.Ch1Measurements.Enabled = false;
            this.Ch1Measurements.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ch1Measurements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Ch1Measurements.Location = new System.Drawing.Point(5, 439);
            this.Ch1Measurements.Name = "Ch1Measurements";
            this.Ch1Measurements.Size = new System.Drawing.Size(657, 84);
            this.Ch1Measurements.TabIndex = 1125;
            this.Ch1Measurements.TabStop = false;
            this.Ch1Measurements.Text = "Channel 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(491, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 14);
            this.label4.TabIndex = 1086;
            this.label4.Text = "Resistance [Ω]:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(348, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 14);
            this.label3.TabIndex = 1084;
            this.label3.Text = "Power [W]:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(204, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 14);
            this.label2.TabIndex = 1083;
            this.label2.Text = "Current [A]:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(48, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 1082;
            this.label1.Text = "Voltage [V]:";
            // 
            // Ch2Measurements
            // 
            this.Ch2Measurements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Ch2Measurements.BackColor = System.Drawing.SystemColors.Control;
            this.Ch2Measurements.Controls.Add(this.ledBulb2);
            this.Ch2Measurements.Controls.Add(this.label5);
            this.Ch2Measurements.Controls.Add(this.Ch2_ResSegment);
            this.Ch2Measurements.Controls.Add(this.label8);
            this.Ch2Measurements.Controls.Add(this.label9);
            this.Ch2Measurements.Controls.Add(this.label10);
            this.Ch2Measurements.Controls.Add(this.Ch2_PowSegment);
            this.Ch2Measurements.Controls.Add(this.Ch2_AmpSegment);
            this.Ch2Measurements.Controls.Add(this.Ch2_VoltSegment);
            this.Ch2Measurements.Enabled = false;
            this.Ch2Measurements.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ch2Measurements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Ch2Measurements.Location = new System.Drawing.Point(5, 525);
            this.Ch2Measurements.Name = "Ch2Measurements";
            this.Ch2Measurements.Size = new System.Drawing.Size(657, 84);
            this.Ch2Measurements.TabIndex = 1126;
            this.Ch2Measurements.TabStop = false;
            this.Ch2Measurements.Text = "Channel 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(491, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 14);
            this.label5.TabIndex = 1086;
            this.label5.Text = "Resistance [Ω]:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(348, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 14);
            this.label8.TabIndex = 1084;
            this.label8.Text = "Power [W]:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(204, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 14);
            this.label9.TabIndex = 1083;
            this.label9.Text = "Current [A]:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(48, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 14);
            this.label10.TabIndex = 1082;
            this.label10.Text = "Voltage [V]:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel1,
            this.StatusLabel2,
            this.StatusLabel3,
            this.StatusLabel4,
            this.StatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 613);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(922, 22);
            this.statusStrip1.TabIndex = 1127;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(78, 17);
            this.StatusLabel1.Text = "StatusLabel1";
            // 
            // StatusLabel2
            // 
            this.StatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.StatusLabel2.Name = "StatusLabel2";
            this.StatusLabel2.Size = new System.Drawing.Size(78, 17);
            this.StatusLabel2.Text = "StatusLabel2";
            // 
            // StatusLabel3
            // 
            this.StatusLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.StatusLabel3.Name = "StatusLabel3";
            this.StatusLabel3.Size = new System.Drawing.Size(78, 17);
            this.StatusLabel3.Text = "StatusLabel3";
            // 
            // StatusLabel4
            // 
            this.StatusLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.StatusLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.StatusLabel4.Name = "StatusLabel4";
            this.StatusLabel4.Size = new System.Drawing.Size(78, 17);
            this.StatusLabel4.Text = "StatusLabel4";
            // 
            // StatusLabel5
            // 
            this.StatusLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.StatusLabel5.ForeColor = System.Drawing.Color.Purple;
            this.StatusLabel5.Name = "StatusLabel5";
            this.StatusLabel5.Size = new System.Drawing.Size(78, 17);
            this.StatusLabel5.Text = "StatusLabel5";
            // 
            // Ch1ClassicalGroupBox
            // 
            this.Ch1ClassicalGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ch1ClassicalGroupBox.Controls.Add(this.Ch1DummyLoadGroupBox);
            this.Ch1ClassicalGroupBox.Controls.Add(this.Ch1DummyLoadStartButton);
            this.Ch1ClassicalGroupBox.Controls.Add(this.Ch1DummyLoadStopButton);
            this.Ch1ClassicalGroupBox.Enabled = false;
            this.Ch1ClassicalGroupBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ch1ClassicalGroupBox.Location = new System.Drawing.Point(669, 5);
            this.Ch1ClassicalGroupBox.Name = "Ch1ClassicalGroupBox";
            this.Ch1ClassicalGroupBox.Size = new System.Drawing.Size(247, 214);
            this.Ch1ClassicalGroupBox.TabIndex = 1128;
            this.Ch1ClassicalGroupBox.TabStop = false;
            this.Ch1ClassicalGroupBox.Text = "Ch1 Test Area";
            // 
            // Ch1DummyLoadGroupBox
            // 
            this.Ch1DummyLoadGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.Ch1DummyLoadGroupBox.Controls.Add(this.Ch1ShortSec);
            this.Ch1DummyLoadGroupBox.Controls.Add(this.label25);
            this.Ch1DummyLoadGroupBox.Controls.Add(this.Ch1LoadModel);
            this.Ch1DummyLoadGroupBox.Controls.Add(this.label48);
            this.Ch1DummyLoadGroupBox.Controls.Add(this.Ch1StepSize);
            this.Ch1DummyLoadGroupBox.Controls.Add(this.label49);
            this.Ch1DummyLoadGroupBox.Controls.Add(this.label20);
            this.Ch1DummyLoadGroupBox.Controls.Add(this.Ch1CutoffRef);
            this.Ch1DummyLoadGroupBox.Controls.Add(this.label21);
            this.Ch1DummyLoadGroupBox.Controls.Add(this.label22);
            this.Ch1DummyLoadGroupBox.Controls.Add(this.Ch1LoadingTestValue);
            this.Ch1DummyLoadGroupBox.Controls.Add(this.label23);
            this.Ch1DummyLoadGroupBox.Controls.Add(this.Ch1LoadingSec);
            this.Ch1DummyLoadGroupBox.Controls.Add(this.Ch1ConstantSec);
            this.Ch1DummyLoadGroupBox.Controls.Add(this.Ch1RefValue);
            this.Ch1DummyLoadGroupBox.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ch1DummyLoadGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Ch1DummyLoadGroupBox.Location = new System.Drawing.Point(6, 17);
            this.Ch1DummyLoadGroupBox.Name = "Ch1DummyLoadGroupBox";
            this.Ch1DummyLoadGroupBox.Size = new System.Drawing.Size(235, 160);
            this.Ch1DummyLoadGroupBox.TabIndex = 1061;
            this.Ch1DummyLoadGroupBox.TabStop = false;
            this.Ch1DummyLoadGroupBox.Text = "Ch1 Dummy Load";
            // 
            // Ch1ShortSec
            // 
            this.Ch1ShortSec.AutoSize = true;
            this.Ch1ShortSec.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ch1ShortSec.ForeColor = System.Drawing.Color.Black;
            this.Ch1ShortSec.Location = new System.Drawing.Point(6, 139);
            this.Ch1ShortSec.Name = "Ch1ShortSec";
            this.Ch1ShortSec.Size = new System.Drawing.Size(82, 18);
            this.Ch1ShortSec.TabIndex = 38;
            this.Ch1ShortSec.Text = "Short Test";
            this.Ch1ShortSec.UseVisualStyleBackColor = true;
            this.Ch1ShortSec.CheckedChanged += new System.EventHandler(this.radioButton13_CheckedChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(7, 68);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(74, 14);
            this.label25.TabIndex = 37;
            this.label25.Text = "Load Model:";
            // 
            // Ch1LoadModel
            // 
            this.Ch1LoadModel.CausesValidation = false;
            this.Ch1LoadModel.FormattingEnabled = true;
            this.Ch1LoadModel.Items.AddRange(new object[] {
            "CC",
            "CR",
            "CP",
            "CV"});
            this.Ch1LoadModel.Location = new System.Drawing.Point(133, 65);
            this.Ch1LoadModel.Name = "Ch1LoadModel";
            this.Ch1LoadModel.Size = new System.Drawing.Size(67, 22);
            this.Ch1LoadModel.TabIndex = 36;
            this.Ch1LoadModel.Text = "CC";
            this.Ch1LoadModel.SelectedIndexChanged += new System.EventHandler(this.Ch1LoadModel_SelectedIndexChanged);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label48.ForeColor = System.Drawing.Color.Black;
            this.label48.Location = new System.Drawing.Point(202, 45);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(15, 14);
            this.label48.TabIndex = 30;
            this.label48.Text = "A";
            // 
            // Ch1StepSize
            // 
            this.Ch1StepSize.DecimalPlaces = 2;
            this.Ch1StepSize.Enabled = false;
            this.Ch1StepSize.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ch1StepSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Ch1StepSize.Location = new System.Drawing.Point(133, 42);
            this.Ch1StepSize.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Ch1StepSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.Ch1StepSize.Name = "Ch1StepSize";
            this.Ch1StepSize.Size = new System.Drawing.Size(67, 20);
            this.Ch1StepSize.TabIndex = 22;
            this.Ch1StepSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Enabled = false;
            this.label49.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label49.ForeColor = System.Drawing.Color.Black;
            this.label49.Location = new System.Drawing.Point(7, 44);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(58, 14);
            this.label49.TabIndex = 28;
            this.label49.Text = "Step Size";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(202, 23);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(15, 14);
            this.label20.TabIndex = 27;
            this.label20.Text = "V";
            // 
            // Ch1CutoffRef
            // 
            this.Ch1CutoffRef.DecimalPlaces = 1;
            this.Ch1CutoffRef.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ch1CutoffRef.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Ch1CutoffRef.Location = new System.Drawing.Point(133, 19);
            this.Ch1CutoffRef.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.Ch1CutoffRef.Name = "Ch1CutoffRef";
            this.Ch1CutoffRef.Size = new System.Drawing.Size(67, 20);
            this.Ch1CutoffRef.TabIndex = 21;
            this.Ch1CutoffRef.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Ch1CutoffRef.ValueChanged += new System.EventHandler(this.Ch1CutoffRef_ValueChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(7, 22);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 14);
            this.label21.TabIndex = 25;
            this.label21.Text = "Cutoff Voltage";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(202, 118);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(15, 14);
            this.label22.TabIndex = 14;
            this.label22.Text = "A";
            this.label22.Visible = false;
            // 
            // Ch1LoadingTestValue
            // 
            this.Ch1LoadingTestValue.DecimalPlaces = 3;
            this.Ch1LoadingTestValue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ch1LoadingTestValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Ch1LoadingTestValue.Location = new System.Drawing.Point(133, 115);
            this.Ch1LoadingTestValue.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Ch1LoadingTestValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.Ch1LoadingTestValue.Name = "Ch1LoadingTestValue";
            this.Ch1LoadingTestValue.Size = new System.Drawing.Size(67, 20);
            this.Ch1LoadingTestValue.TabIndex = 24;
            this.Ch1LoadingTestValue.Value = new decimal(new int[] {
            2500,
            0,
            0,
            196608});
            this.Ch1LoadingTestValue.Visible = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(202, 94);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(15, 14);
            this.label23.TabIndex = 10;
            this.label23.Text = "A";
            // 
            // Ch1LoadingSec
            // 
            this.Ch1LoadingSec.AutoSize = true;
            this.Ch1LoadingSec.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ch1LoadingSec.ForeColor = System.Drawing.Color.Black;
            this.Ch1LoadingSec.Location = new System.Drawing.Point(6, 115);
            this.Ch1LoadingSec.Name = "Ch1LoadingSec";
            this.Ch1LoadingSec.Size = new System.Drawing.Size(96, 18);
            this.Ch1LoadingSec.TabIndex = 20;
            this.Ch1LoadingSec.Text = "Loading Test";
            this.Ch1LoadingSec.UseVisualStyleBackColor = true;
            this.Ch1LoadingSec.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // Ch1ConstantSec
            // 
            this.Ch1ConstantSec.AutoSize = true;
            this.Ch1ConstantSec.Checked = true;
            this.Ch1ConstantSec.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ch1ConstantSec.ForeColor = System.Drawing.Color.Black;
            this.Ch1ConstantSec.Location = new System.Drawing.Point(6, 91);
            this.Ch1ConstantSec.Name = "Ch1ConstantSec";
            this.Ch1ConstantSec.Size = new System.Drawing.Size(121, 18);
            this.Ch1ConstantSec.TabIndex = 19;
            this.Ch1ConstantSec.TabStop = true;
            this.Ch1ConstantSec.Text = "Constant Current";
            this.Ch1ConstantSec.UseVisualStyleBackColor = true;
            this.Ch1ConstantSec.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // Ch1RefValue
            // 
            this.Ch1RefValue.DecimalPlaces = 3;
            this.Ch1RefValue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ch1RefValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Ch1RefValue.Location = new System.Drawing.Point(133, 91);
            this.Ch1RefValue.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Ch1RefValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.Ch1RefValue.Name = "Ch1RefValue";
            this.Ch1RefValue.Size = new System.Drawing.Size(67, 20);
            this.Ch1RefValue.TabIndex = 23;
            this.Ch1RefValue.Value = new decimal(new int[] {
            2500,
            0,
            0,
            196608});
            // 
            // Ch1DummyLoadStartButton
            // 
            this.Ch1DummyLoadStartButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ch1DummyLoadStartButton.ForeColor = System.Drawing.Color.Green;
            this.Ch1DummyLoadStartButton.Location = new System.Drawing.Point(6, 183);
            this.Ch1DummyLoadStartButton.Name = "Ch1DummyLoadStartButton";
            this.Ch1DummyLoadStartButton.Size = new System.Drawing.Size(108, 23);
            this.Ch1DummyLoadStartButton.TabIndex = 25;
            this.Ch1DummyLoadStartButton.Text = "Start";
            this.Ch1DummyLoadStartButton.UseVisualStyleBackColor = true;
            this.Ch1DummyLoadStartButton.Click += new System.EventHandler(this.Ch1DummyLoadStartButton_Click);
            // 
            // Ch1DummyLoadStopButton
            // 
            this.Ch1DummyLoadStopButton.Enabled = false;
            this.Ch1DummyLoadStopButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ch1DummyLoadStopButton.ForeColor = System.Drawing.Color.DarkRed;
            this.Ch1DummyLoadStopButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ch1DummyLoadStopButton.Location = new System.Drawing.Point(133, 183);
            this.Ch1DummyLoadStopButton.Name = "Ch1DummyLoadStopButton";
            this.Ch1DummyLoadStopButton.Size = new System.Drawing.Size(108, 23);
            this.Ch1DummyLoadStopButton.TabIndex = 26;
            this.Ch1DummyLoadStopButton.Text = "Stop";
            this.Ch1DummyLoadStopButton.UseVisualStyleBackColor = true;
            this.Ch1DummyLoadStopButton.Click += new System.EventHandler(this.Ch1DummyLoadStopButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.ReceivedBytesThreshold = 5;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Ch2ClassicalGroupBox
            // 
            this.Ch2ClassicalGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ch2ClassicalGroupBox.Controls.Add(this.Ch2DummyLoadGroupBox);
            this.Ch2ClassicalGroupBox.Controls.Add(this.Ch2DummyLoadStartButton);
            this.Ch2ClassicalGroupBox.Controls.Add(this.Ch2DummyLoadStopButton);
            this.Ch2ClassicalGroupBox.Enabled = false;
            this.Ch2ClassicalGroupBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ch2ClassicalGroupBox.Location = new System.Drawing.Point(669, 225);
            this.Ch2ClassicalGroupBox.Name = "Ch2ClassicalGroupBox";
            this.Ch2ClassicalGroupBox.Size = new System.Drawing.Size(247, 214);
            this.Ch2ClassicalGroupBox.TabIndex = 1132;
            this.Ch2ClassicalGroupBox.TabStop = false;
            this.Ch2ClassicalGroupBox.Text = "Ch2 Test Area";
            // 
            // Ch2DummyLoadGroupBox
            // 
            this.Ch2DummyLoadGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.Ch2DummyLoadGroupBox.Controls.Add(this.Ch2ShortSec);
            this.Ch2DummyLoadGroupBox.Controls.Add(this.label51);
            this.Ch2DummyLoadGroupBox.Controls.Add(this.Ch2LoadModel);
            this.Ch2DummyLoadGroupBox.Controls.Add(this.label52);
            this.Ch2DummyLoadGroupBox.Controls.Add(this.Ch2StepSize);
            this.Ch2DummyLoadGroupBox.Controls.Add(this.label53);
            this.Ch2DummyLoadGroupBox.Controls.Add(this.label54);
            this.Ch2DummyLoadGroupBox.Controls.Add(this.Ch2CutoffRef);
            this.Ch2DummyLoadGroupBox.Controls.Add(this.label55);
            this.Ch2DummyLoadGroupBox.Controls.Add(this.label56);
            this.Ch2DummyLoadGroupBox.Controls.Add(this.Ch2LoadingTestValue);
            this.Ch2DummyLoadGroupBox.Controls.Add(this.label57);
            this.Ch2DummyLoadGroupBox.Controls.Add(this.Ch2LoadingSec);
            this.Ch2DummyLoadGroupBox.Controls.Add(this.Ch2ConstantSec);
            this.Ch2DummyLoadGroupBox.Controls.Add(this.Ch2RefValue);
            this.Ch2DummyLoadGroupBox.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ch2DummyLoadGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Ch2DummyLoadGroupBox.Location = new System.Drawing.Point(6, 19);
            this.Ch2DummyLoadGroupBox.Name = "Ch2DummyLoadGroupBox";
            this.Ch2DummyLoadGroupBox.Size = new System.Drawing.Size(235, 160);
            this.Ch2DummyLoadGroupBox.TabIndex = 1061;
            this.Ch2DummyLoadGroupBox.TabStop = false;
            this.Ch2DummyLoadGroupBox.Text = "Ch2 Dummy Load";
            // 
            // Ch2ShortSec
            // 
            this.Ch2ShortSec.AutoSize = true;
            this.Ch2ShortSec.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ch2ShortSec.ForeColor = System.Drawing.Color.Black;
            this.Ch2ShortSec.Location = new System.Drawing.Point(6, 139);
            this.Ch2ShortSec.Name = "Ch2ShortSec";
            this.Ch2ShortSec.Size = new System.Drawing.Size(82, 18);
            this.Ch2ShortSec.TabIndex = 38;
            this.Ch2ShortSec.Text = "Short Test";
            this.Ch2ShortSec.UseVisualStyleBackColor = true;
            this.Ch2ShortSec.CheckedChanged += new System.EventHandler(this.radioButton18_CheckedChanged);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label51.ForeColor = System.Drawing.Color.Black;
            this.label51.Location = new System.Drawing.Point(7, 68);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(74, 14);
            this.label51.TabIndex = 37;
            this.label51.Text = "Load Model:";
            // 
            // Ch2LoadModel
            // 
            this.Ch2LoadModel.CausesValidation = false;
            this.Ch2LoadModel.FormattingEnabled = true;
            this.Ch2LoadModel.Items.AddRange(new object[] {
            "CC",
            "CR",
            "CP",
            "CV"});
            this.Ch2LoadModel.Location = new System.Drawing.Point(133, 65);
            this.Ch2LoadModel.Name = "Ch2LoadModel";
            this.Ch2LoadModel.Size = new System.Drawing.Size(66, 22);
            this.Ch2LoadModel.TabIndex = 36;
            this.Ch2LoadModel.Text = "CC";
            this.Ch2LoadModel.SelectedIndexChanged += new System.EventHandler(this.Ch2LoadModel_SelectedIndexChanged);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label52.ForeColor = System.Drawing.Color.Black;
            this.label52.Location = new System.Drawing.Point(202, 43);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(15, 14);
            this.label52.TabIndex = 30;
            this.label52.Text = "A";
            // 
            // Ch2StepSize
            // 
            this.Ch2StepSize.DecimalPlaces = 2;
            this.Ch2StepSize.Enabled = false;
            this.Ch2StepSize.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ch2StepSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Ch2StepSize.Location = new System.Drawing.Point(133, 42);
            this.Ch2StepSize.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Ch2StepSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.Ch2StepSize.Name = "Ch2StepSize";
            this.Ch2StepSize.Size = new System.Drawing.Size(66, 20);
            this.Ch2StepSize.TabIndex = 22;
            this.Ch2StepSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Enabled = false;
            this.label53.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label53.ForeColor = System.Drawing.Color.Black;
            this.label53.Location = new System.Drawing.Point(7, 44);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(58, 14);
            this.label53.TabIndex = 28;
            this.label53.Text = "Step Size";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label54.ForeColor = System.Drawing.Color.Black;
            this.label54.Location = new System.Drawing.Point(202, 21);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(15, 14);
            this.label54.TabIndex = 27;
            this.label54.Text = "V";
            // 
            // Ch2CutoffRef
            // 
            this.Ch2CutoffRef.DecimalPlaces = 1;
            this.Ch2CutoffRef.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ch2CutoffRef.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Ch2CutoffRef.Location = new System.Drawing.Point(133, 19);
            this.Ch2CutoffRef.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.Ch2CutoffRef.Name = "Ch2CutoffRef";
            this.Ch2CutoffRef.Size = new System.Drawing.Size(66, 20);
            this.Ch2CutoffRef.TabIndex = 21;
            this.Ch2CutoffRef.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Ch2CutoffRef.ValueChanged += new System.EventHandler(this.Ch2CutoffRef_ValueChanged);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label55.ForeColor = System.Drawing.Color.Black;
            this.label55.Location = new System.Drawing.Point(7, 22);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(85, 14);
            this.label55.TabIndex = 25;
            this.label55.Text = "Cutoff Voltage";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.ForeColor = System.Drawing.Color.Black;
            this.label56.Location = new System.Drawing.Point(202, 118);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(15, 14);
            this.label56.TabIndex = 14;
            this.label56.Text = "A";
            this.label56.Visible = false;
            // 
            // Ch2LoadingTestValue
            // 
            this.Ch2LoadingTestValue.DecimalPlaces = 3;
            this.Ch2LoadingTestValue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ch2LoadingTestValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Ch2LoadingTestValue.Location = new System.Drawing.Point(133, 115);
            this.Ch2LoadingTestValue.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Ch2LoadingTestValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.Ch2LoadingTestValue.Name = "Ch2LoadingTestValue";
            this.Ch2LoadingTestValue.Size = new System.Drawing.Size(67, 20);
            this.Ch2LoadingTestValue.TabIndex = 24;
            this.Ch2LoadingTestValue.Value = new decimal(new int[] {
            2500,
            0,
            0,
            196608});
            this.Ch2LoadingTestValue.Visible = false;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.ForeColor = System.Drawing.Color.Black;
            this.label57.Location = new System.Drawing.Point(202, 94);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(15, 14);
            this.label57.TabIndex = 10;
            this.label57.Text = "A";
            // 
            // Ch2LoadingSec
            // 
            this.Ch2LoadingSec.AutoSize = true;
            this.Ch2LoadingSec.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ch2LoadingSec.ForeColor = System.Drawing.Color.Black;
            this.Ch2LoadingSec.Location = new System.Drawing.Point(6, 115);
            this.Ch2LoadingSec.Name = "Ch2LoadingSec";
            this.Ch2LoadingSec.Size = new System.Drawing.Size(96, 18);
            this.Ch2LoadingSec.TabIndex = 20;
            this.Ch2LoadingSec.Text = "Loading Test";
            this.Ch2LoadingSec.UseVisualStyleBackColor = true;
            this.Ch2LoadingSec.CheckedChanged += new System.EventHandler(this.radioButton19_CheckedChanged);
            // 
            // Ch2ConstantSec
            // 
            this.Ch2ConstantSec.AutoSize = true;
            this.Ch2ConstantSec.Checked = true;
            this.Ch2ConstantSec.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ch2ConstantSec.ForeColor = System.Drawing.Color.Black;
            this.Ch2ConstantSec.Location = new System.Drawing.Point(6, 91);
            this.Ch2ConstantSec.Name = "Ch2ConstantSec";
            this.Ch2ConstantSec.Size = new System.Drawing.Size(121, 18);
            this.Ch2ConstantSec.TabIndex = 19;
            this.Ch2ConstantSec.TabStop = true;
            this.Ch2ConstantSec.Text = "Constant Current";
            this.Ch2ConstantSec.UseVisualStyleBackColor = true;
            this.Ch2ConstantSec.CheckedChanged += new System.EventHandler(this.radioButton20_CheckedChanged);
            // 
            // Ch2RefValue
            // 
            this.Ch2RefValue.DecimalPlaces = 3;
            this.Ch2RefValue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ch2RefValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Ch2RefValue.Location = new System.Drawing.Point(133, 91);
            this.Ch2RefValue.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Ch2RefValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.Ch2RefValue.Name = "Ch2RefValue";
            this.Ch2RefValue.Size = new System.Drawing.Size(67, 20);
            this.Ch2RefValue.TabIndex = 23;
            this.Ch2RefValue.Value = new decimal(new int[] {
            2500,
            0,
            0,
            196608});
            // 
            // Ch2DummyLoadStartButton
            // 
            this.Ch2DummyLoadStartButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ch2DummyLoadStartButton.ForeColor = System.Drawing.Color.Green;
            this.Ch2DummyLoadStartButton.Location = new System.Drawing.Point(6, 183);
            this.Ch2DummyLoadStartButton.Name = "Ch2DummyLoadStartButton";
            this.Ch2DummyLoadStartButton.Size = new System.Drawing.Size(108, 23);
            this.Ch2DummyLoadStartButton.TabIndex = 25;
            this.Ch2DummyLoadStartButton.Text = "Start";
            this.Ch2DummyLoadStartButton.UseVisualStyleBackColor = true;
            this.Ch2DummyLoadStartButton.Click += new System.EventHandler(this.Ch2DummyLoadStartButton_Click);
            // 
            // Ch2DummyLoadStopButton
            // 
            this.Ch2DummyLoadStopButton.Enabled = false;
            this.Ch2DummyLoadStopButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ch2DummyLoadStopButton.ForeColor = System.Drawing.Color.DarkRed;
            this.Ch2DummyLoadStopButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ch2DummyLoadStopButton.Location = new System.Drawing.Point(133, 183);
            this.Ch2DummyLoadStopButton.Name = "Ch2DummyLoadStopButton";
            this.Ch2DummyLoadStopButton.Size = new System.Drawing.Size(108, 23);
            this.Ch2DummyLoadStopButton.TabIndex = 26;
            this.Ch2DummyLoadStopButton.Text = "Stop";
            this.Ch2DummyLoadStopButton.UseVisualStyleBackColor = true;
            this.Ch2DummyLoadStopButton.Click += new System.EventHandler(this.Ch2DummyLoadStopButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(669, 445);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(247, 164);
            this.textBox1.TabIndex = 1134;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 5;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // ledBulb2
            // 
            this.ledBulb2.Color = System.Drawing.Color.Red;
            this.ledBulb2.Location = new System.Drawing.Point(623, 41);
            this.ledBulb2.Name = "ledBulb2";
            this.ledBulb2.On = false;
            this.ledBulb2.Padding = new System.Windows.Forms.Padding(5);
            this.ledBulb2.Size = new System.Drawing.Size(30, 30);
            this.ledBulb2.TabIndex = 1099;
            this.ledBulb2.Text = "ledBulb2";
            // 
            // Ch2_ResSegment
            // 
            this.Ch2_ResSegment.ArrayCount = 6;
            this.Ch2_ResSegment.ColorBackground = System.Drawing.Color.Gainsboro;
            this.Ch2_ResSegment.ColorDark = System.Drawing.Color.White;
            this.Ch2_ResSegment.ColorLight = System.Drawing.Color.Navy;
            this.Ch2_ResSegment.DecimalShow = true;
            this.Ch2_ResSegment.ElementPadding = new System.Windows.Forms.Padding(4);
            this.Ch2_ResSegment.ElementWidth = 10;
            this.Ch2_ResSegment.ForeColor = System.Drawing.Color.Maroon;
            this.Ch2_ResSegment.ItalicFactor = -0.1F;
            this.Ch2_ResSegment.Location = new System.Drawing.Point(455, 33);
            this.Ch2_ResSegment.Name = "Ch2_ResSegment";
            this.Ch2_ResSegment.Size = new System.Drawing.Size(162, 45);
            this.Ch2_ResSegment.TabIndex = 1085;
            this.Ch2_ResSegment.TabStop = false;
            this.Ch2_ResSegment.Value = "------";
            // 
            // Ch2_PowSegment
            // 
            this.Ch2_PowSegment.ArrayCount = 5;
            this.Ch2_PowSegment.ColorBackground = System.Drawing.Color.Gainsboro;
            this.Ch2_PowSegment.ColorDark = System.Drawing.Color.White;
            this.Ch2_PowSegment.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Ch2_PowSegment.DecimalShow = true;
            this.Ch2_PowSegment.ElementPadding = new System.Windows.Forms.Padding(4);
            this.Ch2_PowSegment.ElementWidth = 10;
            this.Ch2_PowSegment.ItalicFactor = -0.1F;
            this.Ch2_PowSegment.Location = new System.Drawing.Point(314, 33);
            this.Ch2_PowSegment.Name = "Ch2_PowSegment";
            this.Ch2_PowSegment.Size = new System.Drawing.Size(135, 45);
            this.Ch2_PowSegment.TabIndex = 2;
            this.Ch2_PowSegment.TabStop = false;
            this.Ch2_PowSegment.Value = "-----";
            // 
            // Ch2_AmpSegment
            // 
            this.Ch2_AmpSegment.ArrayCount = 5;
            this.Ch2_AmpSegment.ColorBackground = System.Drawing.Color.Gainsboro;
            this.Ch2_AmpSegment.ColorDark = System.Drawing.Color.White;
            this.Ch2_AmpSegment.ColorLight = System.Drawing.Color.Green;
            this.Ch2_AmpSegment.DecimalShow = true;
            this.Ch2_AmpSegment.ElementPadding = new System.Windows.Forms.Padding(4);
            this.Ch2_AmpSegment.ElementWidth = 10;
            this.Ch2_AmpSegment.ItalicFactor = -0.1F;
            this.Ch2_AmpSegment.Location = new System.Drawing.Point(173, 33);
            this.Ch2_AmpSegment.Name = "Ch2_AmpSegment";
            this.Ch2_AmpSegment.Size = new System.Drawing.Size(135, 45);
            this.Ch2_AmpSegment.TabIndex = 1;
            this.Ch2_AmpSegment.TabStop = false;
            this.Ch2_AmpSegment.Value = "-----";
            // 
            // Ch2_VoltSegment
            // 
            this.Ch2_VoltSegment.ArrayCount = 6;
            this.Ch2_VoltSegment.ColorBackground = System.Drawing.Color.Gainsboro;
            this.Ch2_VoltSegment.ColorDark = System.Drawing.Color.White;
            this.Ch2_VoltSegment.ColorLight = System.Drawing.SystemColors.HotTrack;
            this.Ch2_VoltSegment.DecimalShow = true;
            this.Ch2_VoltSegment.ElementPadding = new System.Windows.Forms.Padding(4);
            this.Ch2_VoltSegment.ElementWidth = 10;
            this.Ch2_VoltSegment.ItalicFactor = -0.1F;
            this.Ch2_VoltSegment.Location = new System.Drawing.Point(5, 33);
            this.Ch2_VoltSegment.Name = "Ch2_VoltSegment";
            this.Ch2_VoltSegment.Size = new System.Drawing.Size(162, 45);
            this.Ch2_VoltSegment.TabIndex = 0;
            this.Ch2_VoltSegment.TabStop = false;
            this.Ch2_VoltSegment.Value = "------";
            // 
            // ledBulb1
            // 
            this.ledBulb1.Color = System.Drawing.Color.Red;
            this.ledBulb1.Location = new System.Drawing.Point(623, 41);
            this.ledBulb1.Name = "ledBulb1";
            this.ledBulb1.On = false;
            this.ledBulb1.Padding = new System.Windows.Forms.Padding(5);
            this.ledBulb1.Size = new System.Drawing.Size(30, 30);
            this.ledBulb1.TabIndex = 1098;
            this.ledBulb1.Text = "ledBulb1";
            // 
            // Ch1_ResSegment
            // 
            this.Ch1_ResSegment.ArrayCount = 6;
            this.Ch1_ResSegment.ColorBackground = System.Drawing.Color.Gainsboro;
            this.Ch1_ResSegment.ColorDark = System.Drawing.Color.White;
            this.Ch1_ResSegment.ColorLight = System.Drawing.Color.Navy;
            this.Ch1_ResSegment.DecimalShow = true;
            this.Ch1_ResSegment.ElementPadding = new System.Windows.Forms.Padding(4);
            this.Ch1_ResSegment.ElementWidth = 10;
            this.Ch1_ResSegment.ForeColor = System.Drawing.Color.Maroon;
            this.Ch1_ResSegment.ItalicFactor = -0.1F;
            this.Ch1_ResSegment.Location = new System.Drawing.Point(455, 33);
            this.Ch1_ResSegment.Name = "Ch1_ResSegment";
            this.Ch1_ResSegment.Size = new System.Drawing.Size(162, 45);
            this.Ch1_ResSegment.TabIndex = 1085;
            this.Ch1_ResSegment.TabStop = false;
            this.Ch1_ResSegment.Value = "------";
            // 
            // Ch1_PowSegment
            // 
            this.Ch1_PowSegment.ArrayCount = 5;
            this.Ch1_PowSegment.ColorBackground = System.Drawing.Color.Gainsboro;
            this.Ch1_PowSegment.ColorDark = System.Drawing.Color.White;
            this.Ch1_PowSegment.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Ch1_PowSegment.DecimalShow = true;
            this.Ch1_PowSegment.ElementPadding = new System.Windows.Forms.Padding(4);
            this.Ch1_PowSegment.ElementWidth = 10;
            this.Ch1_PowSegment.ItalicFactor = -0.1F;
            this.Ch1_PowSegment.Location = new System.Drawing.Point(314, 33);
            this.Ch1_PowSegment.Name = "Ch1_PowSegment";
            this.Ch1_PowSegment.Size = new System.Drawing.Size(135, 45);
            this.Ch1_PowSegment.TabIndex = 2;
            this.Ch1_PowSegment.TabStop = false;
            this.Ch1_PowSegment.Value = "-----";
            // 
            // Ch1_AmpSegment
            // 
            this.Ch1_AmpSegment.ArrayCount = 5;
            this.Ch1_AmpSegment.ColorBackground = System.Drawing.Color.Gainsboro;
            this.Ch1_AmpSegment.ColorDark = System.Drawing.Color.White;
            this.Ch1_AmpSegment.ColorLight = System.Drawing.Color.Green;
            this.Ch1_AmpSegment.DecimalShow = true;
            this.Ch1_AmpSegment.ElementPadding = new System.Windows.Forms.Padding(4);
            this.Ch1_AmpSegment.ElementWidth = 10;
            this.Ch1_AmpSegment.ItalicFactor = -0.1F;
            this.Ch1_AmpSegment.Location = new System.Drawing.Point(173, 33);
            this.Ch1_AmpSegment.Name = "Ch1_AmpSegment";
            this.Ch1_AmpSegment.Size = new System.Drawing.Size(135, 45);
            this.Ch1_AmpSegment.TabIndex = 1;
            this.Ch1_AmpSegment.TabStop = false;
            this.Ch1_AmpSegment.Value = "-----";
            // 
            // Ch1_VoltSegment
            // 
            this.Ch1_VoltSegment.ArrayCount = 6;
            this.Ch1_VoltSegment.ColorBackground = System.Drawing.Color.Gainsboro;
            this.Ch1_VoltSegment.ColorDark = System.Drawing.Color.White;
            this.Ch1_VoltSegment.ColorLight = System.Drawing.SystemColors.HotTrack;
            this.Ch1_VoltSegment.DecimalShow = true;
            this.Ch1_VoltSegment.ElementPadding = new System.Windows.Forms.Padding(4);
            this.Ch1_VoltSegment.ElementWidth = 10;
            this.Ch1_VoltSegment.ItalicFactor = -0.1F;
            this.Ch1_VoltSegment.Location = new System.Drawing.Point(5, 33);
            this.Ch1_VoltSegment.Name = "Ch1_VoltSegment";
            this.Ch1_VoltSegment.Size = new System.Drawing.Size(162, 45);
            this.Ch1_VoltSegment.TabIndex = 0;
            this.Ch1_VoltSegment.TabStop = false;
            this.Ch1_VoltSegment.Value = "------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 635);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Ch2ClassicalGroupBox);
            this.Controls.Add(this.Ch1ClassicalGroupBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Ch2Measurements);
            this.Controls.Add(this.Ch1Measurements);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.GraphicSettingsGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(938, 674);
            this.Name = "Form1";
            this.Text = "UNI-T UTL8212+ PC Program V1.0";
            this.groupBox1.ResumeLayout(false);
            this.GraphicSettingsGroupBox.ResumeLayout(false);
            this.GraphicSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Ch1Measurements.ResumeLayout(false);
            this.Ch1Measurements.PerformLayout();
            this.Ch2Measurements.ResumeLayout(false);
            this.Ch2Measurements.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.Ch1ClassicalGroupBox.ResumeLayout(false);
            this.Ch1DummyLoadGroupBox.ResumeLayout(false);
            this.Ch1DummyLoadGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ch1StepSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ch1CutoffRef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ch1LoadingTestValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ch1RefValue)).EndInit();
            this.Ch2ClassicalGroupBox.ResumeLayout(false);
            this.Ch2DummyLoadGroupBox.ResumeLayout(false);
            this.Ch2DummyLoadGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ch2StepSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ch2CutoffRef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ch2LoadingTestValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ch2RefValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox BaudList;
        private System.Windows.Forms.Button Connect_Button;
        private System.Windows.Forms.ComboBox ComPortList;
        private System.Windows.Forms.Button disConnect_Button;
        private System.Windows.Forms.GroupBox GraphicSettingsGroupBox;
        private System.Windows.Forms.CheckBox Symb_Select;
        private System.Windows.Forms.ComboBox Y2_Gain_Select;
        private System.Windows.Forms.ComboBox Y1_Gain_Select;
        private System.Windows.Forms.ComboBox X_Gain_Select;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox Y2_Axis_Select;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Y1_Axis_Select;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox X_Axis_Select;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox Grid_Select;
        private System.Windows.Forms.ComboBox Thickness_Select;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox Ch1Measurements;
        private SevenSegmentArray Ch1_VoltSegment;
        private SevenSegmentArray Ch1_PowSegment;
        private SevenSegmentArray Ch1_AmpSegment;
        private System.Windows.Forms.Label label4;
        private SevenSegmentArray Ch1_ResSegment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Ch2Measurements;
        private System.Windows.Forms.Label label5;
        private SevenSegmentArray Ch2_ResSegment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private SevenSegmentArray Ch2_PowSegment;
        private SevenSegmentArray Ch2_AmpSegment;
        private SevenSegmentArray Ch2_VoltSegment;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel2;
        private System.Windows.Forms.GroupBox Ch1ClassicalGroupBox;
        private System.Windows.Forms.GroupBox Ch1DummyLoadGroupBox;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.NumericUpDown Ch1StepSize;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown Ch1CutoffRef;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown Ch1LoadingTestValue;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button Ch1DummyLoadStopButton;
        private System.Windows.Forms.Button Ch1DummyLoadStartButton;
        private System.Windows.Forms.RadioButton Ch1LoadingSec;
        private System.Windows.Forms.RadioButton Ch1ConstantSec;
        private System.Windows.Forms.NumericUpDown Ch1RefValue;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel3;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox Ch1LoadModel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RadioButton Ch1ShortSec;
        private System.Windows.Forms.GroupBox Ch2ClassicalGroupBox;
        private System.Windows.Forms.GroupBox Ch2DummyLoadGroupBox;
        private System.Windows.Forms.RadioButton Ch2ShortSec;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.ComboBox Ch2LoadModel;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.NumericUpDown Ch2StepSize;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.NumericUpDown Ch2CutoffRef;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.NumericUpDown Ch2LoadingTestValue;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Button Ch2DummyLoadStopButton;
        private System.Windows.Forms.Button Ch2DummyLoadStartButton;
        private System.Windows.Forms.RadioButton Ch2LoadingSec;
        private System.Windows.Forms.RadioButton Ch2ConstantSec;
        private System.Windows.Forms.NumericUpDown Ch2RefValue;
        private LedBulb ledBulb1;
        private LedBulb ledBulb2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel5;
    }
}

