using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_1302213120
{
    public partial class Form1 : Form
    {
        double Hasil;
        double angka;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String tampil = label1.Text;
            if (tampil == "")
            {
                tampil = "1";
            }
            else
            {
                tampil = tampil + "1";
            }
            label1.Text = tampil;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String tampil = label1.Text;
            if (tampil == "")
            {
                tampil = "2";
            }
            else
            {
                tampil = tampil + "2";
            }
            label1.Text = tampil;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String tampil = label1.Text;
            if (tampil == "")
            {
                tampil = "3";
            }
            else
            {
                tampil = tampil + "3";
            }
            label1.Text = tampil;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String tampil = label1.Text;
            if (tampil == "")
            {
                tampil = "4";
            }
            else
            {
                tampil = tampil + "4";
            }
            label1.Text = tampil;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String tampil = label1.Text;
            if (tampil == "")
            {
                tampil = "5";
            }
            else
            {
                tampil = tampil + "5";
            }
            label1.Text = tampil;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String tampil = label1.Text;
            if (tampil == "")
            {
                tampil = "6";
            }
            else
            {
                tampil = tampil + "6";
            }
            label1.Text = tampil;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String tampil = label1.Text;
            if (tampil == "")
            {
                tampil = "7";
            }
            else
            {
                tampil = tampil + "7";
            }
            label1.Text = tampil;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String tampil = label1.Text;
            if (tampil == "")   
            {
                tampil = "8";
            }
            else
            {
                tampil = tampil + "8";
            }
            label1.Text = tampil;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            String tampil = label1.Text;
            if (tampil == "")
            {
                tampil = "9";
            }
            else
            {
                tampil = tampil + "9";
            }
            label1.Text = tampil;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            String tampil = label1.Text;
            if (tampil == "")
            {
                tampil = "0";
            }
            else
            {
                tampil = tampil + "0";
            }
            label1.Text = tampil;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            
            if(label1.Text == "0")
            {
                label1.Text = "0";
            }
            else
            {
                label1.Text = "";
                //angka = Convert.ToDouble(label1.Text);
                Hasil += angka;

                

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            angka = Convert.ToDouble(label1.Text);
            Hasil += angka + 2;
            label1.Text = Hasil.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
};
