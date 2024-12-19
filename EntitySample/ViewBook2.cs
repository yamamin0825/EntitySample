using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySample
{
    public class ViewBook2
    {
        [Key]
        public int Book2ID { get; set; }

        [StringLength(100)]
        public string BookName { get; set; } = string.Empty;

        public int CategoryID { get; set; }

        public string CategoryName { get; set; } = string.Empty;
    }
}
