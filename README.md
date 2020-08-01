# BG-CSharp-DemoSolution
Tim Corey learning and exercises

Youtube link: https://www.youtube.com/watch?v=5oHfcyrlHeE&list=PLLWMQd6PeGY3t63w-8MMIjIyYS7MsFcCi&index=10

Pasos:
### 1- Crearemos una Interfaz para la ejecución de acciones de la APP sobre la propia BD:
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
Se define la Interfaz como pública para que cualquier clase que la incluya, pueda acceder a los métodos que esta interfaz contenga.

En este caso, contiene el método CreateEmployee para realizar la acción de guardar los datos recibidos (según el modelo de datos indicado en él mismo (EmployeeModel)), en la BD que designe la conexión de la interfaz (se verá más adelante en este documento).

### 2- Crearemos una clase para almacenar los parámetros globales de la conexión a la BD en la aplicación:
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
Se define la clase como publica para que pueda ser accesible desde cualquier parte de la APP que la invoque.

Contiene una propiedad pública y estática llamada Connections que es del tipo de la interfaz creada en el paso anterior.
Esta propiedad almacenará mediante su método private set el tipo de conexión a BD que usará la APP. 
Hay que destacar que al contener private en la definición de set, únicamente un método ubicado dentro de esta misma clase podrá almacenar información en esta propiedad.

Contiene un método público y estático llamado InitializeSQLConnection que al ser invocado, establecerá el tipo de conexión de la propiedad Connections, de esta misma clase, a partir de la variable sql que ha sido definida y es del tipo SqlConnector (una clase que definiremos más adelante en este documento).

Por último, contiene otra función pública y estática llamada CnnString, que contendrá definidas una o varias connections strings, para realizar la conexión a la BD. 
La elección de la connection string a devolver por esta función  será seleccionada según el parámetro de entrada name recibido.

### 3- Crearemos una clase para conectar y ejecutar las acciones de la APP con la BD, en este caso, SQL Server:



