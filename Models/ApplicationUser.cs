using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeorgianComputers.Models
{
    //Inherit from ASP.NET identity's IdentityUser Class for authentication
    public class ApplicationUser : IdentityUser 
    {
    }
}
