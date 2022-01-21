using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthAppCrud3.Models
{
    public class mvcEmployeeModel
    {
        public int EmployeeID { get; set; }
        [Required(ErrorMessage ="Este Campo es requerido")]
        public string Name { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
    }
}
