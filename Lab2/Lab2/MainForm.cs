using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void visible()
        {
            dataGridView1.Visible = true;
            groupBox1.Visible = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button6.Enabled = true;
            textBox1.Enabled = true;
        }
        public void unvisible()
        { 
            dataGridView1.Visible = false;
            groupBox1.Visible = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button6.Enabled = false;
            textBox1.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            unvisible();
        }
        public bool open_forms(string name)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == name)
                {
                    f.Activate();
                    return false;
                }
            }
            return true;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "costume_shopDataSet.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.costume_shopDataSet.Order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "costume_shopDataSet.Costume". При необходимости она может быть перемещена или удалена.
            this.costumeTableAdapter.Fill(this.costume_shopDataSet.Costume);
            Auth a = new Auth();
            a.ShowDialog();
            visible();
        }

        private void костюмыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CostumeForm cf = new CostumeForm();
            if (open_forms("CostumeForm")) cf.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            unvisible();
            groupBox1.Text = "Оформление заказа на аренду костюмов";
            label3.Text = "Дата заказа";
            label11.Visible = true;
            dateTimePicker1.Visible = true;
            button10.Enabled = true;
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients cli = new Clients();
            if (open_forms("Clients")) cli.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            visible();//сохранить или изменить данные
        }

        private void button5_Click(object sender, EventArgs e)
        {
            visible();//ничего не делать
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            unvisible();
            groupBox1.Text = "Бронирование";
            label3.Text = "Дата по плану";
            label11.Visible = false;
            dateTimePicker1.Visible = false;
            button10.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            unvisible();
            groupBox1.Text = "Редактирование";
            label3.Text = "Дата заказа";
            label11.Visible = true;
            dateTimePicker1.Visible = true;
            button10.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //удаление строки из таблицы
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CostumeForm cf = new CostumeForm();
            if (open_forms("CostumeForm")) cf.Show();
        }

        private void степениПоврежденияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Damage damage = new Damage();
            if (open_forms("Damage")) damage.Show();
        }

        private void возрастнаяКатегорияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Age age = new Age();
            if (open_forms("Age")) age.Show();
        }

        private void размерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size size = new Size();
            if (open_forms("Size")) size.Show(); 
        }

        private void типКостюмаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeСostume type = new TypeСostume();
            if (open_forms("TypeСostume")) type.Show(); 
        }


        private void счетаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            if (open_forms("Bill")) bill.Show();
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            if (open_forms("Order")) order.Show(); 
        }

        private void броньToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservations reserv = new Reservations();
            if (open_forms("Reservations")) reserv.Show(); 
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void сотрудникиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Employees employee = new Employees();
            if (open_forms("Employees")) employee.Show(); 
        }
    }
}
