namespace Lab2
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.броньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.счетаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.костюмыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.типКостюмаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.возрастнаяКатегорияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.степениПоврежденияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.costume_shopDataSet = new Lab2.costume_shopDataSet();
            this.costumeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costumeTableAdapter = new Lab2.costume_shopDataSetTableAdapters.CostumeTableAdapter();
            this.idcostumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumecostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new Lab2.costume_shopDataSetTableAdapters.OrderTableAdapter();
            this.idorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderdatefactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderdateplanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idemployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costume_shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справочникиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(773, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.броньToolStripMenuItem,
            this.заказыToolStripMenuItem,
            this.счетаToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.костюмыToolStripMenuItem,
            this.сотрудникиToolStripMenuItem1,
            this.типКостюмаToolStripMenuItem,
            this.размерыToolStripMenuItem,
            this.возрастнаяКатегорияToolStripMenuItem,
            this.степениПоврежденияToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // броньToolStripMenuItem
            // 
            this.броньToolStripMenuItem.Name = "броньToolStripMenuItem";
            this.броньToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.броньToolStripMenuItem.Text = "Бронь";
            this.броньToolStripMenuItem.Click += new System.EventHandler(this.броньToolStripMenuItem_Click);
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.заказыToolStripMenuItem.Text = "Заказы";
            this.заказыToolStripMenuItem.Click += new System.EventHandler(this.заказыToolStripMenuItem_Click);
            // 
            // счетаToolStripMenuItem
            // 
            this.счетаToolStripMenuItem.Name = "счетаToolStripMenuItem";
            this.счетаToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.счетаToolStripMenuItem.Text = "Счета";
            this.счетаToolStripMenuItem.Click += new System.EventHandler(this.счетаToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // костюмыToolStripMenuItem
            // 
            this.костюмыToolStripMenuItem.Name = "костюмыToolStripMenuItem";
            this.костюмыToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.костюмыToolStripMenuItem.Text = "Костюмы";
            this.костюмыToolStripMenuItem.Click += new System.EventHandler(this.костюмыToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem1
            // 
            this.сотрудникиToolStripMenuItem1.Name = "сотрудникиToolStripMenuItem1";
            this.сотрудникиToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.сотрудникиToolStripMenuItem1.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem1.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem1_Click);
            // 
            // типКостюмаToolStripMenuItem
            // 
            this.типКостюмаToolStripMenuItem.Name = "типКостюмаToolStripMenuItem";
            this.типКостюмаToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.типКостюмаToolStripMenuItem.Text = "Тип костюма";
            this.типКостюмаToolStripMenuItem.Click += new System.EventHandler(this.типКостюмаToolStripMenuItem_Click);
            // 
            // размерыToolStripMenuItem
            // 
            this.размерыToolStripMenuItem.Name = "размерыToolStripMenuItem";
            this.размерыToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.размерыToolStripMenuItem.Text = "Размеры";
            this.размерыToolStripMenuItem.Click += new System.EventHandler(this.размерыToolStripMenuItem_Click);
            // 
            // возрастнаяКатегорияToolStripMenuItem
            // 
            this.возрастнаяКатегорияToolStripMenuItem.Name = "возрастнаяКатегорияToolStripMenuItem";
            this.возрастнаяКатегорияToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.возрастнаяКатегорияToolStripMenuItem.Text = "Возрастная категория";
            this.возрастнаяКатегорияToolStripMenuItem.Click += new System.EventHandler(this.возрастнаяКатегорияToolStripMenuItem_Click);
            // 
            // степениПоврежденияToolStripMenuItem
            // 
            this.степениПоврежденияToolStripMenuItem.Name = "степениПоврежденияToolStripMenuItem";
            this.степениПоврежденияToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.степениПоврежденияToolStripMenuItem.Text = "Степени повреждения";
            this.степениПоврежденияToolStripMenuItem.Click += new System.EventHandler(this.степениПоврежденияToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Арендованные костюмы";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idorderDataGridViewTextBoxColumn,
            this.orderdateDataGridViewTextBoxColumn,
            this.orderdatefactDataGridViewTextBoxColumn,
            this.orderdateplanDataGridViewTextBoxColumn,
            this.sumDataGridViewTextBoxColumn,
            this.idemployeeDataGridViewTextBoxColumn,
            this.idclientDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 102);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(636, 349);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поиск";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 79);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(637, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(668, 191);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 24);
            this.button2.TabIndex = 6;
            this.button2.Text = "Редактирование";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(668, 277);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 24);
            this.button3.TabIndex = 7;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.dateTimePicker3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Location = new System.Drawing.Point(18, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(636, 349);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оформление заказа на аренду костюмов";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(502, 266);
            this.button10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(98, 24);
            this.button10.TabIndex = 25;
            this.button10.Text = "Печать договора";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(479, 50);
            this.button9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(24, 20);
            this.button9.TabIndex = 24;
            this.button9.Text = "...";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(424, 273);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(74, 20);
            this.textBox5.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 277);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Общая сумма заказа";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(604, 137);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(27, 24);
            this.button7.TabIndex = 20;
            this.button7.Text = "+";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(604, 167);
            this.button8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(27, 24);
            this.button8.TabIndex = 21;
            this.button8.Text = "-";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(122, 50);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(133, 20);
            this.dateTimePicker3.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(119, 71);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Дата выдачи";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(575, 320);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 24);
            this.button5.TabIndex = 17;
            this.button5.Text = "Отмена";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(514, 320);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 24);
            this.button4.TabIndex = 16;
            this.button4.Text = "ОК";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(15, 286);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(74, 20);
            this.textBox4.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 269);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Сумма залога";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(111, 286);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(74, 20);
            this.textBox3.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(109, 270);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Сумма аренды";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 50);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(74, 20);
            this.textBox2.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Номер заказа";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 121);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Костюмы";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(286, 89);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(218, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Сотрудник";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(286, 50);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Клиент";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 89);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Дата заказа";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcostumeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.rentcostDataGridViewTextBoxColumn,
            this.costumecostDataGridViewTextBoxColumn,
            this.idtypeDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.costumeBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(15, 137);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(585, 124);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(668, 102);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(97, 24);
            this.button6.TabIndex = 9;
            this.button6.Text = "Аренда";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 131);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 24);
            this.button1.TabIndex = 9;
            this.button1.Text = "Бронирование";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(668, 160);
            this.button11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(97, 24);
            this.button11.TabIndex = 10;
            this.button11.Text = "Возврат";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // costume_shopDataSet
            // 
            this.costume_shopDataSet.DataSetName = "costume_shopDataSet";
            this.costume_shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // costumeBindingSource
            // 
            this.costumeBindingSource.DataMember = "Costume";
            this.costumeBindingSource.DataSource = this.costume_shopDataSet;
            // 
            // costumeTableAdapter
            // 
            this.costumeTableAdapter.ClearBeforeFill = true;
            // 
            // idcostumeDataGridViewTextBoxColumn
            // 
            this.idcostumeDataGridViewTextBoxColumn.DataPropertyName = "id_costume";
            this.idcostumeDataGridViewTextBoxColumn.HeaderText = "id_costume";
            this.idcostumeDataGridViewTextBoxColumn.Name = "idcostumeDataGridViewTextBoxColumn";
            this.idcostumeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // rentcostDataGridViewTextBoxColumn
            // 
            this.rentcostDataGridViewTextBoxColumn.DataPropertyName = "rent_cost";
            this.rentcostDataGridViewTextBoxColumn.HeaderText = "rent_cost";
            this.rentcostDataGridViewTextBoxColumn.Name = "rentcostDataGridViewTextBoxColumn";
            // 
            // costumecostDataGridViewTextBoxColumn
            // 
            this.costumecostDataGridViewTextBoxColumn.DataPropertyName = "costume_cost";
            this.costumecostDataGridViewTextBoxColumn.HeaderText = "costume_cost";
            this.costumecostDataGridViewTextBoxColumn.Name = "costumecostDataGridViewTextBoxColumn";
            // 
            // idtypeDataGridViewTextBoxColumn
            // 
            this.idtypeDataGridViewTextBoxColumn.DataPropertyName = "id_type";
            this.idtypeDataGridViewTextBoxColumn.HeaderText = "id_type";
            this.idtypeDataGridViewTextBoxColumn.Name = "idtypeDataGridViewTextBoxColumn";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.costume_shopDataSet;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // idorderDataGridViewTextBoxColumn
            // 
            this.idorderDataGridViewTextBoxColumn.DataPropertyName = "id_order";
            this.idorderDataGridViewTextBoxColumn.HeaderText = "id_order";
            this.idorderDataGridViewTextBoxColumn.Name = "idorderDataGridViewTextBoxColumn";
            this.idorderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderdateDataGridViewTextBoxColumn
            // 
            this.orderdateDataGridViewTextBoxColumn.DataPropertyName = "order_date";
            this.orderdateDataGridViewTextBoxColumn.HeaderText = "order_date";
            this.orderdateDataGridViewTextBoxColumn.Name = "orderdateDataGridViewTextBoxColumn";
            // 
            // orderdatefactDataGridViewTextBoxColumn
            // 
            this.orderdatefactDataGridViewTextBoxColumn.DataPropertyName = "order_date_fact";
            this.orderdatefactDataGridViewTextBoxColumn.HeaderText = "order_date_fact";
            this.orderdatefactDataGridViewTextBoxColumn.Name = "orderdatefactDataGridViewTextBoxColumn";
            // 
            // orderdateplanDataGridViewTextBoxColumn
            // 
            this.orderdateplanDataGridViewTextBoxColumn.DataPropertyName = "order_date_plan";
            this.orderdateplanDataGridViewTextBoxColumn.HeaderText = "order_date_plan";
            this.orderdateplanDataGridViewTextBoxColumn.Name = "orderdateplanDataGridViewTextBoxColumn";
            // 
            // sumDataGridViewTextBoxColumn
            // 
            this.sumDataGridViewTextBoxColumn.DataPropertyName = "sum";
            this.sumDataGridViewTextBoxColumn.HeaderText = "sum";
            this.sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
            // 
            // idemployeeDataGridViewTextBoxColumn
            // 
            this.idemployeeDataGridViewTextBoxColumn.DataPropertyName = "id_employee";
            this.idemployeeDataGridViewTextBoxColumn.HeaderText = "id_employee";
            this.idemployeeDataGridViewTextBoxColumn.Name = "idemployeeDataGridViewTextBoxColumn";
            // 
            // idclientDataGridViewTextBoxColumn
            // 
            this.idclientDataGridViewTextBoxColumn.DataPropertyName = "id_client";
            this.idclientDataGridViewTextBoxColumn.HeaderText = "id_client";
            this.idclientDataGridViewTextBoxColumn.Name = "idclientDataGridViewTextBoxColumn";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 461);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "ИС учета карнавальных костюмов";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costume_shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem костюмыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem счетаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem броньToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem типКостюмаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem возрастнаяКатегорияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem степениПоврежденияToolStripMenuItem;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private costume_shopDataSet costume_shopDataSet;
        private System.Windows.Forms.BindingSource costumeBindingSource;
        private costume_shopDataSetTableAdapters.CostumeTableAdapter costumeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcostumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumecostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private costume_shopDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdatefactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdateplanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idemployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientDataGridViewTextBoxColumn;
    }
}