﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppEFSqliteEx01.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<ProductTag> ProductTags { get; set; }

        public Product()
        {
            ProductTags = new List<ProductTag>();
        }
    }
}