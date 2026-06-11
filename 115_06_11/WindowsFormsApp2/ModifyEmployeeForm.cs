using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class ModifyEmployeeForm : Form
    {
        private List<Employee> employees;
        private TextBox txtSearchId, txtId, txtName, txtDept, txtPos;
        private Button btnSearch, btnSave, btnClose;

        public ModifyEmployeeForm(List<Employee> employees)
        {
            this.employees = employees;
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = "修改員工";
            this.ClientSize = new System.Drawing.Size(500, 420);

            Label lblTitle = new Label() { Text = "修改員工", Left = 10, Top = 10, Font = new System.Drawing.Font("標楷體", 24) };

            Label lblSearch = new Label() { Text = "員工編號：", Left = 20, Top = 60 };
            txtSearchId = new TextBox() { Left = 140, Top = 60, Width = 200 };
            btnSearch = new Button() { Text = "搜尋", Left = 360, Top = 60, Width = 80 };
            btnSearch.Click += BtnSearch_Click;

            Label lblId = new Label() { Text = "員工編號：", Left = 20, Top = 110 };
            txtId = new TextBox() { Left = 140, Top = 110, Width = 300 };

            Label lblName = new Label() { Text = "姓名：", Left = 20, Top = 150 };
            txtName = new TextBox() { Left = 140, Top = 150, Width = 300 };

            Label lblDept = new Label() { Text = "部門：", Left = 20, Top = 190 };
            txtDept = new TextBox() { Left = 140, Top = 190, Width = 300 };

            Label lblPos = new Label() { Text = "職稱：", Left = 20, Top = 230 };
            txtPos = new TextBox() { Left = 140, Top = 230, Width = 300 };

            btnSave = new Button() { Text = "儲存", Left = 140, Top = 280, Width = 100 };
            btnSave.Click += BtnSave_Click;
            btnClose = new Button() { Text = "離開", Left = 260, Top = 280, Width = 100 };
            btnClose.Click += (s, e) => this.Close();

            this.Controls.Add(lblTitle);
            this.Controls.Add(lblSearch);
            this.Controls.Add(txtSearchId);
            this.Controls.Add(btnSearch);
            this.Controls.Add(lblId);
            this.Controls.Add(txtId);
            this.Controls.Add(lblName);
            this.Controls.Add(txtName);
            this.Controls.Add(lblDept);
            this.Controls.Add(txtDept);
            this.Controls.Add(lblPos);
            this.Controls.Add(txtPos);
            this.Controls.Add(btnSave);
            this.Controls.Add(btnClose);
        }

        private Employee current;

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSearchId.Text.Trim(), out int id))
            {
                MessageBox.Show("員工編號需為整數。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            current = employees.FirstOrDefault(x => x.IdNumber == id);
            if (current == null)
            {
                MessageBox.Show("找不到此員工。", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtId.Text = current.IdNumber.ToString();
            txtName.Text = current.Name;
            txtDept.Text = current.Department;
            txtPos.Text = current.Position;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (current == null)
            {
                MessageBox.Show("請先搜尋要修改的員工。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtId.Text.Trim(), out int newId))
            {
                MessageBox.Show("員工編號需為整數。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // check duplicate id
            if (newId != current.IdNumber && employees.Any(x => x.IdNumber == newId))
            {
                MessageBox.Show("此員工編號已被使用。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            current.IdNumber = newId;
            current.Name = txtName.Text.Trim();
            current.Department = txtDept.Text.Trim();
            current.Position = txtPos.Text.Trim();

            MessageBox.Show("儲存完成。", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
