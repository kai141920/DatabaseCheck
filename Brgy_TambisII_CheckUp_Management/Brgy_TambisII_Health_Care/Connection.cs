using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brgy_TambisII_Health_Care
{
    class Connection
    {
        public static string ConnectionString = "datasource = 127.0.0.1;port = 3306; username =root; password=; database = tambis2checkup";
        public static string IdContent = "";
        public static bool check = false;
        public static bool checkaLL = false;
        public static bool checkUp = false;

        public static string name = "";
        public static string fname = "";
        public static string mname = "";
        public static string lname = "";
        public static string id = "";
    }
}
