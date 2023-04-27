using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zavedenie_Form
{
    public partial class Cenorazpis : Form
    {
        public Cenorazpis()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //5.50
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //3.70
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //4.85
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //3.00
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //25.00
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //10
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            //3
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            //2.50
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //2
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            //7
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            //5.50
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            //15.50
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            //4
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            //1
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {
            //
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            //0.80
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            //0.70
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            //2.00
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            //7.00
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double shopska = int.Parse(textBox1.Text) * 5.50 ;
            double mlecna = int.Parse(textBox2.Text) * 3.70;
            double troshiq = int.Parse(textBox3.Text) * 4.85;

            double kebapche = int.Parse(textBox6.Text) * 3.00;
            double agneshko = int.Parse(textBox5.Text) * 25.50;
            double kartof = int.Parse(textBox4.Text) * 10.00;

            double torta = int.Parse(textBox9.Text) * 3.00;
            double sladoled = int.Parse(textBox8.Text) * 2.50;
            double krem = int.Parse(textBox7.Text) * 3.00;

            double rakij = int.Parse(textBox18.Text) * 7.00;
            double yuiski = int.Parse(textBox17.Text) * 5.50;
            double vodka = int.Parse(textBox16.Text) * 15.00;

            double frape = int.Parse(textBox15.Text) * 4.00;
            double gazvoda = int.Parse(textBox14.Text) * 1.00;
            double voda = int.Parse(textBox13.Text) * 0.80;

            var chai = int.Parse(textBox12.Text) * 0.70;
            var kafe = int.Parse(textBox11.Text) * 2.00;
            var grrakij = int.Parse(textBox10.Text) * 7.00;

            var sumtotal = shopska + mlecna + troshiq + kebapche + agneshko + kartof + torta + sladoled + krem + rakij + yuiski + vodka + frape + gazvoda + voda + chai + kafe + grrakij;

        }
    }
}
