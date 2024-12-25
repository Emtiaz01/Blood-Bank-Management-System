namespace Blood_Bank_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Emtiaz" && txtPassword.Text == "pass")
            {
                dashboard db = new dashboard();
                db.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter valid username or password", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (btnHideShow.Text == "Show")
            {
                btnHideShow.Text = "Hide";
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                btnHideShow.Text = "Show";
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
        }
    }
}
