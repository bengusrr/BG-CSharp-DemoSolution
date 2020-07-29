using DemoLibrary.DataAccess;
using System;
using System.Collections.Generic;
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

    }
}
