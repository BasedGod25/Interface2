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
        public void small()
        {
            dataGridView1.Location = new Point(12, 88);
            groupBox1.Location = new Point(12, 88);
            button2.Location = new Point(866, 88);
            this.Size = new Size(1022, 470);
        }
        public void big()
        {
            dataGridView1.Location = new Point(12, 250);
            groupBox1.Location = new Point(12, 250);
            button2.Location = new Point(866, 250);
            this.Size = new Size(1022, 629);
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

        private void CostumeForm_Load(object sender, EventArgs e)
        {
            small();
        }
    }
}
