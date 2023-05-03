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
                MessageBox.Show("Login successful!");

                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.ShowDialog();
            }
            else
            {
                // Incorrect login credentials
                MessageBox.Show("Incorrect login credentials.");
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
