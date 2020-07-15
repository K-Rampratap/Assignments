using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_MVC_Employee.Entities
{
    public class Customer
    {
        [Key]
        public int Cid { get; set; }
        [Required]
        public string CName { get; set; }

        public string Email { get; set; }
        [Required]
        public int Mobile { get; set; }
        public string City { get; set; }
    }
}
