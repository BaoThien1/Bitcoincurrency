using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;

namespace Login_Page_Design_UI
{
    public partial class Swap : Form
    {
        public Swap()
        {
            InitializeComponent();
        }

        private void Swap_Load(object sender, EventArgs e)
        {
            ToCurrencyBox.SelectedItem = "USD";
        }
        private double GetExchangeRate(string fromCurrency, string toCurrency)
        {
            string json;
            using (var client = new WebClient())
            {
                json = client.DownloadString($"https://api.exchangerate-api.com/v4/latest/{fromCurrency}");
            }
            var data = JObject.Parse(json);
            var rate = (double)data["rates"][toCurrency];

            return rate;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            string fromCurrency = FromCurrencyBox.SelectedItem.ToString();
            string toCurrency = ToCurrencyBox.SelectedItem.ToString();

            double amount;
            if(!double.TryParse(AmountToConvertBox.Text, out amount))
            {
                MessageBox.Show("please enter a valid amount to convert.", "Error", MessageBoxButtons.OK);
                return;
            }

            double exChangeRate;
            try
            {
                exChangeRate = GetExchangeRate(fromCurrency, toCurrency);
            }
            catch
            {
                MessageBox.Show("An error occurred while retrieving the exchange rate!", "Error", MessageBoxButtons.OK);
                return;
            }

            double convertedAmount = amount * exChangeRate;
            ConvertedAmountDisplay.Text = ConvertedAmountDisplay.Text.Replace("???", toCurrency + convertedAmount.ToString("F2"));
            RateDisplay.Text = $"Conversion rate: 1{fromCurrency} = {1 * exChangeRate}{toCurrency}";

        }
    }
}
