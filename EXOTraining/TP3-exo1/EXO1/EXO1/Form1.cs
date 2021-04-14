using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXO1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncliquez_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtuser.Text); //réccupération du valeur entré par le User et la convertir en Int en la déclaron en meme temps
            if (x > 20 || x < 1) //vérification de la condition demandé dans l'exercice
            {
                MessageBox.Show("Plz enter a number between 1 and 20"); // msg d'alert ou cas ou l'utilisateur respect pas la valeur qu'il faut rentrer

            }
            else
            {
                for (int i = 0; i < x; i++) 
                {
                    lbl_result.Text += i.ToString() + " "; //concatenation du résultat Int transformé en String dans notre Label
                }
            }
            btn_recommencer.Visible = true; //rendre le btn visible lors d'un click sur l'operation
        }

        private void btn_recommencer_Click(object sender, EventArgs e)
        {
            txtuser.Text = ""; //Vider le txtbox lors d'un click afin de recommencer l'operation
            lbl_result.Text = ""; //Vider le txtbox lors d'un click afin de recommencer l'operation
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
