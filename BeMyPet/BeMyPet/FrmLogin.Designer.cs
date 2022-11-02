namespace BeMyPet
{
    partial class FrmLogin
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lblklogin = new System.Windows.Forms.LinkLabel();
            this.btncancel = new System.Windows.Forms.Button();
            this.pbxBeMyPet = new System.Windows.Forms.PictureBox();
            this.pbxBackground = new System.Windows.Forms.PictureBox();
            this.txtPassword = new BeMyPet.RJControls.RJTextBox();
            this.txtUsername = new BeMyPet.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBeMyPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(113, 62);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(185, 41);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Login Page";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(50, 127);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(97, 24);
            this.lblusername.TabIndex = 2;
            this.lblusername.Text = "Username";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(50, 190);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(92, 24);
            this.lblpassword.TabIndex = 4;
            this.lblpassword.Text = "Password";
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(150, 266);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(120, 30);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            // 
            // lblklogin
            // 
            this.lblklogin.AutoSize = true;
            this.lblklogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblklogin.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblklogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblklogin.Location = new System.Drawing.Point(135, 319);
            this.lblklogin.Name = "lblklogin";
            this.lblklogin.Size = new System.Drawing.Size(147, 13);
            this.lblklogin.TabIndex = 7;
            this.lblklogin.TabStop = true;
            this.lblklogin.Text = "Forgot Password? Recover it!";
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(150, 350);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(120, 30);
            this.btncancel.TabIndex = 8;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // pbxBeMyPet
            // 
            this.pbxBeMyPet.Image = global::BeMyPet.Properties.Resources.BeMyPet;
            this.pbxBeMyPet.Location = new System.Drawing.Point(0, 383);
            this.pbxBeMyPet.Name = "pbxBeMyPet";
            this.pbxBeMyPet.Size = new System.Drawing.Size(129, 108);
            this.pbxBeMyPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBeMyPet.TabIndex = 10;
            this.pbxBeMyPet.TabStop = false;
            // 
            // pbxBackground
            // 
            this.pbxBackground.BackgroundImage = global::BeMyPet.Properties.Resources.BackgroundLogin;
            this.pbxBackground.Location = new System.Drawing.Point(421, 0);
            this.pbxBackground.Name = "pbxBackground";
            this.pbxBackground.Size = new System.Drawing.Size(380, 490);
            this.pbxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxBackground.TabIndex = 9;
            this.pbxBackground.TabStop = false;
            this.pbxBackground.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxBackground_MouseDown);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.BorderSize = 1;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(54, 218);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(7);
            this.txtPassword.PasswordChar = false;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(320, 31);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUsername.BorderFocusColor = System.Drawing.Color.Gray;
            this.txtUsername.BorderRadius = 10;
            this.txtUsername.BorderSize = 1;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsername.Location = new System.Drawing.Point(54, 155);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(7);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.Size = new System.Drawing.Size(320, 31);
            this.txtUsername.TabIndex = 14;
            this.txtUsername.Texts = "";
            this.txtUsername.UnderlinedStyle = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.pbxBeMyPet);
            this.Controls.Add(this.pbxBackground);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.lblklogin);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBeMyPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.LinkLabel lblklogin;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.PictureBox pbxBackground;
        private System.Windows.Forms.PictureBox pbxBeMyPet;
        private RJControls.RJTextBox txtPassword;
        private RJControls.RJTextBox txtUsername;
    }
}