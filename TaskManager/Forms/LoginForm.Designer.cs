namespace TaskManager.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxUsername.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoxUsername.Location = new System.Drawing.Point(346, 147);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(150, 23);
            this.textBoxUsername.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPassword.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoxPassword.Location = new System.Drawing.Point(346, 208);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(150, 23);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.GhostWhite;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnLogin.Location = new System.Drawing.Point(282, 341);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 30);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Lavender;
            this.labelUsername.Font = new System.Drawing.Font("Arial", 15F);
            this.labelUsername.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelUsername.Location = new System.Drawing.Point(203, 147);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(67, 23);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "Логин:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Lavender;
            this.labelPassword.Font = new System.Drawing.Font("Arial", 15F);
            this.labelPassword.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelPassword.Location = new System.Drawing.Point(203, 208);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(84, 23);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Пароль:";
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Lavender;
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.textBoxUsername);
            this.panelLogin.Controls.Add(this.textBoxPassword);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.labelPassword);
            this.panelLogin.Controls.Add(this.labelUsername);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(724, 404);
            this.panelLogin.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(257, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Авторизация";
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(724, 404);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label label1;
    }
}
