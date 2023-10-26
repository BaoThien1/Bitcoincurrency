using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Profile;
using System.Windows.Forms;

namespace Login_Page_Design_UI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void container(object _form)
        {
            if (guna2Panel3_Container.Controls.Count > 0) guna2Panel3_Container.Controls.Clear();
            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            guna2Panel3_Container.Controls.Add(fm);
            guna2Panel3_Container.Tag = fm;
            fm.Show();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            container(new Dashboard());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            container(new Buy());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            container(new Swap());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            container(new Information());
        }

        private void txtPersonName_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            container(new Money());
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            container(new WalletBitcoin());
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            container(new setting());
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            //container(new coininformation());
        }
    }
}
