﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var student = new Student();    
            List<Student_IF> Student_list = student.Student_IF.ToList();
            dataGridView1.DataSource = Student_list;    
            
            List<CLass> classlist = student.CLass.ToList();
            dataGridView2.DataSource = classlist;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
