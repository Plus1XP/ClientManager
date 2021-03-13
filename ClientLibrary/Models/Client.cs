using System;
using System.ComponentModel.DataAnnotations;

using ClientLibrary.Enums;

namespace ClientLibrary.Models
{
    public class Client
    {
        public string ClientId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public int NumberOfUsers { get; set; }
        public string support { get; set; }
    }
}
