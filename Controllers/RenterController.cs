using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HousingManagementSystemForAIUBStudents.Models;

namespace HousingManagementSystemForAIUBStudents.Controllers
{
    public class RenterController
    {
        public static Renter EditProfile(Renter renter, string oldEmail)
        {
            // Check current user authenticate or not
            if (Database.Instance.Renters.AuthenticateUser(oldEmail, renter.Password) != null)
            {
                bool isUpdate = Database.Instance.Renters.UpdateUser(renter, oldEmail);

                if (isUpdate)
                {
                    return Database.Instance.Renters.GetUser(renter.Email);
                }
            }

            return null;
        }
    }
}
