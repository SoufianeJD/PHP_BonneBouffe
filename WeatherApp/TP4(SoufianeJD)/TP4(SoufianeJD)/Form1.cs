using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4_SoufianeJD_
{
    public partial class Form1 : Form
    {
        public void Refresh_function()
        {
            listBox1_months.Items.Clear();
            listBox1_PMtotal.Items.Clear();
            listBox1_Tmax.Items.Clear();
            listBox1_Tmin.Items.Clear();
            label9.Text = "";
            label12.Text = "";
            label11.Text = "";
            label10.Text = "";
        }
        public void Saving_Data_function() {
            panel2.Visible = true; 
            weather x = new weather(Convert.ToInt16(numericUpDownTMMin.Value), Convert.ToInt16(numericUpDownTMM.Value),
            Convert.ToInt16(numericUpDownPTM.Value), (Convert.ToInt16(numericUpDownTMM.Value) + Convert.ToInt16(numericUpDownPTM.Value)) / 2);
            meteo[Convert.ToInt16(cb_months.SelectedIndex)] = x;
            listBox1_months.Items.Add(cb_months.SelectedIndex + 1);
            listBox1_Tmin.Items.Add(numericUpDownTMMin.Value);
            listBox1_Tmax.Items.Add(numericUpDownTMM.Value);
            listBox1_PMtotal.Items.Add(numericUpDownPTM.Value);
        }
        public void Calculating_Data_function()
        {
            panel3.Visible = true; 
            int maxmonth = 0, minmonth = 0, moy = 0, tot = 0, min = 0, max = 0;
            moy = tot / listBox1_PMtotal.Items.Count;

            for (int i = 0; i < 13; i++)
            {
                tot = tot + meteo[i].Monthss;

                if (meteo[i].TMPMAXX > max)
                {
                    max = meteo[i].TMPMAXX;
                    maxmonth = i + 1;
                }
                if (meteo[i].TMPMINN < min)
                {
                    min = meteo[i].TMPMINN;
                    minmonth = i + 1;
                }
                moy = tot / listBox1_Tmin.Items.Count;
                label12.Text = min.ToString() + " Degrees in month number : " + minmonth.ToString();
                label10.Text = max.ToString() + " Degrees in month number : " + maxmonth.ToString();
                label11.Text = tot.ToString();
                label9.Text = moy.ToString();
            }
        }
        private weather[] meteo;
        public Form1()
        {
            InitializeComponent();
            meteo = new weather[13];
        }
        //A structure in C# is simply a composite data type consisting of a number elements of other types.
        // A C# structure is a value type and the instances or objects of a structure are created in stack. 
        //The structure in C# can contain fields, methods, constants, constructors, properties, indexers, operators and even other structure types. 


        private struct weather //utilisation du structure pour globaliser tt les variables dans une seule VAR (weather)
        {
            private int Months;
            private int TMPMAX;
            private int TMPMIN;
            private int TMPMOYENNE;
            public weather(int Months = 0, int TMPMAX = 0, int TMPMIN = 0, int TMPMOYENNE = 0)
            {
                this.Months = Months;
                this.TMPMAX = TMPMAX;
                this.TMPMIN = TMPMIN;
                this.TMPMOYENNE = TMPMOYENNE;
            }

            public int Monthss
            {
                get { return this.Months; }
            }
            public int TMPMAXX
            {
                get { return this.TMPMAX; }
            }
            public int TMPMINN
            {
                get { return this.TMPMIN; }
            }
            public int TMPMOYENNEE
            {
                get { return this.TMPMOYENNE; }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button4_Click(object sender, EventArgs e)
        {
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
        private void label1_Click_1(object sender, EventArgs e)
        {
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
          if (cb_months.SelectedIndex != -1) { 

                    Saving_Data_function(); 
            }
            else { 
                MessageBox.Show("You forgot to choose the month"); }
        }
        private void bnt_Calculate_Click(object sender, EventArgs e)
        {
            Calculating_Data_function();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Refresh_function();
        }
    }
}