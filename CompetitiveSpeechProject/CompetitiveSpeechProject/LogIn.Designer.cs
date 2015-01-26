namespace CompetitiveSpeechProject
{
    partial class LogIn
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
            this.btnLogInSubmit = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbxLogInUsername = new System.Windows.Forms.TextBox();
            this.tbxLogInPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLogInSubmit
            // 
            this.btnLogInSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogInSubmit.Location = new System.Drawing.Point(104, 122);
            this.btnLogInSubmit.Name = "btnLogInSubmit";
            this.btnLogInSubmit.Size = new System.Drawing.Size(77, 28);
            this.btnLogInSubmit.TabIndex = 0;
            this.btnLogInSubmit.Text = "Log In";
            this.btnLogInSubmit.UseVisualStyleBackColor = true;
            this.btnLogInSubmit.Click += new System.EventHandler(this.btnLogInSubmit_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(13, 35);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 17);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(15, 81);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // tbxLogInUsername
            // 
            this.tbxLogInUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLogInUsername.Location = new System.Drawing.Point(101, 32);
            this.tbxLogInUsername.Name = "tbxLogInUsername";
            this.tbxLogInUsername.Size = new System.Drawing.Size(134, 23);
            this.tbxLogInUsername.TabIndex = 3;

            // 
            // tbxLogInPassword
            // 
            this.tbxLogInPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLogInPassword.Location = new System.Drawing.Point(101, 78);
            this.tbxLogInPassword.Name = "tbxLogInPassword";
            this.tbxLogInPassword.Size = new System.Drawing.Size(134, 23);
            this.tbxLogInPassword.TabIndex = 4;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.Controls.Add(this.tbxLogInPassword);
            this.Controls.Add(this.tbxLogInUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogInSubmit);
            this.Name = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogInSubmit;

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbxLogInUsername;
        private System.Windows.Forms.TextBox tbxLogInPassword;
    }
}