using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCF2
{
    class Account
    {
       [Key]
        public string AccountID { get; set; }
   
        public string AccountType { get; set; }

        public string AccountName { get; set; }

        public int CustID { get; set; }

       [ForeignKey("CustID")]
        public Customer Customer { get; set; }
    }
}
