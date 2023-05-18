namespace HotelReservation
{
    public partial class Form1 : Form
    {
        string username = "administrator";
        string password = "admin";
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == username && txt_password.Text == password)
            {
                // Successful login
                MessageBox.Show("Login Successful!");

                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.ShowDialog();
            }
            else
            {
                // Incorrect Login credentials
                MessageBox.Show("Incorrect Login Credentials.");
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
