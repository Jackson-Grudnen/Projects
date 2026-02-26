namespace AeroNet
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pnlWelcome = new Panel();
            pbxLogo = new PictureBox();
            lblWelcome = new Label();
            lblLogin = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            chkRememberMe = new CheckBox();
            btnLogin = new Button();
            label1 = new Label();
            btnForgotPassword = new Button();
            button1 = new Button();
            lblError = new Label();
            pnlWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlWelcome
            // 
            pnlWelcome.BackColor = Color.FromArgb(255, 62, 23);
            pnlWelcome.Controls.Add(pbxLogo);
            pnlWelcome.Controls.Add(lblWelcome);
            pnlWelcome.Location = new Point(-5, -5);
            pnlWelcome.Name = "pnlWelcome";
            pnlWelcome.Size = new Size(716, 122);
            pnlWelcome.TabIndex = 0;
            // 
            // pbxLogo
            // 
            pbxLogo.BackgroundImage = Properties.Resources.aeronetlogo;
            pbxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pbxLogo.Location = new Point(3, 3);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(132, 119);
            pbxLogo.TabIndex = 3;
            pbxLogo.TabStop = false;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Lexend", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = SystemColors.Control;
            lblWelcome.Location = new Point(169, 30);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(496, 70);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome To AeroNet";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Lexend", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.FromArgb(255, 62, 23);
            lblLogin.Location = new Point(-5, 120);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(160, 74);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Login";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Lexend", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(5, 251);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(278, 36);
            txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Lexend", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(255, 62, 23);
            lblEmail.Location = new Point(-2, 194);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(123, 54);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Lexend", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(255, 62, 23);
            lblPassword.Location = new Point(-2, 290);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(189, 54);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Lexend", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(5, 347);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(278, 36);
            txtPassword.TabIndex = 5;
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.Font = new Font("Lexend", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkRememberMe.ForeColor = Color.FromArgb(255, 62, 23);
            chkRememberMe.Location = new Point(5, 389);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(178, 36);
            chkRememberMe.TabIndex = 6;
            chkRememberMe.Text = "Remember Me";
            chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 62, 23);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Lexend Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(5, 450);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(278, 45);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(608, 583);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 8;
            label1.Text = "Version Alpha";
            // 
            // btnForgotPassword
            // 
            btnForgotPassword.BackColor = Color.FromArgb(255, 62, 23);
            btnForgotPassword.FlatStyle = FlatStyle.Flat;
            btnForgotPassword.Font = new Font("Lexend Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnForgotPassword.ForeColor = SystemColors.Control;
            btnForgotPassword.Location = new Point(5, 501);
            btnForgotPassword.Name = "btnForgotPassword";
            btnForgotPassword.Size = new Size(278, 45);
            btnForgotPassword.TabIndex = 9;
            btnForgotPassword.Text = "Forgot Password";
            btnForgotPassword.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 62, 23);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Lexend Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(5, 552);
            button1.Name = "button1";
            button1.Size = new Size(278, 45);
            button1.TabIndex = 10;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Lexend", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(0, 415);
            lblError.Name = "lblError";
            lblError.Size = new Size(330, 32);
            lblError.TabIndex = 11;
            lblError.Text = "Error: Invalid Email or Password";
            lblError.Visible = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(705, 604);
            Controls.Add(lblError);
            Controls.Add(button1);
            Controls.Add(btnForgotPassword);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(chkRememberMe);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblLogin);
            Controls.Add(pnlWelcome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            Text = "Login";
            FormClosed += frmLogin_FormClosed;
            Load += frmLogin_Load;
            pnlWelcome.ResumeLayout(false);
            pnlWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlWelcome;
        private Label lblWelcome;
        private Label lblLogin;
        private TextBox txtEmail;
        private PictureBox pbxLogo;
        private Label lblEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private CheckBox chkRememberMe;
        private Button btnLogin;
        private Label label1;
        private Button btnForgotPassword;
        private Button button1;
        private Label lblError;
    }
}
