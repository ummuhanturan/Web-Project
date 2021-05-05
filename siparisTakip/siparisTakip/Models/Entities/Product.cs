using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace siparisTakip.Models.Entities
{
    public class Product
    {
        public int id { get; set; }
        [Required, MaxLength(30)]
        public string name { get; set; }
        [Required]
        public double price { get; set; }
        public int categoryId { get; set; }
        [Required]
        public int subCategoryId { get; set; }
        [Required]
        public int storeId { get; set; }
        [Required]
        public int totalCount { get; set; }

    }
}