using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Medicine : CommonProps
    {
        public int Medicine_Id { get; set; } = 0;
        
        public string Medicine_Name { get; set; } = "";

        public int Dianosis_Id { get; set; } = 0;

        public int Patient_Id { get; set; } = 0;


    }
}
