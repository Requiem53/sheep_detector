namespace SheepDetector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sheep?",
                "Sheep Detection",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string videoPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Libraries", "funnyvideo.mp4");

                VideoForm videoForm = new VideoForm(videoPath);
                videoForm.Show();
            }
        }
    }
}
