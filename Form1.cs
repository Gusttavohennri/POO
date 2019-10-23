using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmEq2grau : Form
    {
        public frmEq2grau()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double a, b, c, Delta, Raiz01, Raiz02;

            a = double.Parse(txtA.Text);
            b = double.Parse(txtB.Text);
            c = double.Parse(txtC.Text);

            Delta = Math.Pow(b, 2) - 4 * a * c;
            txtDelta.Text = Delta.ToString("F2");
            lblMsg.Visible = true;
            if (Delta == 0)
                lblMsg.Text = "Raizes Reais iguals";
            else if (Delta > 0)
                lblMsg.Text = "Raizes Reais distintas";
            else if (Delta < 0)
                lblMsg.Text = "Não possui Raizes reais";

            if (Delta >= 0)
            {
                Raiz01 = (-b + Math.Sqrt(Delta)) / (2 * a);
                Raiz02 = (-b - Math.Sqrt(Delta)) / (2 * a);

                txtR1.Text = Raiz01.ToString("F2");
                txtR2.Text = Raiz02.ToString("F2");
            }
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            txtDelta.Text = "";
            txtR1.Text = "";
            txtR2.Text = "";
            lblMsg.Text = "";
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            txtDelta.Text = "";
            txtR1.Text = "";
            txtR2.Text = "";
            lblMsg.Text = "";
        }
        private void txtC_TextChanged(object sender, EventArgs e)
        {
            txtDelta.Text = "";
            txtR1.Text = "";
            txtR2.Text = "";
            lblMsg.Text = "";
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                txtB.Focus();
            }
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtC.Focus();
            }
        }

        private void txtC_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnCalc.Focus();
            }
        }
    }
}




