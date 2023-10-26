using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Page_Design_UI
{
    public partial class Buy : Form
    {
        public Buy()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void Buy_Load(object sender, EventArgs e)
        {

        }

        private void BitcoinAmount_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = BitcoinAmount.Value + " Bitcoin";
        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            siticoneGradientButton1.Text = "Waiting for server";     
        }

        private void siticoneTrackBar2_ValueChanged(object sender, EventArgs e)
        {
            label5.Text = BitcoinAmount2.Value + " Bitcoin";
        }

        private void siticoneGradientButton3_Click(object sender, EventArgs e)
        {
            siticoneGradientButton3.Text = "Waiting for server";
        }

        private void siticoneTrackBar3_ValueChanged(object sender, EventArgs e)
        {
            label7.Text = EtherumAmount.Value + " Etherum";
        }

        private void siticoneGradientButton4_Click(object sender, EventArgs e)
        {
            siticoneGradientButton4.Text = "Waiting for server";
            MessageBox.Show("Successfully buy ethrum.", "Successfull", MessageBoxButtons.OK);
        }

        private void EtherumAmount1_ValueChanged(object sender, EventArgs e)
        {
            label9.Text = EtherumAmount1.Value + " Etherum";
        }

        private void siticoneGradientButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully sold ethrum.", "Successfull", MessageBoxButtons.OK);
        }
        
        private void siticoneGradientButton2_Click(object sender, EventArgs e)
        {
            new PIN().ShowDialog();
            siticoneGradientButton2.Text = "Sending crypto...";
            siticoneTextBox1.Clear();
            siticoneTextBox2.Clear();
            siticoneTextBox3.Clear();
            siticoneTextBox4.Clear();
            siticoneTextBox5.Clear();
        }
    }
    
}
