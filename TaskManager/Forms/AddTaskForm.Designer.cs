namespace TaskManager.Forms
{
    partial class AddTaskForm
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
            this.btnSaveRequest = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblFaultType = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.comboBoxAssignedTo = new System.Windows.Forms.ComboBox();
            this.lblExecutor = new System.Windows.Forms.Label();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSaveRequest
            // 
            this.btnSaveRequest.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveRequest.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSaveRequest.Location = new System.Drawing.Point(237, 240);
            this.btnSaveRequest.Name = "btnSaveRequest";
            this.btnSaveRequest.Size = new System.Drawing.Size(172, 47);
            this.btnSaveRequest.TabIndex = 13;
            this.btnSaveRequest.Text = "Сохранить";
            this.btnSaveRequest.UseVisualStyleBackColor = true;
            this.btnSaveRequest.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(237, 127);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(172, 53);
            this.txtDescription.TabIndex = 12;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescription.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblDescription.Location = new System.Drawing.Point(24, 136);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(120, 27);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Описание:";
            // 
            // lblFaultType
            // 
            this.lblFaultType.AutoSize = true;
            this.lblFaultType.Font = new System.Drawing.Font("Cascadia Mono", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFaultType.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblFaultType.Location = new System.Drawing.Point(24, 79);
            this.lblFaultType.Name = "lblFaultType";
            this.lblFaultType.Size = new System.Drawing.Size(204, 27);
            this.lblFaultType.TabIndex = 9;
            this.lblFaultType.Text = "Приоритет задачи";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(237, 39);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(172, 20);
            this.txtProjectName.TabIndex = 8;
            // 
            // lblEquipment
            // 
            this.lblEquipment.AutoSize = true;
            this.lblEquipment.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEquipment.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblEquipment.Location = new System.Drawing.Point(24, 39);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(120, 27);
            this.lblEquipment.TabIndex = 7;
            this.lblEquipment.Text = "Название ";
            // 
            // comboBoxAssignedTo
            // 
            this.comboBoxAssignedTo.FormattingEnabled = true;
            this.comboBoxAssignedTo.Location = new System.Drawing.Point(237, 194);
            this.comboBoxAssignedTo.Name = "comboBoxAssignedTo";
            this.comboBoxAssignedTo.Size = new System.Drawing.Size(172, 21);
            this.comboBoxAssignedTo.TabIndex = 24;
            // 
            // lblExecutor
            // 
            this.lblExecutor.AutoSize = true;
            this.lblExecutor.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExecutor.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblExecutor.Location = new System.Drawing.Point(24, 186);
            this.lblExecutor.Name = "lblExecutor";
            this.lblExecutor.Size = new System.Drawing.Size(144, 27);
            this.lblExecutor.TabIndex = 25;
            this.lblExecutor.Text = "Исполнитель";
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Items.AddRange(new object[] {
            "низкий",
            "средний",
            "высокий"});
            this.comboBoxPriority.Location = new System.Drawing.Point(237, 85);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(172, 21);
            this.comboBoxPriority.TabIndex = 26;
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(469, 324);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.comboBoxAssignedTo);
            this.Controls.Add(this.lblExecutor);
            this.Controls.Add(this.btnSaveRequest);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblFaultType);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.lblEquipment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddTaskForm";
            this.Text = "Добавление";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveRequest;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblFaultType;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label lblEquipment;
        private System.Windows.Forms.ComboBox comboBoxAssignedTo;
        private System.Windows.Forms.Label lblExecutor;
        private System.Windows.Forms.ComboBox comboBoxPriority;
    }
}