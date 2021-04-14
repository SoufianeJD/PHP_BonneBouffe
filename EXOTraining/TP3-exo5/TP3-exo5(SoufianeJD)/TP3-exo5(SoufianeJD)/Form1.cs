using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_exo5_SoufianeJD_
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
        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(textBox1.Text);
            label_affichage.Text = x.ToString();
            label_affichage.Text += Environment.NewLine;
            label_affichage.Text += "\t";
            for (int a = 1; a <= x; a++)
            {
                label_affichage.Text += a.ToString();
                label_affichage.Text += "\t";
            }
            label_affichage.Text += Environment.NewLine;
            label_affichage.Text += Environment.NewLine;
            for (int i = 1; i <= x; i++)
            {
                label_affichage.Text += i.ToString();
                for (int b = 1; i <= x; i++)
                {
                    label_affichage.Text += "\t";
                    int c = i * b;
                    label_affichage.Text += c.ToString();
                }
                label_affichage.Text += Environment.NewLine;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_affichage_Click(object sender, EventArgs e)
        {

        }
    }
}