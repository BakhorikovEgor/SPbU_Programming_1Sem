namespace Magic_Choice
{
    partial class MagickChoice
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MagickChoice));
            this.UserAttempField = new System.Windows.Forms.TextBox();
            this.MainInfoLabel = new System.Windows.Forms.Label();
            this.RemainingAttemps = new System.Windows.Forms.Label();
            this.WonGamesNumber = new System.Windows.Forms.Label();
            this.PlayedGamesNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserAttempField
            // 
            this.UserAttempField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserAttempField.Location = new System.Drawing.Point(168, 190);
            this.UserAttempField.Multiline = true;
            this.UserAttempField.Name = "UserAttempField";
            this.UserAttempField.Size = new System.Drawing.Size(151, 33);
            this.UserAttempField.TabIndex = 0;
            this.UserAttempField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainInfoLabel
            // 
            this.MainInfoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainInfoLabel.Location = new System.Drawing.Point(98, 88);
            this.MainInfoLabel.Name = "MainInfoLabel";
            this.MainInfoLabel.Size = new System.Drawing.Size(322, 62);
            this.MainInfoLabel.TabIndex = 1;
            this.MainInfoLabel.Text = "Chose the number in range (0,9)";
            this.MainInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemainingAttemps
            // 
            this.RemainingAttemps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemainingAttemps.AutoSize = true;
            this.RemainingAttemps.Location = new System.Drawing.Point(330, 34);
            this.RemainingAttemps.Name = "RemainingAttemps";
            this.RemainingAttemps.Size = new System.Drawing.Size(155, 20);
            this.RemainingAttemps.TabIndex = 2;
            this.RemainingAttemps.Text = "Remaining Attemps: 3";
            // 
            // WonGamesNumber
            // 
            this.WonGamesNumber.AutoSize = true;
            this.WonGamesNumber.Location = new System.Drawing.Point(36, 70);
            this.WonGamesNumber.Name = "WonGamesNumber";
            this.WonGamesNumber.Size = new System.Drawing.Size(56, 20);
            this.WonGamesNumber.TabIndex = 4;
            this.WonGamesNumber.Text = "Wins: 0";
            // 
            // PlayedGamesNumber
            // 
            this.PlayedGamesNumber.AutoSize = true;
            this.PlayedGamesNumber.Location = new System.Drawing.Point(24, 34);
            this.PlayedGamesNumber.Name = "PlayedGamesNumber";
            this.PlayedGamesNumber.Size = new System.Drawing.Size(68, 20);
            this.PlayedGamesNumber.TabIndex = 5;
            this.PlayedGamesNumber.Text = "Played: 0";
            // 
            // MagickChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(521, 402);
            this.Controls.Add(this.PlayedGamesNumber);
            this.Controls.Add(this.WonGamesNumber);
            this.Controls.Add(this.RemainingAttemps);
            this.Controls.Add(this.MainInfoLabel);
            this.Controls.Add(this.UserAttempField);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(539, 449);
            this.Name = "MagickChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MagickChoice";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox UserAttempField;
        private Label MainInfoLabel;
        private Label RemainingAttemps;
        private Label WonGamesNumber;
        private Label PlayedGamesNumber;
    }
}