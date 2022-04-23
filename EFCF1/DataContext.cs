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

///Summary///
///enable-migrations///-to Enables the migration for the project by creating a Configuration class.
///add-migration///-Creates a new migration class as per specified name with the Up() and Down() methods
///update-database///-Executes the last migration file created by the Add-Migration command and applies changes to the database schema.
///update-database -Verbose///Use the –verbose option to view the SQL statements being applied to the target database.
///update-database -TargetMigration:SchoolDB-v1//to roll back the database schema to any of the previous states, 
///        then you can execute the update-database command with the –TargetMigration parameter to the point which you want to roll back to
///        ex: update-database -TargetMigration:202204230757439_data1
