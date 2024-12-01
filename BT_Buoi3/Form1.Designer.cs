namespace BT_Buoi3
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
            this.dta_listviewSinhVien = new System.Windows.Forms.ListView();
            this.Them_but = new System.Windows.Forms.Button();
            this.Sua_but = new System.Windows.Forms.Button();
            this.Xoa_but = new System.Windows.Forms.Button();
            this.Dong_but = new System.Windows.Forms.Button();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_diem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CL_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cl_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cl_score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // dta_listviewSinhVien
            // 
            this.dta_listviewSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CL_ID,
            this.Cl_Name,
            this.Cl_score});
            this.dta_listviewSinhVien.HideSelection = false;
            this.dta_listviewSinhVien.Location = new System.Drawing.Point(85, 54);
            this.dta_listviewSinhVien.Name = "dta_listviewSinhVien";
            this.dta_listviewSinhVien.Size = new System.Drawing.Size(371, 187);
            this.dta_listviewSinhVien.TabIndex = 0;
            this.dta_listviewSinhVien.UseCompatibleStateImageBehavior = false;
            this.dta_listviewSinhVien.View = System.Windows.Forms.View.Details;
            this.dta_listviewSinhVien.SelectedIndexChanged += new System.EventHandler(this.dta_listviewSinhVien_SelectedIndexChanged);
            // 
            // Them_but
            // 
            this.Them_but.Location = new System.Drawing.Point(85, 247);
            this.Them_but.Name = "Them_but";
            this.Them_but.Size = new System.Drawing.Size(75, 23);
            this.Them_but.TabIndex = 1;
            this.Them_but.Text = "Them";
            this.Them_but.UseVisualStyleBackColor = true;
            this.Them_but.Click += new System.EventHandler(this.Them_but_Click);
            // 
            // Sua_but
            // 
            this.Sua_but.Location = new System.Drawing.Point(166, 247);
            this.Sua_but.Name = "Sua_but";
            this.Sua_but.Size = new System.Drawing.Size(75, 23);
            this.Sua_but.TabIndex = 1;
            this.Sua_but.Text = "Sua";
            this.Sua_but.UseVisualStyleBackColor = true;
            this.Sua_but.Click += new System.EventHandler(this.Sua_but_Click);
            // 
            // Xoa_but
            // 
            this.Xoa_but.Location = new System.Drawing.Point(247, 247);
            this.Xoa_but.Name = "Xoa_but";
            this.Xoa_but.Size = new System.Drawing.Size(75, 23);
            this.Xoa_but.TabIndex = 1;
            this.Xoa_but.Text = "Xoa";
            this.Xoa_but.UseVisualStyleBackColor = true;
            this.Xoa_but.Click += new System.EventHandler(this.Xoa_but_Click);
            // 
            // Dong_but
            // 
            this.Dong_but.Location = new System.Drawing.Point(328, 247);
            this.Dong_but.Name = "Dong_but";
            this.Dong_but.Size = new System.Drawing.Size(75, 23);
            this.Dong_but.TabIndex = 1;
            this.Dong_but.Text = "Dong";
            this.Dong_but.UseVisualStyleBackColor = true;
            this.Dong_but.Click += new System.EventHandler(this.Dong_but_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(512, 57);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(217, 22);
            this.txt_ID.TabIndex = 2;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(512, 85);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(217, 22);
            this.txt_Name.TabIndex = 2;
            // 
            // txt_diem
            // 
            this.txt_diem.Location = new System.Drawing.Point(512, 113);
            this.txt_diem.Name = "txt_diem";
            this.txt_diem.Size = new System.Drawing.Size(217, 22);
            this.txt_diem.TabIndex = 2;
            this.txt_diem.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Diem";
            // 
            // CL_ID
            // 
            this.CL_ID.Text = "ID";
            this.CL_ID.Width = 30;
            // 
            // Cl_Name
            // 
            this.Cl_Name.Text = "Name";
            this.Cl_Name.Width = 123;
            // 
            // Cl_score
            // 
            this.Cl_score.Text = "Score";
            this.Cl_score.Width = 141;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_diem);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.Dong_but);
            this.Controls.Add(this.Xoa_but);
            this.Controls.Add(this.Sua_but);
            this.Controls.Add(this.Them_but);
            this.Controls.Add(this.dta_listviewSinhVien);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView dta_listviewSinhVien;
        private System.Windows.Forms.Button Them_but;
        private System.Windows.Forms.Button Sua_but;
        private System.Windows.Forms.Button Xoa_but;
        private System.Windows.Forms.Button Dong_but;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_diem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader CL_ID;
        private System.Windows.Forms.ColumnHeader Cl_Name;
        private System.Windows.Forms.ColumnHeader Cl_score;
    }
}

