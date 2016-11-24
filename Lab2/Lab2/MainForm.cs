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
        }
        public void unvisible()
        { 
            dataGridView1.Visible = false;
            groupBox1.Visible = true;
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
            Auth a = new Auth();
            a.ShowDialog();
            visible();
        }

        private void костюмыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CostumeForm cf = new CostumeForm();
            if (open_forms("CostumeForm")) cf.Show();
        }

        
    }
}
