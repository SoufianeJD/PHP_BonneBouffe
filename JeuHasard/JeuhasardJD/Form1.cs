using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuhasardJD
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

        private void btntirage_Click(object sender, EventArgs e)
        {
            string val_user = txtboxuser.Text;
            int val_userr = Convert.ToInt16(val_user);


            if (val_userr > 6 || val_userr < 1)
            {

                lblalert.Text = "Veuiller entrer un nombre entre 1 et 6 plz...";

            }
    
            else
            {
                var random = new Random();
                int randomnumber = random.Next(1,6);
                string randomnumberr = Convert.ToString(randomnumber);
                lblalert.Text = randomnumberr;
                if(randomnumberr == txtboxuser.Text)
                    {
                    lblalert.Text = "You've Won 0.25$!!! congratulations ! (Loto-JD)";

                }
               
                else
                    lblalert.Text = "You've Lost 100$ , never give up. try again !!! (Loto-JD)";

            }
              
        }

        private void txtboxuser_TextChanged(object sender, EventArgs e)
        {
            /*string val_userrr = txtboxuser.Text;
            if (txtboxuser.Text == "")
            {
               
                val_userrr = "PLZ enter a number";
            }*/
        }

        private void btnrecommencer_Click(object sender, EventArgs e)
        {
            lblalert.Text = "";
            txtboxuser.Text = "";
        }

        private void exitout_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lblmsg_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
 
//les étapes in the button

    //1-récup la val du user
    //2-  f val user is not between 1 and 6 , print a msg " entrer entre 1 et 6" else print val random between 1-6
    // compare between random user and random computer
//random r = new random();
//int val= r.next(1,7);