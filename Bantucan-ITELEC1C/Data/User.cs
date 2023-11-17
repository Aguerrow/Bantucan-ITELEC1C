using System;
using Microsoft.AspNetCore.Identity;
namespace Bantucan_ITELEC1C.Data
{
    public class User : IdentityUser
    {

        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
    }
}
