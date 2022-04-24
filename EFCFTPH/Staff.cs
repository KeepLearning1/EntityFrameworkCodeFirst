using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCFTPH
{
    class Staff : PersonalDetail
    {
        [Index("INDEX_STAFFID",  IsUnique = true)]
        public int StaffID { get; set; }

        public string StaffName { get; set; }

    }
}
