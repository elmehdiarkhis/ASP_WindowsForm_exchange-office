using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prjWinCsCalculatrice_Test1
{
    public partial class frmChangeDollar : Form
    {
        public frmChangeDollar()
        {
            InitializeComponent();
        }

        public struct Country
        {
            public string countryName;
            public string rate;
            public string devise;
        }

        //---------Variable Generale----------
        Country[] tabCountrys = new Country[25];
        int nbrPays, pointcounter=0;
        //---------Variable Generale----------

        private void frmChangeDollar_Load(object sender, EventArgs e)
        {
            //ECRITURE
            ///Ouvrire le fichier :     
            StreamWriter fichierAremplire = new StreamWriter("PaysClassData.txt",true);
            ///( ,true) pour ne pas ecraser le fichier lors de l'ouverture

            ///Fermer le fichier
            fichierAremplire.Close();


            //Lecture
            ///Ouvrire le fichier 
            StreamReader paysFichier = new StreamReader("PaysClassData.txt");

            //Boucler ju'squ'a la fin du fichier pour lire ligne par ligne
            int i = 0;
            while (paysFichier.EndOfStream == false)
            {
                tabCountrys[i].countryName = paysFichier.ReadLine();
                tabCountrys[i].rate = paysFichier.ReadLine();
                tabCountrys[i].devise = paysFichier.ReadLine();
                i++;
            }

            nbrPays = i;

            ///Fermer le fichier
            paysFichier.Close();


            ///remplir le comboBox
            for (int j = 0; j < nbrPays; j++)
            {
                cboCountry.Items.Add(tabCountrys[j].countryName);
            }

            cboCountry.SelectedIndex = 0;

            ///Remplire les rad
            for (int j = 0; j < nbrPays; j++)
            {
                if (cboCountry.SelectedItem.ToString() == tabCountrys[j].countryName)
                {
                    radDollarToCurrency.Text = "From USD to " + tabCountrys[j].devise;
                    radCurrencyToDollar.Text = "From " + tabCountrys[j].devise +" to USD";
                }
            }
            



            radDollarToCurrency.Checked = true;

        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///Modifier les labels lors du changement de choix------------------------------
            for (int i = 0; i < nbrPays; i++)
            {
                if (cboCountry.SelectedItem.ToString() == tabCountrys[i].countryName)
                {
                    lblDollardToCurrency.Text = " 1 USD = " + Convert.ToDouble(tabCountrys[i].rate) + " " + tabCountrys[i].devise;

                    double rateToCurrency = 1 / Convert.ToDouble(tabCountrys[i].rate);
                    lblCurrencytoDollard.Text = " 1 " + tabCountrys[i].devise + " = " + Math.Round(rateToCurrency, 4) + " USD ";
                }
            }


            ///Modifier les rad lors du changement de choix------------------------------
            for (int j = 0; j < nbrPays; j++)
            {
                if (cboCountry.SelectedItem.ToString() == tabCountrys[j].countryName)
                {
                    radDollarToCurrency.Text = "From USD to " + tabCountrys[j].devise;
                    radCurrencyToDollar.Text = "From " + tabCountrys[j].devise + " to USD";
                }
            }


            ///Modifier le lblDeviseFrom lors du changement de choix------------------------------
            if (radCurrencyToDollar.Checked == true)
            {
                for (int j = 0; j < nbrPays; j++)
                {
                    if (cboCountry.SelectedItem.ToString() == tabCountrys[j].countryName)
                    {
                        lblDeviseFrom.Text = tabCountrys[j].devise;
                    }
                }
            }
        }

        private void radDollarToCurrency_CheckedChanged(object sender, EventArgs e)
        {
            if (radDollarToCurrency.Checked == true)
            {
               lblDeviseFrom.Text = "USD";
            }

        }

        private void radCurrencyToDollar_CheckedChanged(object sender, EventArgs e)
        {
            if (radCurrencyToDollar.Checked == true)
            {
                for (int j = 0; j < nbrPays; j++)
                {
                    if (cboCountry.SelectedItem.ToString() == tabCountrys[j].countryName)
                    {
                        lblDeviseFrom.Text = tabCountrys[j].devise;
                    }
                }
            }
        }

        private void btnQuiter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment Quitter ? ", "Fenetre Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == "0")
            {
                txtAmount.Text = "1";
            }

            double amount = Convert.ToDouble(txtAmount.Text);

            if (radDollarToCurrency.Checked == true)
            {
                for (int i = 0; i < nbrPays; i++)
                {
                    if (cboCountry.SelectedItem.ToString() == tabCountrys[i].countryName)
                    {
                        double resultatRate = amount * Convert.ToDouble(tabCountrys[i].rate);
                        lblResultat.Text = Math.Round(resultatRate, 4) + " " + tabCountrys[i].devise;
                    }
                }
            }
            else
            {
                for (int i = 0; i < nbrPays; i++)
                {
                    if (cboCountry.SelectedItem.ToString() == tabCountrys[i].countryName)
                    {
                        double resultatRate = amount / Convert.ToDouble(tabCountrys[i].rate);
                        lblResultat.Text = Math.Round(resultatRate, 4) + " " + " USD";
                    }
                }
            }
           
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtAmount.Text = "1";
            lblResultat.Text = "";
            cboCountry.SelectedIndex = 0;
            radDollarToCurrency.Checked = true;
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (e.KeyChar == '.')
            {
                pointcounter++;
            }else if (txtAmount.Text.Contains(".")==false)
            {
                pointcounter = 0;
            }

            if (char.IsDigit(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || (e.KeyChar == '.' && pointcounter == 1))
            {

                e.Handled = false;

            }

            
        }
    }
}
