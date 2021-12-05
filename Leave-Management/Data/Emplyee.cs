using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management.Data
{
    public class Emplyee : IdentityUser
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }

        public DateTime Datejoined { get; set; }
    }
}
