namespace baitapbuoi4
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
            this.txt_id_f2 = new System.Windows.Forms.TextBox();
            this.txt_namef2 = new System.Windows.Forms.TextBox();
            this.txt_sal_f2 = new System.Windows.Forms.TextBox();
            this.Accept_but = new System.Windows.Forms.Button();
            this.Cancel_but = new System.Windows.Forms.Button();
            this.label1_IDf2 = new System.Windows.Forms.Label();
            this.label2_Namef2 = new System.Windows.Forms.Label();
            this.label3_salf2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_id_f2
            // 
            this.txt_id_f2.Location = new System.Drawing.Point(241, 72);
            this.txt_id_f2.Name = "txt_id_f2";
            this.txt_id_f2.Size = new System.Drawing.Size(243, 22);
            this.txt_id_f2.TabIndex = 0;
            // 
            // txt_namef2
            // 
            this.txt_namef2.Location = new System.Drawing.Point(241, 110);
            this.txt_namef2.Name = "txt_namef2";
            this.txt_namef2.Size = new System.Drawing.Size(243, 22);
            this.txt_namef2.TabIndex = 1;
            // 
            // txt_sal_f2
            // 
            this.txt_sal_f2.Location = new System.Drawing.Point(241, 160);
            this.txt_sal_f2.Name = "txt_sal_f2";
            this.txt_sal_f2.Size = new System.Drawing.Size(243, 22);
            this.txt_sal_f2.TabIndex = 2;
            // 
            // Accept_but
            // 
            this.Accept_but.Location = new System.Drawing.Point(516, 72);
            this.Accept_but.Name = "Accept_but";
            this.Accept_but.Size = new System.Drawing.Size(78, 81);
            this.Accept_but.TabIndex = 3;
            this.Accept_but.Text = "Accept";
            this.Accept_but.UseVisualStyleBackColor = true;
            this.Accept_but.Click += new System.EventHandler(this.Accept_but_Click);
            // 
            // Cancel_but
            // 
            this.Cancel_but.Location = new System.Drawing.Point(516, 204);
            this.Cancel_but.Name = "Cancel_but";
            this.Cancel_but.Size = new System.Drawing.Size(84, 75);
            this.Cancel_but.TabIndex = 3;
            this.Cancel_but.Text = "Cancel";
            this.Cancel_but.UseVisualStyleBackColor = true;
            this.Cancel_but.Click += new System.EventHandler(this.Cancel_but_Click);
            // 
            // label1_IDf2
            // 
            this.label1_IDf2.AutoSize = true;
            this.label1_IDf2.Location = new System.Drawing.Point(122, 78);
            this.label1_IDf2.Name = "label1_IDf2";
            this.label1_IDf2.Size = new System.Drawing.Size(20, 16);
            this.label1_IDf2.TabIndex = 4;
            this.label1_IDf2.Text = "ID";
            // 
            // label2_Namef2
            // 
            this.label2_Namef2.AutoSize = true;
            this.label2_Namef2.Location = new System.Drawing.Point(122, 116);
            this.label2_Namef2.Name = "label2_Namef2";
            this.label2_Namef2.Size = new System.Drawing.Size(44, 16);
            this.label2_Namef2.TabIndex = 4;
            this.label2_Namef2.Text = "Name";
            // 
            // label3_salf2
            // 
            this.label3_salf2.AutoSize = true;
            this.label3_salf2.Location = new System.Drawing.Point(122, 166);
            this.label3_salf2.Name = "label3_salf2";
            this.label3_salf2.Size = new System.Drawing.Size(46, 16);
            this.label3_salf2.TabIndex = 4;
            this.label3_salf2.Text = "Salary";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3_salf2);
            this.Controls.Add(this.label2_Namef2);
            this.Controls.Add(this.label1_IDf2);
            this.Controls.Add(this.Cancel_but);
            this.Controls.Add(this.Accept_but);
            this.Controls.Add(this.txt_sal_f2);
            this.Controls.Add(this.txt_namef2);
            this.Controls.Add(this.txt_id_f2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id_f2;
        private System.Windows.Forms.TextBox txt_namef2;
        private System.Windows.Forms.TextBox txt_sal_f2;
        private System.Windows.Forms.Button Accept_but;
        private System.Windows.Forms.Button Cancel_but;
        private System.Windows.Forms.Label label1_IDf2;
        private System.Windows.Forms.Label label2_Namef2;
        private System.Windows.Forms.Label label3_salf2;
    }
}