using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Login_Page_Design_UI
{
    public partial class Information : Form
    {
        
        public Information()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListData("");
            LoadSex();
        }
        private void LoadSex()
        {
            DataTable dataTable = new DataTable();
            cbosex.Items.Clear();
            dataTable.Columns.Add("ma", typeof(string));
            dataTable.Columns.Add("ten", typeof(string));
            dataTable.Rows.Add("Male", "Male");
            dataTable.Rows.Add("female", "female");
            cbosex.DataSource = dataTable;
            cbosex.DisplayMember = "ten";
            cbosex.ValueMember = "ma";
        }

        private void ListData (string CustomerName)
        {
            string sql = "SELECT * FROM Information WHERE CustomerName LIKE N'%"+ CustomerName + "%'";
            DataTable dt = new DataTable();
            dt = ConnectSQL.GetData(sql);
            grdCustomer.DataSource = dt;
            if(dt.Rows.Count > 0 )
            {
                DataGridViewRow row = this.grdCustomer.Rows[0];
                txtId.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtAddress.Text = row.Cells[2].Value.ToString();
                txtPhoneNumber.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
                cbosex.Text = row.Cells[5].Value.ToString();
                date.Text = row.Cells[6].Value.ToString();
            }  
            else
            {
                txtName.Clear();
                txtEmail.Clear();
                txtPhoneNumber.Clear();
                txtAddress.Clear();
                //cbosex.SelectedIndex = 0;
                txtId.Clear();
            }    
        }
        private void btnLamMoiThongTin_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            txtAddress.Clear();
            cbosex.SelectedIndex = 0;
            txtId.Clear();
            ListData("");


        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
               
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Customer code cannot be empty");
                txtId.Focus();
                return;
            }
            if (txtName.Text == "")
            {
                MessageBox.Show("Customer name cannot be empty");
                txtName.Focus();
                return;
            }
            try
            {
              
                string sql = "INSERT INTO Information (CustomerId, CustomerName, Address ,PhoneNumber ,Email,Sex,Date   ) VALUES ('" + txtId.Text + "', N'" + txtName.Text + "', N'" + txtAddress.Text + "', N'" + txtPhoneNumber.Text + "','" + txtEmail.Text + "',N'" + cbosex.Text + "','" + date.Value.ToString("yyyy-MM-dd") + "'); ";
                ConnectSQL.ExecuteNonQuery(sql);
                MessageBox.Show("Add success");
                ListData("");
            }
            catch (Exception)
            {
                MessageBox.Show("More failure, this customer already exists, please generate another code");
                return;
            }

           
        }

        private void grdCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grdCustomer.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtAddress.Text = row.Cells[2].Value.ToString();
                txtPhoneNumber.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
                cbosex.Text = row.Cells[5].Value.ToString();
                date.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           if(grdCustomer.Rows.Count == 0)
           {
              return;
           }
            try
            {
                string sql = "UPDATE Information SET CustomerId = '" + txtId.Text + "', CustomerName = N'" + txtName.Text + "', Address = N'" + txtAddress.Text + "' ,PhoneNumber = N'" + txtPhoneNumber.Text + "' ,Email = N'" + txtEmail.Text + "',Sex = N'" + cbosex.Text + "',Date = '" + date.Value.ToString("yyyy-MM-dd") + "' WHERE CustomerId = '" + grdCustomer.Rows[grdCustomer.CurrentCell.RowIndex].Cells[0].Value.ToString() + "' ";
                ConnectSQL.ExecuteNonQuery(sql);
                MessageBox.Show("Sửa thành công");
                ListData("");
            }
            catch (Exception)
            {
                MessageBox.Show("Customer data has been created and cannot be edited");
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grdCustomer.Rows.Count == 0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("Are you sure to delete this customer?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                try
                {
                    string sql = "DELETE Information WHERE CustomerId = '" + grdCustomer.Rows[grdCustomer.CurrentCell.RowIndex].Cells[0].Value.ToString() + "'";
                   ConnectSQL.ExecuteNonQuery (sql);
                    MessageBox.Show("Deleted successfully ", "Notificate", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    ListData("");
                }
                catch (Exception)
                {

                    MessageBox.Show("Data that has been created cannot be deleted");
                    return;
                }
            }
            else
                return;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ListData(txtNameSearch.Text.Trim());
        }
    }
}
