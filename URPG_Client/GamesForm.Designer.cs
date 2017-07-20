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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageConnect = new System.Windows.Forms.TabPage();
            this.tabPageSession = new System.Windows.Forms.TabPage();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonLaunchSession = new System.Windows.Forms.Button();
            this.tabPageCharacter = new System.Windows.Forms.TabPage();
            this.tabPagePlay = new System.Windows.Forms.TabPage();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPageConnect.SuspendLayout();
            this.tabPageSession.SuspendLayout();
            this.tabPageCharacter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamesListBox
            // 
            this.gamesListBox.FormattingEnabled = true;
            this.gamesListBox.Items.AddRange(new object[] {
            "Classic fantasy",
            "Fallout"});
            this.gamesListBox.Location = new System.Drawing.Point(9, 45);
            this.gamesListBox.Name = "gamesListBox";
            this.gamesListBox.Size = new System.Drawing.Size(180, 485);
            this.gamesListBox.TabIndex = 2;
            this.gamesListBox.SelectedIndexChanged += new System.EventHandler(this.gamesListBox_SelectedIndexChanged);
            // 
            // sessionsListBox
            // 
            this.sessionsListBox.FormattingEnabled = true;
            this.sessionsListBox.Items.AddRange(new object[] {
            "TEST SESSION"});
            this.sessionsListBox.Location = new System.Drawing.Point(195, 45);
            this.sessionsListBox.Name = "sessionsListBox";
            this.sessionsListBox.Size = new System.Drawing.Size(180, 485);
            this.sessionsListBox.TabIndex = 4;
            this.sessionsListBox.SelectedIndexChanged += new System.EventHandler(this.sessionsListBox_SelectedIndexChanged);
            // 
            // gamesLabel
            // 
            this.gamesLabel.AutoSize = true;
            this.gamesLabel.Location = new System.Drawing.Point(6, 3);
            this.gamesLabel.Name = "gamesLabel";
            this.gamesLabel.Size = new System.Drawing.Size(43, 13);
            this.gamesLabel.TabIndex = 5;
            this.gamesLabel.Text = "Games:";
            // 
            // sessionsLabel
            // 
            this.sessionsLabel.AutoSize = true;
            this.sessionsLabel.Location = new System.Drawing.Point(192, 3);
            this.sessionsLabel.Name = "sessionsLabel";
            this.sessionsLabel.Size = new System.Drawing.Size(52, 13);
            this.sessionsLabel.TabIndex = 6;
            this.sessionsLabel.Text = "Sessions:";
            // 
            // findGamesTextBox
            // 
            this.findGamesTextBox.Location = new System.Drawing.Point(9, 19);
            this.findGamesTextBox.Name = "findGamesTextBox";
            this.findGamesTextBox.Size = new System.Drawing.Size(180, 20);
            this.findGamesTextBox.TabIndex = 7;
            // 
            // findSessionsTextBox
            // 
            this.findSessionsTextBox.Location = new System.Drawing.Point(195, 19);
            this.findSessionsTextBox.Name = "findSessionsTextBox";
            this.findSessionsTextBox.Size = new System.Drawing.Size(180, 20);
            this.findSessionsTextBox.TabIndex = 8;
            // 
            // joinButton
            // 
            this.joinButton.Enabled = false;
            this.joinButton.Location = new System.Drawing.Point(693, 504);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(75, 23);
            this.joinButton.TabIndex = 9;
            this.joinButton.Text = "Join";
            this.joinButton.UseVisualStyleBackColor = true;
            this.joinButton.Click += new System.EventHandler(this.joinButton_Click);
            // 
            // createButton
            // 
            this.createButton.Enabled = false;
            this.createButton.Location = new System.Drawing.Point(693, 479);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 10;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageConnect);
            this.tabControlMain.Controls.Add(this.tabPageSession);
            this.tabControlMain.Controls.Add(this.tabPageCharacter);
            this.tabControlMain.Controls.Add(this.tabPagePlay);
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(800, 600);
            this.tabControlMain.TabIndex = 11;
            // 
            // tabPageConnect
            // 
            this.tabPageConnect.Controls.Add(this.createButton);
            this.tabPageConnect.Controls.Add(this.findSessionsTextBox);
            this.tabPageConnect.Controls.Add(this.joinButton);
            this.tabPageConnect.Controls.Add(this.findGamesTextBox);
            this.tabPageConnect.Controls.Add(this.gamesLabel);
            this.tabPageConnect.Controls.Add(this.sessionsLabel);
            this.tabPageConnect.Controls.Add(this.gamesListBox);
            this.tabPageConnect.Controls.Add(this.sessionsListBox);
            this.tabPageConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageConnect.Location = new System.Drawing.Point(4, 22);
            this.tabPageConnect.Name = "tabPageConnect";
            this.tabPageConnect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConnect.Size = new System.Drawing.Size(792, 574);
            this.tabPageConnect.TabIndex = 0;
            this.tabPageConnect.Text = "Connect";
            this.tabPageConnect.UseVisualStyleBackColor = true;
            // 
            // tabPageSession
            // 
            this.tabPageSession.Controls.Add(this.buttonBack);
            this.tabPageSession.Controls.Add(this.buttonLaunchSession);
            this.tabPageSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageSession.Location = new System.Drawing.Point(4, 22);
            this.tabPageSession.Name = "tabPageSession";
            this.tabPageSession.Size = new System.Drawing.Size(792, 574);
            this.tabPageSession.TabIndex = 2;
            this.tabPageSession.Text = "Edit session";
            this.tabPageSession.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(8, 504);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(109, 23);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonLaunchSession
            // 
            this.buttonLaunchSession.Location = new System.Drawing.Point(659, 504);
            this.buttonLaunchSession.Name = "buttonLaunchSession";
            this.buttonLaunchSession.Size = new System.Drawing.Size(109, 23);
            this.buttonLaunchSession.TabIndex = 0;
            this.buttonLaunchSession.Text = "Launch";
            this.buttonLaunchSession.UseVisualStyleBackColor = true;
            this.buttonLaunchSession.Click += new System.EventHandler(this.buttonLaunchSession_Click);
            // 
            // tabPageCharacter
            // 
            this.tabPageCharacter.Controls.Add(this.buttonPlay);
            this.tabPageCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageCharacter.Location = new System.Drawing.Point(4, 22);
            this.tabPageCharacter.Name = "tabPageCharacter";
            this.tabPageCharacter.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCharacter.Size = new System.Drawing.Size(792, 574);
            this.tabPageCharacter.TabIndex = 1;
            this.tabPageCharacter.Text = "Edit character";
            this.tabPageCharacter.UseVisualStyleBackColor = true;
            // 
            // tabPagePlay
            // 
            this.tabPagePlay.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlay.Name = "tabPagePlay";
            this.tabPagePlay.Size = new System.Drawing.Size(792, 574);
            this.tabPagePlay.TabIndex = 3;
            this.tabPagePlay.Text = "Play";
            this.tabPagePlay.UseVisualStyleBackColor = true;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Enabled = false;
            this.buttonPlay.Location = new System.Drawing.Point(682, 503);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(86, 24);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // GamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControlMain);
            this.Name = "GamesForm";
            this.Text = "GamesForm";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageConnect.ResumeLayout(false);
            this.tabPageConnect.PerformLayout();
            this.tabPageSession.ResumeLayout(false);
            this.tabPageCharacter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox gamesListBox;
        public System.Windows.Forms.ListBox sessionsListBox;
        public System.Windows.Forms.Label gamesLabel;
        public System.Windows.Forms.Label sessionsLabel;
        public System.Windows.Forms.TextBox findGamesTextBox;
        public System.Windows.Forms.TextBox findSessionsTextBox;
        public System.Windows.Forms.Button joinButton;
        public System.Windows.Forms.Button createButton;
        public System.Windows.Forms.TabControl tabControlMain;
        public System.Windows.Forms.TabPage tabPageConnect;
        public System.Windows.Forms.TabPage tabPageSession;
        public System.Windows.Forms.TabPage tabPageCharacter;
        public System.Windows.Forms.TabPage tabPagePlay;
        public System.Windows.Forms.Button buttonBack;
        public System.Windows.Forms.Button buttonLaunchSession;
        public System.Windows.Forms.Button buttonPlay;
    }
}