using System;
using System.ComponentModel.DataAnnotations;
namespace MyFirstAPI.Models
{
    public class Email
    {
        [Key]
        public int EmailId { get; set; }
        public string EmailAddress { get; set; }
        public bool IsSubscribed { get; set; }
    }
}
