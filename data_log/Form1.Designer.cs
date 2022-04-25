
namespace data_log
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_go = new System.Windows.Forms.Button();
            this.txtbx_data = new System.Windows.Forms.TextBox();
            this.rchtxtbx_output = new System.Windows.Forms.RichTextBox();
            this.chkbx_1hz = new System.Windows.Forms.CheckBox();
            this.chkbx_2hz = new System.Windows.Forms.CheckBox();
            this.chkbx_5hz = new System.Windows.Forms.CheckBox();
            this.chkbx_10hz = new System.Windows.Forms.CheckBox();
            this.chkbx_20hz = new System.Windows.Forms.CheckBox();
            this.chkbx_50hz = new System.Windows.Forms.CheckBox();
            this.chkbx_100hz = new System.Windows.Forms.CheckBox();
            this.chkbx_200hz = new System.Windows.Forms.CheckBox();
            this.chkbx_1000hz = new System.Windows.Forms.CheckBox();
            this.chkbx_500hz = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_id_1hz = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbx_id_2hz = new System.Windows.Forms.TextBox();
            this.txtbx_id_5hz = new System.Windows.Forms.TextBox();
            this.txtbx_id_10hz = new System.Windows.Forms.TextBox();
            this.txtbx_id_20hz = new System.Windows.Forms.TextBox();
            this.txtbx_id_50hz = new System.Windows.Forms.TextBox();
            this.txtbx_id_100hz = new System.Windows.Forms.TextBox();
            this.txtbx_id_200hz = new System.Windows.Forms.TextBox();
            this.txtbx_id_500hz = new System.Windows.Forms.TextBox();
            this.txtbx_id_1000hz = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.txtbx_num_items = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_populate = new System.Windows.Forms.Button();
            this.txtbx_values = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_LoggedData = new System.Windows.Forms.DataGridView();
            this.rdobtn_0 = new System.Windows.Forms.RadioButton();
            this.rdobtn_438 = new System.Windows.Forms.RadioButton();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoggedData)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_go
            // 
            this.btn_go.Location = new System.Drawing.Point(291, 23);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(83, 58);
            this.btn_go.TabIndex = 0;
            this.btn_go.Text = "Go";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // txtbx_data
            // 
            this.txtbx_data.Location = new System.Drawing.Point(114, 23);
            this.txtbx_data.Name = "txtbx_data";
            this.txtbx_data.Size = new System.Drawing.Size(118, 26);
            this.txtbx_data.TabIndex = 1;
            // 
            // rchtxtbx_output
            // 
            this.rchtxtbx_output.Location = new System.Drawing.Point(644, 12);
            this.rchtxtbx_output.Name = "rchtxtbx_output";
            this.rchtxtbx_output.Size = new System.Drawing.Size(621, 705);
            this.rchtxtbx_output.TabIndex = 2;
            this.rchtxtbx_output.Text = "";
            // 
            // chkbx_1hz
            // 
            this.chkbx_1hz.AutoSize = true;
            this.chkbx_1hz.Location = new System.Drawing.Point(60, 42);
            this.chkbx_1hz.Name = "chkbx_1hz";
            this.chkbx_1hz.Size = new System.Drawing.Size(64, 24);
            this.chkbx_1hz.TabIndex = 3;
            this.chkbx_1hz.Text = "1Hz";
            this.chkbx_1hz.UseVisualStyleBackColor = true;
            // 
            // chkbx_2hz
            // 
            this.chkbx_2hz.AutoSize = true;
            this.chkbx_2hz.Location = new System.Drawing.Point(281, 42);
            this.chkbx_2hz.Name = "chkbx_2hz";
            this.chkbx_2hz.Size = new System.Drawing.Size(64, 24);
            this.chkbx_2hz.TabIndex = 4;
            this.chkbx_2hz.Text = "2Hz";
            this.chkbx_2hz.UseVisualStyleBackColor = true;
            // 
            // chkbx_5hz
            // 
            this.chkbx_5hz.AutoSize = true;
            this.chkbx_5hz.Location = new System.Drawing.Point(487, 42);
            this.chkbx_5hz.Name = "chkbx_5hz";
            this.chkbx_5hz.Size = new System.Drawing.Size(64, 24);
            this.chkbx_5hz.TabIndex = 5;
            this.chkbx_5hz.Text = "5Hz";
            this.chkbx_5hz.UseVisualStyleBackColor = true;
            // 
            // chkbx_10hz
            // 
            this.chkbx_10hz.AutoSize = true;
            this.chkbx_10hz.Location = new System.Drawing.Point(60, 74);
            this.chkbx_10hz.Name = "chkbx_10hz";
            this.chkbx_10hz.Size = new System.Drawing.Size(73, 24);
            this.chkbx_10hz.TabIndex = 6;
            this.chkbx_10hz.Text = "10Hz";
            this.chkbx_10hz.UseVisualStyleBackColor = true;
            // 
            // chkbx_20hz
            // 
            this.chkbx_20hz.AutoSize = true;
            this.chkbx_20hz.Location = new System.Drawing.Point(281, 76);
            this.chkbx_20hz.Name = "chkbx_20hz";
            this.chkbx_20hz.Size = new System.Drawing.Size(73, 24);
            this.chkbx_20hz.TabIndex = 7;
            this.chkbx_20hz.Text = "20Hz";
            this.chkbx_20hz.UseVisualStyleBackColor = true;
            // 
            // chkbx_50hz
            // 
            this.chkbx_50hz.AutoSize = true;
            this.chkbx_50hz.Location = new System.Drawing.Point(487, 78);
            this.chkbx_50hz.Name = "chkbx_50hz";
            this.chkbx_50hz.Size = new System.Drawing.Size(73, 24);
            this.chkbx_50hz.TabIndex = 8;
            this.chkbx_50hz.Text = "50Hz";
            this.chkbx_50hz.UseVisualStyleBackColor = true;
            // 
            // chkbx_100hz
            // 
            this.chkbx_100hz.AutoSize = true;
            this.chkbx_100hz.Location = new System.Drawing.Point(61, 106);
            this.chkbx_100hz.Name = "chkbx_100hz";
            this.chkbx_100hz.Size = new System.Drawing.Size(82, 24);
            this.chkbx_100hz.TabIndex = 9;
            this.chkbx_100hz.Text = "100Hz";
            this.chkbx_100hz.UseVisualStyleBackColor = true;
            // 
            // chkbx_200hz
            // 
            this.chkbx_200hz.AutoSize = true;
            this.chkbx_200hz.Location = new System.Drawing.Point(281, 108);
            this.chkbx_200hz.Name = "chkbx_200hz";
            this.chkbx_200hz.Size = new System.Drawing.Size(82, 24);
            this.chkbx_200hz.TabIndex = 10;
            this.chkbx_200hz.Text = "200Hz";
            this.chkbx_200hz.UseVisualStyleBackColor = true;
            // 
            // chkbx_1000hz
            // 
            this.chkbx_1000hz.AutoSize = true;
            this.chkbx_1000hz.Location = new System.Drawing.Point(61, 138);
            this.chkbx_1000hz.Name = "chkbx_1000hz";
            this.chkbx_1000hz.Size = new System.Drawing.Size(91, 24);
            this.chkbx_1000hz.TabIndex = 12;
            this.chkbx_1000hz.Text = "1000Hz";
            this.chkbx_1000hz.UseVisualStyleBackColor = true;
            // 
            // chkbx_500hz
            // 
            this.chkbx_500hz.AutoSize = true;
            this.chkbx_500hz.Location = new System.Drawing.Point(487, 110);
            this.chkbx_500hz.Name = "chkbx_500hz";
            this.chkbx_500hz.Size = new System.Drawing.Size(82, 24);
            this.chkbx_500hz.TabIndex = 11;
            this.chkbx_500hz.Text = "500Hz";
            this.chkbx_500hz.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Start Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "ms";
            // 
            // txtbx_id_1hz
            // 
            this.txtbx_id_1hz.Location = new System.Drawing.Point(14, 40);
            this.txtbx_id_1hz.Name = "txtbx_id_1hz";
            this.txtbx_id_1hz.Size = new System.Drawing.Size(40, 26);
            this.txtbx_id_1hz.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Frequency";
            // 
            // txtbx_id_2hz
            // 
            this.txtbx_id_2hz.Location = new System.Drawing.Point(235, 40);
            this.txtbx_id_2hz.Name = "txtbx_id_2hz";
            this.txtbx_id_2hz.Size = new System.Drawing.Size(40, 26);
            this.txtbx_id_2hz.TabIndex = 18;
            // 
            // txtbx_id_5hz
            // 
            this.txtbx_id_5hz.Location = new System.Drawing.Point(441, 40);
            this.txtbx_id_5hz.Name = "txtbx_id_5hz";
            this.txtbx_id_5hz.Size = new System.Drawing.Size(40, 26);
            this.txtbx_id_5hz.TabIndex = 19;
            // 
            // txtbx_id_10hz
            // 
            this.txtbx_id_10hz.Location = new System.Drawing.Point(14, 72);
            this.txtbx_id_10hz.Name = "txtbx_id_10hz";
            this.txtbx_id_10hz.Size = new System.Drawing.Size(40, 26);
            this.txtbx_id_10hz.TabIndex = 20;
            // 
            // txtbx_id_20hz
            // 
            this.txtbx_id_20hz.Location = new System.Drawing.Point(235, 74);
            this.txtbx_id_20hz.Name = "txtbx_id_20hz";
            this.txtbx_id_20hz.Size = new System.Drawing.Size(40, 26);
            this.txtbx_id_20hz.TabIndex = 21;
            // 
            // txtbx_id_50hz
            // 
            this.txtbx_id_50hz.Location = new System.Drawing.Point(441, 76);
            this.txtbx_id_50hz.Name = "txtbx_id_50hz";
            this.txtbx_id_50hz.Size = new System.Drawing.Size(40, 26);
            this.txtbx_id_50hz.TabIndex = 22;
            // 
            // txtbx_id_100hz
            // 
            this.txtbx_id_100hz.Location = new System.Drawing.Point(15, 104);
            this.txtbx_id_100hz.Name = "txtbx_id_100hz";
            this.txtbx_id_100hz.Size = new System.Drawing.Size(40, 26);
            this.txtbx_id_100hz.TabIndex = 23;
            // 
            // txtbx_id_200hz
            // 
            this.txtbx_id_200hz.Location = new System.Drawing.Point(235, 106);
            this.txtbx_id_200hz.Name = "txtbx_id_200hz";
            this.txtbx_id_200hz.Size = new System.Drawing.Size(40, 26);
            this.txtbx_id_200hz.TabIndex = 24;
            // 
            // txtbx_id_500hz
            // 
            this.txtbx_id_500hz.Location = new System.Drawing.Point(441, 108);
            this.txtbx_id_500hz.Name = "txtbx_id_500hz";
            this.txtbx_id_500hz.Size = new System.Drawing.Size(40, 26);
            this.txtbx_id_500hz.TabIndex = 25;
            // 
            // txtbx_id_1000hz
            // 
            this.txtbx_id_1000hz.Location = new System.Drawing.Point(15, 136);
            this.txtbx_id_1000hz.Name = "txtbx_id_1000hz";
            this.txtbx_id_1000hz.Size = new System.Drawing.Size(40, 26);
            this.txtbx_id_1000hz.TabIndex = 26;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(644, 723);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(135, 44);
            this.btn_clear.TabIndex = 27;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(1152, 723);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(113, 44);
            this.btn_close.TabIndex = 28;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txtbx_num_items
            // 
            this.txtbx_num_items.Location = new System.Drawing.Point(114, 55);
            this.txtbx_num_items.Name = "txtbx_num_items";
            this.txtbx_num_items.Size = new System.Drawing.Size(118, 26);
            this.txtbx_num_items.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Data Length";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "bytes";
            // 
            // btn_populate
            // 
            this.btn_populate.Location = new System.Drawing.Point(414, 42);
            this.btn_populate.Name = "btn_populate";
            this.btn_populate.Size = new System.Drawing.Size(160, 39);
            this.btn_populate.TabIndex = 32;
            this.btn_populate.Text = "Populate";
            this.btn_populate.UseVisualStyleBackColor = true;
            this.btn_populate.Click += new System.EventHandler(this.btn_populate_Click);
            // 
            // txtbx_values
            // 
            this.txtbx_values.Location = new System.Drawing.Point(114, 87);
            this.txtbx_values.Name = "txtbx_values";
            this.txtbx_values.Size = new System.Drawing.Size(473, 26);
            this.txtbx_values.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Values";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(277, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Frequency";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(242, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(481, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 38;
            this.label10.Text = "Frequency";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(446, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 20);
            this.label11.TabIndex = 37;
            this.label11.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtbx_id_1000hz);
            this.groupBox1.Controls.Add(this.txtbx_id_500hz);
            this.groupBox1.Controls.Add(this.txtbx_id_200hz);
            this.groupBox1.Controls.Add(this.txtbx_id_100hz);
            this.groupBox1.Controls.Add(this.txtbx_id_50hz);
            this.groupBox1.Controls.Add(this.txtbx_id_20hz);
            this.groupBox1.Controls.Add(this.txtbx_id_10hz);
            this.groupBox1.Controls.Add(this.txtbx_id_5hz);
            this.groupBox1.Controls.Add(this.txtbx_id_2hz);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtbx_id_1hz);
            this.groupBox1.Controls.Add(this.chkbx_1000hz);
            this.groupBox1.Controls.Add(this.chkbx_500hz);
            this.groupBox1.Controls.Add(this.chkbx_200hz);
            this.groupBox1.Controls.Add(this.chkbx_100hz);
            this.groupBox1.Controls.Add(this.chkbx_50hz);
            this.groupBox1.Controls.Add(this.chkbx_20hz);
            this.groupBox1.Controls.Add(this.chkbx_10hz);
            this.groupBox1.Controls.Add(this.chkbx_5hz);
            this.groupBox1.Controls.Add(this.chkbx_2hz);
            this.groupBox1.Controls.Add(this.chkbx_1hz);
            this.groupBox1.Location = new System.Drawing.Point(27, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 183);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdobtn_438);
            this.groupBox2.Controls.Add(this.rdobtn_0);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtbx_values);
            this.groupBox2.Controls.Add(this.btn_populate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtbx_num_items);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtbx_data);
            this.groupBox2.Controls.Add(this.btn_go);
            this.groupBox2.Location = new System.Drawing.Point(27, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 129);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            // 
            // dgv_LoggedData
            // 
            this.dgv_LoggedData.AllowUserToAddRows = false;
            this.dgv_LoggedData.AllowUserToDeleteRows = false;
            this.dgv_LoggedData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_LoggedData.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_LoggedData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_LoggedData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LoggedData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.StartTime,
            this.Frequency,
            this.Count,
            this.Value});
            this.dgv_LoggedData.Location = new System.Drawing.Point(27, 336);
            this.dgv_LoggedData.Name = "dgv_LoggedData";
            this.dgv_LoggedData.ReadOnly = true;
            this.dgv_LoggedData.RowHeadersVisible = false;
            this.dgv_LoggedData.RowHeadersWidth = 62;
            this.dgv_LoggedData.RowTemplate.Height = 28;
            this.dgv_LoggedData.Size = new System.Drawing.Size(595, 431);
            this.dgv_LoggedData.TabIndex = 41;
            // 
            // rdobtn_0
            // 
            this.rdobtn_0.AutoSize = true;
            this.rdobtn_0.Location = new System.Drawing.Point(526, 12);
            this.rdobtn_0.Name = "rdobtn_0";
            this.rdobtn_0.Size = new System.Drawing.Size(43, 24);
            this.rdobtn_0.TabIndex = 35;
            this.rdobtn_0.Text = "0";
            this.rdobtn_0.UseVisualStyleBackColor = true;
            // 
            // rdobtn_438
            // 
            this.rdobtn_438.AutoSize = true;
            this.rdobtn_438.Checked = true;
            this.rdobtn_438.Location = new System.Drawing.Point(414, 12);
            this.rdobtn_438.Name = "rdobtn_438";
            this.rdobtn_438.Size = new System.Drawing.Size(88, 24);
            this.rdobtn_438.TabIndex = 36;
            this.rdobtn_438.TabStop = true;
            this.rdobtn_438.Text = "456438";
            this.rdobtn_438.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "Start Time";
            this.StartTime.MinimumWidth = 8;
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            this.StartTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Frequency
            // 
            this.Frequency.HeaderText = "Frequency";
            this.Frequency.MinimumWidth = 8;
            this.Frequency.Name = "Frequency";
            this.Frequency.ReadOnly = true;
            this.Frequency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Count
            // 
            this.Count.HeaderText = "Count";
            this.Count.MinimumWidth = 8;
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.MinimumWidth = 8;
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 779);
            this.Controls.Add(this.dgv_LoggedData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.rchtxtbx_output);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Data Logger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoggedData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.TextBox txtbx_data;
        private System.Windows.Forms.RichTextBox rchtxtbx_output;
        private System.Windows.Forms.CheckBox chkbx_1hz;
        private System.Windows.Forms.CheckBox chkbx_2hz;
        private System.Windows.Forms.CheckBox chkbx_5hz;
        private System.Windows.Forms.CheckBox chkbx_10hz;
        private System.Windows.Forms.CheckBox chkbx_20hz;
        private System.Windows.Forms.CheckBox chkbx_50hz;
        private System.Windows.Forms.CheckBox chkbx_100hz;
        private System.Windows.Forms.CheckBox chkbx_200hz;
        private System.Windows.Forms.CheckBox chkbx_1000hz;
        private System.Windows.Forms.CheckBox chkbx_500hz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_id_1hz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbx_id_2hz;
        private System.Windows.Forms.TextBox txtbx_id_5hz;
        private System.Windows.Forms.TextBox txtbx_id_10hz;
        private System.Windows.Forms.TextBox txtbx_id_20hz;
        private System.Windows.Forms.TextBox txtbx_id_50hz;
        private System.Windows.Forms.TextBox txtbx_id_100hz;
        private System.Windows.Forms.TextBox txtbx_id_200hz;
        private System.Windows.Forms.TextBox txtbx_id_500hz;
        private System.Windows.Forms.TextBox txtbx_id_1000hz;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txtbx_num_items;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_populate;
        private System.Windows.Forms.TextBox txtbx_values;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_LoggedData;
        private System.Windows.Forms.RadioButton rdobtn_438;
        private System.Windows.Forms.RadioButton rdobtn_0;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}

