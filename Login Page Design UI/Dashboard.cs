using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Policy;

namespace Login_Page_Design_UI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            string url = "https://vn.investing.com/crypto/chainlink/link-btc";
            Process.Start(url);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
        string url ="https://vn.investing.com/crypto/chainlink/link-eth";
            Process.Start(url);
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
        string url = "https://vn.investing.com/crypto/xrp/xrp-usd";
            Process.Start(url);
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
        string url ="https://vn.investing.com/crypto/dogecoin/doge-usd";
            Process.Start(url);
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            string url = "https://vn.tradingview.com/symbols/LINKUSD/";
            Process.Start(url);
        }
    }
}
