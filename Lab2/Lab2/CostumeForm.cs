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
    public partial class CostumeForm : Form
    {
        public CostumeForm()
        {
            InitializeComponent();
        }
        
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public void visible()
        {
            dataGridView1.Visible = true;
            groupBox1.Visible = false;
            button1.Enabled = true;
            button2.Enabled = true;
            textBox1.Enabled = true;
        }
        public void unvisible()
        {
            dataGridView1.Visible = false;
            groupBox1.Visible = true;
            button1.Enabled = false;
            button2.Enabled = false;
            textBox1.Enabled = false;
        }
        public void small()
        {
            dataGridView1.Location = new Point(12, 88);
            groupBox1.Location = new Point(12, 88);
            button2.Location = new Point(866, 88);
            this.Height = this.Height - groupBox2.Height - 5;
            groupBox2.Visible = false;
        }
        public void big()
        {
            dataGridView1.Location = new Point(12, 250);
            groupBox1.Location = new Point(12, 250);
            button2.Location = new Point(866, 250);
            this.Height = this.Height + groupBox2.Height + 5;
            groupBox2.Visible = true;
        }
        bool open = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (open)
            {
                big(); //надо сделать чтобы убирался расширенный поиск
                open = false;
            }
            else
            {
                small();
                open = true;
            }
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
        private void CostumeForm_Load(object sender, EventArgs e)
        {
            small(); visible();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            unvisible();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            visible();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            visible();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TypeСostume type = new TypeСostume();
            if (open_forms("TypeСostume")) type.Show(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Size size = new Size();
            if (open_forms("Size")) size.Show(); 
        }
    }
}
