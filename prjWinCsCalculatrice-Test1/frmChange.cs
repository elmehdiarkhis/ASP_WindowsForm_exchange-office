using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;



namespace prjWinCsCalculatrice_Test1
{
    public partial class frmChange : Form
    {
        int pointcounter = 0;
        Currency[] tabCurrencys = new Currency[31];

        public frmChange()
        {
            InitializeComponent();
        }

        private void frmChange_Load(object sender, EventArgs e)
        {

        }

        private void frmChange_Load_1(object sender, EventArgs e)
        {

            XmlToObjects(tabCurrencys);


            for (int i = 0; i < tabCurrencys.Length; i++)
            {
                cboCurrencyFrom.Items.Add(tabCurrencys[i].currencyName);
                cboCurrencyTo.Items.Add(tabCurrencys[i].currencyName);
            }


            cboCurrencyFrom.SelectedIndex = 0;
            cboCurrencyTo.SelectedIndex = 0;

            lblUpdate.Text = " Derniere Mise a Jour : " + DateTime.Now.ToString();

        }

        private void radFromTo_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void radToFrom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cboCurrencyFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDeviseFrom.Text = cboCurrencyFrom.SelectedItem.ToString();

        }

        private void cboCurrencyTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            resetToOneDefault();

            for (int i = 0; i < tabCurrencys.Length; i++)
            {

                if (cboCurrencyFrom.SelectedItem.ToString() == tabCurrencys[i].currencyName && cboCurrencyTo.SelectedIndex != -1 && cboCurrencyFrom.SelectedIndex != -1)
                {

                    double amount = ConvertToEuro(tabCurrencys, i);


                    for (int j = 0; j < tabCurrencys.Length; j++)
                    {
                        if (cboCurrencyTo.SelectedItem.ToString() == tabCurrencys[j].currencyName)
                        {
                            amount = amount * tabCurrencys[j].rate;
                        }

                    }


                    AfficherResultat(amount, 2);
                }

            }
        }

        private void lblRateFrom_Click(object sender, EventArgs e)
        {

        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtAmount.Text="1";
            lblResultat.Text = "";
            cboCurrencyFrom.SelectedIndex = 0;
            cboCurrencyTo.SelectedIndex = 0;
        }

        private void btnQuiter_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voulez vous vraiment Quitter ? ", "Fenetre Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = true;       

            if (e.KeyChar == '.')
            {
                pointcounter++;
            }

            if (char.IsDigit(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || (e.KeyChar == '.'&& pointcounter==1))
            {
                
                e.Handled = false;
 
            }

        }



        private void cboCurrencyFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboCurrencyTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            string c;

            c = cboCurrencyFrom.SelectedItem.ToString();
            cboCurrencyFrom.SelectedItem = cboCurrencyTo.SelectedItem;
            cboCurrencyTo.SelectedItem = c;

            btnConvertir.PerformClick();
        }
        //========================================Methods=========================================================//
        public void XmlToObjects(Currency[] _tabCurrencys)
        {
            var doc = new XmlDocument();
            doc.Load(@"http://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml");

            XmlNodeList nodes = doc.SelectNodes("/*/*/*/*");

            for (int i = 0; i < nodes.Count; i++)
            {
                _tabCurrencys[i].currencyName = nodes[i].Attributes[0].Value;
                _tabCurrencys[i].rate = Convert.ToDouble(nodes[i].Attributes[1].Value);
            };

            _tabCurrencys[nodes.Count - 1].currencyName = "EUR";
            _tabCurrencys[nodes.Count - 1].rate = 1;
        }





        public void resetToOneDefault()
        {
            if (txtAmount.Text == "0")
            {
                txtAmount.Text = "1";
            }
        }

        public double ConvertToEuro(Currency[] _tabCurrencys, int _i)
        {
            double _amount = Convert.ToDouble(txtAmount.Text);

            _amount = _amount / _tabCurrencys[_i].rate;

            return _amount;
        }

        public void AfficherResultat(double _amount, int nbrVirgule)
        {
            lblResultat.Text = Math.Round(_amount, nbrVirgule) + " " + cboCurrencyTo.SelectedItem.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            XmlToObjects(tabCurrencys);


            for (int i = 0; i < tabCurrencys.Length; i++)
            {
                cboCurrencyFrom.Items.Add(tabCurrencys[i].currencyName);
                cboCurrencyTo.Items.Add(tabCurrencys[i].currencyName);
            }


            cboCurrencyFrom.SelectedIndex = 0;
            cboCurrencyTo.SelectedIndex = 0;

            lblUpdate.Text = " Derniere Mise a Jour : " + DateTime.Now.ToString();
        }

        private void lblUpdate_Click(object sender, EventArgs e)
        {

        }
        //========================================Methods=========================================================//
    }


}
