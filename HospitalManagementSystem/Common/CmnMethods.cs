using HospitalManagementSystem.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Common
{
    public static class CmnMethods
    {

        public static void ResetGlobal()
        {
            Global.UserInfo = new Models.User_Infoo();
        }
        
        public static SqlConnection OpenConnectionString(SqlConnection sqlCon)
        {
            if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            sqlCon.Open();
            return sqlCon;

        }

        public static void GetUserInfo(DataTable dt)
        {
            Global.UserInfo = 
        }

    }
}
