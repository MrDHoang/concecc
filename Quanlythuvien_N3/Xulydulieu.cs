using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien_N3
{
    internal class Xulydulieu
    {
        SqlConnection con;
        public void KetNoi()
        {
            if (con == null)
                con = new SqlConnection();
            con.ConnectionString = "Data Source=HOANG\\SQLEXPRESS;Initial Catalog=Qlythuvien;Integrated Security=True";
            con.Open();

        }
        public void NgatKetNoi()
        {
            if (con != null)
                con.Close();
        }
        //hàm này dùng để thực hiện lệnh insert/update/delete
        public int ThucHienLenh(string sql)
        {
            int ketqua = -1;
            try
            {
                KetNoi();
                SqlCommand command = new SqlCommand(sql, con);
                ketqua = command.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                NgatKetNoi();
            }
            return ketqua;
        }
        //hàm này dùng để thực hiện lệnh select
        public DataTable LayDuLieu(string sql)
        {
            DataTable ketqua = new DataTable();
            try
            {
                KetNoi();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(ketqua);
            }
            catch
            {

            }
            finally
            {
                NgatKetNoi();
            }
            return ketqua;
        }
        public DataTable LayDuLieuWithParams(SqlCommand command)
        {
            DataTable result = new DataTable();
            try
            {
                KetNoi(); // Kết nối cơ sở dữ liệu
                command .Connection = con; // Gán kết nối vào SqlCommand
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter .Fill(result); // Điền dữ liệu vào DataTable
            }
            catch (Exception ex)
            {
                // Log lỗi nếu cần
                Console .WriteLine(ex .Message);
            }
            finally
            {
                NgatKetNoi(); // Ngắt kết nối
            }
            return result;
        }
    }
}
