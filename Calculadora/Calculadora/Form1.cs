using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        private decimal Resultado;
        private decimal Valor;
        private string Simbolo;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Visor.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Visor.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Visor.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Visor.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Visor.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Visor.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Visor.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Visor.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Visor.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Visor.Text += "9";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (Simbolo == null)
            {
                if (string.IsNullOrEmpty(Visor.Text)) { Visor.Text = "0"; }
                Valor = Convert.ToDecimal(Visor.Text);

            }
            Visor.Text = "";
            Simbolo = "/";
            Sinal.Text = $"{Valor.ToString("G29")} {Simbolo}";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (Simbolo == null)
            {
                if (string.IsNullOrEmpty(Visor.Text)) { Visor.Text = "0"; }
                Valor = Convert.ToDecimal(Visor.Text);

            }
            Visor.Text = "";
            Simbolo = "*";
            Sinal.Text = $"{Valor.ToString("G29")} {Simbolo}";

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (Simbolo == null)
            {
                if (string.IsNullOrEmpty(Visor.Text)) { Visor.Text = "0"; }
                Valor = Convert.ToDecimal(Visor.Text);

            }
            Visor.Text = "";
            Simbolo = "-";
            Sinal.Text = $"{Valor.ToString("G29")} {Simbolo}";

        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            if (Simbolo == null)
            {
                if (string.IsNullOrEmpty(Visor.Text)) { Visor.Text = "0"; }
                Valor = Convert.ToDecimal(Visor.Text);
            }
            Visor.Text = "";
            Simbolo = "+";
            Sinal.Text = $"{Valor.ToString("G29")} {Simbolo}";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            switch (Simbolo)
            {
                case "/":
                    if (Convert.ToDecimal(Visor.Text) == 0)
                    {
                        Resultado = 0;
                        return;
                    }
                    Resultado = Valor / Convert.ToDecimal(Visor.Text);
                    break;
                case "*":
                    Resultado = Valor * Convert.ToDecimal(Visor.Text);
                    break;
                case "-":
                    Resultado = Valor - Convert.ToDecimal(Visor.Text);
                    break;
                case "+":
                    Resultado = Valor + Convert.ToDecimal(Visor.Text);
                    break;
            }
            Sinal.Text = $"{Valor.ToString("G29")} {Simbolo} {Convert.ToDecimal(Visor.Text).ToString("G29")} =";
            Visor.Text = Resultado.ToString("G29");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Visor.Text.Contains(","))
                Visor.Text += ",";
            if (Visor.Text == ",")
                Visor.Text = "0,";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Visor.Text = "";
            Sinal.Text = "";
            Simbolo = null;
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void Sinal_Click(object sender, EventArgs e)
        {

        }
    }
}