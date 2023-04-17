using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace VaporStore.Data.Models
{
   public class User
    {
        public User()
        {
            this.Cards = new HashSet<Card>(); 
        }
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(3)]
        public string Username { get; set; }
        [Required]
        
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }

        [Required]
        [Range(3,103)]
        public int Age { get; set; }
        public ICollection<Card> Cards { get; set; }
    }
}
