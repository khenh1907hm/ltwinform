using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace lab06
{
    public partial class Form1 : Form
    {
        public class Employee
        {
            public string MSNV { get; set; }
            public string TenNV { get; set; }
            public decimal LuongCB { get; set; }
        }
        private List<Employee> employees = new List<Employee>(); // Danh sách nhân viên

        public Form1()
        {
            InitializeComponent();
            LoadData(); // Tải dữ liệu khi khởi động form
            UpdateListView(); // Cập nhật ListView với dữ liệu hiện tại
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowAddEditForm(null); // Gọi form thêm nhân viên mới
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listViewEmployees.SelectedItems.Count > 0)
            {
                var selectedEmployee = (Employee)listViewEmployees.SelectedItems[0].Tag;
                ShowAddEditForm(selectedEmployee); // Gọi form sửa nhân viên hiện tại
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewEmployees.SelectedItems.Count > 0)
            {
                var selectedEmployee = (Employee)listViewEmployees.SelectedItems[0].Tag;
                employees.Remove(selectedEmployee);
                SaveData();
                UpdateListView();
            }
        }

        private void ShowAddEditForm(Employee employee)
        {
            FormAddEdit form = new FormAddEdit(employee);
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (employee == null)
                {
                    // Thêm nhân viên mới
                    employees.Add(form.Employee);
                }
                else
                {
                    // Cập nhật thông tin nhân viên hiện tại
                    var existingEmployee = employees.First(e => e.MSNV == form.Employee.MSNV);
                    existingEmployee.TenNV = form.Employee.TenNV;
                    existingEmployee.LuongCB = form.Employee.LuongCB;
                }
                SaveData();
                UpdateListView();
            }
        }

        private void LoadData()
        {
            // Tải dữ liệu từ nguồn (file, cơ sở dữ liệu, vv)
        }

        private void SaveData()
        {
            // Lưu dữ liệu vào nguồn (file, cơ sở dữ liệu, vv)
        }

        private void UpdateListView()
        {
            listViewEmployees.Items.Clear();
            foreach (var employee in employees)
            {
                var item = new ListViewItem(employee.MSNV);
                item.SubItems.Add(employee.TenNV);
                item.SubItems.Add(employee.LuongCB.ToString());
                item.Tag = employee;
                listViewEmployees.Items.Add(item);
            }
        }
    }
}
