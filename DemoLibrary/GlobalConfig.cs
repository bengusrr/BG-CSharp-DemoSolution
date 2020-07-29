using DemoLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connections { get; private set; }

        public static void InitializeSQLConnection()
        {
            SqlConnector sql = new SqlConnector();
            Connections = sql;
        }

        public static string CnnString(string name)
        {
            if (name == "RRHH01")
            {
                return "Server=ESMARSQL01\\ESMARSQL01;database=RRHH_01;uid=APP_RRHH01;pwd=APPrrhh.01;";
            }

            return "";
        }

    }
}
