using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class User_Infoo : CommonProps
    {
        public int User_Id { get; set; } = 0;

        public string User_Name { get; set; } = "";

        public string User_Password { get; set; } = "";

        public int User_Type { get; set; } = 0;

        public int Doctor_Id { get; set; } = 0;

    }
}
