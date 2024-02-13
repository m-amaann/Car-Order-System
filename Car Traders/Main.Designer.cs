namespace Car_Traders
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.closeBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.AdminOption = new Guna.UI2.WinForms.Guna2ImageButton();
            this.CustomerOption = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.HoverState.ImageSize = new System.Drawing.Size(43, 43);
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.closeBtn.ImageRotate = 0F;
            this.closeBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.closeBtn.IndicateFocus = true;
            this.closeBtn.Location = new System.Drawing.Point(619, 1);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.PressedState.ImageSize = new System.Drawing.Size(43, 43);
            this.closeBtn.Size = new System.Drawing.Size(35, 37);
            this.closeBtn.TabIndex = 39;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // AdminOption
            // 
            this.AdminOption.BackColor = System.Drawing.Color.White;
            this.AdminOption.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.AdminOption.HoverState.ImageSize = new System.Drawing.Size(100, 100);
            this.AdminOption.Image = ((System.Drawing.Image)(resources.GetObject("AdminOption.Image")));
            this.AdminOption.ImageOffset = new System.Drawing.Point(0, 0);
            this.AdminOption.ImageRotate = 0F;
            this.AdminOption.ImageSize = new System.Drawing.Size(100, 100);
            this.AdminOption.IndicateFocus = true;
            this.AdminOption.Location = new System.Drawing.Point(361, 144);
            this.AdminOption.Name = "AdminOption";
            this.AdminOption.PressedState.ImageSize = new System.Drawing.Size(110, 110);
            this.AdminOption.Size = new System.Drawing.Size(122, 113);
            this.AdminOption.TabIndex = 38;
            this.AdminOption.Click += new System.EventHandler(this.AdminOption_Click);
            // 
            // CustomerOption
            // 
            this.CustomerOption.BackColor = System.Drawing.Color.White;
            this.CustomerOption.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.CustomerOption.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CustomerOption.HoverState.ImageSize = new System.Drawing.Size(100, 100);
            this.CustomerOption.Image = ((System.Drawing.Image)(resources.GetObject("CustomerOption.Image")));
            this.CustomerOption.ImageOffset = new System.Drawing.Point(0, 0);
            this.CustomerOption.ImageRotate = 0F;
            this.CustomerOption.ImageSize = new System.Drawing.Size(100, 100);
            this.CustomerOption.IndicateFocus = true;
            this.CustomerOption.Location = new System.Drawing.Point(181, 144);
            this.CustomerOption.Name = "CustomerOption";
            this.CustomerOption.PressedState.ImageSize = new System.Drawing.Size(110, 110);
            this.CustomerOption.Size = new System.Drawing.Size(122, 113);
            this.CustomerOption.TabIndex = 37;
            this.CustomerOption.Click += new System.EventHandler(this.CustomerOption_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(256, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 28);
            this.label1.TabIndex = 51;
            this.label1.Text = "Choose Option";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(657, 378);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.AdminOption);
            this.Controls.Add(this.CustomerOption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton CustomerOption;
        private Guna.UI2.WinForms.Guna2ImageButton AdminOption;
        private Guna.UI2.WinForms.Guna2ImageButton closeBtn;
        private System.Windows.Forms.Label label1;
    }
}