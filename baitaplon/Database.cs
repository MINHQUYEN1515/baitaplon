using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitaplon
{
    internal class Database
    {
        public static SqlConnection SqlConnection = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["Database"]);
    }
}
