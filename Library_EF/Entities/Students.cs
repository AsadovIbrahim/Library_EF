using Library_EF.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Library_EF.Entities
{
    public class Students:BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int SchoolNumber { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirtDay { get; set; }
        public string? PhoneNumber { get; set; }

        public ICollection<StudentBooks> ?StudentBooks { get; set; } 
    }
}
