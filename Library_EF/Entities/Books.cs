using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_EF.Entities
{
    public class Books : BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int PageCount { get; set; }
        public ICollection<StudentBooks>? StudentBooks { get; set; }

        public int BookTypeId { get; set; }
        public int AuthorId { get; set; }
    }
}
