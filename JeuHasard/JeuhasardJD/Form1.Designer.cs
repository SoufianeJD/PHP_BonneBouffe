namespace JeuhasardJD
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
            this.lblmsg = new System.Windows.Forms.Label();
            this.txtboxuser = new System.Windows.Forms.TextBox();
            this.btntirage = new System.Windows.Forms.Button();
            this.btnrecommencer = new System.Windows.Forms.Button();
            this.exitout = new System.Windows.Forms.Button();
            this.lblalert = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmsg.Location = new System.Drawing.Point(31, 26);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(209, 13);
            this.lblmsg.TabIndex = 0;
            this.lblmsg.Text = "Entrer un nombre compris entre 1 et 6 (incl)";
            this.lblmsg.Click += new System.EventHandler(this.lblmsg_Click);
            // 
            // txtboxuser
            // 
            this.txtboxuser.Location = new System.Drawing.Point(262, 23);
            this.txtboxuser.Name = "txtboxuser";
            this.txtboxuser.Size = new System.Drawing.Size(31, 20);
            this.txtboxuser.TabIndex = 1;
            this.txtboxuser.TextChanged += new System.EventHandler(this.txtboxuser_TextChanged);
            // 
            // btntirage
            // 
            this.btntirage.Location = new System.Drawing.Point(143, 71);
            this.btntirage.Name = "btntirage";
            this.btntirage.Size = new System.Drawing.Size(75, 23);
            this.btntirage.TabIndex = 2;
            this.btntirage.Text = "Tirage";
            this.btntirage.UseVisualStyleBackColor = true;
            this.btntirage.Click += new System.EventHandler(this.btntirage_Click);
            // 
            // btnrecommencer
            // 
            this.btnrecommencer.Location = new System.Drawing.Point(3, 209);
            this.btnrecommencer.Name = "btnrecommencer";
            this.btnrecommencer.Size = new System.Drawing.Size(107, 23);
            this.btnrecommencer.TabIndex = 3;
            this.btnrecommencer.Text = "Recommencer";
            this.btnrecommencer.UseVisualStyleBackColor = true;
            this.btnrecommencer.Click += new System.EventHandler(this.btnrecommencer_Click);
            // 
            // exitout
            // 
            this.exitout.Location = new System.Drawing.Point(280, 209);
            this.exitout.Name = "exitout";
            this.exitout.Size = new System.Drawing.Size(75, 23);
            this.exitout.TabIndex = 4;
            this.exitout.Text = "Terminer";
            this.exitout.UseVisualStyleBackColor = true;
            this.exitout.Click += new System.EventHandler(this.exitout_Click);
            // 
            // lblalert
            // 
            this.lblalert.AutoSize = true;
            this.lblalert.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblalert.Location = new System.Drawing.Point(31, 135);
            this.lblalert.Name = "lblalert";
            this.lblalert.Size = new System.Drawing.Size(0, 13);
            this.lblalert.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.txtboxuser);
            this.panel1.Controls.Add(this.btnrecommencer);
            this.panel1.Controls.Add(this.lblalert);
            this.panel1.Controls.Add(this.lblmsg);
            this.panel1.Controls.Add(this.exitout);
            this.panel1.Controls.Add(this.btntirage);
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 235);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JeuhasardJD.Properties.Resources.Screenshot_3;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.TextBox txtboxuser;
        private System.Windows.Forms.Button btntirage;
        private System.Windows.Forms.Button btnrecommencer;
        private System.Windows.Forms.Button exitout;
        private System.Windows.Forms.Label lblalert;
        private System.Windows.Forms.Panel panel1;
    }
}

