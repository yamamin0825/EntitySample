﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySample
{
    [Table("BookCategory")]
    public class ModelBookCategory
    {
        [Key]
        public int CategoryID { get; set; }

        [StringLength(100)]
        public string CategoryName { get; set; } = string.Empty;

        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
