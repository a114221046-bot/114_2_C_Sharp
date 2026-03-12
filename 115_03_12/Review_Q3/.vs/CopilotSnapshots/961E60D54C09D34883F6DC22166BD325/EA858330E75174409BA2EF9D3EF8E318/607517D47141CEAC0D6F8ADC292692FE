using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Review_Q3
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        private List<int> userNumbers = new List<int>();
        private List<int> drawnNumbers = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            userNumbers.Clear();
            while (userNumbers.Count < 5)
            {
                int n = rnd.Next(1, 50); // 1..49
                if (!userNumbers.Contains(n)) userNumbers.Add(n);
            }
            userNumbers.Sort();

            // Update top labels
            lblNum1.Text = userNumbers[0].ToString();
            lblNum2.Text = userNumbers[1].ToString();
            lblNum3.Text = userNumbers[2].ToString();
            lblNum4.Text = userNumbers[3].ToString();
            lblNum5.Text = userNumbers[4].ToString();

            // Clear previous comparison
            lblMatchCount.Text = "中0個號碼";
            lblWinningNums.Text = "中獎號碼: ";
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            // Ensure user has numbers
            if (userNumbers.Count != 5)
            {
                MessageBox.Show("請先按「產生號碼」生成您的號碼。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Generate 4 drawn numbers
            drawnNumbers.Clear();
            while (drawnNumbers.Count < 4)
            {
                int n = rnd.Next(1, 50);
                if (!drawnNumbers.Contains(n)) drawnNumbers.Add(n);
            }
            drawnNumbers.Sort();

            // Update listbox items (assume initial layout has 5 items as set in designer)
            if (lstResults.Items.Count >= 5)
            {
                lstResults.Items[0] = "本期開獎號碼：";
                lstResults.Items[1] = "第1個號碼: " + drawnNumbers[0];
                lstResults.Items[2] = "第2個號碼: " + drawnNumbers[1];
                lstResults.Items[3] = "第3個號碼: " + drawnNumbers[2];
                lstResults.Items[4] = "第4個號碼: " + drawnNumbers[3];
            }
            else
            {
                lstResults.Items.Clear();
                lstResults.Items.Add("本期開獎號碼：");
                for (int i = 0; i < drawnNumbers.Count; i++) lstResults.Items.Add($"第{i+1}個號碼: {drawnNumbers[i]}");
            }

            // Compare
            var matches = userNumbers.Intersect(drawnNumbers).OrderBy(x => x).ToList();
            lblMatchCount.Text = "中" + matches.Count + "個號碼";
            if (matches.Count > 0)
            {
                lblWinningNums.Text = "中獎號碼: " + string.Join(", ", matches);
            }
            else
            {
                lblWinningNums.Text = "😞 沒中獎";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
