﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nha_Sach_Desktop.BUS;
using Nha_Sach_Desktop.DTO;

namespace Nha_Sach_Desktop.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            BUSLogin lg = new BUSLogin();
            DTOLogin acc = new DTOLogin();
            acc.taiKhoan = txtTaiKhoan.Text;
            acc.matKhau = txtMatKhau.Text;

            if (lg.BLLKTraTKhoan(acc) == true)
            {
                this.Hide();
                frmTrangChu frmTrangChu = new frmTrangChu();
                frmTrangChu.ShowDialog();
                this.Close();
            }    
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại");
            }    
        }
    }
}
