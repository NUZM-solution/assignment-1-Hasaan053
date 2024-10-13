using System;
using System.Windows.Forms;

namespace LoginAndDataGridApp
{
    public partial class LoginForm : Form
    {
        public LoginForm() // Constructor
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Clear text boxes on form load
            txtUsername.Clear();
            txtPassword.Clear(); // Clear the password field
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            string correctUsername = "hasaan_azeem"; // Your username
            string correctPassword = "22011556-053"; // Your roll number

            if (txtUsername.Text == correctUsername && txtPassword.Text == correctPassword)
            {
                MessageBox.Show("Correct Login", "Login Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataGridForm dataGridForm = new DataGridForm(); // Reference to your DataGridForm
                dataGridForm.Show(); // Show the DataGridForm
                this.Hide(); // Hide the login form
            }
            else
            {
                MessageBox.Show("Login Failed", "Login Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            // Handle text changes if needed
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
