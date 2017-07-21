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
            this.textBoxSessionName = new System.Windows.Forms.TextBox();
            this.labelSessionName = new System.Windows.Forms.Label();
            this.trackBarMinPlayers = new System.Windows.Forms.TrackBar();
            this.trackBarMaxPlayers = new System.Windows.Forms.TrackBar();
            this.labelMinPlayers = new System.Windows.Forms.Label();
            this.labelMaxPlayers = new System.Windows.Forms.Label();
            this.trackBarStatsPoints = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCharStatsPoints = new System.Windows.Forms.Label();
            this.labelCharQualitiesNumber = new System.Windows.Forms.Label();
            this.trackBarCharQualitiesNum = new System.Windows.Forms.TrackBar();
            this.tabControlMain.SuspendLayout();
            this.tabPageConnect.SuspendLayout();
            this.tabPageSession.SuspendLayout();
            this.tabPageCharacter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMaxPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStatsPoints)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCharQualitiesNum)).BeginInit();
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
            this.tabControlMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlMain_Selected);
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
            this.tabPageSession.Controls.Add(this.groupBox1);
            this.tabPageSession.Controls.Add(this.labelMaxPlayers);
            this.tabPageSession.Controls.Add(this.labelMinPlayers);
            this.tabPageSession.Controls.Add(this.trackBarMaxPlayers);
            this.tabPageSession.Controls.Add(this.trackBarMinPlayers);
            this.tabPageSession.Controls.Add(this.labelSessionName);
            this.tabPageSession.Controls.Add(this.textBoxSessionName);
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
            // textBoxSessionName
            // 
            this.textBoxSessionName.Location = new System.Drawing.Point(8, 57);
            this.textBoxSessionName.MaxLength = 32;
            this.textBoxSessionName.Name = "textBoxSessionName";
            this.textBoxSessionName.Size = new System.Drawing.Size(276, 20);
            this.textBoxSessionName.TabIndex = 2;
            // 
            // labelSessionName
            // 
            this.labelSessionName.AutoSize = true;
            this.labelSessionName.Location = new System.Drawing.Point(8, 26);
            this.labelSessionName.Name = "labelSessionName";
            this.labelSessionName.Size = new System.Drawing.Size(76, 13);
            this.labelSessionName.TabIndex = 3;
            this.labelSessionName.Text = "Session name:";
            // 
            // trackBarMinPlayers
            // 
            this.trackBarMinPlayers.LargeChange = 1;
            this.trackBarMinPlayers.Location = new System.Drawing.Point(8, 123);
            this.trackBarMinPlayers.Maximum = 8;
            this.trackBarMinPlayers.Minimum = 1;
            this.trackBarMinPlayers.Name = "trackBarMinPlayers";
            this.trackBarMinPlayers.Size = new System.Drawing.Size(276, 45);
            this.trackBarMinPlayers.TabIndex = 4;
            this.trackBarMinPlayers.Value = 1;
            // 
            // trackBarMaxPlayers
            // 
            this.trackBarMaxPlayers.LargeChange = 1;
            this.trackBarMaxPlayers.Location = new System.Drawing.Point(8, 213);
            this.trackBarMaxPlayers.Maximum = 8;
            this.trackBarMaxPlayers.Minimum = 1;
            this.trackBarMaxPlayers.Name = "trackBarMaxPlayers";
            this.trackBarMaxPlayers.Size = new System.Drawing.Size(276, 45);
            this.trackBarMaxPlayers.TabIndex = 5;
            this.trackBarMaxPlayers.Value = 4;
            // 
            // labelMinPlayers
            // 
            this.labelMinPlayers.AutoSize = true;
            this.labelMinPlayers.Location = new System.Drawing.Point(8, 104);
            this.labelMinPlayers.Name = "labelMinPlayers";
            this.labelMinPlayers.Size = new System.Drawing.Size(101, 13);
            this.labelMinPlayers.TabIndex = 6;
            this.labelMinPlayers.Text = "Min players number:";
            // 
            // labelMaxPlayers
            // 
            this.labelMaxPlayers.AutoSize = true;
            this.labelMaxPlayers.Location = new System.Drawing.Point(8, 197);
            this.labelMaxPlayers.Name = "labelMaxPlayers";
            this.labelMaxPlayers.Size = new System.Drawing.Size(104, 13);
            this.labelMaxPlayers.TabIndex = 7;
            this.labelMaxPlayers.Text = "Max players number:";
            // 
            // trackBarStatsPoints
            // 
            this.trackBarStatsPoints.Location = new System.Drawing.Point(132, 31);
            this.trackBarStatsPoints.Maximum = 30;
            this.trackBarStatsPoints.Minimum = 5;
            this.trackBarStatsPoints.Name = "trackBarStatsPoints";
            this.trackBarStatsPoints.Size = new System.Drawing.Size(276, 45);
            this.trackBarStatsPoints.TabIndex = 8;
            this.trackBarStatsPoints.Value = 20;
            this.trackBarStatsPoints.Scroll += new System.EventHandler(this.trackBarStatsPoints_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCharQualitiesNumber);
            this.groupBox1.Controls.Add(this.labelCharStatsPoints);
            this.groupBox1.Controls.Add(this.trackBarCharQualitiesNum);
            this.groupBox1.Controls.Add(this.trackBarStatsPoints);
            this.groupBox1.Location = new System.Drawing.Point(311, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 232);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game balance";
            // 
            // labelCharStatsPoints
            // 
            this.labelCharStatsPoints.AutoSize = true;
            this.labelCharStatsPoints.Location = new System.Drawing.Point(16, 38);
            this.labelCharStatsPoints.Name = "labelCharStatsPoints";
            this.labelCharStatsPoints.Size = new System.Drawing.Size(112, 13);
            this.labelCharStatsPoints.TabIndex = 9;
            this.labelCharStatsPoints.Text = "Character stats points:";
            // 
            // labelCharQualitiesNumber
            // 
            this.labelCharQualitiesNumber.AutoSize = true;
            this.labelCharQualitiesNumber.Location = new System.Drawing.Point(16, 104);
            this.labelCharQualitiesNumber.Name = "labelCharQualitiesNumber";
            this.labelCharQualitiesNumber.Size = new System.Drawing.Size(97, 13);
            this.labelCharQualitiesNumber.TabIndex = 11;
            this.labelCharQualitiesNumber.Text = "Character qualities:";
            // 
            // trackBarCharQualitiesNum
            // 
            this.trackBarCharQualitiesNum.LargeChange = 1;
            this.trackBarCharQualitiesNum.Location = new System.Drawing.Point(132, 97);
            this.trackBarCharQualitiesNum.Maximum = 5;
            this.trackBarCharQualitiesNum.Minimum = 1;
            this.trackBarCharQualitiesNum.Name = "trackBarCharQualitiesNum";
            this.trackBarCharQualitiesNum.Size = new System.Drawing.Size(276, 45);
            this.trackBarCharQualitiesNum.TabIndex = 10;
            this.trackBarCharQualitiesNum.Value = 2;
            this.trackBarCharQualitiesNum.Scroll += new System.EventHandler(this.trackBarCharQualitiesNum_Scroll);
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
            this.tabPageSession.PerformLayout();
            this.tabPageCharacter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMaxPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStatsPoints)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCharQualitiesNum)).EndInit();
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
        private System.Windows.Forms.Label labelMaxPlayers;
        private System.Windows.Forms.Label labelMinPlayers;
        private System.Windows.Forms.TrackBar trackBarMaxPlayers;
        private System.Windows.Forms.TrackBar trackBarMinPlayers;
        private System.Windows.Forms.Label labelSessionName;
        private System.Windows.Forms.TextBox textBoxSessionName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCharQualitiesNumber;
        private System.Windows.Forms.Label labelCharStatsPoints;
        private System.Windows.Forms.TrackBar trackBarCharQualitiesNum;
        private System.Windows.Forms.TrackBar trackBarStatsPoints;
    }
}