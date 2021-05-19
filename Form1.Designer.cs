
namespace MusicGame
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnParametrs = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Segoe Print", 22.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btnPlay.Location = new System.Drawing.Point(212, 29);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(792, 160);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "И г р а";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // btnParametrs
            // 
            this.btnParametrs.Font = new System.Drawing.Font("Segoe Print", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnParametrs.Location = new System.Drawing.Point(212, 261);
            this.btnParametrs.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.btnParametrs.Name = "btnParametrs";
            this.btnParametrs.Size = new System.Drawing.Size(792, 160);
            this.btnParametrs.TabIndex = 1;
            this.btnParametrs.Text = "Н а с т р о й к и";
            this.btnParametrs.UseVisualStyleBackColor = true;
            this.btnParametrs.Click += new System.EventHandler(this.btnParametrs_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe Print", 22.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(212, 504);
            this.btnExit.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(792, 160);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "В ы х о д";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 65F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1268, 738);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnParametrs);
            this.Controls.Add(this.btnPlay);
            this.Font = new System.Drawing.Font("Segoe Print", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.Name = "fMain";
            this.Text = "Угадай мелодию";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnParametrs;
        private System.Windows.Forms.Button btnExit;
    }
}

