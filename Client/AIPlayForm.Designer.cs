namespace Client
{
    partial class AIPlayForm
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
            this.boardPicture = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.boardPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // boardPicture
            // 
            this.boardPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(216)))));
            this.boardPicture.Location = new System.Drawing.Point(17, 18);
            this.boardPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boardPicture.Name = "boardPicture";
            this.boardPicture.Size = new System.Drawing.Size(714, 750);
            this.boardPicture.TabIndex = 0;
            this.boardPicture.TabStop = false;
            this.boardPicture.Paint += new System.Windows.Forms.PaintEventHandler(this.boardPicture_Paint);
            this.boardPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boardPicture_MouseDown);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(919, 63);
            this.playButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(143, 60);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "게임 시작";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(797, 144);
            this.status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(389, 22);
            this.status.TabIndex = 2;
            this.status.Text = "게임을 시작해주세요.";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AIPlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 812);
            this.Controls.Add(this.status);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.boardPicture);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AIPlayForm";
            this.Text = "AIPlayForm";
            this.Load += new System.EventHandler(this.AIPlayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boardPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox boardPicture;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label status;
    }
}