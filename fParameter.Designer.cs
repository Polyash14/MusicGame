
namespace MusicGame
{
    partial class fParameter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fParameter));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.cbAllDirectory = new System.Windows.Forms.CheckBox();
            this.btnCanel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(776, 284);
            this.listBox1.TabIndex = 0;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelectFolder.Location = new System.Drawing.Point(12, 310);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(197, 44);
            this.btnSelectFolder.TabIndex = 1;
            this.btnSelectFolder.Text = "Выбрать папку";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearList.Location = new System.Drawing.Point(281, 310);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(143, 44);
            this.btnClearList.TabIndex = 2;
            this.btnClearList.Text = "Очистить";
            this.btnClearList.UseVisualStyleBackColor = true;
            // 
            // cbAllDirectory
            // 
            this.cbAllDirectory.AutoSize = true;
            this.cbAllDirectory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbAllDirectory.Location = new System.Drawing.Point(572, 310);
            this.cbAllDirectory.Name = "cbAllDirectory";
            this.cbAllDirectory.Size = new System.Drawing.Size(165, 24);
            this.cbAllDirectory.TabIndex = 3;
            this.cbAllDirectory.Text = "Вложенные папки";
            this.cbAllDirectory.UseVisualStyleBackColor = true;
            // 
            // btnCanel
            // 
            this.btnCanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCanel.Location = new System.Drawing.Point(572, 391);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(122, 41);
            this.btnCanel.TabIndex = 4;
            this.btnCanel.Text = "Отмена";
            this.btnCanel.UseVisualStyleBackColor = true;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOk.Location = new System.Drawing.Point(334, 391);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(90, 41);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "О К";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // fParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.cbAllDirectory);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fParameter";
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.CheckBox cbAllDirectory;
        private System.Windows.Forms.Button btnCanel;
        private System.Windows.Forms.Button btnOk;
    }
}