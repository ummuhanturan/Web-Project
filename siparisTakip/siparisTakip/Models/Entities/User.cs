using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace siparisTakip.Models.Entities
{
    public class User
    {
        public int id { get; set; }
        [Required, MaxLength(20)]
        public string name { get; set; }
        [Required, MaxLength(30)]
        public string surname { get; set; }
        [Required, MaxLength(10)]
        public string phonenumber { get; set; }
        [Required, MaxLength(30)]
        public string email { get; set; }
        [Required, MaxLength(50)]
        public string address { get; set; }
        public UserGroup userGroup { get; set; }

    }
}