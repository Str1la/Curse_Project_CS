namespace CurseProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            button1 = new Button();
            TBsurname = new TextBox();
            TBfirstname = new TextBox();
            TBmiddlename = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TBspeciality = new TextBox();
            label4 = new Label();
            button2 = new Button();
            numericUpDown = new NumericUpDown();
            TBuniversity = new TextBox();
            TBthesis = new TextBox();
            TBperid = new TextBox();
            dateTimePicker = new DateTimePicker();
            comboBoxStatus = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            sortByDate = new Button();
            comboBoxStatus2 = new ComboBox();
            filterByStatus = new Button();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            saveBtn = new Button();
            loadBtn = new Button();
            sortByName = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(223, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(941, 539);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 506);
            button1.Name = "button1";
            button1.Size = new Size(205, 45);
            button1.TabIndex = 1;
            button1.Text = "Оновити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TBsurname
            // 
            TBsurname.Location = new Point(12, 30);
            TBsurname.Name = "TBsurname";
            TBsurname.Size = new Size(205, 23);
            TBsurname.TabIndex = 2;
            // 
            // TBfirstname
            // 
            TBfirstname.Location = new Point(12, 74);
            TBfirstname.Name = "TBfirstname";
            TBfirstname.Size = new Size(205, 23);
            TBfirstname.TabIndex = 3;
            // 
            // TBmiddlename
            // 
            TBmiddlename.Location = new Point(12, 118);
            TBmiddlename.Name = "TBmiddlename";
            TBmiddlename.Size = new Size(205, 23);
            TBmiddlename.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 5;
            label1.Text = "Прізвище";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 6;
            label2.Text = "Імя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 7;
            label3.Text = "По батькові";
            // 
            // TBspeciality
            // 
            TBspeciality.Location = new Point(12, 206);
            TBspeciality.Name = "TBspeciality";
            TBspeciality.Size = new Size(205, 23);
            TBspeciality.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 144);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 9;
            label4.Text = "Рік народження";
            // 
            // button2
            // 
            button2.Location = new Point(12, 455);
            button2.Name = "button2";
            button2.Size = new Size(205, 45);
            button2.TabIndex = 10;
            button2.Text = "Добавити";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // numericUpDown
            // 
            numericUpDown.Location = new Point(12, 162);
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(205, 23);
            numericUpDown.TabIndex = 11;
            // 
            // TBuniversity
            // 
            TBuniversity.Location = new Point(12, 250);
            TBuniversity.Name = "TBuniversity";
            TBuniversity.Size = new Size(205, 23);
            TBuniversity.TabIndex = 12;
            // 
            // TBthesis
            // 
            TBthesis.Location = new Point(12, 294);
            TBthesis.Name = "TBthesis";
            TBthesis.Size = new Size(205, 23);
            TBthesis.TabIndex = 13;
            // 
            // TBperid
            // 
            TBperid.Location = new Point(12, 338);
            TBperid.Name = "TBperid";
            TBperid.Size = new Size(205, 23);
            TBperid.TabIndex = 14;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(12, 382);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(205, 23);
            dateTimePicker.TabIndex = 15;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(12, 426);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(205, 23);
            comboBoxStatus.TabIndex = 16;
            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 188);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 17;
            label5.Text = "Спеціальність";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 232);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 18;
            label6.Text = "Університет";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 276);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 19;
            label7.Text = "Тема диплому";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 320);
            label8.Name = "label8";
            label8.Size = new Size(177, 15);
            label8.TabIndex = 20;
            label8.Text = "Термін проходження практики";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 364);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 21;
            label9.Text = "Дата здачі";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 408);
            label10.Name = "label10";
            label10.Size = new Size(43, 15);
            label10.TabIndex = 22;
            label10.Text = "Статус";
            // 
            // sortByDate
            // 
            sortByDate.Location = new Point(1170, 30);
            sortByDate.Name = "sortByDate";
            sortByDate.Size = new Size(139, 76);
            sortByDate.TabIndex = 23;
            sortByDate.Text = "Відсортувати студентів за віком";
            sortByDate.UseVisualStyleBackColor = true;
            sortByDate.Click += sortByDate_Click;
            // 
            // comboBoxStatus2
            // 
            comboBoxStatus2.FormattingEnabled = true;
            comboBoxStatus2.Location = new Point(1171, 261);
            comboBoxStatus2.Name = "comboBoxStatus2";
            comboBoxStatus2.Size = new Size(139, 23);
            comboBoxStatus2.TabIndex = 24;
            comboBoxStatus2.SelectedIndexChanged += comboBoxStatus2_SelectedIndexChanged;
            // 
            // filterByStatus
            // 
            filterByStatus.Location = new Point(1171, 287);
            filterByStatus.Name = "filterByStatus";
            filterByStatus.Size = new Size(139, 30);
            filterByStatus.TabIndex = 25;
            filterByStatus.Text = "Скинути";
            filterByStatus.UseVisualStyleBackColor = true;
            filterByStatus.Click += filterByStatus_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1170, 12);
            label11.Name = "label11";
            label11.Size = new Size(72, 15);
            label11.TabIndex = 26;
            label11.Text = "Сортування";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1171, 206);
            label12.Name = "label12";
            label12.Size = new Size(85, 15);
            label12.TabIndex = 27;
            label12.Text = "Фільтрування ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1172, 223);
            label13.Name = "label13";
            label13.Size = new Size(71, 15);
            label13.TabIndex = 28;
            label13.Text = "за статусом";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(1172, 238);
            label14.Name = "label14";
            label14.Size = new Size(56, 15);
            label14.TabIndex = 29;
            label14.Text = "диплому";
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(1171, 455);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(138, 45);
            saveBtn.TabIndex = 30;
            saveBtn.Text = "Зберегти";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // loadBtn
            // 
            loadBtn.Location = new Point(1171, 506);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(138, 45);
            loadBtn.TabIndex = 31;
            loadBtn.Text = "Загрузити";
            loadBtn.UseVisualStyleBackColor = true;
            loadBtn.Click += loadBtn_Click;
            // 
            // sortByName
            // 
            sortByName.Location = new Point(1170, 109);
            sortByName.Name = "sortByName";
            sortByName.Size = new Size(139, 76);
            sortByName.TabIndex = 32;
            sortByName.Text = "Відсортувати студентів за Ім'ям";
            sortByName.UseVisualStyleBackColor = true;
            sortByName.Click += sortByName_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1172, 349);
            button3.Name = "button3";
            button3.Size = new Size(139, 56);
            button3.TabIndex = 33;
            button3.Text = "Приклад пізнього звязування";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 564);
            Controls.Add(button3);
            Controls.Add(sortByName);
            Controls.Add(loadBtn);
            Controls.Add(saveBtn);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(filterByStatus);
            Controls.Add(comboBoxStatus2);
            Controls.Add(sortByDate);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBoxStatus);
            Controls.Add(dateTimePicker);
            Controls.Add(TBperid);
            Controls.Add(TBthesis);
            Controls.Add(TBuniversity);
            Controls.Add(numericUpDown);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(TBspeciality);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TBmiddlename);
            Controls.Add(TBfirstname);
            Controls.Add(TBsurname);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private TextBox TBsurname;
        private TextBox TBfirstname;
        private TextBox TBmiddlename;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TBspeciality;
        private Label label4;
        private Button button2;
        private NumericUpDown numericUpDown;
        private TextBox TBuniversity;
        private TextBox TBthesis;
        private TextBox TBperid;
        private DateTimePicker dateTimePicker;
        private ComboBox comboBoxStatus;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button sortByDate;
        private ComboBox comboBoxStatus2;
        private Button filterByStatus;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button saveBtn;
        private Button loadBtn;
        private Button sortByName;
        private Button button3;
    }
}
