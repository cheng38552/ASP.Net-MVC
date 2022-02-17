using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class GamerBusinessLayer
    {
        public IEnumerable<Gamer> Gamers
        {
            get
            {
                string connectionString =
                    ConfigurationManager.ConnectionStrings["OnlineGameContext"].ConnectionString;
                List<Gamer> gamers = new List<Gamer>();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spGetGamers", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Gamer gamer = new Gamer();
                        gamer.Id = Convert.ToInt32(rdr["Id"]);
                        gamer.Name = rdr["Name"].ToString();
                        gamer.Gender = rdr["Gender"].ToString();
                        gamer.City = rdr["City"].ToString();
                        gamer.DateOfBirth = Convert.ToDateTime(rdr["DateOfBirth"]);
                        gamer.TeamId = Convert.ToInt32(rdr["TeamId"]);
                        gamers.Add(gamer);
                    }
                }
                return gamers;
            }
        }
        public void AddGamer(Gamer gamer)
        {
            string connectionString =
            ConfigurationManager.ConnectionStrings["OnlineGameContext"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddGamer", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(CreateSqlParameter("@Name",gamer.Name));
                cmd.Parameters.Add(CreateSqlParameter("@Gender", gamer.Gender));
                cmd.Parameters.Add(CreateSqlParameter("@City", gamer.City));
                cmd.Parameters.Add(CreateSqlParameter("@DateOfBirth", gamer.DateOfBirth));
                cmd.Parameters.Add(CreateSqlParameter("@TeamId", gamer.TeamId));
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        SqlParameter CreateSqlParameter(string name,object value)
        {
            return new SqlParameter
            {
                ParameterName = name,
                Value = value
            };
        }
    }
}