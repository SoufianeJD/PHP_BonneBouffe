using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPv1
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtnomfamille_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblname_Click(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {

            lblfullname.Text = txtprenom.Text + " " + textBox1.Text;
            lbladress.Text = txtadresse.Text;
            lblprovincee.Text = txtville.Text+"  " + " Province : "+ txtprovince.Text;


        }

        private void txtprenom_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void txtadresse_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
