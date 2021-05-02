﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HousingManagementSystemForAIUBStudents.Models
{
    public class Renters
    {
        private static SqlConnection connection = Database.GetConnection();

        public Renters()
        {

        }

        public Renters(SqlConnection conn)
        {
            Renters.connection = conn;
        }

        public Renter AuthenticateUser(string email, string password)
        {
            string query = "";
            Renter renter = null;
            Renters.connection.Open();
            try
            {
                query = String.Format("SELECT * FROM renter WHERE email='{0}' AND password='{1}'", email, password);

                SqlCommand cmd = new SqlCommand(query, Renters.connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    renter = new Renter();
                    renter.Id = reader.GetInt32(reader.GetOrdinal("r_id"));
                    renter.Name = reader.GetString(reader.GetOrdinal("name"));
                    renter.Email = reader.GetString(reader.GetOrdinal("email"));
                    renter.Phone = reader.GetString(reader.GetOrdinal("phone"));
                }
            }
            catch (Exception ex)
            {
                Renters.connection.Close();

                // Displays the MessageBox.
                MessageBox.Show(
                    "User is not Authenticate!\n\n" + ex,
                    "Not Authenticate",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            Renters.connection.Close();
            return renter;
        }
        public bool Create(Renter renter)
        {
            string query = "";
            int result = 0;

            Renters.connection.Open();

            try
            {
                query = String.Format("INSERT INTO renter VALUES ('{0}','{1}','{2}', '{3}')", renter.Name, renter.Email, renter.Phone, renter.Password);
                SqlCommand cmd = new SqlCommand(query, Renters.connection);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Renters.connection.Close();

                // Displays the MessageBox.
                MessageBox.Show(
                    "Renter Added Unsuccessfull!\n\n" + ex,
                    "ERROR | Renter not added",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            Renters.connection.Close();
            if (result > 0) return true;

            return false;
        }
    }
}
