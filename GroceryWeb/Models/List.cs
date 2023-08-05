using System.ComponentModel.DataAnnotations;

namespace GroceryWeb.Models
{
    public class List
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? ItemName { get; set; }
        public int Quantity { get; set; }
        public DateTime DateTimeCreated { get; set; } = DateTime.Now;

    }
}
