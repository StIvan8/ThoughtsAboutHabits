using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Domain.Models.Account
{
    public class User : IdentityUser<long>
    {
        public virtual List<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();
    }
}
