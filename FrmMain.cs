﻿using System;
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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int so = Convert.ToInt32(txtNhapso.Text);
            for (int i = 1;i <= so;i++)
            {
                if (so % i == 0)
                {
                    listBox1.Items.Add(i.ToString());
                }
            }
        }
    }
}
