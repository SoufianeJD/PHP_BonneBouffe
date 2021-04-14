using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_exo4_SoufianeJD_
{
    public partial class Form1 : Form
    {        
        double intrest, VO, inter;  //déclaration des variables d'une façon globale pr multiples utilisations 
        int year; //
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_terminer_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); //methode c# pour shut down le programme
        }

        private void btn_recommencer_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); //faire vider tt les textes et la listebox afin de recommencer une autre opération
            txt_int.Text = "";  //
            txt_interet.Text = "";  //
            txt_mi.Text = "";  //
            txt_ni.Text = "";      //
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void bnt_calcule_Click(object sender, EventArgs e)
        {
            intrest = Convert.ToDouble(txt_interet.Text);//réccupération du valeur entré par le User et la convertir en Int en la déclaron en meme temps
            double taux = intrest / 100; //récuperer le taux entrer par le user a l'aide un petit calcule
            VO = Convert.ToDouble(txt_mi.Text);//réccupération du valeur entré par le User et la convertir en Int en la déclaron en meme temps
            year = Convert.ToInt16(txt_ni.Text);//réccupération du valeur entré par le User et la convertir en Int en la déclaron en meme temps
            listBox1.Items.Add("Vous investissez : $ " + VO); //affichier la VO dans la listbox
            int interval = Convert.ToInt16(txt_int.Text);//réccupération du valeur entré par le User et la convertir en Int en la déclaron en meme temps
            int i = 0;

            if (interval % 2 == 0)
            {
                for (i = 1; i < year; i++)


                    //Pow() is a Math class method. This method is used to calculate a number raise to the power of some other number. 
                    //Parameters: double base: It is a double-precision floating-point number which is to be raised to a power and type of this parameter is System

                     //in C#, Math. Round() is a Math class method which is used to round a value to the nearest integer or to the particular number of fractional digits.
                       // This method has another overload with which, you can specify the number of digits beyond the decimal point in the returned value.
                
                {
                    inter = VO * Math.Pow((1 + taux), i);
                    inter = Math.Round(inter, 2);
                    listBox1.Items.Add("Après " + i + " c'est => $" + inter);
                }
            }
            else if (interval % 3 == 0)
            {
                for (i = 1; i < year; i++)
                {
                    inter = VO * Math.Pow((1 * taux),i);
                    inter = Math.Round(inter, 2);
                    listBox1.Items.Add("Après " + i + "ans c'est => $" + inter);
                }
            }
            else
            {
                for (i = 1; i < year; i++)
                {
                    inter = VO * Math.Pow((1 + taux), i);
                    inter = Math.Round(inter, 2);
                    if (i == 1)
                    {
                        listBox1.Items.Add("Après " + i + "ans c'est => $" + inter);
                    }
                    else
                    {
                        listBox1.Items.Add("Après " + i + "ans c'est => $" + inter);
                    }
                }
            }
            inter = VO * Math.Pow((1 + taux), year);
            inter = Math.Round(inter, 2);
            listBox1.Items.Add("Après " + year + "ans c'est => $" + inter);
        }

    } }