using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Enteties
{
    public class AppUser
    { 
        public int Id { get; set; }
        public required string UserName { get; set; }
    }
}