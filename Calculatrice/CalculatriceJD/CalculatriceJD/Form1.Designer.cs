namespace CalculatriceJD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.txtbox2 = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.btnmoins = new System.Windows.Forms.Button();
            this.btnmulti = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl1.Location = new System.Drawing.Point(60, 29);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(95, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Enter first number :";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl2.Location = new System.Drawing.Point(60, 84);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(114, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Enter second number :";
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(215, 29);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(44, 20);
            this.txtbox1.TabIndex = 2;
            this.txtbox1.TextChanged += new System.EventHandler(this.txtbox1_TextChanged);
            // 
            // txtbox2
            // 
            this.txtbox2.Location = new System.Drawing.Point(215, 84);
            this.txtbox2.Name = "txtbox2";
            this.txtbox2.Size = new System.Drawing.Size(44, 20);
            this.txtbox2.TabIndex = 3;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnclear.Location = new System.Drawing.Point(122, 347);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 8;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblresult.Location = new System.Drawing.Point(168, 295);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(0, 13);
            this.lblresult.TabIndex = 9;
            // 
            // btnmoins
            // 
            this.btnmoins.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnmoins.Enabled = false;
            this.btnmoins.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnmoins.Location = new System.Drawing.Point(194, 218);
            this.btnmoins.Name = "btnmoins";
            this.btnmoins.Size = new System.Drawing.Size(59, 49);
            this.btnmoins.TabIndex = 7;
            this.btnmoins.Text = "-";
            this.btnmoins.UseVisualStyleBackColor = false;
            this.btnmoins.Click += new System.EventHandler(this.btnmoins_Click);
            // 
            // btnmulti
            // 
            this.btnmulti.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnmulti.Enabled = false;
            this.btnmulti.Location = new System.Drawing.Point(77, 218);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.Size = new System.Drawing.Size(55, 49);
            this.btnmulti.TabIndex = 6;
            this.btnmulti.Text = "x";
            this.btnmulti.UseVisualStyleBackColor = false;
            this.btnmulti.Click += new System.EventHandler(this.btnmulti_Click);
            // 
            // btndiv
            // 
            this.btndiv.BackColor = System.Drawing.SystemColors.Highlight;
            this.btndiv.Enabled = false;
            this.btndiv.Location = new System.Drawing.Point(194, 139);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(59, 52);
            this.btndiv.TabIndex = 5;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = false;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnplus
            // 
            this.btnplus.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnplus.Enabled = false;
            this.btnplus.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnplus.Location = new System.Drawing.Point(77, 139);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(55, 52);
            this.btnplus.TabIndex = 4;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = false;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::CalculatriceJD.Properties.Resources.Calculator_a_background590;
            this.ClientSize = new System.Drawing.Size(334, 393);
            this.Controls.Add(this.btnmoins);
            this.Controls.Add(this.btnmulti);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtbox2);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "JD\'s Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.TextBox txtbox2;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btnmoins;
        private System.Windows.Forms.Button btnmulti;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnplus;
    }
}

