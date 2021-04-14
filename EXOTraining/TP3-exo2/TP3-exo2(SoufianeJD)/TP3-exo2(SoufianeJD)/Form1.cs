using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_exo2_SoufianeJD_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void btncliquez_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(txtuser.Text);//réccupération du valeur entré par le User et la convertir en Int en la déclaron en meme temps
            int sum = 0;
            for(int i=0; i<=x;i++)
            {
                sum += i;//déplacer les données dans la var sum afin de finaliser la convertion et effec l'affichage
            }
            lbl_result.Text = sum.ToString();//résultat Int transformé en String et affichier dans notre Label
            panel1.Visible = true;//rendre le panel visible lors du click sur btn
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lbl_result.Text = "";//Vider le txtbox loSrs d'un click afin de recommencer l'operation
            txtuser.Text = "";//Vider le txtbox lors d'un click afin de recommencer l'operation
        }
    }
}