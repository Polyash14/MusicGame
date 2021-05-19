using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MusicGame
{
    public partial class fParameter : Form
    {
        public fParameter()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string[] music_list = Directory.GetFiles(fbd.SelectedPath, "*.mp3", cbAllDirectory.Checked?SearchOption.AllDirectories: SearchOption.TopDirectoryOnly);
                listBox1.Items.Clear();
                listBox1.Items.AddRange(music_list);
            }
        }
    }
}
