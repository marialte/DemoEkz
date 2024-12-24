using System;
using System.Windows.Forms;
using Npgsql;
using RepairRequestSystem;

namespace TaskManager.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пожалуйста, введите логин и пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var connection = Database.GetConnection())
            {
                string query = "SELECT role FROM users WHERE username = @username AND password = @password";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    try
                    {
                        var role = command.ExecuteScalar();

                        if (role != null)
                        {
                            MessageBox.Show($"Добро пожаловать, {username}! Ваша роль: {role}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();
                            var mainForm = new MainForm();
                            mainForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
