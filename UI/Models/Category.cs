﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UI.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(15)]
        public string Name { get; set; }
    }
}
