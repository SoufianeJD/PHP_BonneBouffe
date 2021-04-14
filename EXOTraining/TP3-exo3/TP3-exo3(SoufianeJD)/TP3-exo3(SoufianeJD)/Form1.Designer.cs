namespace TP3_exo3_SoufianeJD_
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btncliquez = new System.Windows.Forms.Button();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.lblaffiche = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_result);
            this.panel1.Location = new System.Drawing.Point(3, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 100);
            this.panel1.TabIndex = 15;
            this.panel1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Les nombres pairs :";
            // 
            // lbl_result
            // 
            this.lbl_result.Location = new System.Drawing.Point(107, 28);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(179, 26);
            this.lbl_result.TabIndex = 9;
            // 
            // btncliquez
            // 
            this.btncliquez.Location = new System.Drawing.Point(70, 41);
            this.btncliquez.Name = "btncliquez";
            this.btncliquez.Size = new System.Drawing.Size(111, 23);
            this.btncliquez.TabIndex = 14;
            this.btncliquez.Text = "Obtenir la liste";
            this.btncliquez.UseVisualStyleBackColor = true;
            this.btncliquez.Click += new System.EventHandler(this.btncliquez_Click);
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(208, 11);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(36, 20);
            this.txtuser.TabIndex = 13;
            // 
            // lblaffiche
            // 
            this.lblaffiche.AutoSize = true;
            this.lblaffiche.Location = new System.Drawing.Point(26, 14);
            this.lblaffiche.Name = "lblaffiche";
            this.lblaffiche.Size = new System.Drawing.Size(176, 13);
            this.lblaffiche.TabIndex = 12;
            this.lblaffiche.Text = "Entrer un nombre plus grand que 0 :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 216);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btncliquez);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lblaffiche);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button btncliquez;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label lblaffiche;
    }
}

