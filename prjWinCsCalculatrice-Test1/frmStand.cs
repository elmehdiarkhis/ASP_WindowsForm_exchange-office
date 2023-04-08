using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsCalculatrice_Test1
{
    public partial class frmStand : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false, btnPourcentageClicked = false;

        public frmStand()
        {
            InitializeComponent();
        }

        private void btnEqualClick(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    if (btnPourcentageClicked == true)
                    {
                        txtResultat.Text = (resultValue + ((resultValue * Double.Parse(txtResultat.Text)) / 100)).ToString();
                        btnPourcentageClicked = false;
                    }
                    else
                    {
                        txtResultat.Text = (resultValue + Double.Parse(txtResultat.Text)).ToString();
                    }
                    break;


                case "-":
                    if (btnPourcentageClicked == true)
                    {
                        txtResultat.Text = (resultValue - ((resultValue * Double.Parse(txtResultat.Text)) / 100)).ToString();
                        btnPourcentageClicked = false;
                    }
                    else
                    {
                        txtResultat.Text = (resultValue - Double.Parse(txtResultat.Text)).ToString();
                    }
                    break;


                case "*":
                    if (btnPourcentageClicked == true)
                    {
                        txtResultat.Text = (resultValue * ((resultValue * Double.Parse(txtResultat.Text)) / 100)).ToString();
                        btnPourcentageClicked = false;
                    }
                    else
                    {
                        txtResultat.Text = (resultValue * Double.Parse(txtResultat.Text)).ToString();
                    }
                    break;


                case "/":
                    if (btnPourcentageClicked == true)
                    {
                        txtResultat.Text = (resultValue / ((resultValue * Double.Parse(txtResultat.Text)) / 100)).ToString();
                        btnPourcentageClicked = false;
                    }
                    else
                    {
                        txtResultat.Text = (resultValue / Double.Parse(txtResultat.Text)).ToString();
                    }
                    break;


                default:
                    break;
            }
            resultValue = Double.Parse(txtResultat.Text);
            txtCalcul.Text = "";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                btnEqual.PerformClick();
                operationPerformed = button.Text;
                txtCalcul.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {

                operationPerformed = button.Text;
                resultValue = Double.Parse(txtResultat.Text);
                txtCalcul.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String resultat = txtResultat.Text;
            if (resultat.Length != 1 && txtResultat.Text != "0")
            {
                txtResultat.Text = resultat.Remove(resultat.Length - 1, 1);
            }
            else
            {
                txtResultat.Text = "0";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResultat.Text = "0";
            txtCalcul.Text = "";
            resultValue = 0;
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            txtResultat.Text = "0";
            txtCalcul.Text = "";
            resultValue = 0;
        }

        private void btnRacine_Click(object sender, EventArgs e)
        {
            resultValue = Convert.ToDouble(txtResultat.Text);
            txtResultat.Text = (Math.Pow(resultValue, (1.0 / 2.0))).ToString();

            txtCalcul.Text = "√(" + (resultValue).ToString() + ")";
        }

        private void btnPuissanceDeux_Click(object sender, EventArgs e)
        {
            resultValue = Convert.ToDouble(txtResultat.Text);
            txtResultat.Text = (resultValue * resultValue).ToString();

            txtCalcul.Text = "squar(" + (resultValue).ToString() + ")";
        }

        private void btnDivX_Click(object sender, EventArgs e)
        {
            resultValue = Convert.ToDouble(txtResultat.Text);
            txtResultat.Text = (1 / resultValue).ToString();

            txtCalcul.Text += "1/(" + (resultValue).ToString() + ")";
        }

        private void btnPourcentage_Click(object sender, EventArgs e)
        {
            btnPourcentageClicked = true;
            txtCalcul.Text = resultValue + " " + operationPerformed + " " + txtResultat.Text.ToString() + "%";
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            Double resultat = Convert.ToDouble(txtResultat.Text);
            txtResultat.Text = (resultat * (-1)).ToString();
        }

        private void frmStand_Load(object sender, EventArgs e)
        {
            btnMc.Enabled = btnMr.Enabled = btnMf.Enabled = false;
            btnMc.ForeColor = btnMr.ForeColor = btnMf.ForeColor = Color.Gray;
            btnMc.BackColor = btnMr.BackColor = btnMf.BackColor = Color.Gray;

        }

        private void btnMp_Click(object sender, EventArgs e)
        {
            btnMc.Enabled = btnMr.Enabled = btnMf.Enabled = true;
            btnMc.ForeColor = btnMr.ForeColor = btnMf.ForeColor = Color.Black;
            btnMc.BackColor = btnMr.BackColor = btnMf.BackColor = Color.White;
        }

        private void btnMc_Click(object sender, EventArgs e)
        {
            btnMc.Enabled = btnMr.Enabled = btnMf.Enabled = false;
            btnMc.ForeColor = btnMr.ForeColor = btnMf.ForeColor = Color.Gray;
            btnMc.BackColor = btnMr.BackColor = btnMf.BackColor = Color.Gray;
        }

        private void chiffre_click(object sender, EventArgs e)
        {
            if ((txtResultat.Text == "0") || (isOperationPerformed))
            {
                txtResultat.Clear();
            }


            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!txtResultat.Text.Contains("."))
                    txtResultat.Text = txtResultat.Text + button.Text;

            }
            else
            {
                txtResultat.Text = txtResultat.Text + button.Text;
            }
        }
    }
}
