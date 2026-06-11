using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class QueryEmployeeForm : Form
    {
        private List<Employee> employees;
        private TextBox txtId;
        private Button btnQuery, btnClose;
        private TextBox resultBox;

        public QueryEmployeeForm(List<Employee> employees)
        {
            this.employees = employees;
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = "查詢員工";
            this.ClientSize = new System.Drawing.Size(500, 320);

            Label lblTitle = new Label() { Text = "查詢員工", Left = 10, Top = 10, Font = new System.Drawing.Font("標楷體", 24) };
            Label lblId = new Label() { Text = "員工編號：", Left = 20, Top = 70 };
            txtId = new TextBox() { Left = 140, Top = 70, Width = 200 };

            btnQuery = new Button() { Text = "查詢", Left = 140, Top = 110, Width = 100 };
            btnQuery.Click += BtnQuery_Click;
            btnClose = new Button() { Text = "離開", Left = 260, Top = 110, Width = 100 };
            btnClose.Click += (s, e) => this.Close();

            resultBox = new TextBox() { Left = 20, Top = 160, Width = 440, Height = 120, Multiline = true, ReadOnly = true, ScrollBars = ScrollBars.Vertical };

            this.Controls.Add(lblTitle);
            this.Controls.Add(lblId);
            this.Controls.Add(txtId);
            this.Controls.Add(btnQuery);
            this.Controls.Add(btnClose);
            this.Controls.Add(resultBox);
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text.Trim(), out int id))
            {
                MessageBox.Show("員工編號需為整數。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var emp = employees.FirstOrDefault(x => x.IdNumber == id);
            if (emp == null)
            {
                resultBox.Text = "找不到此員工。";
                return;
            }
            resultBox.Text = $"員工編號: {emp.IdNumber}\r\n姓名: {emp.Name}\r\n部門: {emp.Department}\r\n職稱: {emp.Position}";
        }
    }
}
