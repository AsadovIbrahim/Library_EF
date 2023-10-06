using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_EF.Entities
{
    public class StudentBooks : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int BookId { get; set; }

        [ForeignKey("StudentId")]
        public Students ?Students { get; set; }

        [ForeignKey("BookId")]
        public Books? Books { get; set; }
        public Operations ?Operations { get; set; }
    }
}
