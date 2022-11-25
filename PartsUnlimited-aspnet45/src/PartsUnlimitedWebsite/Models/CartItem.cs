using System;
using System.ComponentModel.DataAnnotations;
namespace PartsUnlimited.Models
{
// I could've added a note here too
    public class CartItem : ILineItem
    {
        // my first comment is the first change 
        [Key]
        public int CartItemId { get; set; }

        [Required]
        public string CartId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; }

        public virtual Product Product { get; set; }
    }
}