namespace CompetitiveSpeechProject
{
    partial class Tournament
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
            System.Windows.Forms.Label goalLabel;
            System.Windows.Forms.Label teamPlacementLabel;
            System.Windows.Forms.Label locationIDLabel;
            System.Windows.Forms.Label dayLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label tournamentIDLabel;
            this.goalTextBox = new System.Windows.Forms.TextBox();
            this.teamPlacementTextBox = new System.Windows.Forms.TextBox();
            this.locationIDTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.tournamentIDTextBox = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.dateSelection = new System.Windows.Forms.DateTimePicker();
            goalLabel = new System.Windows.Forms.Label();
            teamPlacementLabel = new System.Windows.Forms.Label();
            locationIDLabel = new System.Windows.Forms.Label();
            dayLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            tournamentIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // goalLabel
            // 
            goalLabel.AutoSize = true;
            goalLabel.Location = new System.Drawing.Point(13, 199);
            goalLabel.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            goalLabel.Name = "goalLabel";
            goalLabel.Size = new System.Drawing.Size(40, 16);
            goalLabel.TabIndex = 46;
            goalLabel.Text = "Goal:";
            goalLabel.Click += new System.EventHandler(this.goalLabel_Click);
            // 
            // teamPlacementLabel
            // 
            teamPlacementLabel.AutoSize = true;
            teamPlacementLabel.Location = new System.Drawing.Point(13, 163);
            teamPlacementLabel.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            teamPlacementLabel.Name = "teamPlacementLabel";
            teamPlacementLabel.Size = new System.Drawing.Size(75, 16);
            teamPlacementLabel.TabIndex = 44;
            teamPlacementLabel.Text = "Placement:";
            teamPlacementLabel.Click += new System.EventHandler(this.teamPlacementLabel_Click);
            // 
            // locationIDLabel
            // 
            locationIDLabel.AutoSize = true;
            locationIDLabel.Location = new System.Drawing.Point(13, 130);
            locationIDLabel.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            locationIDLabel.Name = "locationIDLabel";
            locationIDLabel.Size = new System.Drawing.Size(78, 16);
            locationIDLabel.TabIndex = 42;
            locationIDLabel.Text = "Location ID:";
            // 
            // dayLabel
            // 
            dayLabel.AutoSize = true;
            dayLabel.Location = new System.Drawing.Point(13, 94);
            dayLabel.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            dayLabel.Name = "dayLabel";
            dayLabel.Size = new System.Drawing.Size(37, 16);
            dayLabel.TabIndex = 41;
            dayLabel.Text = "Date";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(13, 58);
            titleLabel.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(48, 16);
            titleLabel.TabIndex = 38;
            titleLabel.Text = "Name:";
            // 
            // tournamentIDLabel
            // 
            tournamentIDLabel.AutoSize = true;
            tournamentIDLabel.Location = new System.Drawing.Point(13, 22);
            tournamentIDLabel.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            tournamentIDLabel.Name = "tournamentIDLabel";
            tournamentIDLabel.Size = new System.Drawing.Size(34, 16);
            tournamentIDLabel.TabIndex = 37;
            tournamentIDLabel.Text = "ID #:";
            // 
            // goalTextBox
            // 
            this.goalTextBox.Location = new System.Drawing.Point(95, 196);
            this.goalTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.goalTextBox.Name = "goalTextBox";
            this.goalTextBox.Size = new System.Drawing.Size(129, 22);
            this.goalTextBox.TabIndex = 48;
            // 
            // teamPlacementTextBox
            // 
            this.teamPlacementTextBox.Location = new System.Drawing.Point(96, 160);
            this.teamPlacementTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.teamPlacementTextBox.Name = "teamPlacementTextBox";
            this.teamPlacementTextBox.Size = new System.Drawing.Size(129, 22);
            this.teamPlacementTextBox.TabIndex = 47;
            // 
            // locationIDTextBox
            // 
            this.locationIDTextBox.Location = new System.Drawing.Point(95, 127);
            this.locationIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.locationIDTextBox.Name = "locationIDTextBox";
            this.locationIDTextBox.Size = new System.Drawing.Size(129, 22);
            this.locationIDTextBox.TabIndex = 45;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(96, 55);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(184, 22);
            this.titleTextBox.TabIndex = 40;
            // 
            // tournamentIDTextBox
            // 
            this.tournamentIDTextBox.Location = new System.Drawing.Point(96, 19);
            this.tournamentIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tournamentIDTextBox.Name = "tournamentIDTextBox";
            this.tournamentIDTextBox.Size = new System.Drawing.Size(81, 22);
            this.tournamentIDTextBox.TabIndex = 39;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(203, 244);
            this.cancel.Margin = new System.Windows.Forms.Padding(4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(70, 28);
            this.cancel.TabIndex = 36;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(107, 244);
            this.reset.Margin = new System.Windows.Forms.Padding(4);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(70, 28);
            this.reset.TabIndex = 35;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(11, 244);
            this.submit.Margin = new System.Windows.Forms.Padding(4);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(70, 28);
            this.submit.TabIndex = 34;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // dateSelection
            // 
            this.dateSelection.Location = new System.Drawing.Point(95, 89);
            this.dateSelection.Margin = new System.Windows.Forms.Padding(4);
            this.dateSelection.Name = "dateSelection";
            this.dateSelection.Size = new System.Drawing.Size(185, 22);
            this.dateSelection.TabIndex = 49;
            // 
            // Tournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 288);
            this.Controls.Add(this.dateSelection);
            this.Controls.Add(goalLabel);
            this.Controls.Add(this.goalTextBox);
            this.Controls.Add(teamPlacementLabel);
            this.Controls.Add(this.teamPlacementTextBox);
            this.Controls.Add(locationIDLabel);
            this.Controls.Add(this.locationIDTextBox);
            this.Controls.Add(dayLabel);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(tournamentIDLabel);
            this.Controls.Add(this.tournamentIDTextBox);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.submit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Tournament";
            this.Text = "Tournament Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox goalTextBox;
        private System.Windows.Forms.TextBox teamPlacementTextBox;
        private System.Windows.Forms.TextBox locationIDTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox tournamentIDTextBox;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.DateTimePicker dateSelection;

     }
}