﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Age : Form
    {
        public Age()
        {
            InitializeComponent();
        }
        public void visible()
        {
            dataGridView1.Visible = true;
            groupBox1.Visible = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }
        public void unvisible()
        {
            dataGridView1.Visible = false;
            groupBox1.Visible = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            visible(); //добавить или изменить
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //удаление
        }

        private void button2_Click(object sender, EventArgs e)
        {
            unvisible();
            groupBox1.Text = "Редактировать";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            unvisible();
            groupBox1.Text = "Добавить";
        }

        private void Age_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "costume_shopDataSet.Age_category". При необходимости она может быть перемещена или удалена.
            this.age_categoryTableAdapter.Fill(this.costume_shopDataSet.Age_category);
            visible();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            visible();// ничего не делать
        }
    }
}
