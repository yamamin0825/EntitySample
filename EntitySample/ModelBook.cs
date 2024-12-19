using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySample
{
    [Table("Book")]
    public class ModelBook
    {
        [Key]
        public int BookID {  get; set; }

        [StringLength(100)]
        public string BookName { get; set; } = string.Empty;

        public ModelBookCategory? Category { get; set; }

    }
}
