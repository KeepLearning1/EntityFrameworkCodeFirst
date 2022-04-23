using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCF2
{
    class Customer
    {
       
         [Key]
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
    
        [ForeignKey("CustomerID")]
        public ICollection<Account> Account { get; set; }
    }
}
