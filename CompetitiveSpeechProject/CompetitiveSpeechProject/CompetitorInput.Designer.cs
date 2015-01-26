namespace CompetitiveSpeechProject
{
    partial class CompetitorInput
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxMiddleName = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.btnCompetitorSubmit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(34, 46);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(10);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(39, 17);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(6);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(37, 20);
            this.File.Text = "File";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(24, 83);
            this.lblMiddleName.Margin = new System.Windows.Forms.Padding(10);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(49, 17);
            this.lblMiddleName.TabIndex = 2;
            this.lblMiddleName.Text = "Middle";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(31, 120);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(10);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(35, 17);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(31, 157);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(10);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbxFirstName.Location = new System.Drawing.Point(86, 43);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(139, 23);
            this.tbxFirstName.TabIndex = 5;
            this.tbxFirstName.TextChanged += new System.EventHandler(this.tbxFirstName_TextChanged);
            // 
            // tbxMiddleName
            // 
            this.tbxMiddleName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbxMiddleName.Location = new System.Drawing.Point(86, 80);
            this.tbxMiddleName.Name = "tbxMiddleName";
            this.tbxMiddleName.Size = new System.Drawing.Size(139, 23);
            this.tbxMiddleName.TabIndex = 6;
            this.tbxMiddleName.TextChanged += new System.EventHandler(this.tbxMiddleName_TextChanged);
            // 
            // tbxLastName
            // 
            this.tbxLastName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbxLastName.Location = new System.Drawing.Point(86, 117);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(139, 23);
            this.tbxLastName.TabIndex = 7;
            this.tbxLastName.TextChanged += new System.EventHandler(this.tbxLastName_TextChanged);
            // 
            // tbxEmail
            // 
            this.tbxEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbxEmail.Location = new System.Drawing.Point(86, 154);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(139, 23);
            this.tbxEmail.TabIndex = 8;
            this.tbxEmail.TextChanged += new System.EventHandler(this.tbxEmail_TextChanged);
            // 
            // btnCompetitorSubmit
            // 
            this.btnCompetitorSubmit.Location = new System.Drawing.Point(105, 189);
            this.btnCompetitorSubmit.Name = "btnCompetitorSubmit";
            this.btnCompetitorSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnCompetitorSubmit.TabIndex = 9;
            this.btnCompetitorSubmit.Text = "Submit";
            this.btnCompetitorSubmit.UseVisualStyleBackColor = true;
            // 
            // CompetitorInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 224);
            this.Controls.Add(this.btnCompetitorSubmit);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.tbxMiddleName);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CompetitorInput";
            this.Text = "CompetitorInput";
            this.Load += new System.EventHandler(this.CompetitorInput_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxMiddleName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Button btnCompetitorSubmit;
    }
}