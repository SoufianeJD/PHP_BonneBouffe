namespace TP3_exo4_SoufianeJD_
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
            this.txt_interet = new System.Windows.Forms.TextBox();
            this.txt_int = new System.Windows.Forms.TextBox();
            this.txt_ni = new System.Windows.Forms.TextBox();
            this.txt_mi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bnt_calcule = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_recommencer = new System.Windows.Forms.Button();
            this.btn_terminer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_interet
            // 
            this.txt_interet.Location = new System.Drawing.Point(222, 8);
            this.txt_interet.Name = "txt_interet";
            this.txt_interet.Size = new System.Drawing.Size(29, 20);
            this.txt_interet.TabIndex = 0;
            // 
            // txt_int
            // 
            this.txt_int.Location = new System.Drawing.Point(222, 107);
            this.txt_int.Name = "txt_int";
            this.txt_int.Size = new System.Drawing.Size(29, 20);
            this.txt_int.TabIndex = 1;
            // 
            // txt_ni
            // 
            this.txt_ni.Location = new System.Drawing.Point(222, 76);
            this.txt_ni.Name = "txt_ni";
            this.txt_ni.Size = new System.Drawing.Size(29, 20);
            this.txt_ni.TabIndex = 2;
            // 
            // txt_mi
            // 
            this.txt_mi.Location = new System.Drawing.Point(222, 41);
            this.txt_mi.Name = "txt_mi";
            this.txt_mi.Size = new System.Drawing.Size(29, 20);
            this.txt_mi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Entre le taux d\'intéret en % :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Entrer le montant initial :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Entrer le nombre d\'année :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Entrer l\'intervalle :";
            // 
            // bnt_calcule
            // 
            this.bnt_calcule.Location = new System.Drawing.Point(123, 160);
            this.bnt_calcule.Name = "bnt_calcule";
            this.bnt_calcule.Size = new System.Drawing.Size(75, 23);
            this.bnt_calcule.TabIndex = 8;
            this.bnt_calcule.Text = "Calcule";
            this.bnt_calcule.UseVisualStyleBackColor = true;
            this.bnt_calcule.Click += new System.EventHandler(this.bnt_calcule_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(52, 205);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(213, 199);
            this.listBox1.TabIndex = 9;
            // 
            // btn_recommencer
            // 
            this.btn_recommencer.Location = new System.Drawing.Point(24, 422);
            this.btn_recommencer.Name = "btn_recommencer";
            this.btn_recommencer.Size = new System.Drawing.Size(116, 23);
            this.btn_recommencer.TabIndex = 10;
            this.btn_recommencer.Text = "Une autre simulation";
            this.btn_recommencer.UseVisualStyleBackColor = true;
            this.btn_recommencer.Click += new System.EventHandler(this.btn_recommencer_Click);
            // 
            // btn_terminer
            // 
            this.btn_terminer.Location = new System.Drawing.Point(174, 422);
            this.btn_terminer.Name = "btn_terminer";
            this.btn_terminer.Size = new System.Drawing.Size(116, 23);
            this.btn_terminer.TabIndex = 11;
            this.btn_terminer.Text = "Terminer";
            this.btn_terminer.UseVisualStyleBackColor = true;
            this.btn_terminer.Click += new System.EventHandler(this.btn_terminer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 474);
            this.Controls.Add(this.btn_terminer);
            this.Controls.Add(this.btn_recommencer);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bnt_calcule);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_mi);
            this.Controls.Add(this.txt_ni);
            this.Controls.Add(this.txt_int);
            this.Controls.Add(this.txt_interet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_interet;
        private System.Windows.Forms.TextBox txt_int;
        private System.Windows.Forms.TextBox txt_ni;
        private System.Windows.Forms.TextBox txt_mi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bnt_calcule;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_recommencer;
        private System.Windows.Forms.Button btn_terminer;
    }
}

