using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class CommonProps
    {
        public DateTime? Added_Date { get; set; } = null;

        public int Added_By { get; set; } = 0;

        public DateTime? Updated_Date { get; set; } = null;

        public int Updated_By { get; set; } = 0;


    }
}
