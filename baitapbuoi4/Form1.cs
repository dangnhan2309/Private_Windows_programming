using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitapbuoi4
{
    public partial class Form1 : Form
    {
        public List<NhanVien> listnhanvien = new List<NhanVien>();
        public Form1()
        {
            InitializeComponent();
            listnhanvien.Add(new NhanVien("1", "Alice", 85.5));
            listnhanvien.Add(new NhanVien("2", "Bob", 90.0));
            listnhanvien.Add(new NhanVien("3", "Charlie", 78.5));
            RefreshGridView();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    
        private void RefreshGridView()
        {
            // Clear the DataGridView and bind updated data
            dtGridNhanvien.DataSource = null;
            dtGridNhanvien.DataSource = listnhanvien;
        }        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) 
            {
                DataGridViewRow selectedRow = dtGridNhanvien.Rows[e.RowIndex];
            }

        }

        private void them_but_Click(object sender, EventArgs e)
        {
            Form2 formnhanvien = new Form2();

            formnhanvien.OnLuuThongTin += Form2_OnLuuThongTin; 

            formnhanvien.ShowDialog();  

        }
        private void Form2_OnLuuThongTin(string id_main, string name_main, double sal_main)
        {
            listnhanvien.Add(new NhanVien(id_main, name_main, sal_main));
            RefreshGridView();

        }

        private void Sua_but_Click(object sender, EventArgs e)
        {
            if (dtGridNhanvien.SelectedRows.Count > 0)
            {
                int selected_in = dtGridNhanvien.SelectedRows[0].Index;
                NhanVien sel = listnhanvien[selected_in];

                Form2 formNhanvien = new Form2(sel);
                formNhanvien.OnLuuThongTin += (id, name, sal) =>
                {
                    sel.MSNV = id;
                    sel.Name = name;
                    sel.Salary = sal;

                    RefreshGridView();

                };
                formNhanvien.ShowDialog();

            }
            else 
            {
                MessageBox.Show("Chon 1 nhan vien de chinh sua", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void dtGridNhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Xoa_but_Click(object sender, EventArgs e)
        {
            if (dtGridNhanvien.SelectedRows.Count > 0)
            {
                int selected_intdex = dtGridNhanvien.SelectedRows[0].Index;

                listnhanvien.Remove(listnhanvien[selected_intdex]);
                RefreshGridView();


            }
            else
            {
                MessageBox.Show("Chon 1 nhan vien");
            }

        }
    }
    public class NhanVien 
    {
        public String MSNV { get; set; }
        public String Name { get; set; } 
        public double Salary { get; set; }

        public NhanVien() { }

        public NhanVien(String ma, String Na, double sal)
        {
            this.MSNV = ma;
            this.Name = Na;
            this.Salary = sal;
        }

    }
}
