using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace siparisTakip.Models.Entities
{
    public class SubCategory
    {
        public int id { get; set; }
        [Required, MaxLength(20)]
        public string name { get; set; }
        [Required]
        public Category category { get; set; }

    }
}