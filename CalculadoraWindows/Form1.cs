using System;
using System.Windows.Forms;

namespace CalculadoraWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double numero1, numero2, resultado;
        char operador;

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "0";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            txtPainel.Text += ",";
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtPainel.Text);
            txtPainel.Text += "+";
            operador = '+';
            lblCalculo.Text = txtPainel.Text;
            lblCalculo.Visible = true;
            txtPainel.Clear();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtPainel.Text);
            txtPainel.Text += "-";
            operador = '-';
            lblCalculo.Text = txtPainel.Text;
            lblCalculo.Visible = true;
            txtPainel.Clear();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtPainel.Text);
            txtPainel.Text += "*";
            operador = '*';
            lblCalculo.Text = txtPainel.Text;
            lblCalculo.Visible = true;
            txtPainel.Clear();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtPainel.Text);
            txtPainel.Text += "/";
            operador = '/';
            lblCalculo.Text = txtPainel.Text;
            lblCalculo.Visible = true;
            txtPainel.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPainel.Text = txtPainel.Text.Remove(txtPainel.Text.Length - 1);
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtPainel.Clear();
            lblCalculo.Text = string.Empty;
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(txtPainel.Text);
            switch (operador)
            {
                case '+':
                    resultado = numero1 + numero2;
                    break;
                case '-':
                    resultado = numero1 - numero2;
                    break;
                case '*':
                    resultado = numero1 * numero2;
                    break;
                case '/':
                    resultado = numero1 / numero2;
                    break;
            }

            txtPainel.Text = resultado.ToString();
            lblCalculo.Text += numero2;
            
        }
    }
}
