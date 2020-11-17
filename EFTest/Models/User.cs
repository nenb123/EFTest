using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFTest.Models
{
    public class User
    {
        [Key]
        public int UerId { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }

    }
}
