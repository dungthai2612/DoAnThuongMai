using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DoAnThuongMai1
{
    public partial class GioHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)Session["GioHang"];
            rptGioHang.DataSource = dt;
            rptGioHang.DataBind();

            int tongTien = 0;
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                tongTien += (int)dt.Rows[i]["ThanhTien"];
            }    
            lbThanhTien.Text = tongTien.ToString();
        }
    }
}