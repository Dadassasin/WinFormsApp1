namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxAuthors.Text))
            {
                listBoxAuthors.Items.Add(textBoxAuthors.Text);
                textBoxAuthors.Clear();
            }
        }

        private void textBox52_TextChanged(object sender, EventArgs e)
        {

        }
    }
}