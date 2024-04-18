namespace Lab3
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this._samplingListBox = new System.Windows.Forms.ListBox();
            this._divisionRuleComboBox = new System.Windows.Forms.ComboBox();
            this._columnsCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this._columnsCountTrackBar = new System.Windows.Forms.TrackBar();
            this._rebuildButton = new System.Windows.Forms.Button();
            this._countNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this._lawDistributionComboBox = new System.Windows.Forms.ComboBox();
            this._calcButton = new System.Windows.Forms.Button();
            this._mNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this._sigmaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this._ExTextBox = new System.Windows.Forms.TextBox();
            this._xTextBox = new System.Windows.Forms.TextBox();
            this._DTextBox = new System.Windows.Forms.TextBox();
            this._sigmaTextBox = new System.Windows.Forms.TextBox();
            this._AsTextBox = new System.Windows.Forms.TextBox();
            this._samplingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this._ExLabel = new System.Windows.Forms.Label();
            this._AsLable = new System.Windows.Forms.Label();
            this._sigmaLable = new System.Windows.Forms.Label();
            this._DLable = new System.Windows.Forms.Label();
            this._xLable = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this._distChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this._barChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._paramGroupBox = new System.Windows.Forms.GroupBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label5 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._columnsCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._columnsCountTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._countNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._mNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._sigmaNumericUpDown)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._samplingChart)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._distChart)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._barChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this._paramGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            groupBox1.Controls.Add(this._samplingListBox);
            groupBox1.Font = new System.Drawing.Font("MxPlus ToshibaSat 9x16", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Margin = new System.Windows.Forms.Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(268, 710);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выборка";
            // 
            // _samplingListBox
            // 
            this._samplingListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._samplingListBox.FormattingEnabled = true;
            this._samplingListBox.HorizontalScrollbar = true;
            this._samplingListBox.ItemHeight = 20;
            this._samplingListBox.Location = new System.Drawing.Point(3, 23);
            this._samplingListBox.Margin = new System.Windows.Forms.Padding(4);
            this._samplingListBox.Name = "_samplingListBox";
            this._samplingListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this._samplingListBox.Size = new System.Drawing.Size(262, 684);
            this._samplingListBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 13);
            label1.Margin = new System.Windows.Forms.Padding(4);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(174, 20);
            label1.TabIndex = 14;
            label1.Text = "Размер выборки:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(13, 46);
            label2.Margin = new System.Windows.Forms.Padding(4);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(218, 20);
            label2.TabIndex = 15;
            label2.Text = "Закон распределения";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(7, 27);
            label3.Margin = new System.Windows.Forms.Padding(4);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(163, 20);
            label3.TabIndex = 17;
            label3.Text = "Мат. ожидание:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(7, 60);
            label4.Margin = new System.Windows.Forms.Padding(4);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(53, 20);
            label4.TabIndex = 18;
            label4.Text = "СКО:";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(this._divisionRuleComboBox);
            groupBox2.Controls.Add(this._columnsCountNumericUpDown);
            groupBox2.Controls.Add(this._columnsCountTrackBar);
            groupBox2.Controls.Add(this._rebuildButton);
            groupBox2.Location = new System.Drawing.Point(14, 279);
            groupBox2.Margin = new System.Windows.Forms.Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(283, 247);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Гистограмма";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(7, 63);
            label5.Margin = new System.Windows.Forms.Padding(4);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(130, 20);
            label5.TabIndex = 19;
            label5.Text = "Количество:";
            // 
            // _divisionRuleComboBox
            // 
            this._divisionRuleComboBox.FormattingEnabled = true;
            this._divisionRuleComboBox.Location = new System.Drawing.Point(7, 27);
            this._divisionRuleComboBox.Margin = new System.Windows.Forms.Padding(4);
            this._divisionRuleComboBox.Name = "_divisionRuleComboBox";
            this._divisionRuleComboBox.Size = new System.Drawing.Size(269, 28);
            this._divisionRuleComboBox.TabIndex = 10;
            this._divisionRuleComboBox.SelectedIndexChanged += new System.EventHandler(this._divisionRuleComboBox_SelectedIndexChanged);
            // 
            // _columnsCountNumericUpDown
            // 
            this._columnsCountNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._columnsCountNumericUpDown.Location = new System.Drawing.Point(157, 63);
            this._columnsCountNumericUpDown.Margin = new System.Windows.Forms.Padding(16, 4, 4, 4);
            this._columnsCountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._columnsCountNumericUpDown.Name = "_columnsCountNumericUpDown";
            this._columnsCountNumericUpDown.Size = new System.Drawing.Size(119, 27);
            this._columnsCountNumericUpDown.TabIndex = 11;
            this._columnsCountNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._columnsCountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._columnsCountNumericUpDown.ValueChanged += new System.EventHandler(this._columnsCountNumericUpDown_ValueChanged);
            // 
            // _columnsCountTrackBar
            // 
            this._columnsCountTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._columnsCountTrackBar.Location = new System.Drawing.Point(7, 98);
            this._columnsCountTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this._columnsCountTrackBar.Maximum = 100;
            this._columnsCountTrackBar.Minimum = 1;
            this._columnsCountTrackBar.Name = "_columnsCountTrackBar";
            this._columnsCountTrackBar.Size = new System.Drawing.Size(265, 69);
            this._columnsCountTrackBar.TabIndex = 12;
            this._columnsCountTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this._columnsCountTrackBar.Value = 1;
            this._columnsCountTrackBar.Scroll += new System.EventHandler(this._columnsCountTrackBar_Scroll);
            // 
            // _rebuildButton
            // 
            this._rebuildButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._rebuildButton.Font = new System.Drawing.Font("MxPlus ToshibaSat 9x16", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._rebuildButton.Location = new System.Drawing.Point(7, 175);
            this._rebuildButton.Margin = new System.Windows.Forms.Padding(4);
            this._rebuildButton.Name = "_rebuildButton";
            this._rebuildButton.Size = new System.Drawing.Size(269, 64);
            this._rebuildButton.TabIndex = 13;
            this._rebuildButton.Text = "Перестроить";
            this._rebuildButton.UseVisualStyleBackColor = true;
            this._rebuildButton.Click += new System.EventHandler(this._rebuildButtom_Click);
            // 
            // _countNumericUpDown
            // 
            this._countNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._countNumericUpDown.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this._countNumericUpDown.Location = new System.Drawing.Point(207, 11);
            this._countNumericUpDown.Margin = new System.Windows.Forms.Padding(16, 4, 4, 4);
            this._countNumericUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this._countNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._countNumericUpDown.Name = "_countNumericUpDown";
            this._countNumericUpDown.Size = new System.Drawing.Size(89, 27);
            this._countNumericUpDown.TabIndex = 0;
            this._countNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._countNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this._countNumericUpDown.ValueChanged += new System.EventHandler(this._countNumericUpDown_ValueChanged);
            // 
            // _lawDistributionComboBox
            // 
            this._lawDistributionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lawDistributionComboBox.FormattingEnabled = true;
            this._lawDistributionComboBox.Location = new System.Drawing.Point(17, 73);
            this._lawDistributionComboBox.Name = "_lawDistributionComboBox";
            this._lawDistributionComboBox.Size = new System.Drawing.Size(279, 28);
            this._lawDistributionComboBox.TabIndex = 1;
            this._lawDistributionComboBox.SelectedIndexChanged += new System.EventHandler(this._lawDistributionComboBox_SelectedIndexChanged);
            // 
            // _calcButton
            // 
            this._calcButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._calcButton.Font = new System.Drawing.Font("MxPlus ToshibaSat 9x16", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._calcButton.Location = new System.Drawing.Point(13, 207);
            this._calcButton.Margin = new System.Windows.Forms.Padding(4);
            this._calcButton.Name = "_calcButton";
            this._calcButton.Size = new System.Drawing.Size(283, 64);
            this._calcButton.TabIndex = 2;
            this._calcButton.Text = "Расчитать";
            this._calcButton.UseVisualStyleBackColor = true;
            this._calcButton.Click += new System.EventHandler(this._calcButton_Click);
            // 
            // _mNumericUpDown
            // 
            this._mNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._mNumericUpDown.DecimalPlaces = 2;
            this._mNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this._mNumericUpDown.Location = new System.Drawing.Point(190, 25);
            this._mNumericUpDown.Margin = new System.Windows.Forms.Padding(16, 4, 4, 4);
            this._mNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._mNumericUpDown.Name = "_mNumericUpDown";
            this._mNumericUpDown.Size = new System.Drawing.Size(88, 27);
            this._mNumericUpDown.TabIndex = 5;
            this._mNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._mNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this._mNumericUpDown.ValueChanged += new System.EventHandler(this._mNumericUpDown_ValueChanged);
            // 
            // _sigmaNumericUpDown
            // 
            this._sigmaNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._sigmaNumericUpDown.DecimalPlaces = 2;
            this._sigmaNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this._sigmaNumericUpDown.Location = new System.Drawing.Point(190, 58);
            this._sigmaNumericUpDown.Margin = new System.Windows.Forms.Padding(16, 4, 4, 4);
            this._sigmaNumericUpDown.Name = "_sigmaNumericUpDown";
            this._sigmaNumericUpDown.Size = new System.Drawing.Size(88, 27);
            this._sigmaNumericUpDown.TabIndex = 6;
            this._sigmaNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._sigmaNumericUpDown.ValueChanged += new System.EventHandler(this._sigmaNumericUpDown_ValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("MxPlus ToshibaSat 9x16", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(874, 744);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this._ExTextBox);
            this.tabPage1.Controls.Add(this._xTextBox);
            this.tabPage1.Controls.Add(this._DTextBox);
            this.tabPage1.Controls.Add(this._sigmaTextBox);
            this.tabPage1.Controls.Add(this._AsTextBox);
            this.tabPage1.Controls.Add(groupBox1);
            this.tabPage1.Controls.Add(this._samplingChart);
            this.tabPage1.Controls.Add(this._ExLabel);
            this.tabPage1.Controls.Add(this._AsLable);
            this.tabPage1.Controls.Add(this._sigmaLable);
            this.tabPage1.Controls.Add(this._DLable);
            this.tabPage1.Controls.Add(this._xLable);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(866, 710);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Числовые характеристики";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // _ExTextBox
            // 
            this._ExTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._ExTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._ExTextBox.Location = new System.Drawing.Point(585, 160);
            this._ExTextBox.Margin = new System.Windows.Forms.Padding(4);
            this._ExTextBox.Name = "_ExTextBox";
            this._ExTextBox.ReadOnly = true;
            this._ExTextBox.Size = new System.Drawing.Size(272, 27);
            this._ExTextBox.TabIndex = 21;
            // 
            // _xTextBox
            // 
            this._xTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._xTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._xTextBox.Location = new System.Drawing.Point(585, 20);
            this._xTextBox.Margin = new System.Windows.Forms.Padding(4);
            this._xTextBox.Name = "_xTextBox";
            this._xTextBox.ReadOnly = true;
            this._xTextBox.Size = new System.Drawing.Size(272, 27);
            this._xTextBox.TabIndex = 20;
            // 
            // _DTextBox
            // 
            this._DTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._DTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._DTextBox.Location = new System.Drawing.Point(585, 55);
            this._DTextBox.Margin = new System.Windows.Forms.Padding(4);
            this._DTextBox.Name = "_DTextBox";
            this._DTextBox.ReadOnly = true;
            this._DTextBox.Size = new System.Drawing.Size(272, 27);
            this._DTextBox.TabIndex = 19;
            // 
            // _sigmaTextBox
            // 
            this._sigmaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._sigmaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._sigmaTextBox.Location = new System.Drawing.Point(585, 90);
            this._sigmaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this._sigmaTextBox.Name = "_sigmaTextBox";
            this._sigmaTextBox.ReadOnly = true;
            this._sigmaTextBox.Size = new System.Drawing.Size(272, 27);
            this._sigmaTextBox.TabIndex = 18;
            // 
            // _AsTextBox
            // 
            this._AsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._AsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._AsTextBox.Location = new System.Drawing.Point(585, 125);
            this._AsTextBox.Margin = new System.Windows.Forms.Padding(32, 4, 4, 4);
            this._AsTextBox.Name = "_AsTextBox";
            this._AsTextBox.ReadOnly = true;
            this._AsTextBox.Size = new System.Drawing.Size(272, 27);
            this._AsTextBox.TabIndex = 17;
            // 
            // _samplingChart
            // 
            this._samplingChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea7.AxisX.TitleFont = new System.Drawing.Font("MxPlus ToshibaSat 9x16", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea7.AxisX2.TitleFont = new System.Drawing.Font("MxPlus ToshibaSat 9x16", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea7.AxisY.TitleFont = new System.Drawing.Font("MxPlus ToshibaSat 9x16", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea7.AxisY2.TitleFont = new System.Drawing.Font("MxPlus ToshibaSat 9x16", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea7.Name = "ChartArea1";
            this._samplingChart.ChartAreas.Add(chartArea7);
            this._samplingChart.Location = new System.Drawing.Point(276, 195);
            this._samplingChart.Margin = new System.Windows.Forms.Padding(4);
            this._samplingChart.Name = "_samplingChart";
            series7.BorderWidth = 4;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series7.Name = "Series1";
            this._samplingChart.Series.Add(series7);
            this._samplingChart.Size = new System.Drawing.Size(581, 506);
            this._samplingChart.TabIndex = 15;
            this._samplingChart.Text = "chart3";
            // 
            // _ExLabel
            // 
            this._ExLabel.AutoSize = true;
            this._ExLabel.Location = new System.Drawing.Point(276, 162);
            this._ExLabel.Margin = new System.Windows.Forms.Padding(4);
            this._ExLabel.Name = "_ExLabel";
            this._ExLabel.Size = new System.Drawing.Size(251, 20);
            this._ExLabel.TabIndex = 14;
            this._ExLabel.Text = "Оценка коэф. эксцесса:";
            // 
            // _AsLable
            // 
            this._AsLable.AutoSize = true;
            this._AsLable.Location = new System.Drawing.Point(276, 127);
            this._AsLable.Margin = new System.Windows.Forms.Padding(4);
            this._AsLable.Name = "_AsLable";
            this._AsLable.Size = new System.Drawing.Size(273, 20);
            this._AsLable.TabIndex = 13;
            this._AsLable.Text = "Оценка коэф. асимметрии:";
            // 
            // _sigmaLable
            // 
            this._sigmaLable.AutoSize = true;
            this._sigmaLable.Location = new System.Drawing.Point(276, 92);
            this._sigmaLable.Margin = new System.Windows.Forms.Padding(4);
            this._sigmaLable.Name = "_sigmaLable";
            this._sigmaLable.Size = new System.Drawing.Size(130, 20);
            this._sigmaLable.TabIndex = 12;
            this._sigmaLable.Text = "Оценка СКО:";
            // 
            // _DLable
            // 
            this._DLable.AutoSize = true;
            this._DLable.Location = new System.Drawing.Point(276, 57);
            this._DLable.Margin = new System.Windows.Forms.Padding(4);
            this._DLable.Name = "_DLable";
            this._DLable.Size = new System.Drawing.Size(196, 20);
            this._DLable.TabIndex = 11;
            this._DLable.Text = "Оценка дисперсии:";
            // 
            // _xLable
            // 
            this._xLable.AutoSize = true;
            this._xLable.Location = new System.Drawing.Point(276, 22);
            this._xLable.Margin = new System.Windows.Forms.Padding(4);
            this._xLable.Name = "_xLable";
            this._xLable.Size = new System.Drawing.Size(240, 20);
            this._xLable.TabIndex = 10;
            this._xLable.Text = "Оценка мат. ожидания:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this._distChart);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(764, 510);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Оценка функции распределения";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // _distChart
            // 
            chartArea8.Name = "ChartArea1";
            this._distChart.ChartAreas.Add(chartArea8);
            this._distChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this._distChart.Location = new System.Drawing.Point(3, 3);
            this._distChart.Name = "_distChart";
            series8.BorderWidth = 4;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Name = "Series1";
            this._distChart.Series.Add(series8);
            this._distChart.Size = new System.Drawing.Size(758, 504);
            this._distChart.TabIndex = 0;
            this._distChart.Text = "chart1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this._barChart);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(764, 510);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Гистограмма";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // _barChart
            // 
            chartArea9.AxisX.TitleFont = new System.Drawing.Font("MxPlus ToshibaSat 9x16", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea9.AxisX2.TitleFont = new System.Drawing.Font("MxPlus ToshibaSat 9x16", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea9.AxisY.TitleFont = new System.Drawing.Font("MxPlus ToshibaSat 9x16", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea9.AxisY2.TitleFont = new System.Drawing.Font("MxPlus ToshibaSat 9x16", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea9.Name = "ChartArea1";
            this._barChart.ChartAreas.Add(chartArea9);
            this._barChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this._barChart.Location = new System.Drawing.Point(3, 3);
            this._barChart.Name = "_barChart";
            series9.ChartArea = "ChartArea1";
            series9.Font = new System.Drawing.Font("MxPlus ToshibaSat 9x16", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series9.IsValueShownAsLabel = true;
            series9.Name = "Series1";
            this._barChart.Series.Add(series9);
            this._barChart.Size = new System.Drawing.Size(758, 504);
            this._barChart.TabIndex = 1;
            this._barChart.Text = "chart2";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this._paramGroupBox);
            this.splitContainer1.Panel1.Controls.Add(label2);
            this.splitContainer1.Panel1.Controls.Add(label1);
            this.splitContainer1.Panel1.Controls.Add(this._countNumericUpDown);
            this.splitContainer1.Panel1.Controls.Add(this._lawDistributionComboBox);
            this.splitContainer1.Panel1.Controls.Add(this._calcButton);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("MxPlus ToshibaSat 9x16", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1178, 744);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 14;
            // 
            // _paramGroupBox
            // 
            this._paramGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._paramGroupBox.Controls.Add(label4);
            this._paramGroupBox.Controls.Add(label3);
            this._paramGroupBox.Controls.Add(this._mNumericUpDown);
            this._paramGroupBox.Controls.Add(this._sigmaNumericUpDown);
            this._paramGroupBox.Location = new System.Drawing.Point(13, 108);
            this._paramGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this._paramGroupBox.Name = "_paramGroupBox";
            this._paramGroupBox.Size = new System.Drawing.Size(284, 91);
            this._paramGroupBox.TabIndex = 16;
            this._paramGroupBox.TabStop = false;
            this._paramGroupBox.Text = "Параметры";
            this._paramGroupBox.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Main";
            this.Text = " Main";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._columnsCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._columnsCountTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._countNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._mNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._sigmaNumericUpDown)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._samplingChart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._distChart)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._barChart)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this._paramGroupBox.ResumeLayout(false);
            this._paramGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown _countNumericUpDown;
        private System.Windows.Forms.ComboBox _lawDistributionComboBox;
        private System.Windows.Forms.Button _calcButton;
        private System.Windows.Forms.NumericUpDown _mNumericUpDown;
        private System.Windows.Forms.NumericUpDown _sigmaNumericUpDown;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox _samplingListBox;
        private System.Windows.Forms.Label _ExLabel;
        private System.Windows.Forms.Label _AsLable;
        private System.Windows.Forms.Label _sigmaLable;
        private System.Windows.Forms.Label _DLable;
        private System.Windows.Forms.Label _xLable;
        private System.Windows.Forms.DataVisualization.Charting.Chart _distChart;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart _samplingChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart _barChart;
        private System.Windows.Forms.ComboBox _divisionRuleComboBox;
        private System.Windows.Forms.NumericUpDown _columnsCountNumericUpDown;
        private System.Windows.Forms.TrackBar _columnsCountTrackBar;
        private System.Windows.Forms.Button _rebuildButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox _AsTextBox;
        private System.Windows.Forms.TextBox _ExTextBox;
        private System.Windows.Forms.TextBox _xTextBox;
        private System.Windows.Forms.TextBox _DTextBox;
        private System.Windows.Forms.TextBox _sigmaTextBox;
        private System.Windows.Forms.GroupBox _paramGroupBox;
    }
}

