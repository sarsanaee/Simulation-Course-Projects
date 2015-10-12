namespace ableAndBakerProblem
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.simBtn = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clearBtn = new System.Windows.Forms.Button();
            this.ChartPanel = new System.Windows.Forms.Panel();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl0 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeChart = new System.Windows.Forms.Button();
            this.SecondResault = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.drawChart = new System.Windows.Forms.Button();
            this.comboCharts = new System.Windows.Forms.ComboBox();
            this.txtCustomerNum = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAr1 = new System.Windows.Forms.TextBox();
            this.txtAr2 = new System.Windows.Forms.TextBox();
            this.txtAr3 = new System.Windows.Forms.TextBox();
            this.txtAr4 = new System.Windows.Forms.TextBox();
            this.txtAble4 = new System.Windows.Forms.TextBox();
            this.txtAble3 = new System.Windows.Forms.TextBox();
            this.txtAble2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAble1 = new System.Windows.Forms.TextBox();
            this.txtBaker4 = new System.Windows.Forms.TextBox();
            this.txtBaker3 = new System.Windows.Forms.TextBox();
            this.txtBaker2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBaker1 = new System.Windows.Forms.TextBox();
            this.statsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.ChartPanel.SuspendLayout();
            this.statsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondResault)).BeginInit();
            this.SuspendLayout();
            // 
            // simBtn
            // 
            this.simBtn.Location = new System.Drawing.Point(503, 455);
            this.simBtn.Name = "simBtn";
            this.simBtn.Size = new System.Drawing.Size(107, 51);
            this.simBtn.TabIndex = 0;
            this.simBtn.Text = "Simulation";
            this.simBtn.UseVisualStyleBackColor = true;
            this.simBtn.Click += new System.EventHandler(this.simBtn_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dataGrid.Location = new System.Drawing.Point(12, 12);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(1199, 424);
            this.dataGrid.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Costumer Number";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Inter Arrival Time";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Arrival Time";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "When Able Available";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "When Baker Available";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Server Choosen";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Service Time";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Time Service Begins";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Able Service Compelete Time";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Baker Service Compelete Time";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Costumer Delay";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Time in System";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(519, 512);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "Clear table";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // ChartPanel
            // 
            this.ChartPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ChartPanel.Controls.Add(this.label2);
            this.ChartPanel.Controls.Add(this.label1);
            this.ChartPanel.Controls.Add(this.closeChart);
            this.ChartPanel.Controls.Add(this.SecondResault);
            this.ChartPanel.Location = new System.Drawing.Point(260, 71);
            this.ChartPanel.Name = "ChartPanel";
            this.ChartPanel.Size = new System.Drawing.Size(579, 328);
            this.ChartPanel.TabIndex = 3;
            this.ChartPanel.Visible = false;
            this.ChartPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.chart_Paint);
            // 
            // statsPanel
            // 
            this.statsPanel.BackColor = System.Drawing.Color.RosyBrown;
            this.statsPanel.Controls.Add(this.label21);
            this.statsPanel.Controls.Add(this.label22);
            this.statsPanel.Controls.Add(this.label19);
            this.statsPanel.Controls.Add(this.label20);
            this.statsPanel.Controls.Add(this.label17);
            this.statsPanel.Controls.Add(this.label18);
            this.statsPanel.Controls.Add(this.label15);
            this.statsPanel.Controls.Add(this.label16);
            this.statsPanel.Controls.Add(this.label13);
            this.statsPanel.Controls.Add(this.label14);
            this.statsPanel.Controls.Add(this.button1);
            this.statsPanel.Controls.Add(this.label11);
            this.statsPanel.Controls.Add(this.label12);
            this.statsPanel.Controls.Add(this.label9);
            this.statsPanel.Controls.Add(this.label10);
            this.statsPanel.Controls.Add(this.label7);
            this.statsPanel.Controls.Add(this.label8);
            this.statsPanel.Controls.Add(this.lbl0);
            this.statsPanel.Controls.Add(this.label6);
            this.statsPanel.Location = new System.Drawing.Point(260, 71);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(579, 328);
            this.statsPanel.TabIndex = 4;
            this.statsPanel.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(266, 289);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 13);
            this.label21.TabIndex = 18;
            this.label21.Text = "label21";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(35, 289);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(98, 13);
            this.label22.TabIndex = 17;
            this.label22.Text = "total baker idle time";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(265, 256);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 16;
            this.label19.Text = "label19";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(34, 256);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 13);
            this.label20.TabIndex = 15;
            this.label20.Text = "total able idle time";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(265, 223);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "label17";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(34, 223);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(194, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "average time costumers spent in system";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(265, 190);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "label15";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(34, 190);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(190, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "average waiting time of those who wait";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(265, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 157);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(148, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "average time between arrivals";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(522, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 57);
            this.button1.TabIndex = 8;
            this.button1.Text = "close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(265, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "baker service utilization";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(265, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "able service utilization";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "total time costumers wait in queue";
            // 
            // lbl0
            // 
            this.lbl0.AutoSize = true;
            this.lbl0.Location = new System.Drawing.Point(265, 25);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(35, 13);
            this.lbl0.TabIndex = 1;
            this.lbl0.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "wait Probability";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of People";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // closeChart
            // 
            this.closeChart.Location = new System.Drawing.Point(519, 3);
            this.closeChart.Name = "closeChart";
            this.closeChart.Size = new System.Drawing.Size(57, 57);
            this.closeChart.TabIndex = 1;
            this.closeChart.Text = "close";
            this.closeChart.UseVisualStyleBackColor = true;
            this.closeChart.Click += new System.EventHandler(this.closeChart_Click);
            // 
            // SecondResault
            // 
            this.SecondResault.BackColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea6.Name = "ChartArea1";
            this.SecondResault.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.SecondResault.Legends.Add(legend6);
            this.SecondResault.Location = new System.Drawing.Point(3, 25);
            this.SecondResault.Name = "SecondResault";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.SecondResault.Series.Add(series6);
            this.SecondResault.Size = new System.Drawing.Size(538, 300);
            this.SecondResault.TabIndex = 0;
            this.SecondResault.Text = "chart1";
            // 
            // drawChart
            // 
            this.drawChart.Enabled = false;
            this.drawChart.Location = new System.Drawing.Point(135, 449);
            this.drawChart.Name = "drawChart";
            this.drawChart.Size = new System.Drawing.Size(80, 30);
            this.drawChart.TabIndex = 4;
            this.drawChart.Text = "Draw chart";
            this.drawChart.UseVisualStyleBackColor = true;
            this.drawChart.Click += new System.EventHandler(this.drawChart_Click);
            // 
            // comboCharts
            // 
            this.comboCharts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCharts.FormattingEnabled = true;
            this.comboCharts.Items.AddRange(new object[] {
            "Delay",
            "Time spent in system"});
            this.comboCharts.Location = new System.Drawing.Point(8, 455);
            this.comboCharts.Name = "comboCharts";
            this.comboCharts.Size = new System.Drawing.Size(121, 21);
            this.comboCharts.TabIndex = 5;
            // 
            // txtCustomerNum
            // 
            this.txtCustomerNum.Location = new System.Drawing.Point(115, 543);
            this.txtCustomerNum.Name = "txtCustomerNum";
            this.txtCustomerNum.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerNum.TabIndex = 6;
            this.txtCustomerNum.Text = "100";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(12, 546);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(93, 13);
            this.lbl.TabIndex = 7;
            this.lbl.Text = "CustomersNumber";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "arivalTimes :";
            // 
            // txtAr1
            // 
            this.txtAr1.Location = new System.Drawing.Point(370, 442);
            this.txtAr1.Name = "txtAr1";
            this.txtAr1.Size = new System.Drawing.Size(100, 20);
            this.txtAr1.TabIndex = 8;
            this.txtAr1.Text = "1";
            // 
            // txtAr2
            // 
            this.txtAr2.Location = new System.Drawing.Point(370, 475);
            this.txtAr2.Name = "txtAr2";
            this.txtAr2.Size = new System.Drawing.Size(100, 20);
            this.txtAr2.TabIndex = 10;
            this.txtAr2.Text = "2";
            // 
            // txtAr3
            // 
            this.txtAr3.Location = new System.Drawing.Point(370, 508);
            this.txtAr3.Name = "txtAr3";
            this.txtAr3.Size = new System.Drawing.Size(100, 20);
            this.txtAr3.TabIndex = 12;
            this.txtAr3.Text = "3";
            // 
            // txtAr4
            // 
            this.txtAr4.Location = new System.Drawing.Point(370, 541);
            this.txtAr4.Name = "txtAr4";
            this.txtAr4.Size = new System.Drawing.Size(100, 20);
            this.txtAr4.TabIndex = 14;
            this.txtAr4.Text = "4";
            // 
            // txtAble4
            // 
            this.txtAble4.Location = new System.Drawing.Point(728, 541);
            this.txtAble4.Name = "txtAble4";
            this.txtAble4.Size = new System.Drawing.Size(100, 20);
            this.txtAble4.TabIndex = 19;
            this.txtAble4.Text = "5";
            // 
            // txtAble3
            // 
            this.txtAble3.Location = new System.Drawing.Point(728, 508);
            this.txtAble3.Name = "txtAble3";
            this.txtAble3.Size = new System.Drawing.Size(100, 20);
            this.txtAble3.TabIndex = 18;
            this.txtAble3.Text = "4";
            // 
            // txtAble2
            // 
            this.txtAble2.Location = new System.Drawing.Point(728, 475);
            this.txtAble2.Name = "txtAble2";
            this.txtAble2.Size = new System.Drawing.Size(100, 20);
            this.txtAble2.TabIndex = 17;
            this.txtAble2.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(625, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "able service times :";
            // 
            // txtAble1
            // 
            this.txtAble1.Location = new System.Drawing.Point(728, 442);
            this.txtAble1.Name = "txtAble1";
            this.txtAble1.Size = new System.Drawing.Size(100, 20);
            this.txtAble1.TabIndex = 15;
            this.txtAble1.Text = "2";
            // 
            // txtBaker4
            // 
            this.txtBaker4.Location = new System.Drawing.Point(997, 541);
            this.txtBaker4.Name = "txtBaker4";
            this.txtBaker4.Size = new System.Drawing.Size(100, 20);
            this.txtBaker4.TabIndex = 24;
            this.txtBaker4.Text = "6";
            // 
            // txtBaker3
            // 
            this.txtBaker3.Location = new System.Drawing.Point(997, 508);
            this.txtBaker3.Name = "txtBaker3";
            this.txtBaker3.Size = new System.Drawing.Size(100, 20);
            this.txtBaker3.TabIndex = 23;
            this.txtBaker3.Text = "5";
            // 
            // txtBaker2
            // 
            this.txtBaker2.Location = new System.Drawing.Point(997, 475);
            this.txtBaker2.Name = "txtBaker2";
            this.txtBaker2.Size = new System.Drawing.Size(100, 20);
            this.txtBaker2.TabIndex = 22;
            this.txtBaker2.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(877, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "baker service times :";
            // 
            // txtBaker1
            // 
            this.txtBaker1.Location = new System.Drawing.Point(997, 442);
            this.txtBaker1.Name = "txtBaker1";
            this.txtBaker1.Size = new System.Drawing.Size(100, 20);
            this.txtBaker1.TabIndex = 20;
            this.txtBaker1.Text = "3";
            // 
            // statsBtn
            // 
            this.statsBtn.Location = new System.Drawing.Point(8, 494);
            this.statsBtn.Name = "statsBtn";
            this.statsBtn.Size = new System.Drawing.Size(207, 34);
            this.statsBtn.TabIndex = 25;
            this.statsBtn.Text = "Show statistics";
            this.statsBtn.UseVisualStyleBackColor = true;
            this.statsBtn.Click += new System.EventHandler(this.statsBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 575);
            this.Controls.Add(this.statsPanel);
            this.Controls.Add(this.statsBtn);
            this.Controls.Add(this.txtBaker4);
            this.Controls.Add(this.txtBaker3);
            this.Controls.Add(this.txtBaker2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBaker1);
            this.Controls.Add(this.txtAble4);
            this.Controls.Add(this.txtAble3);
            this.Controls.Add(this.txtAble2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAble1);
            this.Controls.Add(this.txtAr4);
            this.Controls.Add(this.txtAr3);
            this.Controls.Add(this.txtAr2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAr1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtCustomerNum);
            this.Controls.Add(this.comboCharts);
            this.Controls.Add(this.drawChart);
            this.Controls.Add(this.ChartPanel);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.simBtn);
            this.Name = "MainForm";
            this.Text = "Seyed Masoud Barati, Seyed Alireza Sanaee";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ChartPanel.ResumeLayout(false);
            this.ChartPanel.PerformLayout();
            this.statsPanel.ResumeLayout(false);
            this.statsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondResault)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button simBtn;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Panel ChartPanel;
        private System.Windows.Forms.Button closeChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart SecondResault;
        private System.Windows.Forms.Button drawChart;
        private System.Windows.Forms.ComboBox comboCharts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerNum;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAr1;
        private System.Windows.Forms.TextBox txtAr2;
        private System.Windows.Forms.TextBox txtAr3;
        private System.Windows.Forms.TextBox txtAr4;
        private System.Windows.Forms.TextBox txtAble4;
        private System.Windows.Forms.TextBox txtAble3;
        private System.Windows.Forms.TextBox txtAble2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAble1;
        private System.Windows.Forms.TextBox txtBaker4;
        private System.Windows.Forms.TextBox txtBaker3;
        private System.Windows.Forms.TextBox txtBaker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBaker1;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button statsBtn;
    }
}

