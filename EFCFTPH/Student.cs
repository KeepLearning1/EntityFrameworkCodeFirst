using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCFTPH
{
    class Student : PersonalDetail
    {
        [Index("INDEX_STUDENTID", IsUnique = true)]
        public int StudentID { get; set; }

        public string StudentName { get; set; }

    }
}
