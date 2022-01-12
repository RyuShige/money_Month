namespace IS2021_saisyukadai
{
    partial class UserControl3
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
            this.Screen3_label1 = new System.Windows.Forms.Label();
            this.Savings = new System.Windows.Forms.TextBox();
            this.Next1 = new System.Windows.Forms.Button();
            this.Screen3_label2 = new System.Windows.Forms.Label();
            this.AimSavings = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Income = new System.Windows.Forms.TextBox();
            this.Back1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Screen3_label1
            // 
            this.Screen3_label1.AutoSize = true;
            this.Screen3_label1.Font = new System.Drawing.Font("Noto Sans CJK JP Regular", 12F);
            this.Screen3_label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(160)))), ((int)(((byte)(138)))));
            this.Screen3_label1.Location = new System.Drawing.Point(53, 66);
            this.Screen3_label1.Name = "Screen3_label1";
            this.Screen3_label1.Size = new System.Drawing.Size(84, 30);
            this.Screen3_label1.TabIndex = 0;
            this.Screen3_label1.Text = "Savings";
            // 
            // Savings
            // 
            this.Savings.Location = new System.Drawing.Point(57, 106);
            this.Savings.Name = "Savings";
            this.Savings.Size = new System.Drawing.Size(100, 22);
            this.Savings.TabIndex = 1;
            // 
            // Next1
            // 
            this.Next1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(160)))), ((int)(((byte)(138)))));
            this.Next1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Next1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(93)))), ((int)(((byte)(117)))));
            this.Next1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Next1.Location = new System.Drawing.Point(123, 359);
            this.Next1.Name = "Next1";
            this.Next1.Size = new System.Drawing.Size(75, 23);
            this.Next1.TabIndex = 2;
            this.Next1.Text = "next->";
            this.Next1.UseVisualStyleBackColor = false;
            this.Next1.Click += new System.EventHandler(this.Next1_Click);
            // 
            // Screen3_label2
            // 
            this.Screen3_label2.AutoSize = true;
            this.Screen3_label2.Font = new System.Drawing.Font("Noto Sans CJK JP Regular", 12F);
            this.Screen3_label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(160)))), ((int)(((byte)(138)))));
            this.Screen3_label2.Location = new System.Drawing.Point(57, 166);
            this.Screen3_label2.Name = "Screen3_label2";
            this.Screen3_label2.Size = new System.Drawing.Size(125, 30);
            this.Screen3_label2.TabIndex = 3;
            this.Screen3_label2.Text = "Aim Savings";
            // 
            // AimSavings
            // 
            this.AimSavings.Location = new System.Drawing.Point(60, 215);
            this.AimSavings.Name = "AimSavings";
            this.AimSavings.Size = new System.Drawing.Size(100, 22);
            this.AimSavings.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans CJK JP Regular", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(160)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(58, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 60);
            this.label1.TabIndex = 5;
            this.label1.Text = "next month \r\nIncome";
            // 
            // Income
            // 
            this.Income.Location = new System.Drawing.Point(61, 315);
            this.Income.Name = "Income";
            this.Income.Size = new System.Drawing.Size(100, 22);
            this.Income.TabIndex = 6;
            // 
            // Back1
            // 
            this.Back1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(160)))), ((int)(((byte)(138)))));
            this.Back1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Back1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(93)))), ((int)(((byte)(117)))));
            this.Back1.Location = new System.Drawing.Point(23, 358);
            this.Back1.Name = "Back1";
            this.Back1.Size = new System.Drawing.Size(75, 23);
            this.Back1.TabIndex = 7;
            this.Back1.Text = "<-back";
            this.Back1.UseVisualStyleBackColor = false;
            this.Back1.Click += new System.EventHandler(this.Back1_Click);
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(93)))), ((int)(((byte)(117)))));
            this.Controls.Add(this.Back1);
            this.Controls.Add(this.Income);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AimSavings);
            this.Controls.Add(this.Screen3_label2);
            this.Controls.Add(this.Next1);
            this.Controls.Add(this.Savings);
            this.Controls.Add(this.Screen3_label1);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(251, 409);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Screen3_label1;
        public System.Windows.Forms.TextBox Savings;
        private System.Windows.Forms.Label Screen3_label2;
        public System.Windows.Forms.TextBox AimSavings;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Income;
        private System.Windows.Forms.Button Next1;
        private System.Windows.Forms.Button Back1;
    }
}
