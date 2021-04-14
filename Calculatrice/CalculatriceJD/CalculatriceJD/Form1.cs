using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatriceJD
{
    public partial class Form1 : Form
    {
        
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtbox1_TextChanged(object sender, EventArgs e)
        {
            string text = ((sender as TextBox) == null ? string.Empty : (sender as TextBox).Text);
            this.btndiv.Enabled = (string.IsNullOrWhiteSpace(text) == false);
            this.btnmoins.Enabled = (string.IsNullOrWhiteSpace(text) == false);
            this.btnmulti.Enabled = (string.IsNullOrWhiteSpace(text) == false);
            this.btnplus.Enabled = (string.IsNullOrWhiteSpace(text) == false);
        }

        private void btnmoins_Click(object sender, EventArgs e)
        {
            string val1 = txtbox1.Text;
            int val11 = Convert.ToInt16(val1);
            string val2 = txtbox2.Text;
            int val22 = Convert.ToInt16(val2);

            lblresult.Text = (val11 - val22).ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            string val1 = txtbox1.Text;
            int val11 = Convert.ToInt16(val1);
            string val2 = txtbox2.Text;
            int val22 = Convert.ToInt16(val2);

            lblresult.Text = (val11 + val22).ToString();

        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            string val1 = txtbox1.Text;
            int val11 = Convert.ToInt16(val1);
            string val2 = txtbox2.Text;
            int val22 = Convert.ToInt16(val2);

            lblresult.Text = (val11 / val22).ToString();
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            string val1 = txtbox1.Text;
            int val11 = Convert.ToInt16(val1);
            string val2 = txtbox2.Text;
            int val22 = Convert.ToInt16(val2);

            lblresult.Text = (val11 * val22).ToString();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtbox1.Text = "";
            txtbox2.Text = "";
            lblresult.Text = "";


        }   
        }
    }
