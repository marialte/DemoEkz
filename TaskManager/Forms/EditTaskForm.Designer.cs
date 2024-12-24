namespace TaskManager.Forms
{
    partial class EditTaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.comboBoxAssignedTo = new System.Windows.Forms.ComboBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblExecutor = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Location = new System.Drawing.Point(30, 60);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(180, 21);
            this.comboBoxPriority.TabIndex = 16;
            // 
            // comboBoxAssignedTo
            // 
            this.comboBoxAssignedTo.FormattingEnabled = true;
            this.comboBoxAssignedTo.Location = new System.Drawing.Point(29, 133);
            this.comboBoxAssignedTo.Name = "comboBoxAssignedTo";
            this.comboBoxAssignedTo.Size = new System.Drawing.Size(180, 21);
            this.comboBoxAssignedTo.TabIndex = 17;
            this.comboBoxAssignedTo.SelectedIndexChanged += new System.EventHandler(this.comboBoxAssignedTo_SelectedIndexChanged);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSaveChanges.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSaveChanges.Location = new System.Drawing.Point(29, 333);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(470, 40);
            this.btnSaveChanges.TabIndex = 19;
            this.btnSaveChanges.Text = "Сохранить изменения";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Lavender;
            this.lblStatus.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.Location = new System.Drawing.Point(29, 23);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(120, 27);
            this.lblStatus.TabIndex = 22;
            this.lblStatus.Text = "Приоритет";
            // 
            // lblExecutor
            // 
            this.lblExecutor.AutoSize = true;
            this.lblExecutor.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExecutor.Location = new System.Drawing.Point(25, 98);
            this.lblExecutor.Name = "lblExecutor";
            this.lblExecutor.Size = new System.Drawing.Size(144, 27);
            this.lblExecutor.TabIndex = 23;
            this.lblExecutor.Text = "Исполнитель";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescription.Location = new System.Drawing.Point(401, 160);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(108, 27);
            this.lblDescription.TabIndex = 21;
            this.lblDescription.Text = "Описание";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDescription.Location = new System.Drawing.Point(29, 186);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(470, 115);
            this.txtDescription.TabIndex = 15;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(240, 60);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(180, 21);
            this.comboBoxStatus.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(244, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 27);
            this.label1.TabIndex = 29;
            this.label1.Text = "Статус задачи";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Lavender;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.lblExecutor);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.txtDescription);
            this.panelMain.Controls.Add(this.btnSaveChanges);
            this.panelMain.Controls.Add(this.lblStatus);
            this.panelMain.Controls.Add(this.comboBoxAssignedTo);
            this.panelMain.Controls.Add(this.lblDescription);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(850, 433);
            this.panelMain.TabIndex = 30;
            // 
            // EditTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 433);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование задачи";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.ComboBox comboBoxAssignedTo;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblExecutor;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMain;
    }
}
