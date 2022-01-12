namespace IS2021_saisyukadai
{
    partial class UserControl5
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Screen5_labal1 = new System.Windows.Forms.Label();
            this.FixedCost = new System.Windows.Forms.TextBox();
            this.Next3 = new System.Windows.Forms.Button();
            this.Back3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Screen5_labal1
            // 
            this.Screen5_labal1.AutoSize = true;
            this.Screen5_labal1.Font = new System.Drawing.Font("Noto Sans CJK JP Regular", 12F);
            this.Screen5_labal1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(160)))), ((int)(((byte)(138)))));
            this.Screen5_labal1.Location = new System.Drawing.Point(58, 52);
            this.Screen5_labal1.Name = "Screen5_labal1";
            this.Screen5_labal1.Size = new System.Drawing.Size(146, 60);
            this.Screen5_labal1.TabIndex = 1;
            this.Screen5_labal1.Text = "Fixed costs \r\nfor this month";
            // 
            // FixedCost
            // 
            this.FixedCost.Location = new System.Drawing.Point(63, 131);
            this.FixedCost.Name = "FixedCost";
            this.FixedCost.Size = new System.Drawing.Size(100, 22);
            this.FixedCost.TabIndex = 2;
            // 
            // Next3
            // 
            this.Next3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Next3.Font = new System.Drawing.Font("Arial", 9F);
            this.Next3.Location = new System.Drawing.Point(118, 204);
            this.Next3.Name = "Next3";
            this.Next3.Size = new System.Drawing.Size(75, 23);
            this.Next3.TabIndex = 8;
            this.Next3.Text = "next->";
            this.Next3.UseVisualStyleBackColor = true;
            this.Next3.Click += new System.EventHandler(this.Next3_Click);
            // 
            // Back3
            // 
            this.Back3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Back3.Font = new System.Drawing.Font("Arial", 9F);
            this.Back3.Location = new System.Drawing.Point(26, 204);
            this.Back3.Name = "Back3";
            this.Back3.Size = new System.Drawing.Size(75, 23);
            this.Back3.TabIndex = 9;
            this.Back3.Text = "<-back";
            this.Back3.UseVisualStyleBackColor = true;
            this.Back3.Click += new System.EventHandler(this.Back3_Click);
            // 
            // UserControl5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(93)))), ((int)(((byte)(117)))));
            this.Controls.Add(this.Back3);
            this.Controls.Add(this.Next3);
            this.Controls.Add(this.FixedCost);
            this.Controls.Add(this.Screen5_labal1);
            this.Name = "UserControl5";
            this.Size = new System.Drawing.Size(257, 424);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Screen5_labal1;
        public System.Windows.Forms.TextBox FixedCost;
        private System.Windows.Forms.Button Next3;
        private System.Windows.Forms.Button Back3;
    }
}
