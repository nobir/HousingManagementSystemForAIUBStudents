using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HousingManagementSystemForAIUBStudents.Models;

namespace HousingManagementSystemForAIUBStudents.Controllers
{
    public class IndexRegistrationController
    {
        public static bool Registration(Tenant tenant)
        {
            return Database.Instance.Tenants.Create(tenant);
        }

        public static bool Registration(Renter renter)
        {
            return Database.Instance.Renters.Create(renter);
        }
    }
}