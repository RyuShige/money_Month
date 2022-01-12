namespace IS2021_saisyukadai
{
    partial class UserControl4
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
            this.Screen4_labal1 = new System.Windows.Forms.Label();
            this.AimMonth = new System.Windows.Forms.TextBox();
            this.Screen4_label2 = new System.Windows.Forms.Label();
            this.Screen4_label3 = new System.Windows.Forms.Label();
            this.Screen4_label4 = new System.Windows.Forms.Label();
            this.Screen4_label5 = new System.Windows.Forms.Label();
            this.Percent = new System.Windows.Forms.TextBox();
            this.Next2 = new System.Windows.Forms.Button();
            this.Calc1 = new System.Windows.Forms.Button();
            this.Back2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Screen4_labal1
            // 
            this.Screen4_labal1.AutoSize = true;
            this.Screen4_labal1.Font = new System.Drawing.Font("Noto Sans CJK JP Regular", 12F);
            this.Screen4_labal1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(160)))), ((int)(((byte)(138)))));
            this.Screen4_labal1.Location = new System.Drawing.Point(40, 45);
            this.Screen4_labal1.Name = "Screen4_labal1";
            this.Screen4_labal1.Size = new System.Drawing.Size(188, 60);
            this.Screen4_labal1.TabIndex = 0;
            this.Screen4_labal1.Text = "How many months\r\n to save?";
            // 
            // AimMonth
            // 
            this.AimMonth.Location = new System.Drawing.Point(70, 120);
            this.AimMonth.Name = "AimMonth";
            this.AimMonth.Size = new System.Drawing.Size(100, 22);
            this.AimMonth.TabIndex = 1;
            // 
            // Screen4_label2
            // 
            this.Screen4_label2.AutoSize = true;
            this.Screen4_label2.Font = new System.Drawing.Font("Noto Sans CJK JP Regular", 9F);
            this.Screen4_label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(6)))));
            this.Screen4_label2.Location = new System.Drawing.Point(176, 120);
            this.Screen4_label2.Name = "Screen4_label2";
            this.Screen4_label2.Size = new System.Drawing.Size(64, 22);
            this.Screen4_label2.TabIndex = 2;
            this.Screen4_label2.Text = "months";
            // 
            // Screen4_label3
            // 
            this.Screen4_label3.AutoSize = true;
            this.Screen4_label3.Font = new System.Drawing.Font("Noto Sans CJK JP Regular", 12F);
            this.Screen4_label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(160)))), ((int)(((byte)(138)))));
            this.Screen4_label3.Location = new System.Drawing.Point(40, 193);
            this.Screen4_label3.Name = "Screen4_label3";
            this.Screen4_label3.Size = new System.Drawing.Size(130, 30);
            this.Screen4_label3.TabIndex = 3;
            this.Screen4_label3.Text = "Need to save";
            // 
            // Screen4_label4
            // 
            this.Screen4_label4.AutoSize = true;
            this.Screen4_label4.Font = new System.Drawing.Font("Noto Sans CJK JP Regular", 9F);
            this.Screen4_label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(20)))), ((int)(((byte)(6)))));
            this.Screen4_label4.Location = new System.Drawing.Point(184, 229);
            this.Screen4_label4.Name = "Screen4_label4";
            this.Screen4_label4.Size = new System.Drawing.Size(25, 22);
            this.Screen4_label4.TabIndex = 4;
            this.Screen4_label4.Text = "％";
            // 
            // Screen4_label5
            // 
            this.Screen4_label5.AutoSize = true;
            this.Screen4_label5.Font = new System.Drawing.Font("Noto Sans CJK JP Regular", 12F);
            this.Screen4_label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(160)))), ((int)(((byte)(138)))));
            this.Screen4_label5.Location = new System.Drawing.Point(40, 293);
            this.Screen4_label5.Name = "Screen4_label5";
            this.Screen4_label5.Size = new System.Drawing.Size(189, 30);
            this.Screen4_label5.TabIndex = 5;
            this.Screen4_label5.Text = "of monthly income";
            // 
            // Percent
            // 
            this.Percent.Location = new System.Drawing.Point(70, 230);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(100, 22);
            this.Percent.TabIndex = 6;
            // 
            // Next2
            // 
            this.Next2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Next2.Font = new System.Drawing.Font("Arial", 9F);
            this.Next2.Location = new System.Drawing.Point(134, 351);
            this.Next2.Name = "Next2";
            this.Next2.Size = new System.Drawing.Size(75, 23);
            this.Next2.TabIndex = 7;
            this.Next2.Text = "next->";
            this.Next2.UseVisualStyleBackColor = true;
            this.Next2.Click += new System.EventHandler(this.Next2_Click);
            // 
            // Calc1
            // 
            this.Calc1.Font = new System.Drawing.Font("Arial", 9F);
            this.Calc1.Location = new System.Drawing.Point(82, 159);
            this.Calc1.Name = "Calc1";
            this.Calc1.Size = new System.Drawing.Size(75, 23);
            this.Calc1.TabIndex = 8;
            this.Calc1.Text = "->";
            this.Calc1.UseVisualStyleBackColor = true;
            this.Calc1.Click += new System.EventHandler(this.Calc1_Click);
            // 
            // Back2
            // 
            this.Back2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Back2.Font = new System.Drawing.Font("Arial", 9F);
            this.Back2.Location = new System.Drawing.Point(22, 351);
            this.Back2.Name = "Back2";
            this.Back2.Size = new System.Drawing.Size(75, 23);
            this.Back2.TabIndex = 9;
            this.Back2.Text = "<-back";
            this.Back2.UseVisualStyleBackColor = true;
            this.Back2.Click += new System.EventHandler(this.Back2_Click);
            // 
            // UserControl4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(93)))), ((int)(((byte)(117)))));
            this.Controls.Add(this.Back2);
            this.Controls.Add(this.Calc1);
            this.Controls.Add(this.Next2);
            this.Controls.Add(this.Percent);
            this.Controls.Add(this.Screen4_label5);
            this.Controls.Add(this.Screen4_label4);
            this.Controls.Add(this.Screen4_label3);
            this.Controls.Add(this.Screen4_label2);
            this.Controls.Add(this.AimMonth);
            this.Controls.Add(this.Screen4_labal1);
            this.Name = "UserControl4";
            this.Size = new System.Drawing.Size(256, 419);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Screen4_labal1;
        public System.Windows.Forms.TextBox AimMonth;
        private System.Windows.Forms.Label Screen4_label2;
        private System.Windows.Forms.Label Screen4_label3;
        private System.Windows.Forms.Label Screen4_label4;
        private System.Windows.Forms.Label Screen4_label5;
        private System.Windows.Forms.TextBox Percent;
        private System.Windows.Forms.Button Next2;
        private System.Windows.Forms.Button Calc1;
        private System.Windows.Forms.Button Back2;
    }
}
