using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EXO1_TP2__JD_
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

        private void btnracine_Click(object sender, EventArgs e)
        {
            string a = txtva.Text;
            double aa = Convert.ToDouble(a);
            string b = txtvb.Text;
            double bb = Convert.ToDouble(b);
            string c = txtvc.Text;
            double cc = Convert.ToDouble(c);
            double d = bb * bb - 4 * aa * cc;


            if (d < 0) 
            {
                lblalert.Text = "Pas de racine pour ses valeurs";
               
            }
            else if (d == 0)

            {
                double x = -bb / 2 * aa; 
                string xx = Convert.ToString(x);

                lblalert.Text = "La seule valeur est :";
                lbl2.Text =   xx;
                
            }
            else 
            {
                
                double x1 = (-bb + Math.Sqrt(d)) / (2 * aa);
                string xx1 = Convert.ToString(x1);

                lblalert.Text = "La valeur de x1 est :";
                lbl2.Text = xx1;

                lblet.Text = "Et";

                double x2 = (-bb - Math.Sqrt(d)) / (2 * aa);
                string xx2 = Convert.ToString(x2);

                lblalertt.Text = "La valeur de x2 est :";
                lbl3.Text = xx2;

            }
        }

        private void lblalert_Click(object sender, EventArgs e)
        {

        }

        private void btnrecomm_Click(object sender, EventArgs e)
        {
            lblalertt.Text = "";
            lblalert.Text = "";
            txtva.Text = "";
            txtvb.Text = "";
            txtvc.Text = "";
            lbl2.Text = "";
            lbl3.Text = "";
        }

        private void lblet_Click(object sender, EventArgs e)
        {

        }
    }
}
