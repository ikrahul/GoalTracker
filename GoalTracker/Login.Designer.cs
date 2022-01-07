namespace GoalTracker
{
    partial class Login
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
            this.Username_trim = new Telerik.WinControls.UI.RadLabel();
            this.password_trim = new Telerik.WinControls.UI.RadLabel();
            this.btn_login = new Telerik.WinControls.UI.RadButton();
            this.btn_cancel = new Telerik.WinControls.UI.RadButton();
            this.btn_register = new Telerik.WinControls.UI.RadButton();
            this.username = new Telerik.WinControls.UI.RadTextBox();
            this.password = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Username_trim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_trim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_register)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password)).BeginInit();
            this.SuspendLayout();
            // 
            // Username_trim
            // 
            this.Username_trim.Location = new System.Drawing.Point(12, 50);
            this.Username_trim.Name = "Username_trim";
            this.Username_trim.Size = new System.Drawing.Size(62, 18);
            this.Username_trim.TabIndex = 2;
            this.Username_trim.Text = "Username :";
            // 
            // password_trim
            // 
            this.password_trim.Location = new System.Drawing.Point(15, 88);
            this.password_trim.Name = "password_trim";
            this.password_trim.Size = new System.Drawing.Size(59, 18);
            this.password_trim.TabIndex = 3;
            this.password_trim.Text = "Password :";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(15, 145);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(110, 24);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(149, 145);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(110, 24);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(92, 188);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(92, 24);
            this.btn_register.TabIndex = 6;
            this.btn_register.Text = "Register";
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(92, 50);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(132, 20);
            this.username.TabIndex = 7;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(92, 88);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(132, 20);
            this.password.TabIndex = 8;
            // 
            // Login
            // 
            this.AccessibleName = "GoalTracker - Login";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 224);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.password_trim);
            this.Controls.Add(this.Username_trim);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GoalTracker";
            ((System.ComponentModel.ISupportInitialize)(this.Username_trim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_trim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_register)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadLabel Username_trim;
        private Telerik.WinControls.UI.RadLabel password_trim;
        private Telerik.WinControls.UI.RadButton btn_login;
        private Telerik.WinControls.UI.RadButton btn_cancel;
        private Telerik.WinControls.UI.RadButton btn_register;
        private Telerik.WinControls.UI.RadTextBox username;
        private Telerik.WinControls.UI.RadTextBox password;
    }
}