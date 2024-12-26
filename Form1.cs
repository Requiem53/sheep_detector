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
            // Display a confirmation dialog
            DialogResult result = MessageBox.Show(
                "Are you sheep?",
                "Sheep Detection",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }
    }
}
