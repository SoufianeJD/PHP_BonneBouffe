namespace TP3_exo2_SoufianeJD_
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
            this.btncliquez = new System.Windows.Forms.Button();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.lblaffiche = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncliquez
            // 
            this.btncliquez.Location = new System.Drawing.Point(43, 51);
            this.btncliquez.Name = "btncliquez";
            this.btncliquez.Size = new System.Drawing.Size(132, 23);
            this.btncliquez.TabIndex = 7;
            this.btncliquez.Text = "On obtient la somme";
            this.btncliquez.UseVisualStyleBackColor = true;
            this.btncliquez.Click += new System.EventHandler(this.btncliquez_Click);
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(155, 16);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(36, 20);
            this.txtuser.TabIndex = 6;
            // 
            // lblaffiche
            // 
            this.lblaffiche.AutoSize = true;
            this.lblaffiche.Location = new System.Drawing.Point(26, 19);
            this.lblaffiche.Name = "lblaffiche";
            this.lblaffiche.Size = new System.Drawing.Size(123, 13);
            this.lblaffiche.TabIndex = 5;
            this.lblaffiche.Text = "Entrer un nombre entier :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "La somme vaut =";
            // 
            // lbl_result
            // 
            this.lbl_result.Location = new System.Drawing.Point(101, 28);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(96, 26);
            this.lbl_result.TabIndex = 9;
            this.lbl_result.Text = ".....";
            this.lbl_result.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Recommence";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_result);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(29, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 11;
            this.panel1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 206);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btncliquez);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lblaffiche);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncliquez;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label lblaffiche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}

