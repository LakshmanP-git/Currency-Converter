using System.Diagnostics.Eventing.Reader;

namespace currencyCalculator
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
                if (btnConvert.Text.Contains(".") && btnConvert.Text.IndexOf(".") == (btnConvert.Text.Length - 3))
                {
                    decimal.Parse(btnConvert.Text);
                }
                else
                {
                    int.Parse(btnConvert.Text);
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Invalid input.");
            }
        }
    }
}
