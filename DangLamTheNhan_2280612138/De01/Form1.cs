using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Model1 context = new Model1();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<SinhVien> Student_list = context.SinhVien.ToList();
            List<Lop> classlist = context.Lop.ToList();
            FillFalcutyComboBox1(classlist);
            BidGid(Student_list);
            SaveButton.Enabled = false; // Disables the button
            NotSaveButton.Enabled = false;

        }
        private void BidGid(List<SinhVien> studentlist)
        {
            // Clear the existing rows in the DataGridView
            dataGridView1.Rows.Clear();

            // Load all classes into a dictionary for faster lookups
            Dictionary<string, string> classDictionary = context.Lop
                .ToDictionary(c => c.MaLop, c => c.TenLop);

            // Iterate through the student list and add rows to the DataGridView
            foreach (var student in studentlist)
            {
                // Check if the student has a valid class and retrieve the class name
                string className = classDictionary.ContainsKey(student.MaLop)
                    ? classDictionary[student.MaLop]
                    : "Khong Ten"; // Fallback in case class is not found

                // Add a new row to the DataGridView and set its values
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = student.MaSV; // Ensure MaSV is saved in the first column
                dataGridView1.Rows[index].Cells[1].Value = student.HotenSV;
                dataGridView1.Rows[index].Cells[2].Value = student.NgaySinh; // Adjust date format
                dataGridView1.Rows[index].Cells[3].Value = className;
            }
        }





        private void FillFalcutyComboBox1(List<Lop> listclass)
        {

            this.comboBox1.DataSource = listclass;
            this.comboBox1.DisplayMember = "TenLop";
            this.comboBox1.ValueMember = "MaLop";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (txt_searching.Text != null)
            {
                string ma = txt_searching.Text.ToString();
                SinhVien sinhVien = context.SinhVien.FirstOrDefault(c => c.HotenSV == ma);
                if (sinhVien != null)
                {
                    txt_TenSV.Text = sinhVien.HotenSV.ToString();
                    txt_MaSV.Text = sinhVien.MaSV.ToString();
                    comboBox1.SelectedValue = sinhVien.MaLop.ToString();
                    dateTimePicker1.Value = DateTime.Parse(sinhVien.NgaySinh.ToString());

                    MessageBox.Show("Student Found!!!!");
                } else

                    MessageBox.Show("Student not Found!!!!");


            }
            else { MessageBox.Show("Nhap vao Ten Sinh Vien"); }



        }
        private void ReloadData()
        {
            // Fetch the updated list of students
            List<SinhVien> studentList = context.SinhVien.ToList();

            // BidGid and reload the student data into the DataGridView
            BidGid(studentList);
        }
        private void ReloadDateAdjust(List<SinhVien> studentList)
        {
            BidGid(studentList);

        }
        private void Addbutton_Click(object sender, EventArgs e)
        {
            NotSaveButton.Enabled = true;
            SaveButton.Enabled = true;


            if (txt_MaSV != null)
            {
                string ma = txt_MaSV.Text.ToString();
                List<SinhVien> studentList = context.SinhVien.ToList();

                SinhVien sinhVien = context.SinhVien.FirstOrDefault(c => c.HotenSV == ma);
                if (sinhVien == null)
                {
                    DateTime NgaySinh = DateTime.Parse(dateTimePicker1.Value.ToString());

                    var newStudent = new SinhVien
                    {
                        MaSV = ma,
                        HotenSV = txt_TenSV.Text.Trim(),
                        NgaySinh = NgaySinh,
                        MaLop = comboBox1.SelectedValue.ToString(),
                    };
                    studentList.Add(newStudent);
                    ReloadDateAdjust(studentList);
                    MessageBox.Show("Student added successfully.");
                }
            }
            else { MessageBox.Show("Nhap ma sinh vien"); }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                List<SinhVien> studentlist = context.SinhVien.ToList();
                var selectedStudent = studentlist[e.RowIndex];

                // Populate textboxes with the selected student data
                txt_TenSV.Text = selectedStudent.HotenSV.ToString();
                txt_MaSV.Text = selectedStudent.MaSV.ToString();

                comboBox1.SelectedValue = selectedStudent.MaLop.ToString();
                dateTimePicker1.Value = DateTime.Parse(selectedStudent.NgaySinh.ToString());

            }

        }

        private void fixButton_Click(object sender, EventArgs e)
        {
            NotSaveButton.Enabled = true;
            SaveButton.Enabled = true;

            if (string.IsNullOrWhiteSpace(txt_TenSV.Text))
            {
                MessageBox.Show("Name cannot be empty.");
                return;
            }

            if (dateTimePicker1.Value == null)
            {
                MessageBox.Show("Invalid Date of Birth format.");
                return;
            }

            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid class.");
                return;
            }

            SaveButton.Enabled = true; 
            if (txt_MaSV != null)
            {
                string ma = txt_MaSV.Text.ToString();

                List<SinhVien> studentlist = context.SinhVien.ToList();
                SinhVien sinhVien = context.SinhVien.FirstOrDefault(c => c.MaSV == ma);
                SinhVien sinhtheyathe = sinhVien;

                if (sinhVien != null)
                {
                    DateTime NgaySinh = DateTime.Parse(dateTimePicker1.Value.ToString());
                    sinhtheyathe.MaSV = txt_MaSV.Text.ToString();
                    sinhtheyathe.HotenSV = txt_TenSV.Text.ToString();
                    sinhtheyathe.NgaySinh = NgaySinh;
                    sinhtheyathe.MaLop = comboBox1.SelectedValue.ToString();
                    studentlist.Remove(sinhVien); 
                    studentlist.Add(sinhtheyathe);

                    ReloadDateAdjust(studentlist);
                    context.SinhVien.Remove(sinhVien);
                    context.SinhVien.Add(sinhtheyathe);
                    

                    


                    MessageBox.Show("Student fixed successfully.");
                }
            }
            else { MessageBox.Show("Nhap ma sinh vien"); }

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {

            NotSaveButton.Enabled = true;
            SaveButton.Enabled = true;

            List<SinhVien> studentList = context.SinhVien.ToList();
            string idsss = txt_MaSV.Text.ToString().Trim();

            var selectedStudentID = context.SinhVien.FirstOrDefault(p => p.MaSV == idsss);


            if (selectedStudentID != null)
            {
                studentList.Remove(selectedStudentID);
                try
                {
                    ReloadDateAdjust(studentList);
                    context.SinhVien.Remove(selectedStudentID);
                    MessageBox.Show("Student deleted successfully.");
                     }
                catch (Exception ex) {
                
                    MessageBox.Show($"An error occurred while deleting the student: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Student not found.");

            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveButton.Enabled = false;  // Disable SaveButton at the beginning

            try
            {
                // Track the student IDs from the DataGridView
                List<string> studentIdsInGrid = new List<string>();

                // Loop through the DataGridView rows and process the data
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue; // Skip the new row placeholder

                    // Extract data from the DataGridView row
                    string maSV = row.Cells[0].Value?.ToString()?.Trim();
                    string hoTen = row.Cells[1].Value?.ToString()?.Trim();
                    string ngaySinhStr = row.Cells[2].Value?.ToString()?.Trim();
                    string maLop = row.Cells[3].Value?.ToString()?.Trim();

                    // Validate required fields
                    if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(maLop))
                    {
                        studentIdsInGrid.Add(maSV);
                        MessageBox.Show("Some fields are missing or incomplete. Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }

                    // Validate date format
                    DateTime ngaySinh;
                    if (!DateTime.TryParse(ngaySinhStr, out ngaySinh))
                    {
                        MessageBox.Show($"Invalid date format for student ID {maSV}.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }

                    // Check if the student exists in the database
                    var existingStudent = context.SinhVien.FirstOrDefault(sv => sv.MaSV == maSV);

                    if (existingStudent != null)
                    {
                        // Update existing student
                        existingStudent.HotenSV = hoTen;
                        existingStudent.NgaySinh = ngaySinh;
                        existingStudent.MaLop = maLop;
                    }
                    else
                    {
                        // Add new student
                        var newStudent = new SinhVien
                        {
                            MaSV = maSV,
                            HotenSV = hoTen,
                            NgaySinh = ngaySinh,
                            MaLop = maLop
                        };
                        context.SinhVien.Add(newStudent);
                    }

                    // Track student ID in the grid for later removal checks
                }

                // Now remove students from the database that are not in the grid
                var studentsInDb = context.SinhVien.ToList();
                foreach (var student in studentsInDb)
                {
                    
                    
                    if (!studentIdsInGrid.Contains(student.MaSV))
                    {
                        MessageBox.Show("Co" + student.MaSV);
                        // Remove the student from the database if not in the grid
                        context.SinhVien.Remove(student);
                    }
                }

                // Save all changes to the database
                context.SaveChanges();

                // Refresh DataGridView and show success message
                ReloadData();
                MessageBox.Show("Changes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving changes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SaveButton.Enabled = true; // Re-enable the SaveButton in case of success or failure
            }
        }

        private void NotSaveButton_Click(object sender, EventArgs e)
        {
            List<SinhVien> studentList = context.SinhVien.ToList();

            // BidGid and reload the student data into the DataGridView
            BidGid(studentList);
            NotSaveButton.Enabled = false ;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
