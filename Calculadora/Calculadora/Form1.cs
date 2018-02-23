using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double valorA = System.Convert.ToDouble(txbValorA.Text);
            double valorB = System.Convert.ToDouble(txbValorB.Text);
            double Resp = valorA+valorB;
            lblResposta.Text ="o valor é:"+Resp;
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double valorA = System.Convert.ToDouble(txbValorA.Text);
            double valorB = System.Convert.ToDouble(txbValorB.Text);
            double Resp = valorA - valorB;
            lblResposta.Text = "o valor é:" + Resp;
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            double valorA = System.Convert.ToDouble(txbValorA.Text);
            double valorB = System.Convert.ToDouble(txbValorB.Text);
            double Resp = valorA * valorB;
            lblResposta.Text = "o valor é:" + Resp;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double valorA = System.Convert.ToDouble(txbValorA.Text);
            double valorB = System.Convert.ToDouble(txbValorB.Text);
            if (valorA == 0 || valorB == 0)
            {
                lblResposta.Text = "impossivel dividir por zero";
            }
            else
            {
            double Resp = valorA / valorB;
            lblResposta.Text = "o valor é:" + Resp;
            }
            
        }
    }
}
