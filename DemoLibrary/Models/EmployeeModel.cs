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

        /// <summary>
        /// Represents the departments where the employee owns
        /// </summary>
        //public List<DepartmentModel> WorkDepartment { get; set; } = new List<DepartmentModel>
    
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
