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
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("RRHH01")))
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("HorasExtras.Registro_Entradas_insertar", connection);
                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.Parameters.Add("@firsName", SqlDbType.NVarChar).Value = model.FirstName;
                    Comando.Parameters.Add("@IdGestor", SqlDbType.Int).Value = Obj.IdGestor;
                    Comando.Parameters.Add("@NumEmpleado", SqlDbType.Int).Value = Obj.NumEmpleado;
                    Comando.Parameters.Add("@GFH", SqlDbType.Int).Value = Obj.GFH;
                    Comando.Parameters.Add("@Fecha", SqlDbType.Date).Value = Obj.Fecha;
                    Comando.Parameters.Add("@HoraEntrada", SqlDbType.Time).Value = Obj.HoraEntrada;
                    Comando.Parameters.Add("@HoraSalida", SqlDbType.Time).Value = Obj.HoraSalida;
                    Comando.Parameters.Add("@EstadoValidacion", SqlDbType.Int).Value = Obj.EstadoValidacion;
                    Comando.Parameters.Add("@IdTipoHoras", SqlDbType.Int).Value = Obj.IdTipoHoras;
                    Comando.Parameters.Add("@IdTipoCompensacion", SqlDbType.Int).Value = Obj.IdTipoCompensacion;
                    Comando.Parameters.Add("@IdTipoTrabajo", SqlDbType.Int).Value = Obj.IdTipoTrabajo;
                    Comando.Parameters.Add("@DescTrabajos", SqlDbType.NVarChar).Value = Obj.DescTrabajo;
                    Comando.Parameters.Add("@Activo", SqlDbType.Bit).Value = Obj.Activo;
                    Comando.Parameters.Add("@EmailEnviado", SqlDbType.Bit).Value = Obj.EmailEnviado;
                    Comando.Parameters.Add("@WinUser", SqlDbType.NVarChar).Value = Obj.WinUser;
                    Comando.Parameters.Add("@IdPaqueteHorasWeb", SqlDbType.NVarChar).Value = Obj.IdPaqueteHorasWeb;


                    conn_Rh.Open();
                    Comando.ExecuteNonQuery();
                    conn_Rh.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw ex;
                }
            }
        }
    }
}
