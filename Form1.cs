using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vki_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kilo=Convert.ToDouble(textBox1.Text);
            double boy=Convert.ToDouble(textBox2.Text);
            double boykare = Math.Pow(boy, 2);
            double sonuc = kilo / boykare;
            
            label7.Text= sonuc.ToString();

            if (sonuc > 24 && sonuc < 31)
            {
                label8.Text = "Fazla kilolusunuz.Kilo vermelisiniz.";
                label8.ForeColor = Color.Yellow;
            }
            else if (sonuc > 31 && sonuc < 41)
            {
                label8.Text = "Maalesef Obezsiniz (Şişman). Bir doktor yardımına ihtiyacınız var.";
                label8.ForeColor = Color.Orange;
            }
            else if (sonuc > 41)
            {
                label8.Text = "Maalesef Morbid Obezsiniz(Aşırı Şişman). En kısa zamanda doktora görünmelisiniz";
                label8.ForeColor = Color.Red;
            }
            else if (sonuc > 18 && sonuc < 25)
            {
                label8.Text = "Kitle İndeksiniz gayet iyi. Böyle devam. ";
                label8.ForeColor = Color.Green;
            }
            else if (sonuc < 18)
            {
                label8.Text = "Zayıfsınız. Kilo almaya ihtiyacınız var.";
                label8.ForeColor = Color.Orange;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
