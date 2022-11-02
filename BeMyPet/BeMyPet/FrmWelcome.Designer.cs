namespace BeMyPet
{
    partial class FrmWelcome
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
            this.lblWhat = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCreateAcccount = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pbxBeMyPet = new System.Windows.Forms.PictureBox();
            this.pbxBackground = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBeMyPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWhat
            // 
            this.lblWhat.AutoSize = true;
            this.lblWhat.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.lblWhat.Location = new System.Drawing.Point(427, 254);
            this.lblWhat.Name = "lblWhat";
            this.lblWhat.Size = new System.Drawing.Size(303, 31);
            this.lblWhat.TabIndex = 16;
            this.lblWhat.Text = "What do you want to do?";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(417, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(322, 41);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Hi! And Welcome to";
            // 
            // btnCreateAcccount
            // 
            this.btnCreateAcccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(129)))));
            this.btnCreateAcccount.FlatAppearance.BorderSize = 0;
            this.btnCreateAcccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAcccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAcccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAcccount.Location = new System.Drawing.Point(514, 386);
            this.btnCreateAcccount.Name = "btnCreateAcccount";
            this.btnCreateAcccount.Size = new System.Drawing.Size(120, 30);
            this.btnCreateAcccount.TabIndex = 20;
            this.btnCreateAcccount.Text = "Create Account";
            this.btnCreateAcccount.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(514, 338);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 30);
            this.btnLogin.TabIndex = 19;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // pbxBeMyPet
            // 
            this.pbxBeMyPet.Image = global::BeMyPet.Properties.Resources.BeMyPet;
            this.pbxBeMyPet.Location = new System.Drawing.Point(504, 88);
            this.pbxBeMyPet.Name = "pbxBeMyPet";
            this.pbxBeMyPet.Size = new System.Drawing.Size(159, 138);
            this.pbxBeMyPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBeMyPet.TabIndex = 15;
            this.pbxBeMyPet.TabStop = false;
            // 
            // pbxBackground
            // 
            this.pbxBackground.BackgroundImage = global::BeMyPet.Properties.Resources.BackgroundLogin;
            this.pbxBackground.Location = new System.Drawing.Point(-5, 0);
            this.pbxBackground.Name = "pbxBackground";
            this.pbxBackground.Size = new System.Drawing.Size(378, 492);
            this.pbxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxBackground.TabIndex = 11;
            this.pbxBackground.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BeMyPet.Properties.Resources.CerrarPestaña;
            this.pictureBox1.Location = new System.Drawing.Point(767, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // FrmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCreateAcccount);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblWhat);
            this.Controls.Add(this.pbxBeMyPet);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbxBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.pbxBeMyPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxBackground;
        private System.Windows.Forms.Label lblWhat;
        private System.Windows.Forms.PictureBox pbxBeMyPet;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCreateAcccount;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}