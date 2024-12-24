using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Npgsql;
using RepairRequestSystem;

namespace TaskManager.Forms
{
    public partial class EditTaskForm : Form
    {
        private int taskId;

        public EditTaskForm(int taskId)
        {
            InitializeComponent();
            this.taskId = taskId;
            LoadTaskData();
            LoadUsers();
            LoadPriorities();
            LoadStatuses();
        }

        private void LoadTaskData()
        {
            try
            {
                using (var connection = Database.GetConnection())
                {
                    var command = new NpgsqlCommand(
                        "SELECT project_name, description, priority, assigned_to, status FROM tasks WHERE id = @id",
                        connection
                    );
                    command.Parameters.AddWithValue("id", taskId);
                    var reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        txtDescription.Text = reader.GetString(1);
                        comboBoxPriority.SelectedItem = reader.GetString(2);
                        comboBoxAssignedTo.SelectedValue = reader.GetInt32(3);
                        comboBoxStatus.SelectedItem = reader.GetString(4); // Загружаем текущий статус
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных задачи: {ex.Message}");
            }
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
                MessageBox.Show($"Ошибка загрузки исполнителей: {ex.Message}");
            }
        }

        private void LoadPriorities()
        {
            comboBoxPriority.Items.AddRange(new[] { "низкий", "средний", "высокий" });
        }

        private void LoadStatuses()
        {
            comboBoxStatus.Items.AddRange(new[] { "в ожидании", "в работе", "выполнено" });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtDescription.Text))
                {
                    MessageBox.Show("Описание задачи не может быть пустым.");
                    return; 
                }


                using (var connection = Database.GetConnection())
                {
                    var command = new NpgsqlCommand(
                        "UPDATE tasks SET description = @description, priority = @priority, assigned_to = @assigned_to, status = @status WHERE id = @id",
                        connection
                    );


                    command.Parameters.AddWithValue("description", txtDescription.Text);

          
                    if (comboBoxPriority.SelectedItem != null)
                    {
                        command.Parameters.AddWithValue("priority", comboBoxPriority.SelectedItem.ToString());
                    }

       
                    if (comboBoxAssignedTo.SelectedValue != null)
                    {
                        command.Parameters.AddWithValue("assigned_to", Convert.ToInt32(comboBoxAssignedTo.SelectedValue));
                    }

          
                    if (comboBoxStatus.SelectedItem != null)
                    {
                        command.Parameters.AddWithValue("status", comboBoxStatus.SelectedItem.ToString());
                    }

            
                    command.Parameters.AddWithValue("id", taskId);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Задача успешно обновлена!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения изменений: {ex.Message}");
            }
        }

        private void comboBoxAssignedTo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}