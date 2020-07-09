using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuppliersHub.Models
{
    public class Supplier
    {
        public int Id { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }

        public string FullName { get; set; }

        public string CompanyName { get; set; }

        public string Address { get; set; }

        public DateTime RegisterAt { get; set; }

        public City City { get; set; }

        public int CityId { get; set; }

    }
}