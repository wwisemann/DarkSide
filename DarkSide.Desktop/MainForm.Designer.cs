
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.deathstarPanel = new System.Windows.Forms.Panel();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.battleFieldPanel = new System.Windows.Forms.Panel();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // deathstarPanel
            // 
            this.deathstarPanel.BackColor = System.Drawing.Color.Black;
            this.deathstarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.deathstarPanel.Location = new System.Drawing.Point(0, 888);
            this.deathstarPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deathstarPanel.Name = "deathstarPanel";
            this.deathstarPanel.Size = new System.Drawing.Size(1573, 62);
            this.deathstarPanel.TabIndex = 1;
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.Black;
            this.infoPanel.Controls.Add(this.timeLabel);
            this.infoPanel.Controls.Add(this.infoLabel);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoPanel.Location = new System.Drawing.Point(0, 0);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(1573, 166);
            this.infoPanel.TabIndex = 2;
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLabel.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(1308, 42);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(249, 89);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "0:00";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(16, 11);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(559, 147);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Başla = Enter\r\nHareket = Yön Tuşları \r\nAteş = Boşluk \r\n";
            // 
            // battleFieldPanel
            // 
            this.battleFieldPanel.BackgroundImage = global::DarkSide.Desktop.Properties.Resources.arkaplan;
            this.battleFieldPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.battleFieldPanel.Location = new System.Drawing.Point(0, 166);
            this.battleFieldPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.battleFieldPanel.Name = "battleFieldPanel";
            this.battleFieldPanel.Size = new System.Drawing.Size(1573, 722);
            this.battleFieldPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1573, 950);
            this.Controls.Add(this.battleFieldPanel);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.deathstarPanel);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Dark Side";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
    }
}

