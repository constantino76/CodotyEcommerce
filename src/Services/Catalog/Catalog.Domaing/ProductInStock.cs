﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Domaing
{
   public class ProductInStock
    {
        [Key]
        public int ProductInStockId { get; set; }
        public int ProductId { get; set; }
        public int stock { get; set; }

    }
}
