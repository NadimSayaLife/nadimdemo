using Emloyee.Model.Model;
using Employee.Repository.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeAPI.Controllers
{
    public class AccountController : ApiController
    {
// account controller changes for testing 
        AccountRepository accountRepository = new AccountRepository();
        [HttpGet]
        public object SignUp(Emloyee.Model.Model.Employee employee)
        {
            try
            {
                //long custId = 0;
                
                
                    bool response = accountRepository.SignUp(employee);
                    if (response)
                    {
                    return true;
                    }
                    else
                    {
                        return false;
                    }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
