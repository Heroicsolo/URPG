namespace URPG_Client
{
    partial class CharacterScreen
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
            this.labelStr = new System.Windows.Forms.Label();
            this.labelAgi = new System.Windows.Forms.Label();
            this.labelInt = new System.Windows.Forms.Label();
            this.labelSta = new System.Windows.Forms.Label();
            this.checkBoxPoisonResist = new System.Windows.Forms.CheckBox();
            this.checkBoxAmbidextry = new System.Windows.Forms.CheckBox();
            this.checkBoxCrit = new System.Windows.Forms.CheckBox();
            this.checkBoxRegen = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxWeaponMaster = new System.Windows.Forms.CheckBox();
            this.checkBoxDodginess = new System.Windows.Forms.CheckBox();
            this.checkBoxArcane = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAgility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIntelligence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStamina)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.trackBarStrength.Location = new System.Drawing.Point(64, 19);
            this.trackBarStrength.Maximum = 20;
            this.trackBarStrength.Name = "trackBarStrength";
            this.trackBarStrength.Size = new System.Drawing.Size(232, 45);
            this.trackBarStrength.TabIndex = 1;
            this.trackBarStrength.ValueChanged += new System.EventHandler(this.trackBarStrength_Scroll);
            // 
            // trackBarAgility
            // 
            this.trackBarAgility.LargeChange = 1;
            this.trackBarAgility.Location = new System.Drawing.Point(64, 70);
            this.trackBarAgility.Maximum = 20;
            this.trackBarAgility.Name = "trackBarAgility";
            this.trackBarAgility.Size = new System.Drawing.Size(232, 45);
            this.trackBarAgility.TabIndex = 2;
            this.trackBarAgility.ValueChanged += new System.EventHandler(this.trackBarAgility_Scroll);
            // 
            // trackBarIntelligence
            // 
            this.trackBarIntelligence.LargeChange = 1;
            this.trackBarIntelligence.Location = new System.Drawing.Point(64, 121);
            this.trackBarIntelligence.Maximum = 20;
            this.trackBarIntelligence.Name = "trackBarIntelligence";
            this.trackBarIntelligence.Size = new System.Drawing.Size(232, 45);
            this.trackBarIntelligence.TabIndex = 3;
            this.trackBarIntelligence.ValueChanged += new System.EventHandler(this.trackBarIntelligence_Scroll);
            // 
            // trackBarStamina
            // 
            this.trackBarStamina.LargeChange = 1;
            this.trackBarStamina.Location = new System.Drawing.Point(64, 172);
            this.trackBarStamina.Maximum = 20;
            this.trackBarStamina.Name = "trackBarStamina";
            this.trackBarStamina.Size = new System.Drawing.Size(232, 45);
            this.trackBarStamina.TabIndex = 4;
            this.trackBarStamina.ValueChanged += new System.EventHandler(this.trackBarStamina_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "STR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "AGI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "INT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "STA:";
            // 
            // labelStr
            // 
            this.labelStr.AutoSize = true;
            this.labelStr.Location = new System.Drawing.Point(303, 19);
            this.labelStr.Name = "labelStr";
            this.labelStr.Size = new System.Drawing.Size(13, 13);
            this.labelStr.TabIndex = 10;
            this.labelStr.Text = "0";
            // 
            // labelAgi
            // 
            this.labelAgi.AutoSize = true;
            this.labelAgi.Location = new System.Drawing.Point(303, 70);
            this.labelAgi.Name = "labelAgi";
            this.labelAgi.Size = new System.Drawing.Size(13, 13);
            this.labelAgi.TabIndex = 11;
            this.labelAgi.Text = "0";
            // 
            // labelInt
            // 
            this.labelInt.AutoSize = true;
            this.labelInt.Location = new System.Drawing.Point(303, 121);
            this.labelInt.Name = "labelInt";
            this.labelInt.Size = new System.Drawing.Size(13, 13);
            this.labelInt.TabIndex = 12;
            this.labelInt.Text = "0";
            // 
            // labelSta
            // 
            this.labelSta.AutoSize = true;
            this.labelSta.Location = new System.Drawing.Point(303, 172);
            this.labelSta.Name = "labelSta";
            this.labelSta.Size = new System.Drawing.Size(13, 13);
            this.labelSta.TabIndex = 13;
            this.labelSta.Text = "0";
            // 
            // checkBoxPoisonResist
            // 
            this.checkBoxPoisonResist.AutoSize = true;
            this.checkBoxPoisonResist.Location = new System.Drawing.Point(19, 19);
            this.checkBoxPoisonResist.Name = "checkBoxPoisonResist";
            this.checkBoxPoisonResist.Size = new System.Drawing.Size(244, 17);
            this.checkBoxPoisonResist.TabIndex = 14;
            this.checkBoxPoisonResist.Text = "Poison resistance (-50% damage from poisons)";
            this.checkBoxPoisonResist.UseVisualStyleBackColor = true;
            this.checkBoxPoisonResist.CheckedChanged += new System.EventHandler(this.checkBoxPoisonResist_CheckedChanged);
            // 
            // checkBoxAmbidextry
            // 
            this.checkBoxAmbidextry.AutoSize = true;
            this.checkBoxAmbidextry.Location = new System.Drawing.Point(19, 47);
            this.checkBoxAmbidextry.Name = "checkBoxAmbidextry";
            this.checkBoxAmbidextry.Size = new System.Drawing.Size(221, 17);
            this.checkBoxAmbidextry.TabIndex = 15;
            this.checkBoxAmbidextry.Text = "Ambidexterity (left hand does full damage)";
            this.checkBoxAmbidextry.UseVisualStyleBackColor = true;
            this.checkBoxAmbidextry.CheckedChanged += new System.EventHandler(this.checkBoxAmbidextry_CheckedChanged);
            // 
            // checkBoxCrit
            // 
            this.checkBoxCrit.AutoSize = true;
            this.checkBoxCrit.Location = new System.Drawing.Point(19, 70);
            this.checkBoxCrit.Name = "checkBoxCrit";
            this.checkBoxCrit.Size = new System.Drawing.Size(337, 17);
            this.checkBoxCrit.TabIndex = 16;
            this.checkBoxCrit.Text = "Critical strikes (+25% damage from your direct attacks and abilities)";
            this.checkBoxCrit.UseVisualStyleBackColor = true;
            this.checkBoxCrit.CheckedChanged += new System.EventHandler(this.checkBoxCrit_CheckedChanged);
            // 
            // checkBoxRegen
            // 
            this.checkBoxRegen.AutoSize = true;
            this.checkBoxRegen.Location = new System.Drawing.Point(19, 98);
            this.checkBoxRegen.Name = "checkBoxRegen";
            this.checkBoxRegen.Size = new System.Drawing.Size(221, 17);
            this.checkBoxRegen.TabIndex = 17;
            this.checkBoxRegen.Text = "Regeneration (+5 HP and +3 EP per turn)";
            this.checkBoxRegen.UseVisualStyleBackColor = true;
            this.checkBoxRegen.CheckedChanged += new System.EventHandler(this.checkBoxRegen_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBarStrength);
            this.groupBox1.Controls.Add(this.trackBarAgility);
            this.groupBox1.Controls.Add(this.trackBarIntelligence);
            this.groupBox1.Controls.Add(this.trackBarStamina);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelSta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelInt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelAgi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelStr);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 220);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Primary stats (split 20 points between these stats)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxWeaponMaster);
            this.groupBox2.Controls.Add(this.checkBoxDodginess);
            this.groupBox2.Controls.Add(this.checkBoxArcane);
            this.groupBox2.Controls.Add(this.checkBoxPoisonResist);
            this.groupBox2.Controls.Add(this.checkBoxAmbidextry);
            this.groupBox2.Controls.Add(this.checkBoxRegen);
            this.groupBox2.Controls.Add(this.checkBoxCrit);
            this.groupBox2.Location = new System.Drawing.Point(362, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 220);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Qualities (choose 2 of them)";
            // 
            // checkBoxWeaponMaster
            // 
            this.checkBoxWeaponMaster.AutoSize = true;
            this.checkBoxWeaponMaster.Location = new System.Drawing.Point(19, 172);
            this.checkBoxWeaponMaster.Name = "checkBoxWeaponMaster";
            this.checkBoxWeaponMaster.Size = new System.Drawing.Size(343, 17);
            this.checkBoxWeaponMaster.TabIndex = 20;
            this.checkBoxWeaponMaster.Text = "Weapon master (-1 EP cost and +1 damage for all weapon attacks)";
            this.checkBoxWeaponMaster.UseVisualStyleBackColor = true;
            this.checkBoxWeaponMaster.CheckedChanged += new System.EventHandler(this.checkBoxWeaponMaster_CheckedChanged);
            // 
            // checkBoxDodginess
            // 
            this.checkBoxDodginess.AutoSize = true;
            this.checkBoxDodginess.Location = new System.Drawing.Point(19, 149);
            this.checkBoxDodginess.Name = "checkBoxDodginess";
            this.checkBoxDodginess.Size = new System.Drawing.Size(302, 17);
            this.checkBoxDodginess.TabIndex = 19;
            this.checkBoxDodginess.Text = "Dodginess (+20% for dodge modifier given from your agility)";
            this.checkBoxDodginess.UseVisualStyleBackColor = true;
            this.checkBoxDodginess.CheckedChanged += new System.EventHandler(this.checkBoxDodginess_CheckedChanged);
            // 
            // checkBoxArcane
            // 
            this.checkBoxArcane.AutoSize = true;
            this.checkBoxArcane.Location = new System.Drawing.Point(19, 121);
            this.checkBoxArcane.Name = "checkBoxArcane";
            this.checkBoxArcane.Size = new System.Drawing.Size(378, 17);
            this.checkBoxArcane.TabIndex = 18;
            this.checkBoxArcane.Text = "Arcane intelligence (-25% of MP cost for all abilities with 8 MP cost or more)";
            this.checkBoxArcane.UseVisualStyleBackColor = true;
            this.checkBoxArcane.CheckedChanged += new System.EventHandler(this.checkBoxArcane_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelInfo);
            this.groupBox3.Location = new System.Drawing.Point(90, 342);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 119);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Secondary stats";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(18, 28);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 13);
            this.labelInfo.TabIndex = 0;
            // 
            // CharacterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 541);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CharacterScreen";
            this.Text = "URPG Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAgility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIntelligence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStamina)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Label labelStr;
        private System.Windows.Forms.Label labelAgi;
        private System.Windows.Forms.Label labelInt;
        private System.Windows.Forms.Label labelSta;
        private System.Windows.Forms.CheckBox checkBoxPoisonResist;
        private System.Windows.Forms.CheckBox checkBoxAmbidextry;
        private System.Windows.Forms.CheckBox checkBoxCrit;
        private System.Windows.Forms.CheckBox checkBoxRegen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxWeaponMaster;
        private System.Windows.Forms.CheckBox checkBoxDodginess;
        private System.Windows.Forms.CheckBox checkBoxArcane;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelInfo;
    }
}

