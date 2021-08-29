using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float num1, num2;
        string operacao;

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "9";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + ".";
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtResultado.Text);
            txtResultado.Text = "";
            operacao = "subtracao";
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtResultado.Text);
            txtResultado.Text = "";
            operacao = "multiplicacao";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtResultado.Text);
            txtResultado.Text = "";
            operacao = "divisao";
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            num2 = float.Parse(txtResultado.Text);
            if (operacao == "soma")
            {
                txtResultado.Text = Convert.ToString(num1 + num2);
            } else if (operacao == "subtracao")
            {
                txtResultado.Text = Convert.ToString(num1 - num2);
            } else if (operacao == "divisao")
            {
                txtResultado.Text = Convert.ToString(num1 / num2);
            } else if (operacao == "multiplicacao")
            {
                txtResultado.Text = Convert.ToString(num1 * num2);
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            num1 = 0;
            num2 = 0;
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtResultado.Text);
            txtResultado.Text = "";
            operacao = "soma";
        }

    }
}
