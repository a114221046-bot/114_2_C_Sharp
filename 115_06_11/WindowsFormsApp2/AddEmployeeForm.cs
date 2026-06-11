using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class AddEmployeeForm : Form
    {
        private List<Employee> employees;
        private TextBox txtId, txtName, txtDept, txtPos;
        private Button btnAdd, btnClose;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // AddEmployeeForm
            // 
            this.ClientSize = new System.Drawing.Size(741, 417);
            this.Name = "AddEmployeeForm";
            this.ResumeLayout(false);

        }

        public AddEmployeeForm(List<Employee> employees)
        {
            this.employees = employees;
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = "新增員工";
            this.ClientSize = new System.Drawing.Size(500, 350);

            Label lblTitle = new Label() { Text = "新增員工", Left = 10, Top = 10, Font = new System.Drawing.Font("標楷體", 24) };

            Label lblId = new Label() { Text = "員工編號：", Left = 20, Top = 60 };
            txtId = new TextBox() { Left = 140, Top = 60, Width = 300 };

            Label lblName = new Label() { Text = "姓名：", Left = 20, Top = 100 };
            txtName = new TextBox() { Left = 140, Top = 100, Width = 300 };

            Label lblDept = new Label() { Text = "部門：", Left = 20, Top = 140 };
            txtDept = new TextBox() { Left = 140, Top = 140, Width = 300 };

            Label lblPos = new Label() { Text = "職稱：", Left = 20, Top = 180 };
            txtPos = new TextBox() { Left = 140, Top = 180, Width = 300 };

            btnAdd = new Button() { Text = "新增", Left = 140, Top = 220, Width = 100 };
            btnAdd.Click += BtnAdd_Click;
            btnClose = new Button() { Text = "離開", Left = 260, Top = 220, Width = 100 };
            btnClose.Click += (s, e) => this.Close();

            this.Controls.Add(lblTitle);
            this.Controls.Add(lblId);
            this.Controls.Add(txtId);
            this.Controls.Add(lblName);
            this.Controls.Add(txtName);
            this.Controls.Add(lblDept);
            this.Controls.Add(txtDept);
            this.Controls.Add(lblPos);
            this.Controls.Add(txtPos);
            this.Controls.Add(btnAdd);
            this.Controls.Add(btnClose);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text.Trim(), out int id))
            {
                MessageBox.Show("員工編號需為整數。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string name = txtName.Text.Trim();
            string dept = txtDept.Text.Trim();
            string pos = txtPos.Text.Trim();

            if (employees.Any(x => x.IdNumber == id))
            {
                MessageBox.Show("員工編號已存在。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            employees.Add(new Employee(name, id, dept, pos));
            MessageBox.Show("新增完成。", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
