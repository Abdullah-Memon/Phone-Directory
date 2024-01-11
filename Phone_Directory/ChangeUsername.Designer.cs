namespace Phone_Directory
{
    partial class ChangeUsername
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
            this.username = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.confirmation = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.update = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.BorderRadius = 15;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.DefaultText = "";
            this.username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.DisabledState.Parent = this.username;
            this.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username.FocusedState.Parent = this.username;
            this.username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username.HoverState.Parent = this.username;
            this.username.Location = new System.Drawing.Point(42, 116);
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.PlaceholderText = "";
            this.username.SelectedText = "";
            this.username.ShadowDecoration.Parent = this.username;
            this.username.Size = new System.Drawing.Size(200, 36);
            this.username.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Times New Roman", 19F);
            this.gunaLabel1.Location = new System.Drawing.Point(37, 38);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(204, 29);
            this.gunaLabel1.TabIndex = 24;
            this.gunaLabel1.Text = "Change Username";
            // 
            // cu
            // 
            this.cu.BorderRadius = 15;
            this.cu.CheckedState.Parent = this.cu;
            this.cu.CustomImages.Parent = this.cu;
            this.cu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cu.ForeColor = System.Drawing.Color.White;
            this.cu.HoverState.Parent = this.cu;
            this.cu.Location = new System.Drawing.Point(42, 213);
            this.cu.Name = "cu";
            this.cu.ShadowDecoration.Parent = this.cu;
            this.cu.Size = new System.Drawing.Size(200, 36);
            this.cu.TabIndex = 23;
            this.cu.Text = "Change Username";
            this.cu.Click += new System.EventHandler(this.cu_Click);
            // 
            // gunaCircleButton1
            // 
            this.gunaCircleButton1.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton1.AnimationSpeed = 0.03F;
            this.gunaCircleButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gunaCircleButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton1.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.Image = null;
            this.gunaCircleButton1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleButton1.Location = new System.Drawing.Point(242, 12);
            this.gunaCircleButton1.MaximumSize = new System.Drawing.Size(30, 30);
            this.gunaCircleButton1.MinimumSize = new System.Drawing.Size(30, 30);
            this.gunaCircleButton1.Name = "gunaCircleButton1";
            this.gunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.Red;
            this.gunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.OnHoverImage = null;
            this.gunaCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Size = new System.Drawing.Size(30, 30);
            this.gunaCircleButton1.TabIndex = 22;
            this.gunaCircleButton1.Text = "X";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(41, 98);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(81, 15);
            this.gunaLabel2.TabIndex = 24;
            this.gunaLabel2.Text = "New Username";
            // 
            // confirmation
            // 
            this.confirmation.BorderRadius = 15;
            this.confirmation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmation.DefaultText = "";
            this.confirmation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.confirmation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.confirmation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmation.DisabledState.Parent = this.confirmation;
            this.confirmation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirmation.FocusedState.Parent = this.confirmation;
            this.confirmation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirmation.HoverState.Parent = this.confirmation;
            this.confirmation.Location = new System.Drawing.Point(42, 116);
            this.confirmation.Name = "confirmation";
            this.confirmation.PasswordChar = '\0';
            this.confirmation.PlaceholderText = "";
            this.confirmation.SelectedText = "";
            this.confirmation.ShadowDecoration.Parent = this.confirmation;
            this.confirmation.Size = new System.Drawing.Size(200, 36);
            this.confirmation.TabIndex = 0;
            this.confirmation.UseSystemPasswordChar = true;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLabel3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.Red;
            this.gunaLabel3.Location = new System.Drawing.Point(40, 157);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Padding = new System.Windows.Forms.Padding(5);
            this.gunaLabel3.Size = new System.Drawing.Size(205, 48);
            this.gunaLabel3.TabIndex = 24;
            this.gunaLabel3.Text = "Verify your account changes \r\nwith the help of your password";
            // 
            // update
            // 
            this.update.BorderRadius = 15;
            this.update.CheckedState.Parent = this.update;
            this.update.CustomImages.Parent = this.update;
            this.update.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.HoverState.Parent = this.update;
            this.update.Location = new System.Drawing.Point(42, 213);
            this.update.Name = "update";
            this.update.ShadowDecoration.Parent = this.update;
            this.update.Size = new System.Drawing.Size(203, 36);
            this.update.TabIndex = 23;
            this.update.Text = "Confirm";
            this.update.Click += new System.EventHandler(this.confirm_Click);
            // 
            // ChangeUsername
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 273);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.cu);
            this.Controls.Add(this.gunaCircleButton1);
            this.Controls.Add(this.confirmation);
            this.Controls.Add(this.username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeUsername";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ChangeUsername_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox username;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2GradientButton cu;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2TextBox confirmation;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2GradientButton update;
    }
}