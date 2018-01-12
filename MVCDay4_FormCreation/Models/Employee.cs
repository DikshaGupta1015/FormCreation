using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVCDay4_FormCreation.Models
{
    public class Employee
    {
        [DisplayName("Enter your First Name:")]
        public string FirstName { get; set; }

        [DisplayName("Enter your Last Name:")]
        public string LastName { get; set; }
    }
}