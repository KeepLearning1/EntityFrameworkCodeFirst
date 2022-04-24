﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCFTPH
{
    class DataContext : DbContext
    {
        public DataContext() : base("name=con")
        {

        }

        public DbSet<PersonalDetail> PersonalDetails { get; set; }
    }
}
