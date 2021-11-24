using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChonNganhThi_Nhom11
{
    class sukien_xl
    {
        ketnoi kn = new ketnoi();
        public void them(sukien sk)
        {
            String sql = "insert into tblsukien values('" + sk.Masukien + "',N'" + sk.Motasukien + "','"+sk.LoaiSK+"')";
            kn.thuchien(sql);

        }
        public void sua(sukien sk)
        {
            String sql = "update tblsukien set motasukien = N'" + sk.Motasukien+ "',loaisukien='"+sk.LoaiSK+"' where masukien = '" + sk.Masukien + "' ";
            kn.thuchien(sql);
        }
        public void xoa(String mask)
        {
            String sql = "delete from tblsukien where masukien ='" + mask + "'";
            kn.thuchien(sql);


        }
        public DataTable timkiem(String mask)
        {
            String sql = "select * from tblsukien where masukien ='" + mask + "'";
            return kn.getTable(sql);
        }
        public DataTable loadsukien()
        {
            String sql = "select * from tblsukien";
            return kn.getTable(sql);
        }
        public DataTable LoadLoaiSK() {
            string sql = "select distinct loaisukien FROM tblsukien";
            return kn.getTable(sql);
        }
    }
}
