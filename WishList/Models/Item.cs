using System.ComponentModel.DataAnnotations;

namespace WishList.Models
{
    public class Item
    {
        public virtual ApplicationUser User { get; set; }

        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Description { get; set; }
    }
}
