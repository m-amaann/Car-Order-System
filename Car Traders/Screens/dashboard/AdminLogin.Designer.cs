namespace Car_Traders.Screens.dashboard
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.LoginBtn1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PasstxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Usertxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.closeBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.checkTogglePassword = new Guna.UI2.WinForms.Guna2CheckBox();
            this.SuspendLayout();
            // 
            // LoginBtn1
            // 
            this.LoginBtn1.Animated = true;
            this.LoginBtn1.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginBtn1.BackgroundImage")));
            this.LoginBtn1.BorderColor = System.Drawing.Color.Transparent;
            this.LoginBtn1.BorderRadius = 10;
            this.LoginBtn1.CustomBorderThickness = new System.Windows.Forms.Padding(5);
            this.LoginBtn1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginBtn1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginBtn1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginBtn1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginBtn1.FillColor = System.Drawing.Color.RoyalBlue;
            this.LoginBtn1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn1.ForeColor = System.Drawing.Color.White;
            this.LoginBtn1.Location = new System.Drawing.Point(392, 363);
            this.LoginBtn1.Name = "LoginBtn1";
            this.LoginBtn1.Size = new System.Drawing.Size(94, 38);
            this.LoginBtn1.TabIndex = 12;
            this.LoginBtn1.Text = "LOGIN";
            this.LoginBtn1.Click += new System.EventHandler(this.LoginBtn1_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(100, 100);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(100, 100);
            this.guna2ImageButton1.Location = new System.Drawing.Point(350, 27);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(110, 110);
            this.guna2ImageButton1.Size = new System.Drawing.Size(127, 122);
            this.guna2ImageButton1.TabIndex = 13;
            // 
            // PasstxtBox
            // 
            this.PasstxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasstxtBox.DefaultText = "";
            this.PasstxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasstxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasstxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasstxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasstxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasstxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasstxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PasstxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasstxtBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("PasstxtBox.IconLeft")));
            this.PasstxtBox.IconLeftSize = new System.Drawing.Size(15, 15);
            this.PasstxtBox.IconRightSize = new System.Drawing.Size(17, 17);
            this.PasstxtBox.Location = new System.Drawing.Point(285, 236);
            this.PasstxtBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PasstxtBox.Name = "PasstxtBox";
            this.PasstxtBox.PasswordChar = '\0';
            this.PasstxtBox.PlaceholderText = "Password";
            this.PasstxtBox.SelectedText = "";
            this.PasstxtBox.ShadowDecoration.BorderRadius = 15;
            this.PasstxtBox.Size = new System.Drawing.Size(281, 36);
            this.PasstxtBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.PasstxtBox.TabIndex = 11;
            this.PasstxtBox.TextChanged += new System.EventHandler(this.PasstxtBox_TextChanged);
            // 
            // Usertxtbox
            // 
            this.Usertxtbox.AutoRoundedCorners = true;
            this.Usertxtbox.BorderRadius = 17;
            this.Usertxtbox.BorderThickness = 0;
            this.Usertxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Usertxtbox.DefaultText = "";
            this.Usertxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Usertxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Usertxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Usertxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Usertxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Usertxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usertxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Usertxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Usertxtbox.IconLeft = ((System.Drawing.Image)(resources.GetObject("Usertxtbox.IconLeft")));
            this.Usertxtbox.IconLeftSize = new System.Drawing.Size(15, 15);
            this.Usertxtbox.Location = new System.Drawing.Point(285, 173);
            this.Usertxtbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Usertxtbox.Name = "Usertxtbox";
            this.Usertxtbox.PasswordChar = '\0';
            this.Usertxtbox.PlaceholderText = "Name";
            this.Usertxtbox.SelectedText = "";
            this.Usertxtbox.ShadowDecoration.BorderRadius = 15;
            this.Usertxtbox.Size = new System.Drawing.Size(281, 36);
            this.Usertxtbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Usertxtbox.TabIndex = 10;
            this.Usertxtbox.TextChanged += new System.EventHandler(this.Usertxtbox_TextChanged);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.closeBtn.HoverState.ImageSize = new System.Drawing.Size(43, 43);
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.closeBtn.ImageRotate = 0F;
            this.closeBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.closeBtn.IndicateFocus = true;
            this.closeBtn.Location = new System.Drawing.Point(817, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.PressedState.ImageSize = new System.Drawing.Size(43, 43);
            this.closeBtn.Size = new System.Drawing.Size(35, 37);
            this.closeBtn.TabIndex = 15;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // checkTogglePassword
            // 
            this.checkTogglePassword.AutoSize = true;
            this.checkTogglePassword.BackColor = System.Drawing.Color.Transparent;
            this.checkTogglePassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkTogglePassword.CheckedState.BorderRadius = 0;
            this.checkTogglePassword.CheckedState.BorderThickness = 0;
            this.checkTogglePassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkTogglePassword.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.checkTogglePassword.ForeColor = System.Drawing.Color.White;
            this.checkTogglePassword.Location = new System.Drawing.Point(505, 280);
            this.checkTogglePassword.Name = "checkTogglePassword";
            this.checkTogglePassword.Size = new System.Drawing.Size(61, 21);
            this.checkTogglePassword.TabIndex = 16;
            this.checkTogglePassword.Text = "Show";
            this.checkTogglePassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkTogglePassword.UncheckedState.BorderRadius = 0;
            this.checkTogglePassword.UncheckedState.BorderThickness = 0;
            this.checkTogglePassword.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkTogglePassword.UseVisualStyleBackColor = false;
            this.checkTogglePassword.CheckedChanged += new System.EventHandler(this.checkTogglePassword_CheckedChanged);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Car_Traders.Properties.Resources.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(853, 487);
            this.Controls.Add(this.checkTogglePassword);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.LoginBtn1);
            this.Controls.Add(this.PasstxtBox);
            this.Controls.Add(this.Usertxtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2Button LoginBtn1;
        private Guna.UI2.WinForms.Guna2TextBox PasstxtBox;
        private Guna.UI2.WinForms.Guna2TextBox Usertxtbox;
        private Guna.UI2.WinForms.Guna2ImageButton closeBtn;
        private Guna.UI2.WinForms.Guna2CheckBox checkTogglePassword;
    }
}