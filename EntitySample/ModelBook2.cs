using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySample
{
    [Table("Book2")]
    public class ModelBook2
    {
        [Key]
        public int Book2ID {  get; set; }

        [StringLength(100)]
        public string BookName { get; set; } = string.Empty;

        public int CategoryID { get; set; }

    }
}
