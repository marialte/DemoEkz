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
using QRCoder;
using RepairRequestSystem;

namespace TaskManager.Forms
{
    public partial class StatistickForm : Form
    {
        public StatistickForm()
        {
            InitializeComponent();
            GenerateQRCode("https://vk.com/marialte");
        }

        private void GenerateQRCode(string Str)
        {

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(Str, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);

            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            pictureBoxQRCode.Image = qrCodeImage;
        }
    

     private void btnGetStatistics_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = dateTimePickerStart.Value;
                DateTime endDate = dateTimePickerEnd.Value;

         
                if (endDate < startDate)
                {
                    MessageBox.Show("Дата окончания не может быть раньше даты начала.");
                    return;
                }

        
                GetCompletedTasksStatistics(startDate, endDate);

               
                GetProjectStatistics(startDate, endDate);

              
                GetUserStatistics(startDate, endDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при получении статистики: {ex.Message}");
            }
        }


        private void GetCompletedTasksStatistics(DateTime startDate, DateTime endDate)
        {
            try
            {
                using (var connection = Database.GetConnection())
                {
                    string query = @"
                        SELECT COUNT(*) FROM tasks
                        WHERE status = 'выполнено'
                        AND created_at BETWEEN @startDate AND @endDate";
                    var command = new NpgsqlCommand(query, connection);
                    command.Parameters.AddWithValue("startDate", startDate);
                    command.Parameters.AddWithValue("endDate", endDate);

                    var result = command.ExecuteScalar();
                    lblCompletedTasks.Text = $"Кол-во Выполн: {result}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при получении статистики по выполненным задачам: {ex.Message}");
            }
        }


        private void GetProjectStatistics(DateTime startDate, DateTime endDate)
        {
            try
            {
                using (var connection = Database.GetConnection())
                {
                    string query = @"
                        SELECT project_name, COUNT(*) 
                        FROM tasks
                        WHERE created_at BETWEEN @startDate AND @endDate
                        GROUP BY project_name";
                    var command = new NpgsqlCommand(query, connection);
                    command.Parameters.AddWithValue("startDate", startDate);
                    command.Parameters.AddWithValue("endDate", endDate);

                    var adapter = new NpgsqlDataAdapter(command);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);

   
                    dataGridViewProjectStatistics.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при получении статистики по проектам: {ex.Message}");
            }
        }

        private void GetUserStatistics(DateTime startDate, DateTime endDate)
        {
            try
            {
                using (var connection = Database.GetConnection())
                {
                    string query = @"
                SELECT u.first_name || ' ' || u.last_name AS full_name, COUNT(DISTINCT t.project_name) AS project_count
                FROM tasks t
                JOIN users u ON t.assigned_to = u.id
                WHERE t.created_at BETWEEN @startDate AND @endDate
                GROUP BY u.first_name, u.last_name";

                    var command = new NpgsqlCommand(query, connection);
                    command.Parameters.AddWithValue("startDate", startDate);
                    command.Parameters.AddWithValue("endDate", endDate);

                    var adapter = new NpgsqlDataAdapter(command);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewUserStatistics.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при получении статистики по исполнителям: {ex.Message}");
            }
        }

    }
}
