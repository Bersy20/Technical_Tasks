using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeAjaxTask.Models
{
    public class EmpDetails
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public List<string> Skills { get; set; }
       
    }
}