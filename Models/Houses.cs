using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HousingManagementSystemForAIUBStudents.Models
{
    public class Houses
    {
        private static SqlConnection connection = Database.GetConnection();
        public Houses()
        {

        }

        public ArrayList GetAllHouse()
        {
            string query = "";
            ArrayList houses = new ArrayList();

            Houses.connection.Open();

            try
            {
                query = "SELECT * FROM house";
                SqlCommand cmd = new SqlCommand(query, Houses.connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    House house = new House();

                    house.Id = reader.GetInt32(reader.GetOrdinal("h_id"));
                    house.Name = reader.GetString(reader.GetOrdinal("name"));
                    house.Number = reader.GetInt32(reader.GetOrdinal("number"));
                    house.Sector = reader.GetInt32(reader.GetOrdinal("sector"));
                    house.Price = reader.GetString(reader.GetOrdinal("price"));
                    house.Status = reader.GetInt32(reader.GetOrdinal("status"));

                    houses.Add(house);
                }

            }
            catch (Exception ex)
            {
                Houses.connection.Close();

                // Displays the MessageBox.
                MessageBox.Show(
                    "There is and error to getting house!\n\n" + ex,
                    "Error | Getting House information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            Houses.connection.Close();
            return houses;
        }

        public House GetHouse(string houseId)
        {
            string query = "";
            House house = null;

            Houses.connection.Open();

            try
            {
                query = String.Format("SELECT * FROM house WHERE h_id='{0}'", houseId);
                SqlCommand cmd = new SqlCommand(query, Houses.connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    house = new House();

                    house.Id = reader.GetInt32(reader.GetOrdinal("h_id"));
                    house.Name = reader.GetString(reader.GetOrdinal("name"));
                    house.Number = reader.GetInt32(reader.GetOrdinal("number"));
                    house.Sector = reader.GetInt32(reader.GetOrdinal("sector"));
                    house.Price = reader.GetString(reader.GetOrdinal("price"));
                    house.Status = reader.GetInt32(reader.GetOrdinal("status"));
                }

            }
            catch (Exception ex)
            {
                Houses.connection.Close();

                // Displays the MessageBox.
                MessageBox.Show(
                    "There is and error to getting house!\n\n" + ex,
                    "Error | Getting House information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            Houses.connection.Close();
            return house;
        }
    }
}
