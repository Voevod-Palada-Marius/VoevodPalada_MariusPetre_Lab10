using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace VoevodPalada_MariusPetre_Lab10.Models
{
    public class ShopList
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
