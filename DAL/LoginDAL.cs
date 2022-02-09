using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using SDA.DAL.DataSet1TableAdapters;

namespace SDA.DAL
{
    public class LoginDAL
    {

        public Staff Login (string username, int pass){
            Staff staff =new Staff();
            bool found = false;
         
          StaffTableAdapter sta = new StaffTableAdapter();
          foreach(DataSet1.StaffRow row in sta.GetData())
            {
                if(row.name == username && row.id == pass)
                {
                    staff.Age = row.age;
                    staff.Name = row.name;
                    staff.Id = row.id;
                    staff.Pnumber = row.pnumb;


                    found = true;
                    return staff;
                }

            }
            if (found == false)
            {
                return null;
            }
            
            return null;
        }
    }
}