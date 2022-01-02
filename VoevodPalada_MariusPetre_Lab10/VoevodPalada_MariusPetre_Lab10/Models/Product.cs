﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace VoevodPalada_MariusPetre_Lab10.Models
{
    
        public class Product
        {
            [PrimaryKey, AutoIncrement]
            public int ID { get; set; }
            public string Description { get; set; }
            [OneToMany]
            public List<ListProduct> ListProducts { get; set; }
        }
    
}