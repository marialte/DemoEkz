using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using RepairRequestSystem;
using System.Windows.Forms.VisualStyles;

namespace TaskManager.Forms
{
    public partial class AddTaskForm : Form
    {
        public AddTaskForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                using (var connection = Database.GetConnection())
                {
                    var command = new NpgsqlCommand("SELECT id, first_name || ' ' || last_name AS full_name FROM users", connection);
                    var adapter = new NpgsqlDataAdapter(command);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    comboBoxAssignedTo.DataSource = dataTable;
                    comboBoxAssignedTo.DisplayMember = "full_name";
                    comboBoxAssignedTo.ValueMember = "id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки пользователей: {ex.Message}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = Database.GetConnection())
                {
                    var command = new NpgsqlCommand(
                        "INSERT INTO tasks (project_name, description, priority, assigned_to, status) VALUES (@project_name, @description, @priority, @assigned_to, @status)",
                        connection
                    );

                    command.Parameters.AddWithValue("project_name", txtProjectName.Text);
                    command.Parameters.AddWithValue("description", txtDescription.Text);
                    command.Parameters.AddWithValue("priority", comboBoxPriority.SelectedItem.ToString());
                    command.Parameters.AddWithValue("assigned_to", Convert.ToInt32(comboBoxAssignedTo.SelectedValue));
                    command.Parameters.AddWithValue("status", "в ожидании");

                    command.ExecuteNonQuery();

                    MessageBox.Show("Задача успешно добавлена!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения задачи: {ex.Message}");
            }
        }
    }
}