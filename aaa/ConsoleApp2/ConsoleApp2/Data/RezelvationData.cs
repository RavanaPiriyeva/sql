using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ConsoleApp2.Data
{
    internal class RezelvationData
    {
        public void Add(Rezelvation rezelvation)
        {
            using (SqlConnection con = new SqlConnection(Sql.ConnectionString))
            {
                con.Open();
                string query = $"INSERT INTO Reservations (StadionId,UserId,StartDate,EndDate) Values ({rezelvation.StadionId},{rezelvation.UserId},{rezelvation.StartDate},{rezelvation.EndDate})";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
