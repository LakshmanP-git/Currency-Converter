using System.Diagnostics.Eventing.Reader;

namespace currencyConverter
{
    public partial class curerncyConverterForm : Form
    {
        public curerncyConverterForm()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                txtDollars.Text = Math.Round(double.Parse(txtDollars.Text), 2).ToString();
                txtPounds.Text = Math.Round(double.Parse(txtDollars.Text) * 0.76, 2).ToString();
                txtYen.Text = Math.Round(double.Parse(txtDollars.Text) * 104.53, 2).ToString();
                txtEuros.Text = Math.Round(double.Parse(txtDollars.Text) * 0.84, 2).ToString();
                if (rdoDollars.Checked) {
                    partMoney(txtDollars.Text);
                } else if (rdoEuros.Checked) {
                    partMoney(txtEuros.Text);
                } else if (rdoYen.Checked) {
                    partMoney(txtYen.Text);
                } else if (rdoPounds.Checked) {
                    partMoney(txtYen.Text);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input.");
            }
        }

        private void partMoney(string txt) {
            txtHundredBills.Text = (Math.Floor(double.Parse(txt) / 100) * 100).ToString();
            txtFiftyBills.Text = (Math.Floor((double.Parse(txt) - double.Parse(txtHundredBills.Text)) / 100) * 100).ToString();
        }
    }
}
