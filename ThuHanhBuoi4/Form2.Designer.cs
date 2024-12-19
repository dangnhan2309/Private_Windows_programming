namespace buoi_6
{
    partial class Form2
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_DOB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_gender = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.Sua_but = new System.Windows.Forms.Button();
            this.Xoa_but = new System.Windows.Forms.Button();
            this.Class_combo_box = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(150, 51);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 22);
            this.txt_id.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(150, 79);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 22);
            this.txt_name.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // txt_DOB
            // 
            this.txt_DOB.Location = new System.Drawing.Point(150, 107);
            this.txt_DOB.Name = "txt_DOB";
            this.txt_DOB.Size = new System.Drawing.Size(100, 22);
            this.txt_DOB.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 1;
            // 
            // txt_gender
            // 
            this.txt_gender.Location = new System.Drawing.Point(150, 163);
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.Size = new System.Drawing.Size(100, 22);
            this.txt_gender.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Class";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name_id,
            this.name_Name,
            this.name_DOB,
            this.name_Gender,
            this.name_Class});
            this.dataGridView1.Location = new System.Drawing.Point(312, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(334, 197);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // name_id
            // 
            this.name_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name_id.HeaderText = "ID";
            this.name_id.MinimumWidth = 6;
            this.name_id.Name = "name_id";
            // 
            // name_Name
            // 
            this.name_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name_Name.HeaderText = "Name";
            this.name_Name.MinimumWidth = 6;
            this.name_Name.Name = "name_Name";
            // 
            // name_DOB
            // 
            this.name_DOB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name_DOB.HeaderText = "DOB";
            this.name_DOB.MinimumWidth = 6;
            this.name_DOB.Name = "name_DOB";
            // 
            // name_Gender
            // 
            this.name_Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name_Gender.HeaderText = "Gender";
            this.name_Gender.MinimumWidth = 6;
            this.name_Gender.Name = "name_Gender";
            // 
            // name_Class
            // 
            this.name_Class.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name_Class.HeaderText = "Class";
            this.name_Class.MinimumWidth = 6;
            this.name_Class.Name = "name_Class";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "DOB";
            // 
            // Sua_but
            // 
            this.Sua_but.Location = new System.Drawing.Point(155, 320);
            this.Sua_but.Name = "Sua_but";
            this.Sua_but.Size = new System.Drawing.Size(77, 25);
            this.Sua_but.TabIndex = 5;
            this.Sua_but.Text = "sua/them";
            this.Sua_but.UseVisualStyleBackColor = true;
            this.Sua_but.Click += new System.EventHandler(this.Sua_but_Click);
            // 
            // Xoa_but
            // 
            this.Xoa_but.Location = new System.Drawing.Point(258, 320);
            this.Xoa_but.Name = "Xoa_but";
            this.Xoa_but.Size = new System.Drawing.Size(77, 25);
            this.Xoa_but.TabIndex = 5;
            this.Xoa_but.Text = "xoa";
            this.Xoa_but.UseVisualStyleBackColor = true;
            this.Xoa_but.Click += new System.EventHandler(this.Xoa_but_Click);
            // 
            // Class_combo_box
            // 
            this.Class_combo_box.FormattingEnabled = true;
            this.Class_combo_box.Location = new System.Drawing.Point(150, 238);
            this.Class_combo_box.Name = "Class_combo_box";
            this.Class_combo_box.Size = new System.Drawing.Size(121, 24);
            this.Class_combo_box.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Class_combo_box);
            this.Controls.Add(this.Xoa_but);
            this.Controls.Add(this.Sua_but);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_gender);
            this.Controls.Add(this.txt_DOB);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FillFalcutyComboBox;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_DOB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_gender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Sua_but;
        private System.Windows.Forms.Button Xoa_but;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_Class;
        private System.Windows.Forms.ComboBox Class_combo_box;
    }
}