namespace TPv1
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
            this.lblprenom = new System.Windows.Forms.Label();
            this.lblnomfamille = new System.Windows.Forms.Label();
            this.textadresse = new System.Windows.Forms.Label();
            this.lblcity = new System.Windows.Forms.Label();
            this.lblprovince = new System.Windows.Forms.Label();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.txtadresse = new System.Windows.Forms.TextBox();
            this.txtville = new System.Windows.Forms.TextBox();
            this.txtprovince = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblfullname = new System.Windows.Forms.Label();
            this.lbladress = new System.Windows.Forms.Label();
            this.lblprovincee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblprenom
            // 
            this.lblprenom.AutoSize = true;
            this.lblprenom.Location = new System.Drawing.Point(37, 28);
            this.lblprenom.Name = "lblprenom";
            this.lblprenom.Size = new System.Drawing.Size(106, 13);
            this.lblprenom.TabIndex = 0;
            this.lblprenom.Text = "Entrer votre prénom :";
            // 
            // lblnomfamille
            // 
            this.lblnomfamille.AutoSize = true;
            this.lblnomfamille.Location = new System.Drawing.Point(37, 68);
            this.lblnomfamille.Name = "lblnomfamille";
            this.lblnomfamille.Size = new System.Drawing.Size(120, 13);
            this.lblnomfamille.TabIndex = 1;
            this.lblnomfamille.Text = "Enter votre nom famille :";
            // 
            // textadresse
            // 
            this.textadresse.AutoSize = true;
            this.textadresse.Location = new System.Drawing.Point(38, 104);
            this.textadresse.Name = "textadresse";
            this.textadresse.Size = new System.Drawing.Size(108, 13);
            this.textadresse.TabIndex = 2;
            this.textadresse.Text = "Entrer votre adresse :";
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Location = new System.Drawing.Point(38, 142);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(73, 13);
            this.lblcity.TabIndex = 3;
            this.lblcity.Text = "Entrer la ville :";
            // 
            // lblprovince
            // 
            this.lblprovince.AutoSize = true;
            this.lblprovince.Location = new System.Drawing.Point(38, 184);
            this.lblprovince.Name = "lblprovince";
            this.lblprovince.Size = new System.Drawing.Size(96, 13);
            this.lblprovince.TabIndex = 4;
            this.lblprovince.Text = "Entrer la province :";
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(210, 28);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(100, 20);
            this.txtprenom.TabIndex = 5;
            this.txtprenom.TextChanged += new System.EventHandler(this.txtprenom_TextChanged);
            // 
            // txtadresse
            // 
            this.txtadresse.Location = new System.Drawing.Point(210, 101);
            this.txtadresse.Name = "txtadresse";
            this.txtadresse.Size = new System.Drawing.Size(100, 20);
            this.txtadresse.TabIndex = 7;
            this.txtadresse.TextChanged += new System.EventHandler(this.txtadresse_TextChanged);
            // 
            // txtville
            // 
            this.txtville.Location = new System.Drawing.Point(210, 142);
            this.txtville.Name = "txtville";
            this.txtville.Size = new System.Drawing.Size(100, 20);
            this.txtville.TabIndex = 8;
            // 
            // txtprovince
            // 
            this.txtprovince.Location = new System.Drawing.Point(210, 181);
            this.txtprovince.Name = "txtprovince";
            this.txtprovince.Size = new System.Drawing.Size(100, 20);
            this.txtprovince.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cliquez pour affichier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // lblfullname
            // 
            this.lblfullname.Location = new System.Drawing.Point(67, 257);
            this.lblfullname.Name = "lblfullname";
            this.lblfullname.Size = new System.Drawing.Size(111, 35);
            this.lblfullname.TabIndex = 12;
            // 
            // lbladress
            // 
            this.lbladress.Location = new System.Drawing.Point(67, 310);
            this.lbladress.Name = "lbladress";
            this.lbladress.Size = new System.Drawing.Size(110, 35);
            this.lbladress.TabIndex = 13;
            // 
            // lblprovincee
            // 
            this.lblprovincee.Location = new System.Drawing.Point(67, 365);
            this.lblprovincee.Name = "lblprovincee";
            this.lblprovincee.Size = new System.Drawing.Size(253, 51);
            this.lblprovincee.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TPv1.Properties.Resources.depositphotos_34864947_stock_photo_feather_on_a_background_of;
            this.ClientSize = new System.Drawing.Size(385, 437);
            this.Controls.Add(this.lblprovincee);
            this.Controls.Add(this.lbladress);
            this.Controls.Add(this.lblfullname);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtprovince);
            this.Controls.Add(this.txtville);
            this.Controls.Add(this.txtadresse);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.lblprovince);
            this.Controls.Add(this.lblcity);
            this.Controls.Add(this.textadresse);
            this.Controls.Add(this.lblnomfamille);
            this.Controls.Add(this.lblprenom);
            this.Name = "Form1";
            this.Text = "FormulairJD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblprenom;
        private System.Windows.Forms.Label lblnomfamille;
        private System.Windows.Forms.Label textadresse;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.Label lblprovince;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.TextBox txtadresse;
        private System.Windows.Forms.TextBox txtville;
        private System.Windows.Forms.TextBox txtprovince;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblfullname;
        private System.Windows.Forms.Label lbladress;
        private System.Windows.Forms.Label lblprovincee;
    }
}

