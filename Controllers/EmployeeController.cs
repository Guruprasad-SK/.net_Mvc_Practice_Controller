using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo2.Controllers
{
    public class EmployeeController : Controller
    {
        
        public string EmployeeProfile(int id)


        {
            string Profile = string.Empty;
            if(id==1)
            {
                Profile = "Employe profile 1";
            }
            else if(id==2)
            {
                Profile = "Employe profile 2";
            }
            else
            {
                Profile = "Employe profile empty";
            }

            return Profile;
        }

        public string Address(int id,string Department)
        {
            return "id=" + id + " "+"department=" + Department;

        }
    }
}