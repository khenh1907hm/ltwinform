using System.Windows.Forms;

namespace lab06
{
    partial class FormAddEdit
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtMSNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtLuongCB;
        private System.Windows.Forms.Button btnOK;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtMSNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtLuongCB = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMSNV
            // 
            this.txtMSNV.Location = new System.Drawing.Point(12, 12);
            this.txtMSNV.Name = "txtMSNV";
            this.txtMSNV.Size = new System.Drawing.Size(260, 22);
            this.txtMSNV.TabIndex = 0;
            this.txtMSNV.Text = "Mã số nhân viên";
            this.txtMSNV.ForeColor = System.Drawing.Color.Gray;
            this.txtMSNV.Enter += new System.EventHandler(this.txtMSNV_Enter);
            this.txtMSNV.Leave += new System.EventHandler(this.txtMSNV_Leave);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(12, 40);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(260, 22);
            this.txtTenNV.TabIndex = 1;
            this.txtTenNV.Text = "Tên nhân viên";
            this.txtTenNV.ForeColor = System.Drawing.Color.Gray;
            this.txtTenNV.Enter += new System.EventHandler(this.txtTenNV_Enter);
            this.txtTenNV.Leave += new System.EventHandler(this.txtTenNV_Leave);
            // 
            // txtLuongCB
            // 
            this.txtLuongCB.Location = new System.Drawing.Point(12, 68);
            this.txtLuongCB.Name = "txtLuongCB";
            this.txtLuongCB.Size = new System.Drawing.Size(260, 22);
            this.txtLuongCB.TabIndex = 2;
            this.txtLuongCB.Text = "Lương cơ bản";
            this.txtLuongCB.ForeColor = System.Drawing.Color.Gray;
            this.txtLuongCB.Enter += new System.EventHandler(this.txtLuongCB_Enter);
            this.txtLuongCB.Leave += new System.EventHandler(this.txtLuongCB_Leave);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 96);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FormAddEdit
            // 
            this.ClientSize = new System.Drawing.Size(284, 131);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtLuongCB);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtMSNV);
            this.Name = "FormAddEdit";
            this.Text = "Thêm/Sửa Nhân Viên";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

    }
}
