# BG-CSharp-DemoSolution
Tim Corey learning and exercises

Youtube link: https://www.youtube.com/watch?v=5oHfcyrlHeE&list=PLLWMQd6PeGY3t63w-8MMIjIyYS7MsFcCi&index=10

Pasos:
### 1- Crearemos la clase que contendrá uno de los modelo de datos que usará la APP:

```
using System;
using System.Collections.Generic;

namespace DemoLibrary.Models
{
    public class EmployeeModel
    {
        /// <summary>
        /// Represents the unique identifier for the employee
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the first name of the employee
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents the last name of the employee
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents the email address of the employee
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Represents the mobile phone number of the employee
        /// </summary>
        public string MobilePhoneNumber { get; set; }

        public EmployeeModel()
        {
        }

        public EmployeeModel(string firstName, string lastName, string emailAddress, string mobilePhone)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            MobilePhoneNumber = mobilePhone;

            #region "number values example"
            //int numberValueNew = 0;
            //int.TryParse(numberValue, out numberValueNew);
            //NumberValue = numberValueNew;
            #endregion
        }
    }
}
```
Se define una clase pública llamada EmployeeModel con el modelo de datos de la tabla de empleados, para poder ser usada en cualquier parte de la APP que la invoque.

Para cada uno de los campos de la tabla, se creará una propiedad en la clase, que contendrá el nombre y tipo de dato que coincidirá con el original de la tabla de datos.

Por último se creará una función del mismo tipo de la clase para asignar un valor a cada una de sus propiedades.
Estos valores serán enviados a la función como parámetros de entrada, convirtiendo el dato enviado a la función en el tipo de datos de la propiedad, antes de almacenarlo en su propiedad.

### 2- Crearemos una Interfaz para la ejecución de acciones de la APP sobre la propia BD:

```
using DemoLibrary.Models;

namespace DemoLibrary.DataAccess
{
    public interface IDataConnection
    {
        EmployeeModel CreateEmployee(EmployeeModel model);
    }
}
```

Se define una Interfaz pública llamada IDataConnection para que cualquier clase que la incluya, pueda acceder a los métodos que esta interfaz contenga.

En este caso, contiene el método CreateEmployee para realizar la acción de guardar los datos recibidos (según el modelo de datos indicado en él mismo (EmployeeModel)), en la BD que designe la conexión de la interfaz (se verá más adelante en este documento).

### 3- Crearemos una clase para almacenar los parámetros globales de la conexión a la BD en la aplicación:

```
using DemoLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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
```

Se define una clase pública y estática llamada GlobalConfig que será accesible desde cualquier parte de la APP que la invoque.

Contiene una propiedad pública y estática llamada Connections que es del tipo de la interfaz creada en el paso anterior.
Esta propiedad almacenará mediante su método private set el tipo de conexión a BD que usará la APP. 
Hay que destacar que al contener private en la definición de set, únicamente un método ubicado dentro de esta misma clase podrá almacenar información en esta propiedad.

Contiene un método público y estático llamado InitializeSQLConnection que al ser invocado, establecerá el tipo de conexión de la propiedad Connections, de esta misma clase, a partir de la variable sql que ha sido definida y es del tipo SqlConnector (una clase que definiremos más adelante en este documento).

Por último, contiene otra función pública y estática llamada CnnString, que contendrá definidas una o varias connections strings, para realizar la conexión a la BD. 
La elección de la connection string a devolver por esta función  será seleccionada según el parámetro de entrada name recibido.

### 4- Crearemos una clase para conectar y ejecutar las acciones de la APP con la BD, en este caso, SQL Server:

```
using Dapper;
using DemoLibrary.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
                    // using Dapper extension
                    var param = new DynamicParameters();
                    param.Add("@firstName", model.FirstName);
                    param.Add("@lastName", model.LastName);
                    param.Add("@emailAddress", model.EmailAddress);
                    param.Add("@mobilePhone", model.MobilePhoneNumber);
                    param.Add("@id", 0, DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("test_spEmployees_Insert", param, commandType: CommandType.StoredProcedure);

                    model.Id = param.Get<int>("@id");

                    return model;
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
```

Se define una clase pública llamada SqlConnector que será accesible desde cualquier parte de la APP que la invoque. A su vez, esta clase incluye en su definición a la interfaz IDataConnection y por lo tanto, todos los métodos y propiedades de esta interfaz serán también incluidos en la clase.

Contiene una función pública llamada CreateEmploye, esta función será del tipo de datos EmployeeModel, y contendrá un parámetro de entrada model también del mismo tipo.
Dentro de esta función, se creará una conexión SQL a la base de datos, llamando en dicha creación a la propiedad CnnString de la clase GlobalConfig.
Esta conexión se creará dentro de una instrucción using, con el cometido de destruir (dispose) dicha conexión en el momento que concluya el código incluido entre las llaves de esta instrucción.
El contenido de la instrucción es la creación de una variable para contener los parámetros que van a usarse en la llamada a la store procedure que almacenará los datos. 
Hay que destacar que la clase usada para crear esta variable (DynamicParameters) forma parte de un complemento llamado Dapper que deberá ser cargado en el IDE de VisualStudio (explicación en video de Tim Corey Youtube: https://youtu.be/Et2khGnrIqc)

Se añadirá un nuevo item a la variable de parámetros por cada uno de los parámetros de entrada que contenga la store procedure de la base de datos, indicando el nombre de estos y el valor que se le va a enviar en cada uno de ellos.
El último parámetro (@id) se indicará que es de salida, porque una vez creado el registro en la tabla, recibirá el número de identificador único (Id) del registro.

Haciendo uso de la conexión creada, ejecutaremos la store procedure según el nombre que le indiquemos, también añadiremos la variable de parámetros a esta ejecución y el tipo de comando que va a ejecutarse en la BD.

Por último, almacenaremos en el modelo de datos el Id devuelto por la store procedure, tras ejecutarse.

### 5 - La llamada a la ejecución de estos datos a la base de datos la podemos efectuar, por ejemplo, desde la pulsación de un botón en un formulario:

```
private void createEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeModel model = new EmployeeModel(
                firstNameValue.Text,
                lastNameValue.Text,
                emailValue.Text,
                mobilePhoneValue.Text );

            GlobalConfig.Connections.CreateEmployee(model);

            IdLabel.Text = model.Id.ToString();

            firstNameValue.Text = "";
            lastNameValue.Text = "";
            emailValue.Text = "";
            mobilePhoneValue.Text = "";
        }
```

Dentro del evento Button_Click, añadiremos una variable del tipo EmployeeModel (el modelo de datos creado anteriormente), y asignaremos un valor a cada una de las propiedades de este modelo, según el valor indicado en varios TextBox (y para simplificar, omitiremos por ahora cualquier comprobación sobre los datos introducidos en estos controles).

Usando la propiedad Connections de la clase GlobalConfig, se llamará a la función CreateEmployee incluida en la interfaz, teniendo como parámetro de entrada el modelo de datos EmployeeModel. Esta llamada a la función, ejecutará la inserción de los datos en la tabla, según las instrucciones indicadas en el paso 4.

### 6 - Anexo: Script para crear la tabla y store procedure en la BD:

```
USE [RRHH_01]
GO

CREATE TABLE [dbo].[test_employees](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [firstName] [nvarchar](50) NULL,
    [lastName] [nvarchar](50) NULL,
    [emailAddress] [nvarchar](50) NULL,
    [mobilePhone] [nvarchar](50) NULL,
    [active] [bit] NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[test_employees] ADD  CONSTRAINT [DF_test_employees_active]  DEFAULT ((1)) FOR [active]
GO


USE [RRHH_01]
GO


CREATE PROCEDURE [dbo].[test_spEmployees_Insert] 
    -- Add the parameters for the stored procedure here
    @firstName  NVARCHAR(50),
    @lastName   NVARCHAR(50),
    @emailAddress   NVARCHAR(50),
    @mobilePhone    NVARCHAR(50),
    @id INT = 0 output
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

    -- Insert statements for procedure here
    INSERT INTO test_employees (firstName, lastName, emailAddress, mobilePhone)
    VALUES (@firstName, @lastName, @emailAddress, @mobilePhone)

    select  @id = SCOPE_IDENTITY();
END
GO
```

Ejemplo del script a utilizar para la creación de la propia tabla y la store procedure en el servidor SQL Server.
