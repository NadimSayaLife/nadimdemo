using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Repository.Account
{
    public interface IAccountRepository
    {
        bool SignUp(Emloyee.Model.Model.Employee employee);
    }
}
