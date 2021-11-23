using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrmBlazorServ.Data {

    public class Employee {
        [Key]
        public int Id {get; set;}
        public string EmployeeName {get; set;}
        public string Gender {get; set;}
        public string City {get; set;}
        public string Designation {get; set;}
    }

}