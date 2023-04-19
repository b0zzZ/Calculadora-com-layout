using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_com_layout
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "SUBT";
            lblOperacao.Text = "-";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "SOMA";
            lblOperacao.Text = "+";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            lblOperacao.Text = "";
            txtResultado.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            switch (operacao)
            {
                case "SOMA":
                    txtResultado.Text = Convert.ToString(valor1 + valor2);
                    break;


                case "SUBT":
                    txtResultado.Text = Convert.ToString(valor1 - valor2);
                    break;

                case "MULT":
                    txtResultado.Text = Convert.ToString(valor1 * valor2);
                    break;

                case "DIV":
                    txtResultado.Text = Convert.ToString(valor1 / valor2);
                    break;

                default:
                    txtResultado.Text = "";
                    break;
            }

        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "MULT";
            lblOperacao.Text = "X";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "DIV";
            lblOperacao.Text = "/";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
            valor1 = 0;
            valor2 = 0;
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }
    }
}
