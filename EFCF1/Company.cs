using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCF1
{
    class Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        public int EmployeeID { get; set; }  

        public DateTime EmployeeJoinDate { get; set; }  


        [ForeignKey("EmployeeID")]
        public Employee employee { get; set; }
    }
}
