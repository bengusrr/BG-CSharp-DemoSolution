using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Models
{
    public class DepartmentModel
    {
        /// <summary>
        /// Represents the unique identifier for the department
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Represents Department´s name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Represents the cost center of the department
        /// </summary>
        public int CostCenter { get; set; }

        /// <summary>
        /// Represents some additional description for the department
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Represents Activation field for the department
        /// </summary>
        public bool Active { get; set; }
    }
}
