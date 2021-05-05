using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace siparisTakip.Models.Entities
{
    public class Order
    {
        public int id { get; set; }
        public int userId { get; set; }
        public int storeId { get; set; }
        [Required]
        public Product product { get; set; }
        [Required, MaxLength(50)]
        public string Adress { get; set; }
        [Required]
        public Status status { get; set; }
        [Required]
        public int count { get; set; }



    }
}