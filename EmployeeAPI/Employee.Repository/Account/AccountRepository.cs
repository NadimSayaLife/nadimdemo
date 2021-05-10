using Emloyee.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Repository.Account
{
    public class AccountRepository
    {
        public bool SignUp(Emloyee.Model.Model.Employee employee)
        {
            MaxlinkEntities maxlinkEntities = new MaxlinkEntities();
            Emloyee.Model.Model.Employee employee1 = new Emloyee.Model.Model.Employee();
            employee1.Name = employee.Name;
            employee1.Email = employee.Email;
            employee1.Password = employee.Password;
            maxlinkEntities.Employee.Add(employee1);
            maxlinkEntities.SaveChanges();
            return true;
        }
    }
}
