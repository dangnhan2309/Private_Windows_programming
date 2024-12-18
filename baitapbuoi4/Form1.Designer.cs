namespace baitapbuoi4
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
            this.dtGridNhanvien = new System.Windows.Forms.DataGridView();
            this.them_but = new System.Windows.Forms.Button();
            this.Sua_but = new System.Windows.Forms.Button();
            this.Xoa_but = new System.Windows.Forms.Button();
            this.dong_but = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridNhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridNhanvien
            // 
            this.dtGridNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridNhanvien.Location = new System.Drawing.Point(37, 66);
            this.dtGridNhanvien.Name = "dtGridNhanvien";
            this.dtGridNhanvien.RowHeadersWidth = 51;
            this.dtGridNhanvien.RowTemplate.Height = 24;
            this.dtGridNhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridNhanvien.Size = new System.Drawing.Size(428, 289);
            this.dtGridNhanvien.TabIndex = 0;
            this.dtGridNhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dtGridNhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridNhanvien_CellContentClick);
            // 
            // them_but
            // 
            this.them_but.Location = new System.Drawing.Point(507, 65);
            this.them_but.Name = "them_but";
            this.them_but.Size = new System.Drawing.Size(129, 54);
            this.them_but.TabIndex = 1;
            this.them_but.Text = "Them";
            this.them_but.UseVisualStyleBackColor = true;
            this.them_but.Click += new System.EventHandler(this.them_but_Click);
            // 
            // Sua_but
            // 
            this.Sua_but.Location = new System.Drawing.Point(507, 148);
            this.Sua_but.Name = "Sua_but";
            this.Sua_but.Size = new System.Drawing.Size(129, 51);
            this.Sua_but.TabIndex = 2;
            this.Sua_but.Text = "Sua";
            this.Sua_but.UseVisualStyleBackColor = true;
            this.Sua_but.Click += new System.EventHandler(this.Sua_but_Click);
            // 
            // Xoa_but
            // 
            this.Xoa_but.Location = new System.Drawing.Point(507, 244);
            this.Xoa_but.Name = "Xoa_but";
            this.Xoa_but.Size = new System.Drawing.Size(129, 49);
            this.Xoa_but.TabIndex = 3;
            this.Xoa_but.Text = "Xoa";
            this.Xoa_but.UseVisualStyleBackColor = true;
            this.Xoa_but.Click += new System.EventHandler(this.Xoa_but_Click);
            // 
            // dong_but
            // 
            this.dong_but.Location = new System.Drawing.Point(507, 325);
            this.dong_but.Name = "dong_but";
            this.dong_but.Size = new System.Drawing.Size(129, 50);
            this.dong_but.TabIndex = 4;
            this.dong_but.Text = "Dong";
            this.dong_but.UseVisualStyleBackColor = true;
            this.dong_but.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "FORM Quản Lí Nhân Viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dong_but);
            this.Controls.Add(this.Xoa_but);
            this.Controls.Add(this.Sua_but);
            this.Controls.Add(this.them_but);
            this.Controls.Add(this.dtGridNhanvien);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridNhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridNhanvien;
        private System.Windows.Forms.Button them_but;
        private System.Windows.Forms.Button Sua_but;
        private System.Windows.Forms.Button Xoa_but;
        private System.Windows.Forms.Button dong_but;
        private System.Windows.Forms.Label label1;

    }
}

