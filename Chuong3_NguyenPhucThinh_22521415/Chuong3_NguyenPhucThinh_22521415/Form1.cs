using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Chuong3_NguyenPhucThinh_22521415
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lb_ms_Click(object sender, EventArgs e)
        {
             
        }

        private void bt_cong_Click(object sender, EventArgs e)
        {
            PhanSo ps1 = new PhanSo(int.Parse(tb_tu1.Text), int.Parse(tb_mau1.Text));
            PhanSo ps2 = new PhanSo(int.Parse(tb_tu2.Text), int.Parse(tb_mau2.Text));
            MessageBox.Show("Tong 2 phan so: " + ps1.Cong(ps2).ToString());
        }

        private void tb_tu1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_mau1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_tu2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_mau2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_tru_Click(object sender, EventArgs e)
        {
            PhanSo ps1 = new PhanSo(int.Parse(tb_tu1.Text), int.Parse(tb_mau1.Text));
            PhanSo ps2 = new PhanSo(int.Parse(tb_tu2.Text), int.Parse(tb_mau2.Text));
            MessageBox.Show("Hieu 2 phan so: " + ps1.Tru(ps2).ToString());
        }

        private void bt_nhan_Click(object sender, EventArgs e)
        {
            PhanSo ps1 = new PhanSo(int.Parse(tb_tu1.Text), int.Parse(tb_mau1.Text));
            PhanSo ps2 = new PhanSo(int.Parse(tb_tu2.Text), int.Parse(tb_mau2.Text));
            MessageBox.Show("Tich 2 phan so: " + ps1.Nhan(ps2).ToString());
        }

        private void bt_chia_Click(object sender, EventArgs e)
        {
            PhanSo ps1 = new PhanSo(int.Parse(tb_tu1.Text), int.Parse(tb_mau1.Text));
            PhanSo ps2 = new PhanSo(int.Parse(tb_tu2.Text), int.Parse(tb_mau2.Text));
            MessageBox.Show("Thuong 2 phan so: " + ps1.Chia(ps2).ToString());
        }

        private void Form1_Load(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you want to close form?", "Demo form",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
