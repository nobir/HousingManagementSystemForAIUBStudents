using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HousingManagementSystemForAIUBStudents.Models;

namespace HousingManagementSystemForAIUBStudents.Controllers
{
    public class TenantController
    {
        public static Tenant EditProfile(Tenant tenant, string oldEmail)
        {
            // Check current user authenticate or not
            if (Database.Instance.Tenants.AuthenticateUser(oldEmail, tenant.Password) != null)
            {
                bool isUpdate = Database.Instance.Tenants.UpdateUser(tenant, oldEmail);

                if (isUpdate)
                {
                    return Database.Instance.Tenants.GetUser(tenant.Email);
                }
            }

            return null;
        }
    }
}
