using System.Security.Cryptography;
using System.Text;
using InventoryApp.Repositories;
using InventoryApp.Models;

namespace InventoryApp
{
    public partial class InventoryApp : Form
    {
        public InventoryApp()
        {
            InitializeComponent();
        }

        private void InventoryApp_Load(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void LoadUsers()
        {
            UsersRepository userRepository = new UsersRepository();
            List<Users> userList = userRepository.GetUsers();

            // Affichage dans la console (ou autre traitement)
            foreach (var user in userList)
            {
                Console.WriteLine($"ID: {user.id}, Name: {user.name}, Email: {user.email}, Role: {user.role}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string emailInput = EmailBoxSignIn.Text;
            string passwordInput = PasswordBoxSignIn.Text;

            string hashedPassword = HashPassword(passwordInput);

            UsersRepository userRepository = new UsersRepository();
            List<Users> userList = userRepository.GetUsers();

            Users user = userList.FirstOrDefault(u => u.email == emailInput && u.password == hashedPassword);

            if (user != null)
            {
                UserSession.UserId = user.id;
                UserSession.UserName = user.name;
                UserSession.UserEmail = user.email;
                UserSession.UserRole = user.role;

                Form3 form3 = new Form3();
                this.Hide();
                form3.FormClosed += (s, args) => this.Close();
                form3.Show();
            }
            else
            {
                MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }






        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string userInput = EmailBoxSignIn.Text;
            Console.WriteLine(userInput);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create and show the Register form
            Register registerForm = new Register();
            registerForm.FormClosed += (s, args) => this.Close();
            registerForm.Show();

            // Hide the current form
            this.Hide();

        }
    }
}
