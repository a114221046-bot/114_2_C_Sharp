namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblFull = new System.Windows.Forms.Label();
            this.txtFull = new System.Windows.Forms.TextBox();
            this.lblMapping = new System.Windows.Forms.Label();
            this.txtMapping = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(19, 9);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(116, 18);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "請輸入字串：";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(15, 40);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(760, 120);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(493, 520);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(120, 30);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "轉換";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblFull
            // 
            this.lblFull.AutoSize = true;
            this.lblFull.Location = new System.Drawing.Point(19, 178);
            this.lblFull.Name = "lblFull";
            this.lblFull.Size = new System.Drawing.Size(121, 18);
            this.lblFull.TabIndex = 3;
            this.lblFull.Text = "完整摩斯密碼:";
            this.lblFull.Click += new System.EventHandler(this.lblFull_Click);
            // 
            // txtFull
            // 
            this.txtFull.Location = new System.Drawing.Point(15, 208);
            this.txtFull.Multiline = true;
            this.txtFull.Name = "txtFull";
            this.txtFull.ReadOnly = true;
            this.txtFull.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFull.Size = new System.Drawing.Size(760, 90);
            this.txtFull.TabIndex = 4;
            // 
            // lblMapping
            // 
            this.lblMapping.AutoSize = true;
            this.lblMapping.Location = new System.Drawing.Point(19, 311);
            this.lblMapping.Name = "lblMapping";
            this.lblMapping.Size = new System.Drawing.Size(98, 18);
            this.lblMapping.TabIndex = 5;
            this.lblMapping.Text = "逐字對照：";
            // 
            // txtMapping
            // 
            this.txtMapping.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMapping.Location = new System.Drawing.Point(15, 332);
            this.txtMapping.Multiline = true;
            this.txtMapping.Name = "txtMapping";
            this.txtMapping.ReadOnly = true;
            this.txtMapping.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMapping.Size = new System.Drawing.Size(760, 159);
            this.txtMapping.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(645, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "清除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblFull);
            this.Controls.Add(this.txtFull);
            this.Controls.Add(this.lblMapping);
            this.Controls.Add(this.txtMapping);
            this.Name = "Form1";
            this.Text = "摩斯密碼轉換器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblFull;
        private System.Windows.Forms.TextBox txtFull;
        private System.Windows.Forms.Label lblMapping;
        private System.Windows.Forms.TextBox txtMapping;
        private System.Windows.Forms.Button button1;
    }
}

