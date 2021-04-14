using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LABO1_SoufianeJD_
{
    public partial class Form1 : Form
    {
        public void itemsaffichage()
        {
            string order = " ";
            if (checkbox_cream.Checked == true) { order = order + checkbox_cream.Text; }
            if (checkbox_sirop.Checked == true) { order = order + checkbox_sirop.Text; }
            if (checkbox_tartepomme.Checked == true) { order = order + checkbox_tartepomme.Text; }
            if (checkbox_choux.Checked == true) { order = order + checkbox_choux.Text; }
            textBox1.Text = combobox_soupe.Text+"  " + combobox_plat.Text + "  " + combobox_entre.Text + "  " + order;

        }
        private Double Price_soupe = 4.50 ,Price_entre = 6.75 , Price_platP = 15.75,Price_salade = 5;
        private Double Rabaisenfant = 0.1, Rabaisaine = 0.12;
        private string Vsoupe , Ventre , Vplat;

       public void rabaischeck()
        {
            string Price_platPP = Convert.ToString(Price_platP);
            string Price_soupee = Convert.ToString(Price_soupe);
            string Price_entree = Convert.ToString(Price_entre);
            string Price_saladee = Convert.ToString(Price_salade);
            if (rb_adult.Checked)
            {
                label_affichetotal.Text = Price_soupee+ Price_entree+ Price_platPP+ Price_saladee;
            }
            else if (rb_enfant.Checked)
            {
                double rabais = Price_soupe * 0.1;
                double x = Price_soupe - rabais;
                string pxsoupee = Convert.ToString(x);
                label_affichetotal.Text = pxsoupee;
                double xx = Price_entre - rabais;
                string pxsoupeee = Convert.ToString(xx);
                label_affichetotal.Text = pxsoupeee;
                double xxx = Price_platP - rabais;
                string pxsoupi = Convert.ToString(xxx);
                label_affichetotal.Text = pxsoupi;
                double xxxx = Price_salade - rabais;
                string Price_salad = Convert.ToString(xxxx);
                label_affichetotal.Text = Price_salad;
            }
            else if (rb_ainee.Checked)
            {
                double rabais = Price_soupe * 0.12;
                double x = Price_soupe - rabais;
                string pxsoupee = Convert.ToString(x);
                label_affichetotal.Text = pxsoupee;
                double xx = Price_entre - rabais;
                string pxsoupeee = Convert.ToString(xx);
                label_affichetotal.Text = pxsoupeee;
                double xxx = Price_platP - rabais;
                string pxsoupi = Convert.ToString(xxx);
                label_affichetotal.Text = pxsoupi;
                double xxxx = Price_salade - rabais;
                string Price_salad = Convert.ToString(xxxx);
                label_affichetotal.Text = Price_salad;
            }
            else
            {
                double rabais = Price_soupe * 0.02;
                double x = Price_soupe - rabais;
                string pxsoupee = Convert.ToString(x);
                label_affichetotal.Text = pxsoupee;
                double xx = Price_entre - rabais;
                string pxsoupeee = Convert.ToString(xx);
                label_affichetotal.Text = pxsoupeee;
                double xxx = Price_platP - rabais;
                string pxsoupi = Convert.ToString(xxx);
                label_affichetotal.Text = pxsoupi;
                double xxxx = Price_salade - rabais;
                string Price_salad = Convert.ToString(xxxx);
                label_affichetotal.Text = Price_salad;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void combobox_soupe_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void btn_total_Click(object sender, EventArgs e)
        { 
            itemsaffichage();
            //La récupération des valeurs de tt les choix d'utilisateurs
            Vsoupe = combobox_soupe.Text;
             Ventre = combobox_entre.Text;
             Vplat = combobox_plat.Text;
            
            if (combobox_soupe.Text == "Chiken-Soupe" || combobox_soupe.Text == "Beef-Soupe" || combobox_soupe.Text == "JD-Soupe")
            {
                rabaischeck();
            }

            if (combobox_entre.Text == "Salade-Verte" || combobox_entre.Text == "Cake-Fromage" || combobox_entre.Text == "Salade-Fruits")
            {
                rabaischeck();
            }

            if (combobox_plat.Text == "Beef-Steak" || combobox_plat.Text == "Poulet-Grillé" || combobox_plat.Text == "Pizza" || combobox_plat.Text == "Burger")
            {
                rabaischeck();
            }
            if (checkbox_cream.Checked || checkbox_choux.Checked || checkbox_tartepomme.Checked || checkbox_sirop.Checked)
            {
                rabaischeck();
            }
        }
        private void label_alldesserts_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void checkbox_tartepomme_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void panel_calculatricedecor_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}