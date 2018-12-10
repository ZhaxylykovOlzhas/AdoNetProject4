namespace AdoNet_Project4
{
    partial class AdoNet
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdoNet));
            this.label1 = new System.Windows.Forms.Label();
            this.Birthday_textBox = new System.Windows.Forms.TextBox();
            this.ID_label = new System.Windows.Forms.Label();
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.Gender_textBox = new System.Windows.Forms.ComboBox();
            this.Gender_label = new System.Windows.Forms.Label();
            this.Adress_label = new System.Windows.Forms.Label();
            this.Adress_textBox = new System.Windows.Forms.TextBox();
            this.Email_label = new System.Windows.Forms.Label();
            this.Email_textBox = new System.Windows.Forms.TextBox();
            this.LastName_label = new System.Windows.Forms.Label();
            this.LastName_textBox = new System.Windows.Forms.TextBox();
            this.FullName_label = new System.Windows.Forms.Label();
            this.ButtonPhoto_button = new System.Windows.Forms.Button();
            this.FullName_textBox = new System.Windows.Forms.TextBox();
            this.PhotoPic = new System.Windows.Forms.PictureBox();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.PanelConteiner = new System.Windows.Forms.DataGridView();
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoURLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelConteiner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(972, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Введите Дата рождения:";
            // 
            // Birthday_textBox
            // 
            this.Birthday_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Birthday_textBox.Location = new System.Drawing.Point(1183, 197);
            this.Birthday_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Birthday_textBox.Name = "Birthday_textBox";
            this.Birthday_textBox.Size = new System.Drawing.Size(205, 23);
            this.Birthday_textBox.TabIndex = 43;
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_label.Location = new System.Drawing.Point(1115, 106);
            this.ID_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(25, 16);
            this.ID_label.TabIndex = 42;
            this.ID_label.Text = "ID:";
            // 
            // ID_textBox
            // 
            this.ID_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_textBox.Location = new System.Drawing.Point(1183, 103);
            this.ID_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(205, 23);
            this.ID_textBox.TabIndex = 41;
            // 
            // Gender_textBox
            // 
            this.Gender_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Gender_textBox.FormattingEnabled = true;
            this.Gender_textBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.Gender_textBox.Location = new System.Drawing.Point(1183, 226);
            this.Gender_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Gender_textBox.Name = "Gender_textBox";
            this.Gender_textBox.Size = new System.Drawing.Size(140, 24);
            this.Gender_textBox.TabIndex = 40;
            this.Gender_textBox.Text = " Мужской";
            // 
            // Gender_label
            // 
            this.Gender_label.AutoSize = true;
            this.Gender_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Gender_label.Location = new System.Drawing.Point(1028, 229);
            this.Gender_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Gender_label.Name = "Gender_label";
            this.Gender_label.Size = new System.Drawing.Size(112, 16);
            this.Gender_label.TabIndex = 11;
            this.Gender_label.Text = "Выбирайте пол:";
            // 
            // Adress_label
            // 
            this.Adress_label.AutoSize = true;
            this.Adress_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Adress_label.Location = new System.Drawing.Point(1031, 295);
            this.Adress_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Adress_label.Name = "Adress_label";
            this.Adress_label.Size = new System.Drawing.Size(109, 16);
            this.Adress_label.TabIndex = 9;
            this.Adress_label.Text = "Введите Адрес:";
            // 
            // Adress_textBox
            // 
            this.Adress_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Adress_textBox.Location = new System.Drawing.Point(1183, 295);
            this.Adress_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Adress_textBox.Multiline = true;
            this.Adress_textBox.Name = "Adress_textBox";
            this.Adress_textBox.Size = new System.Drawing.Size(205, 82);
            this.Adress_textBox.TabIndex = 8;
            // 
            // Email_label
            // 
            this.Email_label.AutoSize = true;
            this.Email_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email_label.Location = new System.Drawing.Point(1039, 264);
            this.Email_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(101, 16);
            this.Email_label.TabIndex = 7;
            this.Email_label.Text = "Введите Email:";
            // 
            // Email_textBox
            // 
            this.Email_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email_textBox.Location = new System.Drawing.Point(1183, 264);
            this.Email_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Email_textBox.Name = "Email_textBox";
            this.Email_textBox.Size = new System.Drawing.Size(205, 23);
            this.Email_textBox.TabIndex = 6;
            // 
            // LastName_label
            // 
            this.LastName_label.AutoSize = true;
            this.LastName_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName_label.Location = new System.Drawing.Point(1014, 166);
            this.LastName_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastName_label.Name = "LastName_label";
            this.LastName_label.Size = new System.Drawing.Size(126, 16);
            this.LastName_label.TabIndex = 5;
            this.LastName_label.Text = "Введите Фамилия:";
            // 
            // LastName_textBox
            // 
            this.LastName_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName_textBox.Location = new System.Drawing.Point(1183, 166);
            this.LastName_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.LastName_textBox.Name = "LastName_textBox";
            this.LastName_textBox.Size = new System.Drawing.Size(205, 23);
            this.LastName_textBox.TabIndex = 4;
            // 
            // FullName_label
            // 
            this.FullName_label.AutoSize = true;
            this.FullName_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullName_label.Location = new System.Drawing.Point(1048, 137);
            this.FullName_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FullName_label.Name = "FullName_label";
            this.FullName_label.Size = new System.Drawing.Size(92, 16);
            this.FullName_label.TabIndex = 3;
            this.FullName_label.Text = "Введите Имя:";
            // 
            // ButtonPhoto_button
            // 
            this.ButtonPhoto_button.BackColor = System.Drawing.Color.SteelBlue;
            this.ButtonPhoto_button.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.ButtonPhoto_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.ButtonPhoto_button.ForeColor = System.Drawing.Color.White;
            this.ButtonPhoto_button.Location = new System.Drawing.Point(797, 290);
            this.ButtonPhoto_button.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonPhoto_button.Name = "ButtonPhoto_button";
            this.ButtonPhoto_button.Size = new System.Drawing.Size(137, 28);
            this.ButtonPhoto_button.TabIndex = 2;
            this.ButtonPhoto_button.Text = "Выбрать фото";
            this.ButtonPhoto_button.UseVisualStyleBackColor = false;
            this.ButtonPhoto_button.Click += new System.EventHandler(this.ButtonPhoto_button_Click);
            // 
            // FullName_textBox
            // 
            this.FullName_textBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullName_textBox.Location = new System.Drawing.Point(1183, 134);
            this.FullName_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.FullName_textBox.Name = "FullName_textBox";
            this.FullName_textBox.Size = new System.Drawing.Size(205, 23);
            this.FullName_textBox.TabIndex = 1;
            // 
            // PhotoPic
            // 
            this.PhotoPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhotoPic.Location = new System.Drawing.Point(772, 94);
            this.PhotoPic.Margin = new System.Windows.Forms.Padding(4);
            this.PhotoPic.Name = "PhotoPic";
            this.PhotoPic.Size = new System.Drawing.Size(175, 178);
            this.PhotoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoPic.TabIndex = 0;
            this.PhotoPic.TabStop = false;
            // 
            // Edit_button
            // 
            this.Edit_button.BackColor = System.Drawing.Color.SteelBlue;
            this.Edit_button.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.Edit_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.Edit_button.ForeColor = System.Drawing.Color.White;
            this.Edit_button.Location = new System.Drawing.Point(603, 584);
            this.Edit_button.Margin = new System.Windows.Forms.Padding(4);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(137, 28);
            this.Edit_button.TabIndex = 3;
            this.Edit_button.Text = "Редактировать";
            this.Edit_button.UseVisualStyleBackColor = false;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.SteelBlue;
            this.Delete_button.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.Delete_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.Delete_button.ForeColor = System.Drawing.Color.White;
            this.Delete_button.Location = new System.Drawing.Point(748, 584);
            this.Delete_button.Margin = new System.Windows.Forms.Padding(4);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(137, 28);
            this.Delete_button.TabIndex = 4;
            this.Delete_button.Text = "Удалить";
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.Color.SteelBlue;
            this.Cancel_button.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.Cancel_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.Cancel_button.ForeColor = System.Drawing.Color.White;
            this.Cancel_button.Location = new System.Drawing.Point(893, 584);
            this.Cancel_button.Margin = new System.Windows.Forms.Padding(4);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(137, 28);
            this.Cancel_button.TabIndex = 5;
            this.Cancel_button.Text = "Отменить";
            this.Cancel_button.UseVisualStyleBackColor = false;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Save_button
            // 
            this.Save_button.BackColor = System.Drawing.Color.SteelBlue;
            this.Save_button.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.Save_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.Save_button.ForeColor = System.Drawing.Color.White;
            this.Save_button.Location = new System.Drawing.Point(1038, 584);
            this.Save_button.Margin = new System.Windows.Forms.Padding(4);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(137, 28);
            this.Save_button.TabIndex = 6;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.BackColor = System.Drawing.Color.SteelBlue;
            this.Add_button.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.Add_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.Add_button.ForeColor = System.Drawing.Color.White;
            this.Add_button.Location = new System.Drawing.Point(458, 584);
            this.Add_button.Margin = new System.Windows.Forms.Padding(4);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(137, 28);
            this.Add_button.TabIndex = 7;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.genderDataGridViewCheckBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.photoURLDataGridViewTextBoxColumn});
            this.dataGrid.DataSource = this.personsBindingSource;
            this.dataGrid.Location = new System.Drawing.Point(6, 77);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(736, 481);
            this.dataGrid.TabIndex = 8;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            // 
            // PanelConteiner
            // 
            this.PanelConteiner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PanelConteiner.Location = new System.Drawing.Point(748, 77);
            this.PanelConteiner.Name = "PanelConteiner";
            this.PanelConteiner.Size = new System.Drawing.Size(659, 481);
            this.PanelConteiner.TabIndex = 45;
            // 
            // personsBindingSource
            // 
            this.personsBindingSource.DataSource = typeof(AdoNet_Project4.Persons);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewCheckBoxColumn
            // 
            this.genderDataGridViewCheckBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewCheckBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewCheckBoxColumn.Name = "genderDataGridViewCheckBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // photoURLDataGridViewTextBoxColumn
            // 
            this.photoURLDataGridViewTextBoxColumn.DataPropertyName = "PhotoURL";
            this.photoURLDataGridViewTextBoxColumn.HeaderText = "PhotoURL";
            this.photoURLDataGridViewTextBoxColumn.Name = "photoURLDataGridViewTextBoxColumn";
            // 
            // AdoNet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1414, 663);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.Birthday_textBox);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.ID_textBox);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Gender_textBox);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Gender_label);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Adress_label);
            this.Controls.Add(this.Adress_textBox);
            this.Controls.Add(this.FullName_textBox);
            this.Controls.Add(this.Email_label);
            this.Controls.Add(this.PhotoPic);
            this.Controls.Add(this.Email_textBox);
            this.Controls.Add(this.ButtonPhoto_button);
            this.Controls.Add(this.LastName_label);
            this.Controls.Add(this.FullName_label);
            this.Controls.Add(this.LastName_textBox);
            this.Controls.Add(this.PanelConteiner);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdoNet";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "AdoNet";
            this.TransparencyKey = System.Drawing.Color.SteelBlue;
            this.Load += new System.EventHandler(this.AdoNet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelConteiner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Gender_textBox;
        private System.Windows.Forms.Label Gender_label;
        private System.Windows.Forms.Label Adress_label;
        private System.Windows.Forms.TextBox Adress_textBox;
        private System.Windows.Forms.Label Email_label;
        private System.Windows.Forms.TextBox Email_textBox;
        private System.Windows.Forms.Label LastName_label;
        private System.Windows.Forms.TextBox LastName_textBox;
        private System.Windows.Forms.Label FullName_label;
        private System.Windows.Forms.Button ButtonPhoto_button;
        private System.Windows.Forms.TextBox FullName_textBox;
        private System.Windows.Forms.PictureBox PhotoPic;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Birthday_textBox;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridView PanelConteiner;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn genderDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoURLDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource personsBindingSource;
    }
}

