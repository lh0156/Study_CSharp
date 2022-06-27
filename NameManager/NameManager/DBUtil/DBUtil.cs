using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameManager.DBUtil
{
    class DBUtil
    {
        public const string connStr = "Provider=OraOLEDB.Oracle;OLEDB.NET=true;PLSQLRSet=true;Data Source=xe;User Id=hr;Password=java1234;";
        public static string selectEnumDepartment = "select * from tblword";



    }
}
