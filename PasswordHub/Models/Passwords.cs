using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PasswordHub.Models
{
    public class Passwords
    {
        [Key]        
        public string ID { get; set; }
        public string salt { get; set; }
        public string hashedPword { get; set; }

    }
}
