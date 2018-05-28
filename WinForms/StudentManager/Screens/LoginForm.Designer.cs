namespace StudentManager.Screens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureLockScreen1 = new System.Windows.Forms.PictureBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.textBoxForUserName = new System.Windows.Forms.TextBox();
            this.textBoxForPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLockScreen1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureLockScreen1
            // 
            this.pictureLockScreen1.Image = ((System.Drawing.Image)(resources.GetObject("pictureLockScreen1.Image")));
            this.pictureLockScreen1.Location = new System.Drawing.Point(18, 111);
            this.pictureLockScreen1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureLockScreen1.Name = "pictureLockScreen1";
            this.pictureLockScreen1.Size = new System.Drawing.Size(128, 128);
            this.pictureLockScreen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureLockScreen1.TabIndex = 0;
            this.pictureLockScreen1.TabStop = false;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(446, 14);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(110, 25);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "User Name";
            // 
            // textBoxForUserName
            // 
            this.textBoxForUserName.Location = new System.Drawing.Point(320, 45);
            this.textBoxForUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxForUserName.Name = "textBoxForUserName";
            this.textBoxForUserName.Size = new System.Drawing.Size(416, 30);
            this.textBoxForUserName.TabIndex = 2;
            this.textBoxForUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxForPassword
            // 
            this.textBoxForPassword.Location = new System.Drawing.Point(320, 178);
            this.textBoxForPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxForPassword.Name = "textBoxForPassword";
            this.textBoxForPassword.PasswordChar = '*';
            this.textBoxForPassword.Size = new System.Drawing.Size(416, 30);
            this.textBoxForPassword.TabIndex = 4;
            this.textBoxForPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(446, 147);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(98, 25);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Image = ((System.Drawing.Image)(resources.GetObject("btnSignIn.Image")));
            this.btnSignIn.Location = new System.Drawing.Point(320, 275);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(146, 100);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(592, 275);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(146, 100);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 427);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.textBoxForPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxForUserName);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.pictureLockScreen1);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "LoginForm";
            this.ShowInTaskbar = true;
            this.Text = "LoginScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLockScreen1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureLockScreen1;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBoxForUserName;
        private System.Windows.Forms.TextBox textBoxForPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnExit;
    }
}