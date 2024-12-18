using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Text;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            InitializeFontAndSize();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDlg = new FontDialog())
            {
                fontDlg.ShowColor = true;
                fontDlg.ShowApply = false;  // Không cần nút "Apply" vì sẽ áp dụng trực tiếp
                fontDlg.ShowEffects = true;
                fontDlg.ShowHelp = true;

                // Hiển thị hộp thoại FontDialog
                if (fontDlg.ShowDialog() == DialogResult.OK)
                {
                    // Thay đổi font và màu sắc của RichTextBox
                    richTextBox1.ForeColor = fontDlg.Color;
                    richTextBox1.Font = fontDlg.Font;

                    // Nếu muốn đồng bộ hóa với ToolStripComboBox:
                    toolStripComboBox1.Text = fontDlg.Font.FontFamily.Name; // Tên font
                    toolStripComboBox2.Text = fontDlg.Font.Size.ToString(); // Kích thước font
                }
            }
        }

           // toolStripComboBox1.Text = fontDl.
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.Title = "Save File";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Lấy đường dẫn file
                        string filePath = saveFileDialog.FileName;

                        // Ghi nội dung TextBox vào file
                        File.WriteAllText(filePath, richTextBox1.Text);
                        MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
            

            private void openToolStripMenuItem_Click4(object sender, EventArgs e)
            {
                OpenFileDialog O_file = new OpenFileDialog();
                O_file.Filter = "Text Files|*.txt|All Files|*.*";
                O_file.Title = "Open Text File";
                if (O_file.ShowDialog() == DialogResult.OK)
                {
                try
                {
                    string fileContent = File.ReadAllText(O_file.FileName);
                    richTextBox1.Text = fileContent;
                }
                catch (Exception ex)
                {
                       MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy Font hiện tại của RichTextBox
            Font currentFont = richTextBox1.Font;

            // Lấy Font chữ từ ToolStripComboBox1
            string selectedFont = toolStripComboBox1.SelectedItem?.ToString();

            // Kiểm tra null để tránh ngoại lệ
            if (!string.IsNullOrEmpty(selectedFont))
            {
                // Cập nhật Font của RichTextBox
                richTextBox1.Font = new Font(selectedFont, currentFont.Size);
            }
        }
        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy Font hiện tại của RichTextBox
            Font currentFont = richTextBox1.Font;

            // Lấy Font chữ từ ToolStripComboBox1
            string selectedFont = toolStripComboBox2.SelectedItem?.ToString();

            // Kiểm tra null để tránh ngoại lệ
            if (!string.IsNullOrEmpty(selectedFont))
            {
                // Cập nhật Font của RichTextBox
                richTextBox1.Font = new Font(selectedFont, currentFont.Size);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.Title = "Save File";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Lấy đường dẫn file
                        string filePath = saveFileDialog.FileName;

                        // Ghi nội dung TextBox vào file
                        File.WriteAllText(filePath, richTextBox1.Text);
                        MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog O_file = new OpenFileDialog();
                O_file.Filter = "Text Files|*.txt|All Files|*.*";
                O_file.Title = "Open Text File";
                if (O_file.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string fileContent = File.ReadAllText(O_file.FileName);
                        richTextBox1.Text = fileContent;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            InitializeFontAndSize();

        }


        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
        private void InitializeFontAndSize()
        {
            // Tạo danh sách Font chữ cho ComboBox Font
            foreach (FontFamily font in FontFamily.Families)
            {
                toolStripComboBox1.Items.Add(font.Name);
            }
            // Thiết lập giá trị mặc định cho ComboBox Font
            toolStripComboBox1.SelectedItem = "Tahoma";

            // Tạo danh sách Size cho ComboBox Size
            int[] fontSizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int size in fontSizes)
            {
                toolStripComboBox2.Items.Add(size);
            }
            // Thiết lập giá trị mặc định cho ComboBox Size
            toolStripComboBox2.SelectedItem = 14;

            // Đặt giá trị mặc định cho RichTextBox
            richTextBox1.Font = new Font("Tahoma", 14);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle;

                // Nếu đang in nghiêng, bỏ in nghiêng; ngược lại, thêm in nghiêng
                if (currentFont.Italic)
                {
                    newFontStyle = currentFont.Style & ~FontStyle.Italic; // Bỏ Italic
                }
                else
                {
                    newFontStyle = currentFont.Style | FontStyle.Italic; // Thêm Italic
                }

                // Cập nhật lại Font của đoạn văn bản được chọn
                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }


        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle;

                // Nếu đang in đậm, bỏ in đậm; ngược lại, thêm in đậm
                if (currentFont.Bold)
                {
                    newFontStyle = currentFont.Style & ~FontStyle.Bold; // Bỏ Bold
                }
                else
                {
                    newFontStyle = currentFont.Style | FontStyle.Bold; // Thêm Bold
                }

                // Cập nhật lại Font của đoạn văn bản được chọn
                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle;

                // Nếu đang gạch dưới, bỏ gạch dưới; ngược lại, thêm gạch dưới
                if (currentFont.Underline)
                {
                    newFontStyle = currentFont.Style & ~FontStyle.Underline; // Bỏ Underline
                }
                else
                {
                    newFontStyle = currentFont.Style | FontStyle.Underline; // Thêm Underline
                }

                // Cập nhật lại Font của đoạn văn bản được chọn
                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        //private void toolStripComboBox1_Click(object sender, EventArgs e)
        //{
        //    Font currentFont = richTextBox1.Font;
        //    string selectedFont = toolStripComboBox1.SelectedItem.ToString();
        //    richTextBox1.Font = new Font(selectedFont, currentFont.Size);
        //}

        //private void toolStripComboBox2_Click(object sender, EventArgs e)
        //{
        //    Font currentFont = richTextBox1.Font;
        //    float selectedSize = float.Parse(toolStripComboBox2.SelectedItem.ToString());

        //    // Cập nhật Font của RichTextBox với Size mới và giữ nguyên Font
        //    richTextBox1.Font = new Font(currentFont.FontFamily, selectedSize);

        //}
    }
}
