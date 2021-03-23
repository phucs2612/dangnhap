using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNhap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUser.Text =="admin" && txtPassword.Text=="admin"  )
            {
                MessageBox.Show("Đăng nhập thành công");
                Form2 fm = new Form2();
                fm.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập Thất bại");
            }
        }
    }
}
