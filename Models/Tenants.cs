using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HousingManagementSystemForAIUBStudents.Models
{
    public class Tenants
    {
        private static SqlConnection connection = Database.GetConnection();

        public Tenants()
        {

        }

        public Tenants(SqlConnection conn)
        {
            Tenants.connection = conn;
        }

        public Tenant AuthenticateUser(string email, string password)
        {
            string query = "";
            Tenant tenant = null;
            Tenants.connection.Open();
            try
            {
                query = String.Format("SELECT * FROM tenant WHERE email='{0}' AND password='{1}'", email, password);

                SqlCommand cmd = new SqlCommand(query, Tenants.connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tenant = new Tenant();
                    tenant.Id = reader.GetInt32(reader.GetOrdinal("t_id"));
                    tenant.Name = reader.GetString(reader.GetOrdinal("name"));
                    tenant.Email = reader.GetString(reader.GetOrdinal("email"));
                    tenant.Phone = reader.GetString(reader.GetOrdinal("phone"));
                }
            }
            catch (Exception ex)
            {
                Tenants.connection.Close();

                // Displays the MessageBox.
                MessageBox.Show(
                    "User is not Authenticate!\n\n" + ex,
                    "Not Authenticate",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            Tenants.connection.Close();
            return tenant;
        }
    }
}
