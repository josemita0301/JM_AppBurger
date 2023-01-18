﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM_AppBurger.JM_Models
{
    [Table("burger")]
    public class JM_Burger
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(250), Unique]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool WithExtraCheese { get; set; }
    }
}
