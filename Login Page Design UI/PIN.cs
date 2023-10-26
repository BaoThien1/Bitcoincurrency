using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siticone.Desktop.UI.WinForms;

namespace Login_Page_Design_UI
{
    public partial class PIN : Form
    {


        public PIN()
        {
            InitializeComponent();
        }

        private void siticoneTextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void siticoneTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void sgbSend_Click(object sender, EventArgs e)
        {

            Close();
        }
        private void sgbAuthenticate_Click(object sender, EventArgs e)
        {
            bool isValidLevelNumber = (siticoneTextBox1.Text == "8" && siticoneTextBox4.Text == "1"
               && siticoneTextBox2.Text == "1" && siticoneTextBox3.Text == "0" && siticoneTextBox5.Text == "3");
            if (siticoneTextBox1.Text == "")
            {
                MessageBox.Show("Please enter your Pin", "Notificate", MessageBoxButtons.OK);
                
            }
            else if (isValidLevelNumber)
            {
                MessageBox.Show("Authenticate successfully", "", MessageBoxButtons.OK);
                Close();
            }
            else
                MessageBox.Show("An error occurred while retrieving the exchange rate!", "Error", MessageBoxButtons.OK);
            siticoneTextBox1.Clear();
            siticoneTextBox2.Clear();
            siticoneTextBox3.Clear();
            siticoneTextBox4.Clear();
            siticoneTextBox5.Clear();
        
    








    }

        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void siticoneTextBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void siticoneTextBox5_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
