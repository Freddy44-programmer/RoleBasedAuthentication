﻿using Microsoft.AspNetCore.Identity;

namespace RoleBasedAuthentication.Models
{
    public class ApplicationUsers : IdentityUser
    {

        public Guid Id { get; set; }

        public string FirstName { get; set; } = "";

        public string LastName { get; set; } = "";

        public string Address { get; set; } = "";

        public DateTime CreatedAt { get; set; }

    }
}
