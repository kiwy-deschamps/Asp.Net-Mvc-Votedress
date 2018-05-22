﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Votedress.Entities.VeritabaniModellerim
{
    public class ProductCategory
    {
        [Key]
        public int id { get; set; }
        public virtual Category Category { get; set; }
        public virtual Product Product { get; set; }
    }
}
