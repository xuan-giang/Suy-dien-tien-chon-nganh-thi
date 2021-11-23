using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeChuyenGia_Nhom2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnsukien_Click(object sender, EventArgs e)
        {
            quanlysukien frm = new quanlysukien();
            frm.ShowDialog();
        }

        private void btnluat_Click(object sender, EventArgs e)
        {
            quanlyluat frm = new quanlyluat();
            frm.ShowDialog();
        }

        private void btntuvan_Click(object sender, EventArgs e)
        {
            tuvan frm = new tuvan();
            frm.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
