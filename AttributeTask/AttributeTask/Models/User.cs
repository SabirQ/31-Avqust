using AttributeTask.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeTask.Models
{
    public class User
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [ValidEmail]
        public string Email { get; set; }
        [ValidPassword]
        public string Password { get; set; }
        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
