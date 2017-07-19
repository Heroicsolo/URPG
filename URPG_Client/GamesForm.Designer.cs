namespace URPG_Client
{
    partial class GamesForm
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
            this.gamesListBox = new System.Windows.Forms.ListBox();
            this.sessionsListBox = new System.Windows.Forms.ListBox();
            this.gamesLabel = new System.Windows.Forms.Label();
            this.sessionsLabel = new System.Windows.Forms.Label();
            this.findGamesTextBox = new System.Windows.Forms.TextBox();
            this.findSessionsTextBox = new System.Windows.Forms.TextBox();
            this.joinButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gamesListBox
            // 
            this.gamesListBox.FormattingEnabled = true;
            this.gamesListBox.Location = new System.Drawing.Point(12, 51);
            this.gamesListBox.Name = "gamesListBox";
            this.gamesListBox.Size = new System.Drawing.Size(180, 498);
            this.gamesListBox.TabIndex = 2;
            // 
            // sessionsListBox
            // 
            this.sessionsListBox.FormattingEnabled = true;
            this.sessionsListBox.Location = new System.Drawing.Point(198, 51);
            this.sessionsListBox.Name = "sessionsListBox";
            this.sessionsListBox.Size = new System.Drawing.Size(180, 498);
            this.sessionsListBox.TabIndex = 4;
            // 
            // gamesLabel
            // 
            this.gamesLabel.AutoSize = true;
            this.gamesLabel.Location = new System.Drawing.Point(12, 9);
            this.gamesLabel.Name = "gamesLabel";
            this.gamesLabel.Size = new System.Drawing.Size(43, 13);
            this.gamesLabel.TabIndex = 5;
            this.gamesLabel.Text = "Games:";
            // 
            // sessionsLabel
            // 
            this.sessionsLabel.AutoSize = true;
            this.sessionsLabel.Location = new System.Drawing.Point(198, 9);
            this.sessionsLabel.Name = "sessionsLabel";
            this.sessionsLabel.Size = new System.Drawing.Size(52, 13);
            this.sessionsLabel.TabIndex = 6;
            this.sessionsLabel.Text = "Sessions:";
            // 
            // findGamesTextBox
            // 
            this.findGamesTextBox.Location = new System.Drawing.Point(12, 25);
            this.findGamesTextBox.Name = "findGamesTextBox";
            this.findGamesTextBox.Size = new System.Drawing.Size(180, 20);
            this.findGamesTextBox.TabIndex = 7;
            // 
            // findSessionsTextBox
            // 
            this.findSessionsTextBox.Location = new System.Drawing.Point(198, 25);
            this.findSessionsTextBox.Name = "findSessionsTextBox";
            this.findSessionsTextBox.Size = new System.Drawing.Size(180, 20);
            this.findSessionsTextBox.TabIndex = 8;
            // 
            // joinButton
            // 
            this.joinButton.Location = new System.Drawing.Point(697, 526);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(75, 23);
            this.joinButton.TabIndex = 9;
            this.joinButton.Text = "Join";
            this.joinButton.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(697, 497);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 10;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // GamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.joinButton);
            this.Controls.Add(this.findSessionsTextBox);
            this.Controls.Add(this.findGamesTextBox);
            this.Controls.Add(this.sessionsLabel);
            this.Controls.Add(this.gamesLabel);
            this.Controls.Add(this.sessionsListBox);
            this.Controls.Add(this.gamesListBox);
            this.Name = "GamesForm";
            this.Text = "GamesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox gamesListBox;
        private System.Windows.Forms.ListBox sessionsListBox;
        private System.Windows.Forms.Label gamesLabel;
        private System.Windows.Forms.Label sessionsLabel;
        private System.Windows.Forms.TextBox findGamesTextBox;
        private System.Windows.Forms.TextBox findSessionsTextBox;
        private System.Windows.Forms.Button joinButton;
        private System.Windows.Forms.Button createButton;
    }
}