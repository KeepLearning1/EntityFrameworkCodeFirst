using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCF2
{
    class DataContext :DbContext
    {
        public DataContext() :base ("name=con")
        {

        }

        public DbSet<Account> Account { get; set; }

        public DbSet<Customer> Customer { get; set; }

       
    }

    
}
