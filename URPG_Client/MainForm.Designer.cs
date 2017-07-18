namespace URPG_Client
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBarStrength = new System.Windows.Forms.TrackBar();
            this.trackBarAgility = new System.Windows.Forms.TrackBar();
            this.trackBarIntelligence = new System.Windows.Forms.TrackBar();
            this.trackBarStamina = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAgility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIntelligence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStamina)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(876, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // trackBarStrength
            // 
            this.trackBarStrength.LargeChange = 1;
            this.trackBarStrength.Location = new System.Drawing.Point(56, 57);
            this.trackBarStrength.Maximum = 20;
            this.trackBarStrength.Name = "trackBarStrength";
            this.trackBarStrength.Size = new System.Drawing.Size(232, 45);
            this.trackBarStrength.TabIndex = 1;
            this.trackBarStrength.Scroll += new System.EventHandler(this.trackBarStrength_Scroll);
            // 
            // trackBarAgility
            // 
            this.trackBarAgility.LargeChange = 1;
            this.trackBarAgility.Location = new System.Drawing.Point(56, 108);
            this.trackBarAgility.Maximum = 20;
            this.trackBarAgility.Name = "trackBarAgility";
            this.trackBarAgility.Size = new System.Drawing.Size(232, 45);
            this.trackBarAgility.TabIndex = 2;
            this.trackBarAgility.Scroll += new System.EventHandler(this.trackBarAgility_Scroll);
            // 
            // trackBarIntelligence
            // 
            this.trackBarIntelligence.LargeChange = 1;
            this.trackBarIntelligence.Location = new System.Drawing.Point(56, 159);
            this.trackBarIntelligence.Maximum = 20;
            this.trackBarIntelligence.Name = "trackBarIntelligence";
            this.trackBarIntelligence.Size = new System.Drawing.Size(232, 45);
            this.trackBarIntelligence.TabIndex = 3;
            this.trackBarIntelligence.Scroll += new System.EventHandler(this.trackBarIntelligence_Scroll);
            // 
            // trackBarStamina
            // 
            this.trackBarStamina.LargeChange = 1;
            this.trackBarStamina.Location = new System.Drawing.Point(56, 210);
            this.trackBarStamina.Maximum = 20;
            this.trackBarStamina.Name = "trackBarStamina";
            this.trackBarStamina.Size = new System.Drawing.Size(232, 45);
            this.trackBarStamina.TabIndex = 4;
            this.trackBarStamina.Scroll += new System.EventHandler(this.trackBarStamina_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "STR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "AGI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "INT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "STA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Primary stats";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 541);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarStamina);
            this.Controls.Add(this.trackBarIntelligence);
            this.Controls.Add(this.trackBarAgility);
            this.Controls.Add(this.trackBarStrength);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "URPG Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAgility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIntelligence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStamina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBarStrength;
        private System.Windows.Forms.TrackBar trackBarAgility;
        private System.Windows.Forms.TrackBar trackBarIntelligence;
        private System.Windows.Forms.TrackBar trackBarStamina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

