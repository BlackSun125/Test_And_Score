using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestAndScore.Data;

namespace TestAndScore
{
    public partial class Login : Form
    {

        TaiKhoan tk = new TaiKhoan();
        public static int loaitk;
        public static string matk;
        public Login()
        {
            InitializeComponent();
            labelWarning.Hide();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Texts == "" || txtPassword.Texts == "")
            {
                MessageBox.Show("Thông tin chưa đầy đủ!\n Vui long nhập lại thông tin!");
            }
            else
            {
                if (tk.timkiem(txtUsername.Texts, txtPassword.Texts) == 1)
                {
                    MessageBox.Show("Chào Mừng  " + txtUsername.Texts + " Đã Đến Với Phần Mềm Quản Lý Thi Và Chấm Thi");
                    MainForm f = new MainForm();
                    f.Show();
                    Hide();
                    //Dispose();
                }

                else if (tk.timkiem(txtUsername.Texts, txtPassword.Texts) == 2)
                {
                    MessageBox.Show("Chào Mừng == " + txtUsername.Texts + "== Đã Đến Với Phần Mềm Quản Lý Thi Và Chấm Thi");
                    MainForm f = new MainForm();
                    f.Show();
                    Hide();
                    //Dispose();
                }

                else
                {
                    if (MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!\nVui lòng nhập lại thông tin?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        txtUsername.Focus();
                    else
                    {
                        this.Close();
                    }
                }
            }
        }
    }
}
