using System;
using System.ComponentModel.DataAnnotations;
namespace MyFirstAPI.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public Email? Email { get; set; }
    }
}
