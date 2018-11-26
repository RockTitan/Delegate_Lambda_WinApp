namespace Delegate_Lambda_WinApp
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
            this.button_Delegate1 = new System.Windows.Forms.Button();
            this.button_Lambda1 = new System.Windows.Forms.Button();
            this.button_Lambda2 = new System.Windows.Forms.Button();
            this.button_Lambda3 = new System.Windows.Forms.Button();
            this.button_Delegate2Lambda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Delegate1
            // 
            this.button_Delegate1.Location = new System.Drawing.Point(12, 12);
            this.button_Delegate1.Name = "button_Delegate1";
            this.button_Delegate1.Size = new System.Drawing.Size(75, 23);
            this.button_Delegate1.TabIndex = 0;
            this.button_Delegate1.Text = "Delegate1";
            this.button_Delegate1.UseVisualStyleBackColor = true;
            this.button_Delegate1.Click += new System.EventHandler(this.button_Delegate1_Click);
            // 
            // button_Lambda1
            // 
            this.button_Lambda1.Location = new System.Drawing.Point(12, 41);
            this.button_Lambda1.Name = "button_Lambda1";
            this.button_Lambda1.Size = new System.Drawing.Size(75, 23);
            this.button_Lambda1.TabIndex = 1;
            this.button_Lambda1.Text = "Lambda1";
            this.button_Lambda1.UseVisualStyleBackColor = true;
            this.button_Lambda1.Click += new System.EventHandler(this.button_Lambda1_Click);
            // 
            // button_Lambda2
            // 
            this.button_Lambda2.Location = new System.Drawing.Point(12, 70);
            this.button_Lambda2.Name = "button_Lambda2";
            this.button_Lambda2.Size = new System.Drawing.Size(75, 23);
            this.button_Lambda2.TabIndex = 2;
            this.button_Lambda2.Text = "Lambda2";
            this.button_Lambda2.UseVisualStyleBackColor = true;
            this.button_Lambda2.Click += new System.EventHandler(this.button_Lambda2_Click);
            // 
            // button_Lambda3
            // 
            this.button_Lambda3.Location = new System.Drawing.Point(12, 99);
            this.button_Lambda3.Name = "button_Lambda3";
            this.button_Lambda3.Size = new System.Drawing.Size(75, 23);
            this.button_Lambda3.TabIndex = 3;
            this.button_Lambda3.Text = "Lambda3";
            this.button_Lambda3.UseVisualStyleBackColor = true;
            this.button_Lambda3.Click += new System.EventHandler(this.button_Lambda3_Click);
            // 
            // button_Delegate2Lambda
            // 
            this.button_Delegate2Lambda.Location = new System.Drawing.Point(12, 128);
            this.button_Delegate2Lambda.Name = "button_Delegate2Lambda";
            this.button_Delegate2Lambda.Size = new System.Drawing.Size(121, 23);
            this.button_Delegate2Lambda.TabIndex = 4;
            this.button_Delegate2Lambda.Text = "Delegate to Lambda";
            this.button_Delegate2Lambda.UseVisualStyleBackColor = true;
            this.button_Delegate2Lambda.Click += new System.EventHandler(this.button_Delegate2Lambda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 354);
            this.Controls.Add(this.button_Delegate2Lambda);
            this.Controls.Add(this.button_Lambda3);
            this.Controls.Add(this.button_Lambda2);
            this.Controls.Add(this.button_Lambda1);
            this.Controls.Add(this.button_Delegate1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Delegate1;
        private System.Windows.Forms.Button button_Lambda1;
        private System.Windows.Forms.Button button_Lambda2;
        private System.Windows.Forms.Button button_Lambda3;
        private System.Windows.Forms.Button button_Delegate2Lambda;
    }
}

