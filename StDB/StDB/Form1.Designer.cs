namespace StDB
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.View = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxStudentN = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.FemaleV = new System.Windows.Forms.RadioButton();
            this.MaleV = new System.Windows.Forms.RadioButton();
            this.SexV = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DepartmentV = new System.Windows.Forms.Label();
            this.BirthdayV = new System.Windows.Forms.Label();
            this.textBoxBirthdayV = new System.Windows.Forms.TextBox();
            this.comboBoxDepartmentV = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.NameV = new System.Windows.Forms.Label();
            this.textBoxNameV = new System.Windows.Forms.TextBox();
            this.Input = new System.Windows.Forms.TabPage();
            this.monthCalendarIn = new System.Windows.Forms.MonthCalendar();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.FemaleIn = new System.Windows.Forms.RadioButton();
            this.MaleIn = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxBirthdayIn = new System.Windows.Forms.TextBox();
            this.comboBoxDepartmentIn = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNameIn = new System.Windows.Forms.TextBox();
            this.Edit = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxStudentNE = new System.Windows.Forms.TextBox();
            this.monthCalendarEd = new System.Windows.Forms.MonthCalendar();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.FemaleEd = new System.Windows.Forms.RadioButton();
            this.MaleEd = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBirthdayEd = new System.Windows.Forms.TextBox();
            this.comboBoxDepartmentEd = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNameEd = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.View.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Input.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.Edit.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.View);
            this.tabControl1.Controls.Add(this.Input);
            this.tabControl1.Controls.Add(this.Edit);
            this.tabControl1.Location = new System.Drawing.Point(0, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(814, 408);
            this.tabControl1.TabIndex = 3;
            // 
            // View
            // 
            this.View.Controls.Add(this.tableLayoutPanel7);
            this.View.Controls.Add(this.button2);
            this.View.Controls.Add(this.button1);
            this.View.Controls.Add(this.FemaleV);
            this.View.Controls.Add(this.MaleV);
            this.View.Controls.Add(this.SexV);
            this.View.Controls.Add(this.tableLayoutPanel2);
            this.View.Controls.Add(this.tableLayoutPanel1);
            this.View.Location = new System.Drawing.Point(4, 25);
            this.View.Name = "View";
            this.View.Padding = new System.Windows.Forms.Padding(3);
            this.View.Size = new System.Drawing.Size(806, 379);
            this.View.TabIndex = 0;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.86842F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.13158F));
            this.tableLayoutPanel7.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.textBoxStudentN, 1, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(6, 176);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(253, 30);
            this.tableLayoutPanel7.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sudent №";
            // 
            // textBoxStudentN
            // 
            this.textBoxStudentN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxStudentN.Location = new System.Drawing.Point(154, 4);
            this.textBoxStudentN.Name = "textBoxStudentN";
            this.textBoxStudentN.ReadOnly = true;
            this.textBoxStudentN.Size = new System.Drawing.Size(96, 22);
            this.textBoxStudentN.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Vineta BT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(436, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 59);
            this.button2.TabIndex = 5;
            this.button2.Text = "⇨";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Vineta BT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(266, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 59);
            this.button1.TabIndex = 4;
            this.button1.Text = "⇦";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FemaleV
            // 
            this.FemaleV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FemaleV.AutoSize = true;
            this.FemaleV.Enabled = false;
            this.FemaleV.Location = new System.Drawing.Point(297, 65);
            this.FemaleV.Name = "FemaleV";
            this.FemaleV.Size = new System.Drawing.Size(75, 21);
            this.FemaleV.TabIndex = 3;
            this.FemaleV.Text = "Female";
            this.FemaleV.UseVisualStyleBackColor = true;
            // 
            // MaleV
            // 
            this.MaleV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MaleV.AutoSize = true;
            this.MaleV.Checked = true;
            this.MaleV.Enabled = false;
            this.MaleV.Location = new System.Drawing.Point(172, 65);
            this.MaleV.Name = "MaleV";
            this.MaleV.Size = new System.Drawing.Size(59, 21);
            this.MaleV.TabIndex = 2;
            this.MaleV.TabStop = true;
            this.MaleV.Text = "Male";
            this.MaleV.UseVisualStyleBackColor = true;
            // 
            // SexV
            // 
            this.SexV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SexV.AutoSize = true;
            this.SexV.Location = new System.Drawing.Point(9, 69);
            this.SexV.Name = "SexV";
            this.SexV.Size = new System.Drawing.Size(31, 17);
            this.SexV.TabIndex = 1;
            this.SexV.Text = "Sex";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.38775F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.61224F));
            this.tableLayoutPanel2.Controls.Add(this.DepartmentV, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.BirthdayV, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxBirthdayV, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxDepartmentV, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 92);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(784, 87);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // DepartmentV
            // 
            this.DepartmentV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DepartmentV.AutoSize = true;
            this.DepartmentV.Location = new System.Drawing.Point(3, 57);
            this.DepartmentV.Name = "DepartmentV";
            this.DepartmentV.Size = new System.Drawing.Size(82, 17);
            this.DepartmentV.TabIndex = 2;
            this.DepartmentV.Text = "Department";
            // 
            // BirthdayV
            // 
            this.BirthdayV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BirthdayV.AutoSize = true;
            this.BirthdayV.Location = new System.Drawing.Point(3, 14);
            this.BirthdayV.Name = "BirthdayV";
            this.BirthdayV.Size = new System.Drawing.Size(60, 17);
            this.BirthdayV.TabIndex = 1;
            this.BirthdayV.Text = "Birthday";
            // 
            // textBoxBirthdayV
            // 
            this.textBoxBirthdayV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxBirthdayV.Location = new System.Drawing.Point(154, 11);
            this.textBoxBirthdayV.Name = "textBoxBirthdayV";
            this.textBoxBirthdayV.ReadOnly = true;
            this.textBoxBirthdayV.Size = new System.Drawing.Size(150, 22);
            this.textBoxBirthdayV.TabIndex = 3;
            // 
            // comboBoxDepartmentV
            // 
            this.comboBoxDepartmentV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxDepartmentV.AutoCompleteCustomSource.AddRange(new string[] {
            "Учебно-научный институт медицинской инженерии;",
            "Учебно-научный институт компьютерных систем;",
            "Учебно-научный институт информационной безопасности, радиоэлектроники и телекомму" +
                "никаций;",
            "Институт бизнеса, экономики и информационных технологий;",
            "Учебно-научный институт машиностроения;",
            "Учебно-научный институт промышленных технологий, дизайна и менеджмента;",
            "Учебно-научный институт энергетики и компьютерно-интегрированных систем управлени" +
                "я;",
            "Учебно-научный институт электромеханики и энергоменеджмента;",
            "Украинско-испанский учебно-научный институт;",
            "Украинско-немецкий учебно-научный институт;",
            "Украинско-польский учебно-научный институт;",
            "Институт дистанционного и заочного образования;",
            "Учебно-научный институт подготовки иностранных граждан;",
            "Химико-технологический факультет;",
            "Гуманитарный факультет."});
            this.comboBoxDepartmentV.Enabled = false;
            this.comboBoxDepartmentV.FormattingEnabled = true;
            this.comboBoxDepartmentV.Items.AddRange(new object[] {
            "Учебно-научный институт медицинской инженерии;",
            "Учебно-научный институт компьютерных систем;",
            "Учебно-научный институт информационной безопасности, радиоэлектроники и телекомму" +
                "никаций;",
            "Институт бизнеса, экономики и информационных технологий;",
            "Учебно-научный институт машиностроения;",
            "Учебно-научный институт промышленных технологий, дизайна и менеджмента;",
            "Учебно-научный институт энергетики и компьютерно-интегрированных систем управлени" +
                "я;",
            "Учебно-научный институт электромеханики и энергоменеджмента;",
            "Украинско-испанский учебно-научный институт;",
            "Украинско-немецкий учебно-научный институт;",
            "Украинско-польский учебно-научный институт;",
            "Институт дистанционного и заочного образования;",
            "Учебно-научный институт подготовки иностранных граждан;",
            "Химико-технологический факультет;",
            "Гуманитарный факультет."});
            this.comboBoxDepartmentV.Location = new System.Drawing.Point(154, 53);
            this.comboBoxDepartmentV.Name = "comboBoxDepartmentV";
            this.comboBoxDepartmentV.Size = new System.Drawing.Size(580, 24);
            this.comboBoxDepartmentV.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.38775F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.61224F));
            this.tableLayoutPanel1.Controls.Add(this.NameV, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNameV, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 42);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // NameV
            // 
            this.NameV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NameV.AutoSize = true;
            this.NameV.Location = new System.Drawing.Point(3, 12);
            this.NameV.Name = "NameV";
            this.NameV.Size = new System.Drawing.Size(45, 17);
            this.NameV.TabIndex = 0;
            this.NameV.Text = "Name";
            // 
            // textBoxNameV
            // 
            this.textBoxNameV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxNameV.Location = new System.Drawing.Point(154, 10);
            this.textBoxNameV.Name = "textBoxNameV";
            this.textBoxNameV.ReadOnly = true;
            this.textBoxNameV.Size = new System.Drawing.Size(580, 22);
            this.textBoxNameV.TabIndex = 1;
            // 
            // Input
            // 
            this.Input.AllowDrop = true;
            this.Input.Controls.Add(this.monthCalendarIn);
            this.Input.Controls.Add(this.buttonAdd);
            this.Input.Controls.Add(this.FemaleIn);
            this.Input.Controls.Add(this.MaleIn);
            this.Input.Controls.Add(this.label5);
            this.Input.Controls.Add(this.tableLayoutPanel5);
            this.Input.Controls.Add(this.tableLayoutPanel6);
            this.Input.Location = new System.Drawing.Point(4, 25);
            this.Input.Name = "Input";
            this.Input.Padding = new System.Windows.Forms.Padding(3);
            this.Input.Size = new System.Drawing.Size(806, 379);
            this.Input.TabIndex = 1;
            this.Input.Text = "Input";
            this.Input.UseVisualStyleBackColor = true;
            // 
            // monthCalendarIn
            // 
            this.monthCalendarIn.Location = new System.Drawing.Point(455, 64);
            this.monthCalendarIn.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendarIn.Name = "monthCalendarIn";
            this.monthCalendarIn.TabIndex = 12;
            this.monthCalendarIn.Visible = false;
            this.monthCalendarIn.Leave += new System.EventHandler(this.monthCalendar_Leave);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(353, 270);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(87, 59);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FemaleIn
            // 
            this.FemaleIn.AutoSize = true;
            this.FemaleIn.Location = new System.Drawing.Point(297, 65);
            this.FemaleIn.Name = "FemaleIn";
            this.FemaleIn.Size = new System.Drawing.Size(75, 21);
            this.FemaleIn.TabIndex = 8;
            this.FemaleIn.Text = "Female";
            this.FemaleIn.UseVisualStyleBackColor = true;
            // 
            // MaleIn
            // 
            this.MaleIn.AutoSize = true;
            this.MaleIn.Checked = true;
            this.MaleIn.Location = new System.Drawing.Point(172, 65);
            this.MaleIn.Name = "MaleIn";
            this.MaleIn.Size = new System.Drawing.Size(59, 21);
            this.MaleIn.TabIndex = 7;
            this.MaleIn.TabStop = true;
            this.MaleIn.Text = "Male";
            this.MaleIn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sex";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.38775F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.61224F));
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBoxBirthdayIn, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.comboBoxDepartmentIn, 1, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(6, 92);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(784, 87);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Department";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Birthday";
            // 
            // textBoxBirthdayIn
            // 
            this.textBoxBirthdayIn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxBirthdayIn.Location = new System.Drawing.Point(154, 11);
            this.textBoxBirthdayIn.Name = "textBoxBirthdayIn";
            this.textBoxBirthdayIn.Size = new System.Drawing.Size(150, 22);
            this.textBoxBirthdayIn.TabIndex = 3;
            this.textBoxBirthdayIn.Enter += new System.EventHandler(this.textBoxBirthdayInEnter_Enter);
            this.textBoxBirthdayIn.Leave += new System.EventHandler(this.textBoxBirthday_Leave);
            // 
            // comboBoxDepartmentIn
            // 
            this.comboBoxDepartmentIn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxDepartmentIn.AutoCompleteCustomSource.AddRange(new string[] {
            "Учебно-научный институт медицинской инженерии;",
            "Учебно-научный институт компьютерных систем;",
            "Учебно-научный институт информационной безопасности, радиоэлектроники и телекомму" +
                "никаций;",
            "Институт бизнеса, экономики и информационных технологий;",
            "Учебно-научный институт машиностроения;",
            "Учебно-научный институт промышленных технологий, дизайна и менеджмента;",
            "Учебно-научный институт энергетики и компьютерно-интегрированных систем управлени" +
                "я;",
            "Учебно-научный институт электромеханики и энергоменеджмента;",
            "Украинско-испанский учебно-научный институт;",
            "Украинско-немецкий учебно-научный институт;",
            "Украинско-польский учебно-научный институт;",
            "Институт дистанционного и заочного образования;",
            "Учебно-научный институт подготовки иностранных граждан;",
            "Химико-технологический факультет;",
            "Гуманитарный факультет."});
            this.comboBoxDepartmentIn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxDepartmentIn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxDepartmentIn.FormattingEnabled = true;
            this.comboBoxDepartmentIn.Items.AddRange(new object[] {
            "Учебно-научный институт медицинской инженерии;",
            "Учебно-научный институт компьютерных систем;",
            "Учебно-научный институт информационной безопасности, радиоэлектроники и телекомму" +
                "никаций;",
            "Институт бизнеса, экономики и информационных технологий;",
            "Учебно-научный институт машиностроения;",
            "Учебно-научный институт промышленных технологий, дизайна и менеджмента;",
            "Учебно-научный институт энергетики и компьютерно-интегрированных систем управлени" +
                "я;",
            "Учебно-научный институт электромеханики и энергоменеджмента;",
            "Украинско-испанский учебно-научный институт;",
            "Украинско-немецкий учебно-научный институт;",
            "Украинско-польский учебно-научный институт;",
            "Институт дистанционного и заочного образования;",
            "Учебно-научный институт подготовки иностранных граждан;",
            "Химико-технологический факультет;",
            "Гуманитарный факультет."});
            this.comboBoxDepartmentIn.Location = new System.Drawing.Point(154, 54);
            this.comboBoxDepartmentIn.Name = "comboBoxDepartmentIn";
            this.comboBoxDepartmentIn.Size = new System.Drawing.Size(580, 24);
            this.comboBoxDepartmentIn.TabIndex = 4;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.38775F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.61224F));
            this.tableLayoutPanel6.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.textBoxNameIn, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(6, 18);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(784, 42);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Name";
            // 
            // textBoxNameIn
            // 
            this.textBoxNameIn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxNameIn.Location = new System.Drawing.Point(154, 10);
            this.textBoxNameIn.Name = "textBoxNameIn";
            this.textBoxNameIn.Size = new System.Drawing.Size(580, 22);
            this.textBoxNameIn.TabIndex = 1;
            // 
            // Edit
            // 
            this.Edit.Controls.Add(this.tableLayoutPanel8);
            this.Edit.Controls.Add(this.monthCalendarEd);
            this.Edit.Controls.Add(this.button5);
            this.Edit.Controls.Add(this.button3);
            this.Edit.Controls.Add(this.button4);
            this.Edit.Controls.Add(this.FemaleEd);
            this.Edit.Controls.Add(this.MaleEd);
            this.Edit.Controls.Add(this.label1);
            this.Edit.Controls.Add(this.tableLayoutPanel3);
            this.Edit.Controls.Add(this.tableLayoutPanel4);
            this.Edit.Location = new System.Drawing.Point(4, 25);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(806, 379);
            this.Edit.TabIndex = 0;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.86842F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.13158F));
            this.tableLayoutPanel8.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.textBoxStudentNE, 1, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(6, 174);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(253, 35);
            this.tableLayoutPanel8.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Sudent №";
            // 
            // textBoxStudentNE
            // 
            this.textBoxStudentNE.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxStudentNE.Location = new System.Drawing.Point(154, 6);
            this.textBoxStudentNE.Name = "textBoxStudentNE";
            this.textBoxStudentNE.ReadOnly = true;
            this.textBoxStudentNE.Size = new System.Drawing.Size(96, 22);
            this.textBoxStudentNE.TabIndex = 1;
            // 
            // monthCalendarEd
            // 
            this.monthCalendarEd.Location = new System.Drawing.Point(492, 62);
            this.monthCalendarEd.Name = "monthCalendarEd";
            this.monthCalendarEd.TabIndex = 12;
            this.monthCalendarEd.Visible = false;
            this.monthCalendarEd.Leave += new System.EventHandler(this.monthCalendar_Leave);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(351, 271);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 59);
            this.button5.TabIndex = 11;
            this.button5.Text = "Edit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Vineta BT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(492, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 59);
            this.button3.TabIndex = 10;
            this.button3.Text = "⇨";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Vineta BT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(209, 271);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 59);
            this.button4.TabIndex = 9;
            this.button4.Text = "⇦";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // FemaleEd
            // 
            this.FemaleEd.AutoSize = true;
            this.FemaleEd.Location = new System.Drawing.Point(297, 64);
            this.FemaleEd.Name = "FemaleEd";
            this.FemaleEd.Size = new System.Drawing.Size(75, 21);
            this.FemaleEd.TabIndex = 8;
            this.FemaleEd.Text = "Female";
            this.FemaleEd.UseVisualStyleBackColor = true;
            // 
            // MaleEd
            // 
            this.MaleEd.AutoSize = true;
            this.MaleEd.Checked = true;
            this.MaleEd.Location = new System.Drawing.Point(172, 64);
            this.MaleEd.Name = "MaleEd";
            this.MaleEd.Size = new System.Drawing.Size(59, 21);
            this.MaleEd.TabIndex = 7;
            this.MaleEd.TabStop = true;
            this.MaleEd.Text = "Male";
            this.MaleEd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sex";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.38775F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.61224F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxBirthdayEd, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxDepartmentEd, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 91);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(784, 87);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Department";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Birthday";
            // 
            // textBoxBirthdayEd
            // 
            this.textBoxBirthdayEd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxBirthdayEd.Location = new System.Drawing.Point(154, 11);
            this.textBoxBirthdayEd.Name = "textBoxBirthdayEd";
            this.textBoxBirthdayEd.Size = new System.Drawing.Size(150, 22);
            this.textBoxBirthdayEd.TabIndex = 3;
            this.textBoxBirthdayEd.Enter += new System.EventHandler(this.textBoxBirthdayInEnter_Enter);
            this.textBoxBirthdayEd.Leave += new System.EventHandler(this.textBoxBirthday_Leave);
            // 
            // comboBoxDepartmentEd
            // 
            this.comboBoxDepartmentEd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxDepartmentEd.AutoCompleteCustomSource.AddRange(new string[] {
            "Учебно-научный институт медицинской инженерии;",
            "Учебно-научный институт компьютерных систем;",
            "Учебно-научный институт информационной безопасности, радиоэлектроники и телекомму" +
                "никаций;",
            "Институт бизнеса, экономики и информационных технологий;",
            "Учебно-научный институт машиностроения;",
            "Учебно-научный институт промышленных технологий, дизайна и менеджмента;",
            "Учебно-научный институт энергетики и компьютерно-интегрированных систем управлени" +
                "я;",
            "Учебно-научный институт электромеханики и энергоменеджмента;",
            "Украинско-испанский учебно-научный институт;",
            "Украинско-немецкий учебно-научный институт;",
            "Украинско-польский учебно-научный институт;",
            "Институт дистанционного и заочного образования;",
            "Учебно-научный институт подготовки иностранных граждан;",
            "Химико-технологический факультет;",
            "Гуманитарный факультет."});
            this.comboBoxDepartmentEd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxDepartmentEd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxDepartmentEd.FormattingEnabled = true;
            this.comboBoxDepartmentEd.Items.AddRange(new object[] {
            "Учебно-научный институт медицинской инженерии;",
            "Учебно-научный институт компьютерных систем;",
            "Учебно-научный институт информационной безопасности, радиоэлектроники и телекомму" +
                "никаций;",
            "Институт бизнеса, экономики и информационных технологий;",
            "Учебно-научный институт машиностроения;",
            "Учебно-научный институт промышленных технологий, дизайна и менеджмента;",
            "Учебно-научный институт энергетики и компьютерно-интегрированных систем управлени" +
                "я;",
            "Учебно-научный институт электромеханики и энергоменеджмента;",
            "Украинско-испанский учебно-научный институт;",
            "Украинско-немецкий учебно-научный институт;",
            "Украинско-польский учебно-научный институт;",
            "Институт дистанционного и заочного образования;",
            "Учебно-научный институт подготовки иностранных граждан;",
            "Химико-технологический факультет;",
            "Гуманитарный факультет."});
            this.comboBoxDepartmentEd.Location = new System.Drawing.Point(154, 54);
            this.comboBoxDepartmentEd.Name = "comboBoxDepartmentEd";
            this.comboBoxDepartmentEd.Size = new System.Drawing.Size(580, 24);
            this.comboBoxDepartmentEd.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.38775F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.61224F));
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBoxNameEd, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 18);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(784, 42);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // textBoxNameEd
            // 
            this.textBoxNameEd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxNameEd.Location = new System.Drawing.Point(154, 10);
            this.textBoxNameEd.Name = "textBoxNameEd";
            this.textBoxNameEd.Size = new System.Drawing.Size(580, 22);
            this.textBoxNameEd.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.deleteAllToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // deleteAllToolStripMenuItem
            // 
            this.deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem";
            this.deleteAllToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.deleteAllToolStripMenuItem.Text = "Delete All";
            this.deleteAllToolStripMenuItem.Click += new System.EventHandler(this.deleteAllToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "StDB";
            this.tabControl1.ResumeLayout(false);
            this.View.ResumeLayout(false);
            this.View.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.Input.ResumeLayout(false);
            this.Input.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.Edit.ResumeLayout(false);
            this.Edit.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage View;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxStudentN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton FemaleV;
        private System.Windows.Forms.RadioButton MaleV;
        private System.Windows.Forms.Label SexV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label DepartmentV;
        private System.Windows.Forms.Label BirthdayV;
        private System.Windows.Forms.TextBox textBoxBirthdayV;
        private System.Windows.Forms.ComboBox comboBoxDepartmentV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label NameV;
        private System.Windows.Forms.TextBox textBoxNameV;
        private System.Windows.Forms.TabPage Input;
        private System.Windows.Forms.MonthCalendar monthCalendarIn;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.RadioButton FemaleIn;
        private System.Windows.Forms.RadioButton MaleIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxBirthdayIn;
        private System.Windows.Forms.ComboBox comboBoxDepartmentIn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNameIn;
        private System.Windows.Forms.TabPage Edit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxStudentNE;
        private System.Windows.Forms.MonthCalendar monthCalendarEd;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton FemaleEd;
        private System.Windows.Forms.RadioButton MaleEd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBirthdayEd;
        private System.Windows.Forms.ComboBox comboBoxDepartmentEd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNameEd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllToolStripMenuItem;
    }
}

