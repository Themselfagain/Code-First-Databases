using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaporStore.Data.Models
{
   public  class Card
    {
        public Card()
        {
            this.Purchases = new HashSet<Purchase>();
        
        }
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Cvc { get; set; }
        [Required]
        public CardType Type { get; set; }
        [Required]
        public int UserId { get; set; }
        public ICollection<Purchase> Purchases { get; set; }
    }
}
