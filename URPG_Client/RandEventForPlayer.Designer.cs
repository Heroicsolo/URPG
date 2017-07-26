namespace URPG_Client
{
    partial class RandEventForPlayer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelRandEventResultP1 = new System.Windows.Forms.Label();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.textBoxEventChanceP1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelRandEventResultP1
            // 
            this.labelRandEventResultP1.AutoSize = true;
            this.labelRandEventResultP1.Location = new System.Drawing.Point(139, 14);
            this.labelRandEventResultP1.Name = "labelRandEventResultP1";
            this.labelRandEventResultP1.Size = new System.Drawing.Size(20, 13);
            this.labelRandEventResultP1.TabIndex = 9;
            this.labelRandEventResultP1.Text = "fail";
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.Location = new System.Drawing.Point(17, 14);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(45, 13);
            this.labelPlayer1.TabIndex = 8;
            this.labelPlayer1.Text = "Player 1";
            // 
            // textBoxEventChanceP1
            // 
            this.textBoxEventChanceP1.Location = new System.Drawing.Point(71, 14);
            this.textBoxEventChanceP1.MaxLength = 3;
            this.textBoxEventChanceP1.Name = "textBoxEventChanceP1";
            this.textBoxEventChanceP1.Size = new System.Drawing.Size(45, 20);
            this.textBoxEventChanceP1.TabIndex = 7;
            this.textBoxEventChanceP1.TextChanged += new System.EventHandler(this.textBoxEventChanceP1_TextChanged);
            // 
            // RandEventForPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelRandEventResultP1);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.textBoxEventChanceP1);
            this.DoubleBuffered = true;
            this.Name = "RandEventForPlayer";
            this.Size = new System.Drawing.Size(271, 49);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxEventChanceP1;
        private System.Windows.Forms.Label labelRandEventResultP1;
        private System.Windows.Forms.Label labelPlayer1;

    }
}
