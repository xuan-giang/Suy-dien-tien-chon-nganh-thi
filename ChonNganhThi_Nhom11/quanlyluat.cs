using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChonNganhThi_Nhom11
{
    public partial class quanlyluat : Form
    {
        luat_xl xl = new luat_xl();
        private int id;
        public quanlyluat()
        {
            InitializeComponent();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            String mal;
            mal = txttimkiem.Text;
            dataluat.DataSource = xl.timkiem(mal);
            txttimkiem.Text = "";
        }

        private void quanlyluat_Load(object sender, EventArgs e)
        {
            dataluat.DataSource = xl.loadluat();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmaluat.Text != "" && txtnoidung.Text != "")
                {
                    luat l = new luat();
                    l.Maluat = txtmaluat.Text;
                    l.Noidung = txtnoidung.Text;
                    xl.them(l);
                    dataluat.DataSource = xl.loadluat();
                    txtmaluat.Text = "";
                    txtnoidung.Text = "";

                }
                else {
                    MessageBox.Show("Không được để trống!");
                }

            }
            catch 
            {

                MessageBox.Show("Thêm Thành công!");
            }
            
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            luat l = new luat();
            l.Maluat = txtmaluat.Text;
            l.Noidung = txtnoidung.Text;
            xl.sua(l);
            dataluat.DataSource = xl.loadluat();
            txtmaluat.Text = "";
            txtnoidung.Text = "";
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            String mal;
            mal = txtmaluat.Text;
            xl.xoa(mal);
            dataluat.DataSource = xl.loadluat();
            txtmaluat.Text = "";
            txtnoidung.Text = "";
        }

        private void dataluat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = e.RowIndex;
            if (id >= 0 && id < dataluat.Rows.Count)
            {
                this.txtmaluat.Text = dataluat.Rows[id].Cells[0].Value.ToString();
                this.txtnoidung.Text = dataluat.Rows[id].Cells[1].Value.ToString();

            }
        }
    }
}
