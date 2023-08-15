namespace NoteTakingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string correctUser = "Radis";
            string correctPw = "smirda";

            string inputUser = textBox1.Text;
            string inputPw = textBox2.Text;

            if (correctUser == inputUser)
            {
                if (correctPw == inputPw)
                {
                    MessageBox.Show("Login succesful");
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.Show();
                }
                else { MessageBox.Show("Wrong password"); }
            }
            else { MessageBox.Show("Wrong username"); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}