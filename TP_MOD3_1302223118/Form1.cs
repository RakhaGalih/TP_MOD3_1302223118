namespace TP_MOD3_1302223118
{
    public partial class Form1 : Form
    {
        string input;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Form1()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Hello, " + input;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            input = textBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
