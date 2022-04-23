using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCF1
{
    class DataContext :DbContext
    {
        public DataContext() :base ("name=con")
        {

        }

        public DbSet<Employee> Empployee { get; set; }

        public DbSet<Company> Company { get; set; }
    }
}
