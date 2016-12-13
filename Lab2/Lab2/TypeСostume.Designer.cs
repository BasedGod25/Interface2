namespace Lab2
{
    partial class TypeСostume
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.costume_shopDataSet = new Lab2.costume_shopDataSet();
            this.costumesizeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costume_sizeTableAdapter = new Lab2.costume_shopDataSetTableAdapters.Costume_sizeTableAdapter();
            this.costumetypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costume_typeTableAdapter = new Lab2.costume_shopDataSetTableAdapters.Costume_typeTableAdapter();
            this.idtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costume_shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumesizeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumetypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(9, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(238, 214);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактировать";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(178, 184);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 24);
            this.button5.TabIndex = 19;
            this.button5.Text = "Отмена";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(118, 184);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 24);
            this.button4.TabIndex = 18;
            this.button4.Text = "ОК";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Наименование";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 49);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(276, 141);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 24);
            this.button3.TabIndex = 20;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 36);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 24);
            this.button1.TabIndex = 18;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 68);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 24);
            this.button2.TabIndex = 19;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Типы костюмов";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtypeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.costumetypeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(263, 214);
            this.dataGridView1.TabIndex = 16;
            // 
            // costume_shopDataSet
            // 
            this.costume_shopDataSet.DataSetName = "costume_shopDataSet";
            this.costume_shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // costumesizeBindingSource
            // 
            this.costumesizeBindingSource.DataMember = "Costume_size";
            this.costumesizeBindingSource.DataSource = this.costume_shopDataSet;
            // 
            // costume_sizeTableAdapter
            // 
            this.costume_sizeTableAdapter.ClearBeforeFill = true;
            // 
            // costumetypeBindingSource
            // 
            this.costumetypeBindingSource.DataMember = "Costume_type";
            this.costumetypeBindingSource.DataSource = this.costume_shopDataSet;
            // 
            // costume_typeTableAdapter
            // 
            this.costume_typeTableAdapter.ClearBeforeFill = true;
            // 
            // idtypeDataGridViewTextBoxColumn
            // 
            this.idtypeDataGridViewTextBoxColumn.DataPropertyName = "id_type";
            this.idtypeDataGridViewTextBoxColumn.HeaderText = "id_type";
            this.idtypeDataGridViewTextBoxColumn.Name = "idtypeDataGridViewTextBoxColumn";
            this.idtypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // TypeСostume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TypeСostume";
            this.Text = "Типы костюмов";
            this.Load += new System.EventHandler(this.TypeСostume_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costume_shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumesizeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumetypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private costume_shopDataSet costume_shopDataSet;
        private System.Windows.Forms.BindingSource costumesizeBindingSource;
        private costume_shopDataSetTableAdapters.Costume_sizeTableAdapter costume_sizeTableAdapter;
        private System.Windows.Forms.BindingSource costumetypeBindingSource;
        private costume_shopDataSetTableAdapters.Costume_typeTableAdapter costume_typeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}