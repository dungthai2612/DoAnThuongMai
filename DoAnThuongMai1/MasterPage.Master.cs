using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DoAnThuongMai1
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HienThiHangSanXuat();
            }
        }
        void HienThiHangSanXuat()
        {
            string query = "select * from HANGSX";
            DataTable dt = ConnectSql.GetData(query);
            rptHangSanXuat.DataSource = dt;
            rptHangSanXuat.DataBind();
        }
    }
}