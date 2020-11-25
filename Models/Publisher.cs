﻿using System.Collections.Generic;

namespace Iscu_Paula_Lab8.Models
{
    public class Publisher
    {
        public int ID { get; set; }
        public string PublisherName { get; set; }
        public ICollection <Book> Books { get; set; } //navigation property
    }
}