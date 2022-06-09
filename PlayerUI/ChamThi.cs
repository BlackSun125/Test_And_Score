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
    public partial class ChamThi : Form
    {
        public ChamThi()
        {
            InitializeComponent();
            comboBox4.DataSource = a.hienthithisinh();
            comboBox4.DisplayMember = "mssv";
            AddBinding();
        }
        Chamthi a = new Chamthi();
        private void ChamThi_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = a.hienthilop();
            comboBox2.DataSource = a.hienthimonthi();
            comboBox3.DataSource = a.hienthigiangvien();
            comboBox2.DisplayMember = "tenMH";
            comboBox1.DisplayMember = "tenlop";
            comboBox3.DisplayMember = "tenGV";

        }
        void AddBinding()
        {
            customTextBox5.DataBindings.Add(new Binding("Texts", comboBox4.DataSource, "hoten"));
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
             //customComboBox2.DataTextField = ch.mamonhoc().Columns["maMH"].ToString();
             //customComboBox2.DataBindings;
             try
             {
                  float b = float.Parse(customTextBox6.Texts);
                  a.them(comboBox4.SelectedItem.ToString(), b, customTextBox7.Texts, customTextBox8.Texts);
                  MessageBox.Show("Thêm chấm thi mới thành công");
             }
            catch
             {
                  MessageBox.Show("Thêm chấm thi mới thất bại");
             }

        }
    }
}
