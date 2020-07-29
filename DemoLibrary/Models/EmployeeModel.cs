using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Models
{
    public class EmployeeModel
    {
        /// <summary>
        /// Represents the unique identifier for the employed
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the first name of the employed
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents the last name of the employed
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents the email address of the employed
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Represents the mobile phone number of the employed
        /// </summary>
        public string MobilePhoneNumber { get; set; }

        /// <summary>
        /// Represents the departments where the employed owns
        /// </summary>
        public List<DepartmentModel> WorkDepartment { get; set; } = new List<DepartmentModel>
    }

}
