using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_QuanLiBanHang
{
    public class DBConnect
    {
        protected SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QuanLiBanHang;Integrated Security=True");
    }
}
