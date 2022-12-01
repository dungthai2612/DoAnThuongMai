using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoAnThuongMai1
{
    public partial class SanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int MaNSX = int.Parse(Request["MaNSX"]);
            HienThiSanPham(MaNSX);
        }
        void HienThiSanPham(int MaNSX)
        {
            string query ="select* from SANPHAM where MaNSX="+MaNSX;
            DataTable dt = ConnectSql.GetData(query);
            rptSanPham.DataSource = dt;
            rptSanPham.DataBind();


        }
    }
}