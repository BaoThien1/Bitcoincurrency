using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using NBitcoin;

namespace Login_Page_Design_UI
{
    public partial class Money : Form
    {
        public Money()
        {
            InitializeComponent();
        }

        private void btnRecharge_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btnRecharge_Click_1(object sender, EventArgs e)
        {
            new PIN().ShowDialog();
            if (txtWallet.Text == "")
            {
                double numA = double.Parse(txtRecharge.Text);
                
                txtWallet.Text = numA.ToString();

                MessageBox.Show("You have successfully deposited money " + txtRecharge.Text + " $", "", MessageBoxButtons.OK);
                txtRecharge.Clear();
            }else
            {
                double rs = double.Parse(txtWallet.Text) + double.Parse(txtRecharge.Text);
                txtWallet.Text = rs.ToString();
                MessageBox.Show("You have successfully deposited money " + txtRecharge.Text + " $", "", MessageBoxButtons.OK);
                txtRecharge.Clear();
            }
        }

        private void btnwithdraw_Click(object sender, EventArgs e)
        {       
                double numA = double.Parse(txtWallet.Text);
                double numB = double.Parse(txtWithdraw.Text);
                double result = numA - numB;
                
            if(result > 1)
            {
                txtWallet.Text = result.ToString();
                MessageBox.Show("You have successfully withdrawn " + txtWithdraw.Text + " $", "", MessageBoxButtons.OK);
                txtWithdraw.Clear();
            }else
                MessageBox.Show("The blance in your wallet is not enough to make the transaction ", "Error", MessageBoxButtons.OK);
            txtWithdraw.Clear();

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
