namespace OOP4
{
    partial class Form1
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
            System.Windows.Forms.Button buttonRefreshDrives;
            this.labelListOfDrives = new System.Windows.Forms.Label();
            this.comboBoxListOfDrives = new System.Windows.Forms.ComboBox();
            this.labelCurrentDrive = new System.Windows.Forms.Label();
            this.labelCurrentDriveClick = new System.Windows.Forms.Label();
            this.labelDriveCapacity = new System.Windows.Forms.Label();
            this.labelDriveCapacityClick = new System.Windows.Forms.Label();
            this.labelFreeSpace = new System.Windows.Forms.Label();
            this.labelFreeSpaceClick = new System.Windows.Forms.Label();
            this.labelDriveType = new System.Windows.Forms.Label();
            this.labelDriveTypeClick = new System.Windows.Forms.Label();
            this.listDriveDirectories = new System.Windows.Forms.ListBox();
            this.listDriveFiles = new System.Windows.Forms.ListBox();
            this.labelDriveDirectiories = new System.Windows.Forms.Label();
            this.labelFilesList = new System.Windows.Forms.Label();
            this.labelSelectedObject = new System.Windows.Forms.Label();
            this.labelSelectedObjectClick = new System.Windows.Forms.Label();
            this.labelSizeClick = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelDateOfCreationClick = new System.Windows.Forms.Label();
            this.labelDateOfCreation = new System.Windows.Forms.Label();
            this.labelLastAccessDateClick = new System.Windows.Forms.Label();
            this.labelLastAccessDate = new System.Windows.Forms.Label();
            this.labelLastWriteDateClick = new System.Windows.Forms.Label();
            this.labelLastWriteDate = new System.Windows.Forms.Label();
            buttonRefreshDrives = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelListOfDrives
            // 
            this.labelListOfDrives.AutoSize = true;
            this.labelListOfDrives.Location = new System.Drawing.Point(150, 40);
            this.labelListOfDrives.Name = "labelListOfDrives";
            this.labelListOfDrives.Size = new System.Drawing.Size(85, 13);
            this.labelListOfDrives.TabIndex = 0;
            this.labelListOfDrives.Text = "Список Дисків:";
            // 
            // comboBoxListOfDrives
            // 
            this.comboBoxListOfDrives.FormattingEnabled = true;
            this.comboBoxListOfDrives.Location = new System.Drawing.Point(260, 37);
            this.comboBoxListOfDrives.Name = "comboBoxListOfDrives";
            this.comboBoxListOfDrives.Size = new System.Drawing.Size(121, 21);
            this.comboBoxListOfDrives.TabIndex = 1;
            this.comboBoxListOfDrives.SelectedIndexChanged += new System.EventHandler(this.comboBoxListOfDrives_SelectedIndexChanged);
            // 
            // buttonRefreshDrives
            // 
            buttonRefreshDrives.BackColor = System.Drawing.Color.White;
            buttonRefreshDrives.Location = new System.Drawing.Point(408, 37);
            buttonRefreshDrives.Name = "buttonRefreshDrives";
            buttonRefreshDrives.Size = new System.Drawing.Size(75, 23);
            buttonRefreshDrives.TabIndex = 2;
            buttonRefreshDrives.Text = "Оновити";
            buttonRefreshDrives.UseVisualStyleBackColor = false;
            buttonRefreshDrives.Click += new System.EventHandler(this.buttonRefreshDrives_Click);
            // 
            // labelCurrentDrive
            // 
            this.labelCurrentDrive.AutoSize = true;
            this.labelCurrentDrive.Location = new System.Drawing.Point(12, 88);
            this.labelCurrentDrive.Name = "labelCurrentDrive";
            this.labelCurrentDrive.Size = new System.Drawing.Size(85, 13);
            this.labelCurrentDrive.TabIndex = 3;
            this.labelCurrentDrive.Text = "Поточний Диск";
            this.labelCurrentDrive.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelCurrentDriveClick
            // 
            this.labelCurrentDriveClick.AutoSize = true;
            this.labelCurrentDriveClick.Location = new System.Drawing.Point(97, 88);
            this.labelCurrentDriveClick.Name = "labelCurrentDriveClick";
            this.labelCurrentDriveClick.Size = new System.Drawing.Size(13, 13);
            this.labelCurrentDriveClick.TabIndex = 4;
            this.labelCurrentDriveClick.Text = "..";
            this.labelCurrentDriveClick.Click += new System.EventHandler(this.labelCurrentDriveClick_Click);
            // 
            // labelDriveCapacity
            // 
            this.labelDriveCapacity.AutoSize = true;
            this.labelDriveCapacity.Location = new System.Drawing.Point(139, 88);
            this.labelDriveCapacity.Name = "labelDriveCapacity";
            this.labelDriveCapacity.Size = new System.Drawing.Size(73, 13);
            this.labelDriveCapacity.TabIndex = 5;
            this.labelDriveCapacity.Text = "Обсяг Диску";
            this.labelDriveCapacity.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelDriveCapacityClick
            // 
            this.labelDriveCapacityClick.AutoSize = true;
            this.labelDriveCapacityClick.Location = new System.Drawing.Point(209, 88);
            this.labelDriveCapacityClick.Name = "labelDriveCapacityClick";
            this.labelDriveCapacityClick.Size = new System.Drawing.Size(13, 13);
            this.labelDriveCapacityClick.TabIndex = 6;
            this.labelDriveCapacityClick.Text = "..";
            this.labelDriveCapacityClick.Click += new System.EventHandler(this.labelDriveCapacityClick_Click);
            // 
            // labelFreeSpace
            // 
            this.labelFreeSpace.AutoSize = true;
            this.labelFreeSpace.Location = new System.Drawing.Point(271, 88);
            this.labelFreeSpace.Name = "labelFreeSpace";
            this.labelFreeSpace.Size = new System.Drawing.Size(86, 13);
            this.labelFreeSpace.TabIndex = 7;
            this.labelFreeSpace.Text = "Вільного Місця:";
            this.labelFreeSpace.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // labelFreeSpaceClick
            // 
            this.labelFreeSpaceClick.AutoSize = true;
            this.labelFreeSpaceClick.Location = new System.Drawing.Point(352, 88);
            this.labelFreeSpaceClick.Name = "labelFreeSpaceClick";
            this.labelFreeSpaceClick.Size = new System.Drawing.Size(13, 13);
            this.labelFreeSpaceClick.TabIndex = 8;
            this.labelFreeSpaceClick.Text = "..";
            this.labelFreeSpaceClick.Click += new System.EventHandler(this.labelFreeSpaceClick_Click);
            // 
            // labelDriveType
            // 
            this.labelDriveType.AutoSize = true;
            this.labelDriveType.Location = new System.Drawing.Point(433, 88);
            this.labelDriveType.Name = "labelDriveType";
            this.labelDriveType.Size = new System.Drawing.Size(152, 13);
            this.labelDriveType.TabIndex = 9;
            this.labelDriveType.Text = "Формат Файлової Системи:";
            // 
            // labelDriveTypeClick
            // 
            this.labelDriveTypeClick.AutoSize = true;
            this.labelDriveTypeClick.Location = new System.Drawing.Point(582, 88);
            this.labelDriveTypeClick.Name = "labelDriveTypeClick";
            this.labelDriveTypeClick.Size = new System.Drawing.Size(13, 13);
            this.labelDriveTypeClick.TabIndex = 10;
            this.labelDriveTypeClick.Text = "..";
            this.labelDriveTypeClick.Click += new System.EventHandler(this.labelDriveTypeClick_Click);
            // 
            // listDriveDirectories
            // 
            this.listDriveDirectories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listDriveDirectories.FormattingEnabled = true;
            this.listDriveDirectories.Location = new System.Drawing.Point(13, 136);
            this.listDriveDirectories.Name = "listDriveDirectories";
            this.listDriveDirectories.Size = new System.Drawing.Size(222, 251);
            this.listDriveDirectories.TabIndex = 11;
            this.listDriveDirectories.SelectedIndexChanged += new System.EventHandler(this.DriveDirectoriesList_SelectedIndexChanged);
            // 
            // listDriveFiles
            // 
            this.listDriveFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listDriveFiles.FormattingEnabled = true;
            this.listDriveFiles.Location = new System.Drawing.Point(393, 136);
            this.listDriveFiles.Name = "listDriveFiles";
            this.listDriveFiles.Size = new System.Drawing.Size(227, 251);
            this.listDriveFiles.TabIndex = 12;
            this.listDriveFiles.SelectedIndexChanged += new System.EventHandler(this.listDriveFiles_SelectedIndexChanged);
            // 
            // labelDriveDirectiories
            // 
            this.labelDriveDirectiories.AutoSize = true;
            this.labelDriveDirectiories.Location = new System.Drawing.Point(12, 120);
            this.labelDriveDirectiories.Name = "labelDriveDirectiories";
            this.labelDriveDirectiories.Size = new System.Drawing.Size(99, 13);
            this.labelDriveDirectiories.TabIndex = 13;
            this.labelDriveDirectiories.Text = "Список Каталогів:";
            // 
            // labelFilesList
            // 
            this.labelFilesList.AutoSize = true;
            this.labelFilesList.Location = new System.Drawing.Point(390, 120);
            this.labelFilesList.Name = "labelFilesList";
            this.labelFilesList.Size = new System.Drawing.Size(87, 13);
            this.labelFilesList.TabIndex = 14;
            this.labelFilesList.Text = "Список Файлів:";
            // 
            // labelSelectedObject
            // 
            this.labelSelectedObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSelectedObject.AutoSize = true;
            this.labelSelectedObject.Location = new System.Drawing.Point(25, 423);
            this.labelSelectedObject.Name = "labelSelectedObject";
            this.labelSelectedObject.Size = new System.Drawing.Size(89, 13);
            this.labelSelectedObject.TabIndex = 15;
            this.labelSelectedObject.Text = "Обраний об`єкт:";
            // 
            // labelSelectedObjectClick
            // 
            this.labelSelectedObjectClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSelectedObjectClick.AutoSize = true;
            this.labelSelectedObjectClick.Location = new System.Drawing.Point(112, 423);
            this.labelSelectedObjectClick.Name = "labelSelectedObjectClick";
            this.labelSelectedObjectClick.Size = new System.Drawing.Size(13, 13);
            this.labelSelectedObjectClick.TabIndex = 16;
            this.labelSelectedObjectClick.Text = "..";
            this.labelSelectedObjectClick.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // labelSizeClick
            // 
            this.labelSizeClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSizeClick.AutoSize = true;
            this.labelSizeClick.Location = new System.Drawing.Point(313, 423);
            this.labelSizeClick.Name = "labelSizeClick";
            this.labelSizeClick.Size = new System.Drawing.Size(13, 13);
            this.labelSizeClick.TabIndex = 18;
            this.labelSizeClick.Text = "..";
            // 
            // labelSize
            // 
            this.labelSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(271, 423);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(45, 13);
            this.labelSize.TabIndex = 17;
            this.labelSize.Text = "Розмір:";
            // 
            // labelDateOfCreationClick
            // 
            this.labelDateOfCreationClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDateOfCreationClick.AutoSize = true;
            this.labelDateOfCreationClick.Location = new System.Drawing.Point(487, 404);
            this.labelDateOfCreationClick.Name = "labelDateOfCreationClick";
            this.labelDateOfCreationClick.Size = new System.Drawing.Size(13, 13);
            this.labelDateOfCreationClick.TabIndex = 20;
            this.labelDateOfCreationClick.Text = "..";
            this.labelDateOfCreationClick.Click += new System.EventHandler(this.label1_Click_4);
            // 
            // labelDateOfCreation
            // 
            this.labelDateOfCreation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDateOfCreation.AutoSize = true;
            this.labelDateOfCreation.Location = new System.Drawing.Point(400, 404);
            this.labelDateOfCreation.Name = "labelDateOfCreation";
            this.labelDateOfCreation.Size = new System.Drawing.Size(92, 13);
            this.labelDateOfCreation.TabIndex = 19;
            this.labelDateOfCreation.Text = "Дата створення:";
            this.labelDateOfCreation.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelLastAccessDateClick
            // 
            this.labelLastAccessDateClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLastAccessDateClick.AutoSize = true;
            this.labelLastAccessDateClick.Location = new System.Drawing.Point(531, 423);
            this.labelLastAccessDateClick.Name = "labelLastAccessDateClick";
            this.labelLastAccessDateClick.Size = new System.Drawing.Size(13, 13);
            this.labelLastAccessDateClick.TabIndex = 22;
            this.labelLastAccessDateClick.Text = "..";
            // 
            // labelLastAccessDate
            // 
            this.labelLastAccessDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLastAccessDate.AutoSize = true;
            this.labelLastAccessDate.Location = new System.Drawing.Point(400, 423);
            this.labelLastAccessDate.Name = "labelLastAccessDate";
            this.labelLastAccessDate.Size = new System.Drawing.Size(139, 13);
            this.labelLastAccessDate.TabIndex = 21;
            this.labelLastAccessDate.Text = "Дата останнього доступу:";
            // 
            // labelLastWriteDateClick
            // 
            this.labelLastWriteDateClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLastWriteDateClick.AutoSize = true;
            this.labelLastWriteDateClick.Location = new System.Drawing.Point(531, 443);
            this.labelLastWriteDateClick.Name = "labelLastWriteDateClick";
            this.labelLastWriteDateClick.Size = new System.Drawing.Size(13, 13);
            this.labelLastWriteDateClick.TabIndex = 24;
            this.labelLastWriteDateClick.Text = "..";
            this.labelLastWriteDateClick.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelLastWriteDate
            // 
            this.labelLastWriteDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLastWriteDate.AutoSize = true;
            this.labelLastWriteDate.Location = new System.Drawing.Point(400, 443);
            this.labelLastWriteDate.Name = "labelLastWriteDate";
            this.labelLastWriteDate.Size = new System.Drawing.Size(135, 13);
            this.labelLastWriteDate.TabIndex = 23;
            this.labelLastWriteDate.Text = "Дата останнього запису:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = global::OOP4.Properties.Resources.photo_1579546929518_9e396f3cc809;
            this.ClientSize = new System.Drawing.Size(656, 466);
            this.Controls.Add(this.labelLastWriteDateClick);
            this.Controls.Add(this.labelLastWriteDate);
            this.Controls.Add(this.labelLastAccessDateClick);
            this.Controls.Add(this.labelLastAccessDate);
            this.Controls.Add(this.labelDateOfCreationClick);
            this.Controls.Add(this.labelDateOfCreation);
            this.Controls.Add(this.labelSizeClick);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelSelectedObjectClick);
            this.Controls.Add(this.labelSelectedObject);
            this.Controls.Add(this.labelFilesList);
            this.Controls.Add(this.labelDriveDirectiories);
            this.Controls.Add(this.listDriveFiles);
            this.Controls.Add(this.listDriveDirectories);
            this.Controls.Add(this.labelDriveTypeClick);
            this.Controls.Add(this.labelDriveType);
            this.Controls.Add(this.labelFreeSpaceClick);
            this.Controls.Add(this.labelFreeSpace);
            this.Controls.Add(this.labelDriveCapacityClick);
            this.Controls.Add(this.labelDriveCapacity);
            this.Controls.Add(this.labelCurrentDriveClick);
            this.Controls.Add(this.labelCurrentDrive);
            this.Controls.Add(buttonRefreshDrives);
            this.Controls.Add(this.comboBoxListOfDrives);
            this.Controls.Add(this.labelListOfDrives);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListOfDrives;
        private System.Windows.Forms.ComboBox comboBoxListOfDrives;
        private System.Windows.Forms.Label labelCurrentDrive;
        private System.Windows.Forms.Label labelCurrentDriveClick;
        private System.Windows.Forms.Label labelDriveCapacity;
        private System.Windows.Forms.Label labelDriveCapacityClick;
        private System.Windows.Forms.Label labelFreeSpace;
        private System.Windows.Forms.Label labelFreeSpaceClick;
        private System.Windows.Forms.Label labelDriveType;
        private System.Windows.Forms.Label labelDriveTypeClick;
        private System.Windows.Forms.ListBox listDriveDirectories;
        private System.Windows.Forms.ListBox listDriveFiles;
        private System.Windows.Forms.Label labelDriveDirectiories;
        private System.Windows.Forms.Label labelFilesList;
        private System.Windows.Forms.Label labelSelectedObject;
        private System.Windows.Forms.Label labelSelectedObjectClick;
        private System.Windows.Forms.Label labelSizeClick;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelDateOfCreationClick;
        private System.Windows.Forms.Label labelDateOfCreation;
        private System.Windows.Forms.Label labelLastAccessDateClick;
        private System.Windows.Forms.Label labelLastAccessDate;
        private System.Windows.Forms.Label labelLastWriteDateClick;
        private System.Windows.Forms.Label labelLastWriteDate;
    }
}

