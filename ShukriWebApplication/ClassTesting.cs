using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Internal.Account;
using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ShukriWebApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShukriWebApplication.Data.Migrations;
using Microsoft.Data.SqlClient;

namespace ShukriWebApplication
{
    public class ClassTesting
    {
        public string ApplicationDbContextDATA(string UN)
        {
            using (SqlConnection conn3 = new SqlConnection(
                new SqlConnectionStringBuilder()
                {
                    DataSource = "d202.sql.uict.nz",
                    InitialCatalog = "1935890",
                    IntegratedSecurity = bool.Parse("True")
                }.ConnectionString
                ))
            {
                conn3.Open();

                string sqlquery3 = "insert into AspNetUsers(UserName) values (@UserName)";
                SqlCommand sqlcomm3 = new SqlCommand(sqlquery3, conn3);
                sqlcomm3.Parameters.AddWithValue("@UserName", UN);
                sqlcomm3.ExecuteNonQuery();
                string msgText = "The username: " + UN + " is inserted successfully..!";

                conn3.Close();
                return msgText;
            }



        }

    }
    

}
