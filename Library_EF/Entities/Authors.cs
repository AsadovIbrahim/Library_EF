using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_EF.Entities
{
    public class Authors : BaseEntity
    {
        public int ?Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public ICollection<Books> ?Books { get; set; }  
    }
}
