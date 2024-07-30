using System;
using System.Windows.Forms;
using static lab06.Form1;

namespace lab06
{
    public partial class FormAddEdit : Form
    {
        public Employee Employee { get; private set; }

        public FormAddEdit(Employee employee)
        {
            InitializeComponent();
            if (employee != null)
            {
                txtMSNV.Text = employee.MSNV;
                txtTenNV.Text = employee.TenNV;
                txtLuongCB.Text = employee.LuongCB.ToString();
                Employee = employee;
            }
            else
            {
                Employee = new Employee();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtMSNV.Text) ||
                string.IsNullOrEmpty(txtTenNV.Text) ||
                !decimal.TryParse(txtLuongCB.Text, out decimal luongCB))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hợp lệ.");
                return;
            }

            Employee.MSNV = txtMSNV.Text;
            Employee.TenNV = txtTenNV.Text;
            Employee.LuongCB = luongCB;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtMSNV_Enter(object sender, EventArgs e)
        {
            if (txtMSNV.Text == "Mã số nhân viên")
            {
                txtMSNV.Text = "";
                txtMSNV.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtMSNV_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMSNV.Text))
            {
                txtMSNV.Text = "Mã số nhân viên";
                txtMSNV.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtTenNV_Enter(object sender, EventArgs e)
        {
            if (txtTenNV.Text == "Tên nhân viên")
            {
                txtTenNV.Text = "";
                txtTenNV.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtTenNV_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNV.Text))
            {
                txtTenNV.Text = "Tên nhân viên";
                txtTenNV.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtLuongCB_Enter(object sender, EventArgs e)
        {
            if (txtLuongCB.Text == "Lương cơ bản")
            {
                txtLuongCB.Text = "";
                txtLuongCB.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtLuongCB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLuongCB.Text))
            {
                txtLuongCB.Text = "Lương cơ bản";
                txtLuongCB.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}
