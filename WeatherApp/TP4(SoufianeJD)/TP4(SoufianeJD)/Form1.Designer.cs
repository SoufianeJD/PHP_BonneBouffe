namespace TP4_SoufianeJD_
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_months = new System.Windows.Forms.Label();
            this.cb_months = new System.Windows.Forms.ComboBox();
            this.numericUpDownTMMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTMM = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPTM = new System.Windows.Forms.NumericUpDown();
            this.lbl_minT = new System.Windows.Forms.Label();
            this.lbl_maxT = new System.Windows.Forms.Label();
            this.lbl_pmt = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1_months = new System.Windows.Forms.ListBox();
            this.listBox1_PMtotal = new System.Windows.Forms.ListBox();
            this.listBox1_Tmax = new System.Windows.Forms.ListBox();
            this.listBox1_Tmin = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bnt_Calculate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTMMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTMM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPTM)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lbl_months);
            this.panel1.Controls.Add(this.cb_months);
            this.panel1.Controls.Add(this.numericUpDownTMMin);
            this.panel1.Controls.Add(this.numericUpDownTMM);
            this.panel1.Controls.Add(this.numericUpDownPTM);
            this.panel1.Controls.Add(this.lbl_minT);
            this.panel1.Controls.Add(this.lbl_maxT);
            this.panel1.Controls.Add(this.lbl_pmt);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Location = new System.Drawing.Point(70, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 116);
            this.panel1.TabIndex = 1;
            // 
            // lbl_months
            // 
            this.lbl_months.AutoSize = true;
            this.lbl_months.Location = new System.Drawing.Point(656, 27);
            this.lbl_months.Name = "lbl_months";
            this.lbl_months.Size = new System.Drawing.Size(42, 13);
            this.lbl_months.TabIndex = 8;
            this.lbl_months.Text = "Months";
            // 
            // cb_months
            // 
            this.cb_months.FormattingEnabled = true;
            this.cb_months.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cb_months.Location = new System.Drawing.Point(704, 21);
            this.cb_months.Name = "cb_months";
            this.cb_months.Size = new System.Drawing.Size(121, 21);
            this.cb_months.TabIndex = 7;
            // 
            // numericUpDownTMMin
            // 
            this.numericUpDownTMMin.Location = new System.Drawing.Point(146, 22);
            this.numericUpDownTMMin.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numericUpDownTMMin.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            -2147483648});
            this.numericUpDownTMMin.Name = "numericUpDownTMMin";
            this.numericUpDownTMMin.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownTMMin.TabIndex = 6;
            // 
            // numericUpDownTMM
            // 
            this.numericUpDownTMM.Location = new System.Drawing.Point(379, 20);
            this.numericUpDownTMM.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numericUpDownTMM.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            -2147483648});
            this.numericUpDownTMM.Name = "numericUpDownTMM";
            this.numericUpDownTMM.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownTMM.TabIndex = 5;
            // 
            // numericUpDownPTM
            // 
            this.numericUpDownPTM.Location = new System.Drawing.Point(548, 22);
            this.numericUpDownPTM.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numericUpDownPTM.Name = "numericUpDownPTM";
            this.numericUpDownPTM.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownPTM.TabIndex = 4;
            // 
            // lbl_minT
            // 
            this.lbl_minT.AutoSize = true;
            this.lbl_minT.Location = new System.Drawing.Point(23, 24);
            this.lbl_minT.Name = "lbl_minT";
            this.lbl_minT.Size = new System.Drawing.Size(117, 13);
            this.lbl_minT.TabIndex = 3;
            this.lbl_minT.Text = "Minimum Temperature :\r\n";
            // 
            // lbl_maxT
            // 
            this.lbl_maxT.AutoSize = true;
            this.lbl_maxT.Location = new System.Drawing.Point(253, 27);
            this.lbl_maxT.Name = "lbl_maxT";
            this.lbl_maxT.Size = new System.Drawing.Size(120, 13);
            this.lbl_maxT.TabIndex = 2;
            this.lbl_maxT.Text = "Maximum Temperature :";
            // 
            // lbl_pmt
            // 
            this.lbl_pmt.AutoSize = true;
            this.lbl_pmt.Location = new System.Drawing.Point(486, 27);
            this.lbl_pmt.Name = "lbl_pmt";
            this.lbl_pmt.Size = new System.Drawing.Size(56, 13);
            this.lbl_pmt.TabIndex = 1;
            this.lbl_pmt.Text = "PM-Total :";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(379, 71);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(122, 36);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save and add Data";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.listBox1_months);
            this.panel2.Controls.Add(this.listBox1_PMtotal);
            this.panel2.Controls.Add(this.listBox1_Tmax);
            this.panel2.Controls.Add(this.listBox1_Tmin);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.bnt_Calculate);
            this.panel2.Location = new System.Drawing.Point(71, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(837, 167);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // listBox1_months
            // 
            this.listBox1_months.FormattingEnabled = true;
            this.listBox1_months.Location = new System.Drawing.Point(689, 12);
            this.listBox1_months.Name = "listBox1_months";
            this.listBox1_months.Size = new System.Drawing.Size(109, 95);
            this.listBox1_months.TabIndex = 15;
            // 
            // listBox1_PMtotal
            // 
            this.listBox1_PMtotal.FormattingEnabled = true;
            this.listBox1_PMtotal.Location = new System.Drawing.Point(526, 12);
            this.listBox1_PMtotal.Name = "listBox1_PMtotal";
            this.listBox1_PMtotal.Size = new System.Drawing.Size(109, 95);
            this.listBox1_PMtotal.TabIndex = 14;
            // 
            // listBox1_Tmax
            // 
            this.listBox1_Tmax.FormattingEnabled = true;
            this.listBox1_Tmax.Location = new System.Drawing.Point(349, 12);
            this.listBox1_Tmax.Name = "listBox1_Tmax";
            this.listBox1_Tmax.Size = new System.Drawing.Size(109, 95);
            this.listBox1_Tmax.TabIndex = 13;
            // 
            // listBox1_Tmin
            // 
            this.listBox1_Tmin.FormattingEnabled = true;
            this.listBox1_Tmin.Location = new System.Drawing.Point(117, 12);
            this.listBox1_Tmin.Name = "listBox1_Tmin";
            this.listBox1_Tmin.Size = new System.Drawing.Size(109, 95);
            this.listBox1_Tmin.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(641, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Months";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minimum Temperature :\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Maximum Temperature :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "PM-Total :";
            // 
            // bnt_Calculate
            // 
            this.bnt_Calculate.Location = new System.Drawing.Point(428, 123);
            this.bnt_Calculate.Name = "bnt_Calculate";
            this.bnt_Calculate.Size = new System.Drawing.Size(122, 36);
            this.bnt_Calculate.TabIndex = 0;
            this.bnt_Calculate.Text = "Calculate";
            this.bnt_Calculate.UseVisualStyleBackColor = true;
            this.bnt_Calculate.Click += new System.EventHandler(this.bnt_Calculate_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_refresh);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(177, 357);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(635, 170);
            this.panel3.TabIndex = 3;
            this.panel3.Visible = false;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(536, 65);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 4;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label16.Location = new System.Drawing.Point(3, 126);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(242, 20);
            this.label16.TabIndex = 34;
            this.label16.Text = "température annuelle maximale";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label15.Location = new System.Drawing.Point(3, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(238, 20);
            this.label15.TabIndex = 33;
            this.label15.Text = "température annuelle minimale";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(280, 20);
            this.label14.TabIndex = 32;
            this.label14.Text = "moyenne des précipitations annuelle";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label13.Location = new System.Drawing.Point(3, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(213, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "précipitation totale annuelle";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(299, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "......";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(299, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "......";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(299, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "......";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(299, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "......";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP4_SoufianeJD_.Properties.Resources._43920623172_7443b1e368_b;
            this.ClientSize = new System.Drawing.Size(966, 594);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTMMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTMM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPTM)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_months;
        private System.Windows.Forms.NumericUpDown numericUpDownTMMin;
        private System.Windows.Forms.NumericUpDown numericUpDownTMM;
        private System.Windows.Forms.NumericUpDown numericUpDownPTM;
        private System.Windows.Forms.Label lbl_minT;
        private System.Windows.Forms.Label lbl_maxT;
        private System.Windows.Forms.Label lbl_pmt;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_months;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bnt_Calculate;
        private System.Windows.Forms.ListBox listBox1_Tmin;
        private System.Windows.Forms.ListBox listBox1_Tmax;
        private System.Windows.Forms.ListBox listBox1_PMtotal;
        private System.Windows.Forms.ListBox listBox1_months;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_refresh;
    }
}

