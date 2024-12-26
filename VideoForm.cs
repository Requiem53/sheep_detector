using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SheepDetector
{
    public partial class VideoForm : Form
    {
        public VideoForm(string videoPath)
        {
            InitializeComponent();

            if (!System.IO.File.Exists(videoPath))
            {
                MessageBox.Show($"File not found: {videoPath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;

                axWindowsMediaPlayer1.URL = videoPath;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer1.uiMode = "none";
            }

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
