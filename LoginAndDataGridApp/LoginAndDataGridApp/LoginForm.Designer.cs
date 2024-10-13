namespace LoginAndDataGridApp
{
    partial class LoginForm
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
            txt_usename = new Label();
            txt_password = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btn_exit = new Button();
            Welcome = new Label();
            SuspendLayout();
            // 
            // txt_usename
            // 
            txt_usename.AutoSize = true;
            txt_usename.Font = new Font("Segoe UI", 12F);
            txt_usename.Location = new Point(270, 165);
            txt_usename.Name = "txt_usename";
            txt_usename.Size = new Size(88, 21);
            txt_usename.TabIndex = 0;
            txt_usename.Text = "User Name";
            // 
            // txt_password
            // 
            txt_password.AutoSize = true;
            txt_password.Font = new Font("Segoe UI", 12F);
            txt_password.Location = new Point(270, 212);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(76, 21);
            txt_password.TabIndex = 1;
            txt_password.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(381, 162);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(156, 29);
            txtUsername.TabIndex = 2;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(381, 209);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(156, 29);
            txtPassword.TabIndex = 3;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Control;
            btnLogin.Font = new Font("Segoe UI", 12F);
            btnLogin.Location = new Point(270, 266);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(105, 37);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += Btn_login_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = SystemColors.Control;
            btn_exit.Font = new Font("Segoe UI", 12F);
            btn_exit.Location = new Point(432, 266);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(105, 37);
            btn_exit.TabIndex = 5;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.Font = new Font("Microsoft Sans Serif", 14F);
            Welcome.Location = new Point(324, 55);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(171, 24);
            Welcome.TabIndex = 6;
            Welcome.Text = "Welcome To Login";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(800, 450);
            Controls.Add(Welcome);
            Controls.Add(btn_exit);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txt_password);
            Controls.Add(txt_usename);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txt_usename;
        private Label txt_password;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btn_exit;
        private Label Welcome;
    }
}
