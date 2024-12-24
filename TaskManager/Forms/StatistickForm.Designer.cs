namespace TaskManager.Forms
{
    partial class StatistickForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblCompletedTasks = new System.Windows.Forms.Label();
            this.lblCompletedRequests = new System.Windows.Forms.Label();
            this.pictureBoxQRCode = new System.Windows.Forms.PictureBox();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.btnGetStatistics = new System.Windows.Forms.Button();
            this.dataGridViewUserStatistics = new System.Windows.Forms.DataGridView();
            this.dataGridViewProjectStatistics = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjectStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCompletedTasks
            // 
            this.lblCompletedTasks.AutoSize = true;
            this.lblCompletedTasks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCompletedTasks.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblCompletedTasks.Location = new System.Drawing.Point(272, 91);
            this.lblCompletedTasks.Name = "lblCompletedTasks";
            this.lblCompletedTasks.Size = new System.Drawing.Size(134, 19);
            this.lblCompletedTasks.TabIndex = 5;
            this.lblCompletedTasks.Text = "Кол-во Выполн";
            // 
            // lblCompletedRequests
            // 
            this.lblCompletedRequests.AutoSize = true;
            this.lblCompletedRequests.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCompletedRequests.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblCompletedRequests.Location = new System.Drawing.Point(48, 20);
            this.lblCompletedRequests.Name = "lblCompletedRequests";
            this.lblCompletedRequests.Size = new System.Drawing.Size(286, 19);
            this.lblCompletedRequests.TabIndex = 3;
            this.lblCompletedRequests.Text = "Выберите период для статистики:";
            // 
            // pictureBoxQRCode
            // 
            this.pictureBoxQRCode.Location = new System.Drawing.Point(578, 20);
            this.pictureBoxQRCode.Name = "pictureBoxQRCode";
            this.pictureBoxQRCode.Size = new System.Drawing.Size(210, 106);
            this.pictureBoxQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxQRCode.TabIndex = 6;
            this.pictureBoxQRCode.TabStop = false;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CalendarForeColor = System.Drawing.Color.DarkSlateBlue;
            this.dateTimePickerStart.CalendarMonthBackground = System.Drawing.Color.LavenderBlush;
            this.dateTimePickerStart.Location = new System.Drawing.Point(51, 56);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStart.TabIndex = 7;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CalendarForeColor = System.Drawing.Color.DarkSlateBlue;
            this.dateTimePickerEnd.CalendarMonthBackground = System.Drawing.Color.LavenderBlush;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(296, 56);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEnd.TabIndex = 8;
            // 
            // btnGetStatistics
            // 
            this.btnGetStatistics.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnGetStatistics.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnGetStatistics.Location = new System.Drawing.Point(51, 86);
            this.btnGetStatistics.Name = "btnGetStatistics";
            this.btnGetStatistics.Size = new System.Drawing.Size(200, 30);
            this.btnGetStatistics.TabIndex = 11;
            this.btnGetStatistics.Text = "Получить статистику";
            this.btnGetStatistics.UseVisualStyleBackColor = true;
            this.btnGetStatistics.Click += new System.EventHandler(this.btnGetStatistics_Click);
            // 
            // dataGridViewUserStatistics
            // 
            this.dataGridViewUserStatistics.BackgroundColor = System.Drawing.Color.Ivory;
            this.dataGridViewUserStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserStatistics.Location = new System.Drawing.Point(51, 135);
            this.dataGridViewUserStatistics.Name = "dataGridViewUserStatistics";
            this.dataGridViewUserStatistics.Size = new System.Drawing.Size(445, 291);
            this.dataGridViewUserStatistics.TabIndex = 9;
            // 
            // dataGridViewProjectStatistics
            // 
            this.dataGridViewProjectStatistics.BackgroundColor = System.Drawing.Color.Ivory;
            this.dataGridViewProjectStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjectStatistics.Location = new System.Drawing.Point(502, 135);
            this.dataGridViewProjectStatistics.Name = "dataGridViewProjectStatistics";
            this.dataGridViewProjectStatistics.Size = new System.Drawing.Size(286, 291);
            this.dataGridViewProjectStatistics.TabIndex = 10;
            // 
            // StatistickForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetStatistics);
            this.Controls.Add(this.dataGridViewProjectStatistics);
            this.Controls.Add(this.dataGridViewUserStatistics);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.pictureBoxQRCode);
            this.Controls.Add(this.lblCompletedTasks);
            this.Controls.Add(this.lblCompletedRequests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StatistickForm";
            this.Text = "Статистика задач";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjectStatistics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompletedTasks;
        private System.Windows.Forms.Label lblCompletedRequests;
        private System.Windows.Forms.PictureBox pictureBoxQRCode;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button btnGetStatistics; // Кнопка для получения статистики
        private System.Windows.Forms.DataGridView dataGridViewUserStatistics;
        private System.Windows.Forms.DataGridView dataGridViewProjectStatistics;
    }
}
