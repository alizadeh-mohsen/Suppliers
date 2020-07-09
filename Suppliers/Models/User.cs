using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuppliersHub.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string password { get; set; }

        public string Email { get; set; }

        public DateTime LastLoginAt { get; set; }

        public bool IsAdmin { get; set; }
    }
}