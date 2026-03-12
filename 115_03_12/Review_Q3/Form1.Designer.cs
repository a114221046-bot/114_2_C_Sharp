namespace Review_Q3
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // UI controls
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblNum3;
        private System.Windows.Forms.Label lblNum4;
        private System.Windows.Forms.Label lblNum5;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Label lblCompareTitle;
        private System.Windows.Forms.Label lblMatchCount;
        private System.Windows.Forms.Label lblWinningNums;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblNum3 = new System.Windows.Forms.Label();
            this.lblNum4 = new System.Windows.Forms.Label();
            this.lblNum5 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.lblCompareTitle = new System.Windows.Forms.Label();
            this.lblMatchCount = new System.Windows.Forms.Label();
            this.lblWinningNums = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "樂透號碼產生器";
            // 
            // Top number labels
            // 
            System.Drawing.Font bigNumFont = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);

            this.lblNum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNum1.Font = bigNumFont;
            this.lblNum1.Location = new System.Drawing.Point(40, 20);
            this.lblNum1.Size = new System.Drawing.Size(70, 50);
            this.lblNum1.Text = "";
            this.lblNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblNum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNum2.Font = bigNumFont;
            this.lblNum2.Location = new System.Drawing.Point(130, 20);
            this.lblNum2.Size = new System.Drawing.Size(70, 50);
            this.lblNum2.Text = "";
            this.lblNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblNum3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNum3.Font = bigNumFont;
            this.lblNum3.Location = new System.Drawing.Point(220, 20);
            this.lblNum3.Size = new System.Drawing.Size(70, 50);
            this.lblNum3.Text = "";
            this.lblNum3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblNum4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNum4.Font = bigNumFont;
            this.lblNum4.Location = new System.Drawing.Point(310, 20);
            this.lblNum4.Size = new System.Drawing.Size(70, 50);
            this.lblNum4.Text = "";
            this.lblNum4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblNum5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNum5.Font = bigNumFont;
            this.lblNum5.Location = new System.Drawing.Point(400, 20);
            this.lblNum5.Size = new System.Drawing.Size(70, 50);
            this.lblNum5.Text = "";
            this.lblNum5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // Buttons
            // 
            System.Drawing.Font btnFont = new System.Drawing.Font("Microsoft JhengHei", 14F);

            this.btnGenerate.Font = btnFont;
            this.btnGenerate.Location = new System.Drawing.Point(40, 90);
            this.btnGenerate.Size = new System.Drawing.Size(150, 45);
            this.btnGenerate.Text = "產生號碼";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);

            this.btnDraw.Font = btnFont;
            this.btnDraw.Location = new System.Drawing.Point(210, 90);
            this.btnDraw.Size = new System.Drawing.Size(150, 45);
            this.btnDraw.Text = "開獎號碼";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);

            this.btnExit.Font = btnFont;
            this.btnExit.Location = new System.Drawing.Point(380, 90);
            this.btnExit.Size = new System.Drawing.Size(150, 45);
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // 
            // Results listbox
            // 
            this.lstResults.Font = new System.Drawing.Font("Microsoft JhengHei", 12F);
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 20;
            this.lstResults.Location = new System.Drawing.Point(40, 150);
            this.lstResults.Size = new System.Drawing.Size(360, 180);

            // Add default lines like image
            this.lstResults.Items.Add("本期開獎號碼：");
            this.lstResults.Items.Add("第1個號碼: ");
            this.lstResults.Items.Add("第2個號碼: ");
            this.lstResults.Items.Add("第3個號碼: ");
            this.lstResults.Items.Add("第4個號碼: ");

            // 
            // Right-side comparison labels
            // 
            this.lblCompareTitle.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold);
            this.lblCompareTitle.ForeColor = System.Drawing.Color.Red;
            this.lblCompareTitle.Location = new System.Drawing.Point(460, 150);
            this.lblCompareTitle.Size = new System.Drawing.Size(300, 30);
            this.lblCompareTitle.Text = "比對結果：";

            this.lblMatchCount.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold);
            this.lblMatchCount.ForeColor = System.Drawing.Color.Red;
            this.lblMatchCount.Location = new System.Drawing.Point(460, 190);
            this.lblMatchCount.Size = new System.Drawing.Size(300, 40);
            this.lblMatchCount.Text = "中0個號碼";

            this.lblWinningNums.Font = new System.Drawing.Font("Microsoft JhengHei", 16F, System.Drawing.FontStyle.Bold);
            this.lblWinningNums.ForeColor = System.Drawing.Color.Red;
            this.lblWinningNums.Location = new System.Drawing.Point(460, 240);
            this.lblWinningNums.Size = new System.Drawing.Size(300, 40);
            this.lblWinningNums.Text = "中獎號碼: ";

            // 
            // Add controls to form
            // 
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum3);
            this.Controls.Add(this.lblNum4);
            this.Controls.Add(this.lblNum5);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.lblCompareTitle);
            this.Controls.Add(this.lblMatchCount);
            this.Controls.Add(this.lblWinningNums);

            this.ResumeLayout(false);
        }

        #endregion
    }
}

