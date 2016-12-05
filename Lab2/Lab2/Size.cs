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
    public partial class Size : Form
    {
        public Size()
        {
            InitializeComponent();
        }
        public void visible()
        {
            dataGridView1.Visible = true;
            groupBox1.Visible = false;            
            button2.Enabled = true;
            button3.Enabled = true;
        }
        public void unvisible()
        {
            dataGridView1.Visible = false;
            groupBox1.Visible = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            unvisible();//привязка данных
        }

        private void Size_Load(object sender, EventArgs e)
        {
            visible();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            unvisible();//сохранить изменения
        }

        private void button5_Click(object sender, EventArgs e)
        {
            unvisible();//не изменять ничего
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //удаление
        }
    }
}
