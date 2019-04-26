using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auth.Models
{
    public class Role: IdentityRole<int>
    {
        public DateTime DtCreated { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
