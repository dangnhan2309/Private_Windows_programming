namespace De01
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.txt_TenSV = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_searching = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.fixButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NotSaveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thong Tin Chi Tiet";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Sinh Viên ";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Sinh";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Họ Và Tên ";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lớp Học ";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.Location = new System.Drawing.Point(143, 53);
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.Size = new System.Drawing.Size(100, 22);
            this.txt_MaSV.TabIndex = 1;
            // 
            // txt_TenSV
            // 
            this.txt_TenSV.Location = new System.Drawing.Point(429, 56);
            this.txt_TenSV.Name = "txt_TenSV";
            this.txt_TenSV.Size = new System.Drawing.Size(100, 22);
            this.txt_TenSV.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(429, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 108);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txt_searching
            // 
            this.txt_searching.Location = new System.Drawing.Point(12, 186);
            this.txt_searching.Name = "txt_searching";
            this.txt_searching.Size = new System.Drawing.Size(122, 22);
            this.txt_searching.TabIndex = 4;
            // 
            // SearchButton
            // 
            this.SearchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchButton.Location = new System.Drawing.Point(143, 163);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(111, 45);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Tìm ";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(260, 186);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(72, 22);
            this.Addbutton.TabIndex = 5;
            this.Addbutton.Text = "Thêm ";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // fixButton
            // 
            this.fixButton.Location = new System.Drawing.Point(338, 186);
            this.fixButton.Name = "fixButton";
            this.fixButton.Size = new System.Drawing.Size(72, 22);
            this.fixButton.TabIndex = 5;
            this.fixButton.Text = "Sửa";
            this.fixButton.UseVisualStyleBackColor = true;
            this.fixButton.Click += new System.EventHandler(this.fixButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(429, 186);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 22);
            this.button4.TabIndex = 5;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(416, 186);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(72, 22);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.Text = "Xóa";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(494, 186);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(72, 22);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Lưu";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NotSaveButton
            // 
            this.NotSaveButton.Location = new System.Drawing.Point(572, 186);
            this.NotSaveButton.Name = "NotSaveButton";
            this.NotSaveButton.Size = new System.Drawing.Size(72, 22);
            this.NotSaveButton.TabIndex = 5;
            this.NotSaveButton.Text = "K.Lưu";
            this.NotSaveButton.UseVisualStyleBackColor = true;
            this.NotSaveButton.Click += new System.EventHandler(this.NotSaveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(650, 186);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(72, 22);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Thoát";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.Ten,
            this.DOB,
            this.Lop});
            this.dataGridView1.Location = new System.Drawing.Point(15, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(707, 224);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MaSV
            // 
            this.MaSV.HeaderText = "Mã Sinh Viên";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            this.MaSV.Width = 125;
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Họ và Tên";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.Width = 125;
            // 
            // DOB
            // 
            this.DOB.HeaderText = "Ngày Sinh";
            this.DOB.MinimumWidth = 6;
            this.DOB.Name = "DOB";
            this.DOB.Width = 125;
            // 
            // Lop
            // 
            this.Lop.HeaderText = "Lớp";
            this.Lop.MinimumWidth = 6;
            this.Lop.Name = "Lop";
            this.Lop.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.NotSaveButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.fixButton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.txt_searching);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_TenSV);
            this.Controls.Add(this.txt_MaSV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.TextBox txt_TenSV;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_searching;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button fixButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button NotSaveButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
    }
}

