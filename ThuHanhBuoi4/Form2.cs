using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace buoi_6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        Student student = new Student();
        private void Form2_Load(object sender, EventArgs e)
        {
            List<Student_IF> Student_list = student.Student_IF.ToList();
            List<CLass> classlist = student.CLass.ToList();
            FillFalcutyComboBox1(classlist);
            BidGid(Student_list);
        }
        private void FillFalcutyComboBox1(List<CLass> listclass)
        {
            
            this.Class_combo_box.DataSource = listclass;
            this.Class_combo_box.DisplayMember = "Class_Name";
            this.Class_combo_box.ValueMember = "Class_ID";
        }
        private void BidGid(List<Student_IF> studentlist)
        {
            dataGridView1.Rows.Clear();
            foreach (var student in studentlist)
            {
                int intdex = dataGridView1.Rows.Add();
                dataGridView1.Rows[intdex].Cells[0].Value = student.Student_ID;
                dataGridView1.Rows[intdex].Cells[1].Value = student.Student_Name;
                dataGridView1.Rows[intdex].Cells[2].Value = student.DOB;
                if (student.Gender)
                {

                    dataGridView1.Rows[intdex].Cells[3].Value = "Nam";

                }
                else
                {
                    dataGridView1.Rows[intdex].Cells[3].Value = "Nu";


                }
                dataGridView1.Rows[intdex].Cells[4].Value = student.Class_ID;

            }
        }
        private void ReloadData()
        {
            // Fetch the updated list of students
            List<Student_IF> studentList = student.Student_IF.ToList();

            // BidGid and reload the student data into the DataGridView
            BidGid(studentList);
        }
        private void Sua_but_Click(object sender, EventArgs e)
        {
            // Ensure your DbContext class is used here
            using (var context = new Student())
            {
                // Input validation
                if (!int.TryParse(txt_id.Text, out int id_chotrc))
                {
                    MessageBox.Show("Invalid ID. Please enter a valid number.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_name.Text))
                {
                    MessageBox.Show("Name cannot be empty.");
                    return;
                }

                if (!DateTime.TryParse(txt_DOB.Text, out DateTime dob))
                {
                    MessageBox.Show("Invalid Date of Birth format.");
                    return;
                }

                if (Class_combo_box.SelectedValue == null)
                {
                    MessageBox.Show("Please select a valid class.");
                    return;
                }

                // Fetch student from database
                var dbStudent = context.Student_IF.FirstOrDefault(p => p.Student_ID == id_chotrc);

                try
                {
                    if (dbStudent != null)
                    {
                        // Update existing student
                        dbStudent.Student_Name = txt_name.Text.Trim();
                        dbStudent.DOB = dob;
                        dbStudent.Gender = txt_gender.Text.Trim().Equals("Nam", StringComparison.OrdinalIgnoreCase);
                        dbStudent.Class_ID = (int)Class_combo_box.SelectedValue;
                        context.SaveChanges();
                        ReloadData();
                        MessageBox.Show("Student updated successfully.");
                    }
                    else
                    {
                        // Insert new student
                        var newStudent = new Student_IF
                        {
                            Student_ID = id_chotrc,
                            Student_Name = txt_name.Text.Trim(),
                            DOB = dob,
                            Gender = txt_gender.Text.Trim().Equals("Nam", StringComparison.OrdinalIgnoreCase),
                            Class_ID = (int)Class_combo_box.SelectedValue
                        };
                        context.Student_IF.Add(newStudent);
                        ReloadData();
                        context.SaveChanges();
                        MessageBox.Show("Student added successfully.");
                    }
                }
                catch (DbEntityValidationException ex)
                {
                    // Handle validation errors
                    foreach (var validationError in ex.EntityValidationErrors)
                    {
                        foreach (var error in validationError.ValidationErrors)
                        {
                            Console.WriteLine($"Property: {error.PropertyName}, Error: {error.ErrorMessage}");
                        }
                    }
                    MessageBox.Show("Validation error occurred. Check the console for details.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                List<Student_IF> studentlist = student.Student_IF.ToList();
                var selectedStudent = studentlist[e.RowIndex];

                // Populate textboxes with the selected student data
                txt_id.Text = selectedStudent.Student_ID.ToString();    
                txt_name.Text = selectedStudent.Student_Name.ToString();
                if (selectedStudent.Gender)
                {

                    txt_gender.Text = "Nam";

                }
                else
                {
                    txt_gender.Text = "Nu";


                }
                txt_DOB.Text = selectedStudent.DOB.ToString();
                Class_combo_box.SelectedValue = selectedStudent.Class_ID;

            }
        }



        private void Xoa_but_Click(object sender, EventArgs e)
        {
            using (var context = new Student())
            {


                // Ensure a student is selected from the DataGridView

                int idsss = int.Parse(txt_id.Text);

                // Get the selected student ID from the DataGridView
                var selectedStudentID = context.Student_IF.FirstOrDefault(p => p.Student_ID == idsss);

                // Use the correct DbContext (replace `YourDbContext` with your actual context class)
                

                
                    // Find the student to delete
                    var studentToDelete = context.Student_IF.FirstOrDefault(s => s.Student_ID == selectedStudentID.Student_ID);

                    if (studentToDelete != null)
                    {
                        // Remove the student from the DbSet
                        context.Student_IF.Remove(studentToDelete);

                        try
                        {
                            // Save changes to the database
                            context.SaveChanges();
                            MessageBox.Show("Student deleted successfully.");
                            ReloadData();

                            // Optionally, refresh the DataGridView to reflect the changes
                            //LoadStudentData(); // Reload the data after deletion
                        }
                        catch (Exception ex)
                        {
                            // Handle any errors during deletion
                            MessageBox.Show($"An error occurred while deleting the student: {ex.Message}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Student not found.");
                    }
            }
            
        }
    }
}
