using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_EF.Entities
{
    public class BookTypes : BaseEntity
    {
        public int Id { get; set; }
        public string ?Name { get; set; }

        public ICollection<Books> ?Books { get; set; }   
    }
}
