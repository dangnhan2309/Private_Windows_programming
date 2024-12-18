using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void titleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OpenFileDialog O_file = new OpenFileDialog();   
            O_file.Filter = "Bitmap file|*.bmp|JPEG file|*.jpg";
            if (O_file.ShowDialog() == DialogResult.OK)
            {
                Form2 form2 = new Form2(O_file.FileName);
                form2.MdiParent = this; 
          
                form2.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            toolStripStatusLabel1.Text = DateTime.Now.ToString("dd/mm/yy");
        }
    }
}
