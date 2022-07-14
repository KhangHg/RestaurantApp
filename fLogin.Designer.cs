namespace RestaurantApp
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonlLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.labelUsername);
            this.panel1.Location = new System.Drawing.Point(29, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 58);
            this.panel1.TabIndex = 0;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(199, 11);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(315, 27);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.Text = "Admin";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUsername.Location = new System.Drawing.Point(14, 21);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(156, 24);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Tên Đăng Nhập";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxPassword);
            this.panel2.Controls.Add(this.labelPassword);
            this.panel2.Location = new System.Drawing.Point(29, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 58);
            this.panel2.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(199, 11);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(315, 27);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Text = "1";
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(14, 21);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(100, 24);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "Mật Khẩu";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(228, 170);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(126, 35);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Đăng Nhập";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonlLogout
            // 
            this.buttonlLogout.Location = new System.Drawing.Point(417, 170);
            this.buttonlLogout.Name = "buttonlLogout";
            this.buttonlLogout.Size = new System.Drawing.Size(126, 35);
            this.buttonlLogout.TabIndex = 3;
            this.buttonlLogout.Text = "Thoát";
            this.buttonlLogout.UseVisualStyleBackColor = true;
            this.buttonlLogout.Click += new System.EventHandler(this.buttonlLogout_Click);
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 231);
            this.Controls.Add(this.buttonlLogout);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox textBoxUsername;
        private Label labelUsername;
        private Panel panel2;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private Button buttonLogin;
        private Button buttonlLogout;
    }
}