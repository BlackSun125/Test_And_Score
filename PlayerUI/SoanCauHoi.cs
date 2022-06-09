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
    public partial class SoanCauHoi : Form
    {
        CauHoi ch = new CauHoi();
        public SoanCauHoi()
        {
            InitializeComponent();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {

            //customComboBox2.DataTextField = ch.mamonhoc().Columns["maMH"].ToString();
            //customComboBox2.DataBindings;
            try
            {
                string dokho = customComboBox1.Texts;
                ch.them((ch.hienthi().Rows.Count + 1).ToString(), customComboBox2.Texts, dokho, customTextBox1.Texts);
                MessageBox.Show("Thêm câu hỏi mới thành công");
            }
            catch
            {
                MessageBox.Show("Thêm câu hỏi mới thất bại");
            }

        }

        private void customComboBox2_Load(object sender, EventArgs e)
        {
            //customComboBox2.DataSource = ch.mamonhoc();
            for (int j = 0; j < ch.mamonhoc().Rows.Count; j++)

            {
                string text = ch.mamonhoc().Rows[j]["maMH"].ToString();
                this.customComboBox2.Items.Add(text);
            }
        }
    }
}
