namespace EXO1
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
            this.lblaffiche = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.btncliquez = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_recommencer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblaffiche
            // 
            this.lblaffiche.AutoSize = true;
            this.lblaffiche.Location = new System.Drawing.Point(12, 9);
            this.lblaffiche.Name = "lblaffiche";
            this.lblaffiche.Size = new System.Drawing.Size(157, 13);
            this.lblaffiche.TabIndex = 0;
            this.lblaffiche.Text = "Entrer une valeur entre 1 et 20 :";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(190, 6);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(44, 20);
            this.txtuser.TabIndex = 1;
            // 
            // btncliquez
            // 
            this.btncliquez.Location = new System.Drawing.Point(88, 53);
            this.btncliquez.Name = "btncliquez";
            this.btncliquez.Size = new System.Drawing.Size(75, 23);
            this.btncliquez.TabIndex = 2;
            this.btncliquez.Text = "Cliquez";
            this.btncliquez.UseVisualStyleBackColor = true;
            this.btncliquez.Click += new System.EventHandler(this.btncliquez_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.Location = new System.Drawing.Point(6, 92);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(311, 43);
            this.lbl_result.TabIndex = 3;
            // 
            // btn_recommencer
            // 
            this.btn_recommencer.Location = new System.Drawing.Point(101, 161);
            this.btn_recommencer.Name = "btn_recommencer";
            this.btn_recommencer.Size = new System.Drawing.Size(119, 23);
            this.btn_recommencer.TabIndex = 4;
            this.btn_recommencer.Text = "Recommencer";
            this.btn_recommencer.UseVisualStyleBackColor = true;
            this.btn_recommencer.Visible = false;
            this.btn_recommencer.Click += new System.EventHandler(this.btn_recommencer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 205);
            this.Controls.Add(this.btn_recommencer);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btncliquez);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lblaffiche);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblaffiche;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Button btncliquez;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button btn_recommencer;
    }
}

