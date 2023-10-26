using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Page_Design_UI
{
    public partial class setting : Form
    {

        public setting()
        {
            InitializeComponent();
        }
        string passold;
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtNew.Text == "")
            {
                lblShowInfor.ForeColor = System.Drawing.Color.Red;
                lblShowInfor.Text = "Please enter a new password !!";
                txtNew.Focus();
                return;
            }
           if (txtConfirm.Text == "")
            {
                lblShowInfor.ForeColor = System.Drawing.Color.Red;
                lblShowInfor.Text = "Please confirm your password !!";
                txtConfirm.Focus();
                return;
            }
            if (txtNew.Text != txtConfirm.Text)
            {
                lblShowInfor.ForeColor = System.Drawing.Color.Red;
                lblShowInfor.Text = "New password and confirmation password do not match";
                txtConfirm.Focus();
                txtConfirm.SelectAll();
                return;
            }
            if (txtCur.Text.Trim() != passold.Trim())
            {
                lblShowInfor.ForeColor = System.Drawing.Color.Red;
                lblShowInfor.Text = "The old password is incorrect";
                txtCur.Focus();
                txtCur.SelectAll();
                return;
            }
            string str = "UPDATE info_user SET Password = '"+txtNew.Text.Trim()+ "' where Username = '"+txtUser.Text.Trim()+"'";
            ConnectSQL.ExecuteNonQuery(str);
            MessageBox.Show("changed password successfully");
        }

        private void btnShow_CheckedChanged(object sender, EventArgs e)
        {           
                if (chkShow.Checked)
                {
                    txtCur.PasswordChar = (char)0;
                    txtNew.PasswordChar = (char)0;
                    txtConfirm.PasswordChar = (char)0;
                }
                else
                {
                    txtCur.PasswordChar = '*';
                    txtNew.PasswordChar = '*';
                    txtConfirm.PasswordChar = '*';
                }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();           
        }


        private void setting_Load(object sender, EventArgs e)
        {
            txtUser.Text = Login.user;
            txtUser.ReadOnly = true;

            string str = "SELECT Password FROM info_user WHERE Username = '" + txtUser.Text.Trim() + "'";
            DataTable dt = new DataTable();
            dt = ConnectSQL.GetData(str);
            passold = dt.Rows[0][0].ToString();  
        }
    }
}
