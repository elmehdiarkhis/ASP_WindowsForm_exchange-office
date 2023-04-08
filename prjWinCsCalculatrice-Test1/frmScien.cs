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
    public partial class frmScien : Form
    {
        Double resultValue = 0, PI = 3.1415926535897931;
        String operationPerformed = "";
        int counter = 1, operatorclicked=0;
        bool isOperationPerformed = false, btnNdClicked = false, parenthesOpen=false;

        public frmScien()
        {
            InitializeComponent();
        }

        private void btnEqualClick(object sender, EventArgs e)
        {
            

            switch (operationPerformed)
            {
                case "+":
                    txtResultat.Text = (resultValue + Double.Parse(txtResultat.Text)).ToString();
                    ///txtCalcul.Text = "";
                    break;


                case "-":
                    txtResultat.Text = (resultValue - Double.Parse(txtResultat.Text)).ToString();
                    ///txtCalcul.Text = "";
                    break;


                case "*":
                    txtResultat.Text = (resultValue * Double.Parse(txtResultat.Text)).ToString();
                    ///txtCalcul.Text = "";
                    break;


                case "/":
                    txtResultat.Text = (resultValue / Double.Parse(txtResultat.Text)).ToString();
                    ///txtCalcul.Text = "";
                    break;

                case "mod":
                    txtCalcul.Text = resultValue + " Mod(" + txtResultat.Text + ")";
                    txtResultat.Text = (resultValue % Double.Parse(txtResultat.Text)).ToString();
                    isOperationPerformed = true;
                    break;

                case "exp":
                    txtCalcul.Text = resultValue + " .e + " + Double.Parse(txtResultat.Text);
                    txtResultat.Text = (resultValue * Math.Pow(10.0, Double.Parse(txtResultat.Text))).ToString();
                    isOperationPerformed = true;
                    break;

                case "XpuissanceY":
                    txtCalcul.Text = resultValue + " ^ " + Double.Parse(txtResultat.Text);
                    txtResultat.Text = (Math.Pow(resultValue, Double.Parse(txtResultat.Text))).ToString();
                    isOperationPerformed = true;
                    break;

                case "Yroot":
                    txtCalcul.Text = resultValue + " Yroot " + Double.Parse(txtResultat.Text);
                    txtResultat.Text = (Math.Pow(resultValue, 1.0 / Double.Parse(txtResultat.Text))).ToString();
                    isOperationPerformed = true;
                    break;

                case "LogBase":
                    txtCalcul.Text = resultValue + " log base " + Double.Parse(txtResultat.Text);
                    txtResultat.Text = (Math.Log(resultValue, Double.Parse(txtResultat.Text))).ToString();
                    isOperationPerformed = true;
                    break;


                    

                default:
                    break;
            }
            txtCalcul.Text = txtResultat.Text;
            resultValue = Double.Parse(txtResultat.Text);
            
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operatorclicked++;

            if (resultValue != 0 )
            {


                btnEqual.PerformClick();
                operationPerformed = button.Text;
                txtCalcul.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;


            }
            else
            {
                
                operationPerformed = button.Text;
                txtCalcul.Text += operationPerformed;

                resultValue = Double.Parse(txtResultat.Text);
                isOperationPerformed = true;
            }
        }

        private void chiffre_click(object sender, EventArgs e)
        {
            if ((txtResultat.Text == "0") || (isOperationPerformed))
            {
                txtResultat.Clear();
            }

            if ((txtCalcul.Text == "0"))
            {
                txtCalcul.Text="";
            }


            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!txtResultat.Text.Contains("."))
                {
                    txtResultat.Text = txtResultat.Text + button.Text;
                    txtCalcul.Text = txtCalcul.Text + button.Text;
                }
            }
            else
            {
                txtResultat.Text = txtResultat.Text + button.Text;
                txtCalcul.Text = txtCalcul.Text + button.Text;
            }
        }

        private void btlDlt_Click(object sender, EventArgs e)
        {
            String resultat = txtResultat.Text;
            String resultatCalcul = txtCalcul.Text;
            if (resultat.Length != 1 && txtResultat.Text != "0")
            {
                txtResultat.Text = resultat.Remove(resultat.Length - 1, 1);
                txtCalcul.Text = resultatCalcul.Remove(resultatCalcul.Length - 1, 1);
            }
            else
            {
                txtResultat.Text = "0";
                txtCalcul.Text = "0";
            }
        }

        private void butnC_click(object sender, EventArgs e)
        {
            txtResultat.Text = "0";
            txtCalcul.Text = "";
            resultValue = 0;
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            Double resultat = Convert.ToDouble(txtResultat.Text);
            txtResultat.Text = (resultat * (-1)).ToString();
        }

        private void btnDivX_Click(object sender, EventArgs e)
        {
            isOperationPerformed = true;
            resultValue = Convert.ToDouble(txtResultat.Text);
            txtResultat.Text = (1 / resultValue).ToString();

            txtCalcul.Text += "1/(" + (resultValue).ToString() + ")";
        }

        private void btnPuisDeux_Click(object sender, EventArgs e)
        {
            isOperationPerformed = true;

            if (btnNdClicked == false)
            {
                resultValue = Convert.ToDouble(txtResultat.Text);
                txtResultat.Text = (resultValue * resultValue).ToString();

                txtCalcul.Text = "squar(" + (resultValue).ToString() + ")";
            }
            else
            {
                resultValue = Convert.ToDouble(txtResultat.Text);
                txtCalcul.Text = "cubic(" + resultValue + ")";
                txtResultat.Text = (resultValue * resultValue * resultValue).ToString();

                btnNdClicked = false;
                btnDnd.BackColor = Color.Gray;
                btnPuisDeux.Text = "x2";
                btnRacine.Text = "2√x";
                btnPuisan.Text = "Xpy";
                btnPuisanTen.Text = "10px";
                butnLog.Text = "Log";
                butnLn.Text = "ln";
            }
        }

        private void btnRacine_Click(object sender, EventArgs e)
        {
            isOperationPerformed = true;
            

            if (btnNdClicked == false)
            {
                resultValue = Convert.ToDouble(txtResultat.Text);
                txtResultat.Text = (Math.Pow(resultValue, (1.0 / 2.0))).ToString();

                txtCalcul.Text = "√(" + (resultValue).ToString() + ")";
            }
            else
            {
                resultValue = Convert.ToDouble(txtResultat.Text);
                txtCalcul.Text = "cuberoot(" + resultValue + ")";
                txtResultat.Text = (Math.Pow(resultValue, (1.0 / 3.0))).ToString();


                btnNdClicked = false;
                btnDnd.BackColor = Color.Gray;
                btnPuisDeux.Text = "x2";
                btnRacine.Text = "2√x";
                btnPuisan.Text = "Xpy";
                btnPuisanTen.Text = "10px";
                butnLog.Text = "Log";
                butnLn.Text = "ln";
            }
        }

        private void btnFactClick(object sender, EventArgs e)
        {
            isOperationPerformed = true;

            resultValue = Convert.ToDouble(txtResultat.Text);
            int fac = 1;
            for (int i = 1; i <= resultValue; i++)
            {
                fac = fac * i;
            }

            txtCalcul.Text = "fact(" + resultValue + ")";
            txtResultat.Text = fac.ToString();
        }

        private void btnExpo_Click(object sender, EventArgs e)
        {
            isOperationPerformed = true;
            txtResultat.Text = Math.Exp(1).ToString();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            resultValue = Convert.ToDouble(txtResultat.Text);
            txtCalcul.Text = resultValue + ".e + ";
            isOperationPerformed = true;
            operationPerformed = "exp";
        }

        private void btnPuisan_Click(object sender, EventArgs e)
        {
            if (btnNdClicked == false)
            {
                resultValue = Convert.ToDouble(txtResultat.Text);
                txtCalcul.Text = resultValue + "^";
                isOperationPerformed = true;
                operationPerformed = "XpuissanceY";
            }
            else
            {
                resultValue = Convert.ToDouble(txtResultat.Text);
                txtCalcul.Text = resultValue + "Yroot";
                isOperationPerformed = true;
                operationPerformed = "Yroot";

                btnNdClicked = false;
                btnDnd.BackColor = Color.Gray;
                btnPuisDeux.Text = "x2";
                btnRacine.Text = "2√x";
                btnPuisan.Text = "Xpy";
                btnPuisanTen.Text = "10px";
                butnLog.Text = "Log";
                butnLn.Text = "ln";

            }
           
        }

        private void btnPuisanTen_Click(object sender, EventArgs e)
        {
            isOperationPerformed = true;

            if (btnNdClicked == false)
            {
                resultValue = Convert.ToDouble(txtResultat.Text);
                txtResultat.Text = (Math.Pow(10.0, resultValue)).ToString();
                txtCalcul.Text = "10^(" + resultValue.ToString() + ")";
      
            }
            else
            {
                resultValue = Convert.ToDouble(txtResultat.Text);
                txtCalcul.Text = "2^(" + resultValue + ")";
                txtResultat.Text = (Math.Pow(2.0, resultValue)).ToString();

                btnNdClicked = false;
                btnDnd.BackColor = Color.Gray;
                btnPuisDeux.Text = "x2";
                btnRacine.Text = "2√x";
                btnPuisan.Text = "Xpy";
                btnPuisanTen.Text = "10px";
                butnLog.Text = "Log";
                butnLn.Text = "ln";
            }
        }

        private void butnLog_Click(object sender, EventArgs e)
        {
            isOperationPerformed = true;

            if (btnNdClicked == false)
            {
                resultValue = Convert.ToDouble(txtResultat.Text);
                txtResultat.Text = (Math.Log10(resultValue)).ToString();
                txtCalcul.Text = "Log(" + resultValue.ToString() + ")";

            }
            else
            {
                resultValue = Convert.ToDouble(txtResultat.Text);
                txtCalcul.Text = resultValue + " Log Base ";
                isOperationPerformed = true;
                operationPerformed = "LogBase";

                btnNdClicked = false;
                btnDnd.BackColor = Color.Gray;
                btnPuisDeux.Text = "x2";
                btnRacine.Text = "2√x";
                btnPuisan.Text = "Xpy";
                btnPuisanTen.Text = "10px";
                butnLog.Text = "Log";
                butnLn.Text = "ln";
            }
        }

        private void butnLn_Click(object sender, EventArgs e)
        {
            isOperationPerformed = true;

            if (btnNdClicked == false)
            {
                resultValue = Convert.ToDouble(txtResultat.Text);
                txtResultat.Text = (Math.Log(resultValue)).ToString();
                txtCalcul.Text = "ln(" + resultValue.ToString() + ")";

                

            }
            else
            {
                resultValue = Convert.ToDouble(txtResultat.Text);
                txtResultat.Text = (Math.Exp(resultValue)).ToString();
                txtCalcul.Text = "e(" + resultValue + ")";
                isOperationPerformed = true;



                btnNdClicked = false;
                btnDnd.BackColor = Color.Gray;
                btnPuisDeux.Text = "x2";
                btnRacine.Text = "2√x";
                btnPuisan.Text = "Xpy";
                btnPuisanTen.Text = "10px";
                butnLog.Text = "Log";
                butnLn.Text = "ln";
            }
        }

        private void btnPourcentage_Click(object sender, EventArgs e)
        {
            txtCalcul.Text += "(";
            parenthesOpen = true;
        }

        private void btnPuissanceDeux_Click(object sender, EventArgs e)
        {
            if (parenthesOpen == true)
            {
                txtCalcul.Text += ")";
                parenthesOpen = false;

            }


        }

        private void btnAbsolu_Click(object sender, EventArgs e)
        {
            resultValue = Convert.ToDouble(txtResultat.Text);
            isOperationPerformed = true;
            txtCalcul.Text = "abs(" + resultValue + ")";
            txtResultat.Text = Math.Abs(Convert.ToDouble(resultValue)).ToString();
        }

        private void txtResultat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void frmScien_Load(object sender, EventArgs e)
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

        private void txtCalcul_Click(object sender, EventArgs e)
        {

        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            resultValue = Convert.ToDouble(txtResultat.Text);
            txtCalcul.Text = resultValue + "mod(";
            isOperationPerformed = true;
            operationPerformed = "mod";
        }

        private void btnPiClicked(object sender, EventArgs e)
        {
            isOperationPerformed = true;
            txtResultat.Text = PI.ToString();
        }

        private void btnDndClick(object sender, EventArgs e)
        {
            counter++;

            if (counter % 2 == 0)
            {
                btnNdClicked = true;
                btnDnd.BackColor = Color.BlueViolet;

                btnPuisDeux.Text = "x3";
                btnRacine.Text = "3√x";
                btnPuisan.Text = "y√x";
                btnPuisanTen.Text = "2^x";
                butnLog.Text = "LOGy(x)";
                butnLn.Text = "e(x)";
            }
            else
            {
                btnNdClicked = false;
                btnDnd.BackColor = Color.Gray;

                btnPuisDeux.Text = "x2";
                btnRacine.Text = "2√x";
                btnPuisan.Text = "Xpy";
                btnPuisanTen.Text = "10px";
                butnLog.Text = "Log";
                butnLn.Text = "ln";

            }
        }
    }
}
