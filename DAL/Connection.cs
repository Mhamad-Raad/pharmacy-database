using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace SDA.DAL
{
    public class Connection
    {

        public SqlConnection connection()
        {
            SqlConnection connection = null;
            connection= new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hamar\source\repos\SDA\App_Data\Farmacy.mdf;Integrated Security=True");
            return connection;
        }
    }
}

