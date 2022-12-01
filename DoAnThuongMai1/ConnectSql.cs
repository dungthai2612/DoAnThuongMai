using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DoAnThuongMai1
{
    public class ConnectSql
    {
        private static string Connect = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\dthai\\source\\repos\\DoAnThuongMai1\\DoAnThuongMai1\\App_Data\\ShopDongHo.mdf;Integrated Security=True";

        // hàm mở kết nối
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(Connect);    // tạo đói tượng kết nối
            conn.Open();    // mở kết nối
            return conn;
        }

        // hàm thực thi câu lệnh truy vẫn không có dũ liệu trả về
        public static void ExecuteNoneQuery(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql);   // đối tượng chứa câu lệnh truy vấn
            cmd.Connection = GetConnection();   // kết nối vói database
            cmd.ExecuteNonQuery();  // thực thi câu lệnh truy vấn không cần dữ liệu trả về
        }


        // hàm thực thi câu lệnh truy vấn có dữ liệu trả về
        public static DataTable GetData(string sql)
        { 
            SqlCommand cmd = new SqlCommand(sql); // đối tượng chứa câu lệnh truy vấn
            cmd.Connection = GetConnection(); // kết nối đối tượng câu lệnh với database
            DataTable dt = new DataTable(); // tạo table để chứa dữ liệu sau khi thực hiện câu lệnh sql
            SqlDataAdapter adapter = new SqlDataAdapter(); // đối tượng thực thi câu lệnh có data trả về
            adapter.SelectCommand = cmd;    // lựa chọn câu lệnh sql muốn thực hiện
            adapter.Fill(dt);   // thực hiện và lấy dữ liệu đưa vào table
            return dt;
        }
    }
}
