using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_Buoi3
{
    public partial class Form1 : Form
    {
        public List<SinhVien> listSinhVien = new List<SinhVien>(); 
        public Form1()
        {
            InitializeComponent();
            listSinhVien.Add(new SinhVien("01", "Nhan", 6.7));
            listSinhVien.Add(new SinhVien("02", "Thuy", 9.7));
            listSinhVien.Add(new SinhVien("03", "TU", 8.2));
            RefreshlistView();



        }
        private void RefreshlistView()
        {
            dta_listviewSinhVien.Items.Clear(); // Xóa các mục cũ
            foreach (var sv in listSinhVien)
            {
                // Tạo một dòng mới trong ListView
                var item = new ListViewItem(sv.ID); // Dữ liệu cho cột đầu tiên (ID)
                item.SubItems.Add(sv.Name);        // Dữ liệu cho cột thứ hai (Name)
                item.SubItems.Add(sv.Score.ToString()); // Dữ liệu cho cột thứ ba (Score)
                dta_listviewSinhVien.Items.Add(item);
            }
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dta_listviewSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dta_listviewSinhVien.SelectedItems.Count > 0) // Kiểm tra có mục nào được chọn
            {
                // Lấy mục được chọn
                ListViewItem selectedItem = dta_listviewSinhVien.SelectedItems[0];

                // Lấy thông tin từ các cột
                txt_ID.Text = selectedItem.SubItems[0].Text; // Cột "ID"
                txt_Name.Text  = selectedItem.SubItems[1].Text; // Cột "Name"
                txt_diem.Text = selectedItem.SubItems[2].Text; // Cột "Score"

                // Hiển thị thông tin (ví dụ: qua MessageBox)
            }
        }

        private void Them_but_Click(object sender, EventArgs e)
        {
            // Kiểm tra các ô nhập liệu có trống hay không
            if (string.IsNullOrWhiteSpace(txt_ID.Text) ||
                string.IsNullOrWhiteSpace(txt_Name.Text) ||
                string.IsNullOrWhiteSpace(txt_diem.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin từ các TextBox
            string id_them = txt_ID.Text.Trim();
            string name_them = txt_Name.Text.Trim();
            double Score_them = double.Parse(txt_diem.Text.Trim()); 

            // Kiểm tra xem ID đã tồn tại trong danh sách chưa
            if (listSinhVien.Any(sv => sv.ID == id_them))
            {
                MessageBox.Show("ID đã tồn tại, vui lòng nhập ID khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thêm sinh viên vào danh sách
            listSinhVien.Add(new SinhVien(id_them, name_them, Score_them));

            // Cập nhật lại ListView
            RefreshlistView();

            // Thông báo thành công
            MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Xóa dữ liệu trong các ô nhập liệu
            txt_ID.Clear();
            txt_Name.Clear();
            txt_diem.Clear();
            txt_ID.Focus();
        }


        private void Sua_but_Click(object sender, EventArgs e)
        {
            // Ensure that an ID is entered and selected
            string id = txt_ID.Text; // Get the ID from the textbox
            string name = txt_Name.Text;           // Get the name from the textbox
            double Score_them = double.Parse(txt_diem.Text); // Get the score from the textbox

            // Find the student by ID
            var selectedStudent = listSinhVien.FirstOrDefault(s => s.ID == id);

            if (selectedStudent != null)
            {
                // Update the selected student with the new data
                selectedStudent.Name = name;
                selectedStudent.Score = Score_them;

                // Refresh the DataGridView to show updated data
                RefreshlistView();

                MessageBox.Show("Student updated successfully!");
            }
            else
            {
                MessageBox.Show("Student not found!");
            }
        }

        private void Xoa_but_Click(object sender, EventArgs e)
        {
            // Ensure that an ID is entered and selected
            string id = txt_ID.Text; // Get the ID from the textbox
            string name = txt_Name.Text;           // Get the name from the textbox
            double Score_them = double.Parse(txt_diem.Text); // Get the score from the textbox

            // Find the student by ID
            var selectedStudent = listSinhVien.FirstOrDefault(s => s.ID == id);
            if (selectedStudent != null)
            {
                listSinhVien.Remove(selectedStudent);
                RefreshlistView();

                MessageBox.Show("Student remove completed !");

            }
            else 
            {
                MessageBox.Show("Student not found!");

            }

        }

        private void Dong_but_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
    public class SinhVien
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }

        public SinhVien() { }

        public SinhVien(string iD, string name, double score)
        {
            ID = iD;
            Name = name;
            Score = score;
        }   

    }
}
