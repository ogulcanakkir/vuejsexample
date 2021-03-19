using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VueJS.Models
{
    public class User
    {
        public string Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Color { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
    }
}
