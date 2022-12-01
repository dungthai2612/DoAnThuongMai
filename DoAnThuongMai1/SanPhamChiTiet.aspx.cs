using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

namespace DoAnThuongMai1
{
    public partial class SanPhamChiTiet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int MaSP = int.Parse(Request["MaSP"]);
            HienThiSanPhamChiTiet(MaSP);
        }
        void HienThiSanPhamChiTiet(int MaSP)
        {
            string query = "select * from SANPHAM where MaSP=" + MaSP;
            DataTable dt = ConnectSql.GetData(query);
            rptSanPhamChiTiet.DataSource = dt;
            rptSanPhamChiTiet.DataBind();
        }
    }
}