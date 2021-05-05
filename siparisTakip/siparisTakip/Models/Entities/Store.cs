using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace siparisTakip.Models.Entities
{
    public class Store
    {
        public int id { get; set; }
        [Required, MaxLength(30)]
        public string name { get; set; }
        public ICollection<Product> products { get; set; }
        [Required]
        public User userOwner { get; set; }
        public ICollection<Order> orders { get; set; }
    }
}