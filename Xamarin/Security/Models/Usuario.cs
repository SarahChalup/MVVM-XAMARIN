using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Security.Models
{
    
        public enum TypeContact
        {
            Facebook,
            Email,
            PhoneN0umber,

        }
        public class Usuario
        {
            [Key]
            public int PhoneID { get; set; }
            [Required]
            public string Name { get; set; }
            [Required]
            public TypeContact Type { get; set; }
        }
    
}