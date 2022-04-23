using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCF1
{
    class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        public int EmployeeID { get; set; }

        public string EmployeeName { get; set; }

        public string EmployeeRole { get; set; }

        public string EmployeeSalary { get; set; }
     
    }
}
