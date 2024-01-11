using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Phone_Directory
{
    public class DB
    {
        public static SqlConnection con = null;
        public static void sqlcon()
        {
            con = new SqlConnection("server = coder; database = phonedirectory; integrated security = true;");
        }
    }
}
