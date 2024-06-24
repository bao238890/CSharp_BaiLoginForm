using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_BaiLoginForm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtPass.Text == "238890")
            {
                  FrmMain frmMain = new FrmMain();
            this.Hide();
            frmMain.ShowDialog();
            this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu","lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
