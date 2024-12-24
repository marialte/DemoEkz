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
using TaskManager.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace TaskManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadTasks();
            LoadFilters();
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm();
            addTaskForm.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void LoadTasks(string filter = "")
        {
            try
            {
                using (var connection = Database.GetConnection())
                {
                    string query = @"SELECT 
                                        t.id, 
                                        t.project_name, 
                                        t.description, 
                                        t.priority, 
                                        u.first_name || ' ' || u.last_name AS assigned_to, 
                                        t.status, 
                                        t.created_at
                                    FROM tasks t
                                    LEFT JOIN users u ON t.assigned_to = u.id";
                    if (!string.IsNullOrEmpty(filter))
                    {
                        query += $" WHERE {filter}";
                    }

                    var adapter = new NpgsqlDataAdapter(new NpgsqlCommand(query, connection));
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewTasks.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки задач: {ex.Message}");
            }
        }

        private void LoadFilters()
        {
            comboBoxStatus.Items.AddRange(new[] { "все", "в ожидании", "в работе", "выполнено" });
            comboBoxPriority.Items.AddRange(new[] { "все", "низкий", "средний", "высокий" });

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

                    comboBoxAssignedTo.Items.Insert(0, "все");
                    comboBoxAssignedTo.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки фильтров: {ex.Message}");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filter = "";

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                filter += $"(t.id::TEXT LIKE '%{txtSearch.Text}%' OR t.project_name ILIKE '%{txtSearch.Text}%' OR t.description ILIKE '%{txtSearch.Text}%')";
            }

            if (comboBoxStatus.SelectedItem.ToString() != "все")
            {
                filter += (string.IsNullOrEmpty(filter) ? "" : " AND ") + $"t.status = '{comboBoxStatus.SelectedItem}'";
            }

            if (comboBoxPriority.SelectedItem.ToString() != "все")
            {
                filter += (string.IsNullOrEmpty(filter) ? "" : " AND ") + $"t.priority = '{comboBoxPriority.SelectedItem}'";
            }

            if (comboBoxAssignedTo.SelectedItem.ToString() != "все")
            {
                filter += (string.IsNullOrEmpty(filter) ? "" : " AND ") + $"t.assigned_to = {comboBoxAssignedTo.SelectedValue}";
            }

            LoadTasks(filter);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите задачу для удаления.");
                return;
            }

            int taskId = Convert.ToInt32(dataGridViewTasks.SelectedRows[0].Cells["id"].Value);

            try
            {
                using (var connection = Database.GetConnection())
                {
                    var command = new NpgsqlCommand("DELETE FROM tasks WHERE id = @id", connection);
                    command.Parameters.AddWithValue("id", taskId);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Задача успешно удалена.");
                    LoadTasks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления задачи: {ex.Message}");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите задачу для редактирования.");
                return;
            }

            int taskId = Convert.ToInt32(dataGridViewTasks.SelectedRows[0].Cells["id"].Value);
            var editForm = new EditTaskForm(taskId);
            editForm.ShowDialog();
            LoadTasks();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           StatistickForm statistickForm = new StatistickForm();
            statistickForm.ShowDialog();

        }

        private void btnSaveToPDF_Click(object sender, EventArgs e)
        {
            SaveTasksToPDF();
        }

        private void SaveTasksToPDF()
        {
            try
            {
               
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
               
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.DefaultExt = "pdf"; 
                    saveFileDialog.AddExtension = true;

                   
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                       
                        string filePath = saveFileDialog.FileName;

                    
                        PdfDocument pdf = new PdfDocument();
                        pdf.Info.Title = "Список задач";

          
                        PdfPage page = pdf.AddPage();
                        XGraphics gfx = XGraphics.FromPdfPage(page);

                   
                        XFont font = new XFont("Arial", 12);
                        XFont headerFont = new XFont("Arial", 14);

          
                        gfx.DrawString("Список всех задач", headerFont, XBrushes.Black, new XPoint(250, 40));

    
                        gfx.DrawString("ID", font, XBrushes.Black, new XPoint(50, 80));
                        gfx.DrawString("Проект", font, XBrushes.Black, new XPoint(100, 80));
                        gfx.DrawString("Описание", font, XBrushes.Black, new XPoint(250, 80));
                        gfx.DrawString("Приоритет", font, XBrushes.Black, new XPoint(400, 80));
                        gfx.DrawString("Исполнитель", font, XBrushes.Black, new XPoint(500, 80));
                        gfx.DrawString("Статус", font, XBrushes.Black, new XPoint(600, 80));
                        gfx.DrawString("Дата создания", font, XBrushes.Black, new XPoint(700, 80));

                   
                        int yPosition = 100;
                        foreach (DataGridViewRow row in dataGridViewTasks.Rows)
                        {
                            if (row.IsNewRow) continue;

                            gfx.DrawString(row.Cells["id"].Value.ToString(), font, XBrushes.Black, new XPoint(50, yPosition));
                            gfx.DrawString(row.Cells["project_name"].Value.ToString(), font, XBrushes.Black, new XPoint(100, yPosition));
                            gfx.DrawString(row.Cells["description"].Value.ToString(), font, XBrushes.Black, new XPoint(250, yPosition));
                            gfx.DrawString(row.Cells["priority"].Value.ToString(), font, XBrushes.Black, new XPoint(400, yPosition));
                            gfx.DrawString(row.Cells["assigned_to"].Value.ToString(), font, XBrushes.Black, new XPoint(500, yPosition));
                            gfx.DrawString(row.Cells["status"].Value.ToString(), font, XBrushes.Black, new XPoint(600, yPosition));
                            gfx.DrawString(Convert.ToDateTime(row.Cells["created_at"].Value).ToString("dd/MM/yyyy"), font, XBrushes.Black, new XPoint(700, yPosition));

                            yPosition += 20;
                        }

                   
                        pdf.Save(filePath);

              
                        MessageBox.Show($"Задачи успешно сохранены в PDF: {filePath}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении PDF: {ex.Message}");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
