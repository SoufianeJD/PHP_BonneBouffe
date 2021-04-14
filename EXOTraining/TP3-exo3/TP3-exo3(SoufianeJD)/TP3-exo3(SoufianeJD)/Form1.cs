using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_exo3_SoufianeJD_
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
        private void btncliquez_Click(object sender, EventArgs e)
        {
            int xpair = Convert.ToInt16(txtuser.Text); //réccupération du valeur entré par le User et la convertir en Int en la déclaron en meme temps
            for (int i = 1; i < xpair; i++) 
            {
                if (i % 2 == 0) //vérification policière par le modulo afin d'empecher les sale nombres impair de passé vers l'étape prochaine
                {
                    lbl_result.Text += i.ToString() + " | "; //résultat Int transformé en String et affichier dans notre Label
                }
            }
            panel1.Visible = true; //affichage du Panel1 lors d'un click
        }
    }
}
