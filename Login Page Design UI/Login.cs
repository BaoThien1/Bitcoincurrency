using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Login_Page_Design_UI
{
    public partial class Login : Form
    {
        public static string user;
  
        public Login()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string str = "select * from info_user where Username='" + txt_User.Text + "' and Password='" + txt_Pass.Text + "'";
            DataTable dt = new DataTable();
            dt = ConnectSQL.GetData(str);

            if (dt.Rows.Count > 0)
            {
                user = txt_User.Text;
                Home frm = new Home();
                frm.ShowDialog();
            
            }
            else
            {
                MessageBox.Show("Wrong login name or password or password", "Notification",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
        
        }

        private void guna2ControlBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
