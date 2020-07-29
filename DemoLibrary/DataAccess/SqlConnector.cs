using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        /// <summary>
        /// Saves a new employee to the database
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public EmployeeModel CreateEmployee(EmployeeModel model)
        {
            
            using (SqlConnection connection = new SqlConnection(GlobalConfig.CnnString("RRHH01")))
            {                           
                try
                {
                    var param = new DynamicParameters();

                    //SqlCommand Comando = new SqlCommand("name.storeprocedure", connection);
                    //Comando.CommandType = CommandType.StoredProcedure;
                    //Comando.Parameters.Add("@firsName", SqlDbType.NVarChar).Value = model.FirstName;
                    //Comando.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = model.LastName;
                    //Comando.Parameters.Add("@emailAddress", SqlDbType.NVarChar).Value = model.EmailAddress;
                    //Comando.Parameters.Add("@mobilePhone", SqlDbType.NVarChar).Value = model.MobilePhoneNumber;
                    //Comando.Parameters.Add("@Id", SqlDbType.NVarChar).Value = 0;

                    //connection.Open();
                    //Comando.ExecuteNonQuery();
                    //connection.Close();

                    return model;
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    throw ex;
                }
            }
        }
    }
}
