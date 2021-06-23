using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_zad1
{
    public partial class Form1 : Form
    {
        double wynik;
        double wzrost;
        double K = 0.85, M = 0.9;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wzrost = Convert.ToDouble(textBox1.Text);
            if (radioButton1.Checked != true && radioButton2.Checked != true)
            {
                MessageBox.Show("Wybierz płeć");
                return;
            }

            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                MessageBox.Show("Nie zaznaczaj dwóch wag na raz!");
                return;
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                MessageBox.Show("Nie zaznaczyłeś żadnje wagi");
                return;
            }

            if (radioButton1.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    wynik = (wzrost - 100);
                    label3.Text = Convert.ToString(wynik);
                }
                else if (checkBox2.Checked == true)
                {
                    wynik = (wzrost - 100) * K;
                    label3.Text = Convert.ToString(wynik);
                }
            }
            else if (radioButton2.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    wynik = (wzrost - 100);
                    label3.Text = Convert.ToString(wynik);
                }
                else if (checkBox2.Checked == true)
                {
                    wynik = (wzrost - 100) * M;
                    label3.Text = Convert.ToString(wynik);
                }
            }
        }
    }
}
