
namespace DarkSide.Desktop
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.deathstarPanel = new System.Windows.Forms.Panel();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.battleFieldPanel = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // deathstarPanel
            // 
            this.deathstarPanel.BackColor = System.Drawing.Color.Black;
            this.deathstarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.deathstarPanel.Location = new System.Drawing.Point(0, 711);
            this.deathstarPanel.Name = "deathstarPanel";
            this.deathstarPanel.Size = new System.Drawing.Size(1084, 50);
            this.deathstarPanel.TabIndex = 1;
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.Black;
            this.infoPanel.Controls.Add(this.label2);
            this.infoPanel.Controls.Add(this.lbl_Score);
            this.infoPanel.Controls.Add(this.timeLabel);
            this.infoPanel.Controls.Add(this.infoLabel);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoPanel.Location = new System.Drawing.Point(0, 0);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(1084, 141);
            this.infoPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(462, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 72);
            this.label2.TabIndex = 3;
            this.label2.Text = "SKOR:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Score
            // 
            this.lbl_Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Score.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score.Location = new System.Drawing.Point(638, 34);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(187, 72);
            this.lbl_Score.TabIndex = 2;
            this.lbl_Score.Text = "0";
            this.lbl_Score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLabel.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(885, 34);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(187, 72);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "0:00";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(3, 1);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(415, 140);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Başla = Enter\r\nHareket = Yön Tuşları \r\nAteş = Boşluk \r\nDurdur = P";
            this.infoLabel.Click += new System.EventHandler(this.infoLabel_Click);
            // 
            // battleFieldPanel
            // 
            this.battleFieldPanel.AutoScroll = true;
            this.battleFieldPanel.BackgroundImage = global::DarkSide.Desktop.Properties.Resources.arkaplan;
            this.battleFieldPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.battleFieldPanel.Location = new System.Drawing.Point(0, 141);
            this.battleFieldPanel.Name = "battleFieldPanel";
            this.battleFieldPanel.Size = new System.Drawing.Size(1084, 570);
            this.battleFieldPanel.TabIndex = 3;
            this.battleFieldPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.battleFieldPanel_Paint);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1084, 761);
            this.Controls.Add(this.battleFieldPanel);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.deathstarPanel);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Dark Side";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel deathstarPanel;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Panel battleFieldPanel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.Label label2;
    }
}

