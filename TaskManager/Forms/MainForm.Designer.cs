namespace TaskManager
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddRequest = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewTasks = new System.Windows.Forms.DataGridView();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.comboBoxAssignedTo = new System.Windows.Forms.ComboBox();
            this.btnSaveToPDF = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.BackColor = System.Drawing.Color.Ivory;
            this.btnDelete.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.btnDelete.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDelete.Location = new System.Drawing.Point(438, 144);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 33);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Ivory;
            this.button1.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.button1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.Location = new System.Drawing.Point(616, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "Статистика";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddRequest
            // 
            this.btnAddRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRequest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddRequest.BackColor = System.Drawing.Color.Ivory;
            this.btnAddRequest.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.btnAddRequest.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAddRequest.Location = new System.Drawing.Point(346, 143);
            this.btnAddRequest.Name = "btnAddRequest";
            this.btnAddRequest.Size = new System.Drawing.Size(86, 34);
            this.btnAddRequest.TabIndex = 13;
            this.btnAddRequest.Text = "Добавить";
            this.btnAddRequest.UseVisualStyleBackColor = false;
            this.btnAddRequest.Click += new System.EventHandler(this.btnAddRequest_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.BackColor = System.Drawing.Color.Ivory;
            this.btnEdit.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEdit.Location = new System.Drawing.Point(526, 143);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(81, 34);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.BackColor = System.Drawing.Color.Ivory;
            this.btnSearch.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSearch.Location = new System.Drawing.Point(241, 143);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 34);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Искать";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Ivory;
            this.txtSearch.Location = new System.Drawing.Point(63, 144);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(172, 20);
            this.txtSearch.TabIndex = 9;
            // 
            // dataGridViewTasks
            // 
            this.dataGridViewTasks.AllowUserToAddRows = false;
            this.dataGridViewTasks.AllowUserToDeleteRows = false;
            this.dataGridViewTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTasks.BackgroundColor = System.Drawing.Color.Ivory;
            this.dataGridViewTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasks.Location = new System.Drawing.Point(63, 183);
            this.dataGridViewTasks.MultiSelect = false;
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            this.dataGridViewTasks.ReadOnly = true;
            this.dataGridViewTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTasks.Size = new System.Drawing.Size(651, 218);
            this.dataGridViewTasks.TabIndex = 8;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.BackColor = System.Drawing.Color.Ivory;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(63, 88);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStatus.TabIndex = 16;
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.BackColor = System.Drawing.Color.Ivory;
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Location = new System.Drawing.Point(253, 88);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPriority.TabIndex = 17;
            // 
            // comboBoxAssignedTo
            // 
            this.comboBoxAssignedTo.BackColor = System.Drawing.Color.Ivory;
            this.comboBoxAssignedTo.FormattingEnabled = true;
            this.comboBoxAssignedTo.Location = new System.Drawing.Point(438, 88);
            this.comboBoxAssignedTo.Name = "comboBoxAssignedTo";
            this.comboBoxAssignedTo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAssignedTo.TabIndex = 18;
            // 
            // btnSaveToPDF
            // 
            this.btnSaveToPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveToPDF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveToPDF.BackColor = System.Drawing.Color.Ivory;
            this.btnSaveToPDF.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveToPDF.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSaveToPDF.Location = new System.Drawing.Point(650, 405);
            this.btnSaveToPDF.Name = "btnSaveToPDF";
            this.btnSaveToPDF.Size = new System.Drawing.Size(64, 33);
            this.btnSaveToPDF.TabIndex = 19;
            this.btnSaveToPDF.Text = "PDF";
            this.btnSaveToPDF.UseVisualStyleBackColor = false;
            this.btnSaveToPDF.Click += new System.EventHandler(this.btnSaveToPDF_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.Ivory;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.button2.Location = new System.Drawing.Point(616, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 33);
            this.button2.TabIndex = 20;
            this.button2.Text = "Обновление";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(59, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Статус задачи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(249, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Приоритетность ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(434, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Исполнитель";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.BackColor = System.Drawing.Color.Ivory;
            this.button3.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.button3.Location = new System.Drawing.Point(724, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 33);
            this.button3.TabIndex = 24;
            this.button3.Text = "Рук";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSaveToPDF);
            this.Controls.Add(this.comboBoxAssignedTo);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddRequest);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridViewTasks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddRequest;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridViewTasks;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.ComboBox comboBoxAssignedTo;
        private System.Windows.Forms.Button btnSaveToPDF;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
    }
}

