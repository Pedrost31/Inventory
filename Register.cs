using InventoryApp.Models;
using InventoryApp.Repositories;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace InventoryApp
{
    public partial class Register : Form
    {
        MaterialSkinManager materialSkinManager;
        public Register()
        {

            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Cyan700, TextShade.WHITE);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Create_button_Click(object sender, EventArgs e)
        {
            string email = EmailBox.Text;
            string password = PasswordBox.Text;
            string name = NameBox.Text;
            string role = "employe"; // Default role

            // Validate email
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format. Please use the format: example@example.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate password
            if (!IsValidPassword(password))
            {
                MessageBox.Show("Password must contain at least 8 characters, including 1 uppercase letter, 1 lowercase letter, 1 number, and 1 special character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate name
            if (!IsValidName(name))
            {
                MessageBox.Show("Name must contain only letters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hash the password securely
            string hashedPassword = HashPassword(password);

            // Create a new user object
            Users newUser = new Users
            {
                email = email,
                password = hashedPassword,
                name = name,
                role = role
            };

            // Save the new user to the repository
            UsersRepository userRepository = new UsersRepository();
            userRepository.CreateUsers(newUser);

            // Optionally, show a message to the user
            MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPassword(string password)
        {
            if (password.Length < 8) return false;
            bool hasUpperChar = false, hasLowerChar = false, hasDigit = false, hasSpecialChar = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpperChar = true;
                else if (char.IsLower(c)) hasLowerChar = true;
                else if (char.IsDigit(c)) hasDigit = true;
                else if (!char.IsLetterOrDigit(c)) hasSpecialChar = true;
            }

            return hasUpperChar && hasLowerChar && hasDigit && hasSpecialChar;
        }

        private bool IsValidName(string name)
        {
            return name.All(char.IsLetter);
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






        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConnectLikeRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create and show the Register form
            Form SignInForm = new InventoryApp();
            SignInForm.FormClosed += (s, args) => this.Close(); // Close the main form when the Register form is closed
            SignInForm.Show();

            // Hide the current form
            this.Hide();
        }

        private void ResetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}