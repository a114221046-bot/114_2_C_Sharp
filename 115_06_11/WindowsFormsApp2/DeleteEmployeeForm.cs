using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class DeleteEmployeeForm : Form
    {
        private List<Employee> employees;
        private TextBox txtId;
        private Button btnDelete, btnClose;
        private ListBox resultBox;

        public DeleteEmployeeForm(List<Employee> employees)
        {
            this.employees = employees;
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = "刪除員工";
            this.ClientSize = new System.Drawing.Size(600, 400);

            Label lblTitle = new Label() { Text = "刪除員工", Left = 10, Top = 10, Font = new System.Drawing.Font("標楷體", 24) };
            Label lblId = new Label() { Text = "員工編號：", Left = 20, Top = 70 };
            txtId = new TextBox() { Left = 140, Top = 70, Width = 300 };

            btnDelete = new Button() { Text = "刪除", Left = 140, Top = 110, Width = 100 };
            btnDelete.Click += BtnDelete_Click;
            btnClose = new Button() { Text = "離開", Left = 260, Top = 110, Width = 100 };
            btnClose.Click += (s, e) => this.Close();

            resultBox = new ListBox() { Left = 20, Top = 160, Width = 540, Height = 200 };

            this.Controls.Add(lblTitle);
            this.Controls.Add(lblId);
            this.Controls.Add(txtId);
            this.Controls.Add(btnDelete);
            this.Controls.Add(btnClose);
            this.Controls.Add(resultBox);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DeleteEmployeeForm
            // 
            this.ClientSize = new System.Drawing.Size(632, 791);
            this.Name = "DeleteEmployeeForm";
            this.ResumeLayout(false);

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text.Trim(), out int id))
            {
                MessageBox.Show("員工編號需為整數。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var emp = employees.FirstOrDefault(x => x.IdNumber == id);
            if (emp == null)
            {
                MessageBox.Show("找不到此員工。", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var dr = MessageBox.Show($"確定要刪除 {emp.IdNumber} - {emp.Name} 嗎?", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                employees.Remove(emp);
                resultBox.Items.Add($"已刪除: {emp.IdNumber} - {emp.Name}");
            }
        }
    }
}
