﻿using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.DataAccess
{
    public interface IDataConnection
    {
        EmployeeModel CreateEmployee(EmployeeModel model);

        
    }
}
