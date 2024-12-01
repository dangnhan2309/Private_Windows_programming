using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace baitapbuoi4
{
    public partial class Form2 : Form
    {
        public delegate void LuuTHongTinhandler(string id, string name, double sal);
        public event LuuTHongTinhandler OnLuuThongTin;
       

        public Form2()
        {
            InitializeComponent();
        }
        public Form2(NhanVien nhanvien)
        {
            InitializeComponent();
            txt_id_f2.Text = nhanvien.MSNV;
            txt_namef2.Text = nhanvien.Name;

            txt_sal_f2.Text= nhanvien.Salary.ToString();
            txt_id_f2.ReadOnly = true;  
        }

        private void Accept_but_Click(object sender, EventArgs e)
        {
            OnLuuThongTin?.Invoke(txt_id_f2.Text, txt_namef2.Text, double.Parse(txt_sal_f2.Text)); 
            this.Close();
//? check xem cos funtion nao 0 , invoke call all funtion in envent.
/*form2.OnLuuThongTin += Form1_OnLuuThongTin;
Khi OnLuuThongTin.Invoke("1", "Alice", 85.5) được gọi,
nó sẽ thực thi phương thức Form1_OnLuuThongTin với các tham số "1", "Alice", 85.5.
*/
        }

        private void Cancel_but_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
