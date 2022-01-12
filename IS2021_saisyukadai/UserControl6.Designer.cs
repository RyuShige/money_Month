namespace IS2021_saisyukadai
{
    partial class UserControl6
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
            this.Screen6_label1 = new System.Windows.Forms.Label();
            this.MonthMoney = new System.Windows.Forms.TextBox();
            this.Screen6_label2 = new System.Windows.Forms.Label();
            this.Back4 = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Screen6_label1
            // 
            this.Screen6_label1.AutoSize = true;
            this.Screen6_label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(65)))), ((int)(((byte)(17)))));
            this.Screen6_label1.Font = new System.Drawing.Font("Noto Sans CJK JP Black", 12F);
            this.Screen6_label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.Screen6_label1.Location = new System.Drawing.Point(24, 48);
            this.Screen6_label1.Name = "Screen6_label1";
            this.Screen6_label1.Size = new System.Drawing.Size(228, 90);
            this.Screen6_label1.TabIndex = 0;
            this.Screen6_label1.Text = "The money you have \r\nat your disposal \r\nthis month is";
            // 
            // MonthMoney
            // 
            this.MonthMoney.Location = new System.Drawing.Point(71, 163);
            this.MonthMoney.Name = "MonthMoney";
            this.MonthMoney.Size = new System.Drawing.Size(100, 22);
            this.MonthMoney.TabIndex = 1;
            // 
            // Screen6_label2
            // 
            this.Screen6_label2.AutoSize = true;
            this.Screen6_label2.Font = new System.Drawing.Font("Noto Sans CJK JP Regular", 9F);
            this.Screen6_label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.Screen6_label2.Location = new System.Drawing.Point(186, 162);
            this.Screen6_label2.Name = "Screen6_label2";
            this.Screen6_label2.Size = new System.Drawing.Size(35, 22);
            this.Screen6_label2.TabIndex = 2;
            this.Screen6_label2.Text = "yen";
            // 
            // Back4
            // 
            this.Back4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Back4.Font = new System.Drawing.Font("Arial", 9F);
            this.Back4.Location = new System.Drawing.Point(71, 227);
            this.Back4.Name = "Back4";
            this.Back4.Size = new System.Drawing.Size(75, 23);
            this.Back4.TabIndex = 8;
            this.Back4.Text = "<-back";
            this.Back4.UseVisualStyleBackColor = true;
            this.Back4.Click += new System.EventHandler(this.Back4_Click);
            // 
            // home
            // 
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.home.Font = new System.Drawing.Font("Arial", 9F);
            this.home.Location = new System.Drawing.Point(29, 367);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(203, 29);
            this.home.TabIndex = 9;
            this.home.Text = "back to the beginning";
            this.home.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // UserControl6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(65)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.home);
            this.Controls.Add(this.Back4);
            this.Controls.Add(this.Screen6_label2);
            this.Controls.Add(this.MonthMoney);
            this.Controls.Add(this.Screen6_label1);
            this.Name = "UserControl6";
            this.Size = new System.Drawing.Size(268, 438);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Screen6_label1;
        public System.Windows.Forms.TextBox MonthMoney;
        private System.Windows.Forms.Label Screen6_label2;
        private System.Windows.Forms.Button Back4;
        private System.Windows.Forms.Button home;
    }
}
