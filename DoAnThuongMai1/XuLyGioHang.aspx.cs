using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoAnThuongMai1
{
    public partial class XuLyGioHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int MaSP = int.Parse(Request["MaSP"]);
            ThemVaoGioHang(MaSP);
            Response.Redirect("GioHang.aspx");
        }
        void KhoiTaoGioHang()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSP",typeof(int));
            dt.Columns.Add("TenSP",typeof (string));
            dt.Columns.Add("SoLuong", typeof(int));
            dt.Columns.Add("DonGia", typeof(int));
            dt.Columns.Add ("ThanhTien",typeof (int));
            Session["GioHang"] = dt;
        }
        void ThemVaoGioHang(int MaSP)
        {
            //kiemtraxemdataogiohangchua
            if (Session["GioHang"]==null)
            {
                KhoiTaoGioHang();
            }
            //themsanphamvaogiohang

            //laythongtincuasanpham
            string query = "select * from SANPHAM where MaSP=" + MaSP;
            DataTable dt = ConnectSql.GetData(query);
            //lay gio hang ra tu session
            DataTable gioHang = (DataTable)Session["GioHang"];
            
            //truong hop da co san pham trong gio hang
            for(int i = 0; i < gioHang.Rows.Count; i++)
            {
                // kiem tra co trong gio hang khong , neu co thi tang so luong
                if(MaSP == (int)gioHang.Rows[i]["MaSP"])
                {
                    int soLuongCu = (int)gioHang.Rows[i]["SoLuong"];
                    gioHang.Rows[i]["SoLuong"] = soLuongCu + 1;
                    gioHang.Rows[i]["ThanhTien"] = (int)gioHang.Rows[i]["DonGia"] * (int)gioHang.Rows[i]["SoLuong"];
                    Session["GioHang"] = gioHang;
                    return;
                }
            }
            //them vao gio hang
            DataRow newRow = gioHang.NewRow();
            newRow["MaSP"] = MaSP;
            newRow["tenSP"] = dt.Rows[0]["TenSP"].ToString();
            newRow["SoLuong"] = 1;
            newRow["DonGia"] = (int)dt.Rows[0]["DonGia"];
            newRow["ThanhTien"] = (int)dt.Rows[0]["DonGia"];
            gioHang.Rows.Add(newRow);
            Session["GioHang"] = gioHang;
        }
    }
}