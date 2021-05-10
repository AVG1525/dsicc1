using System.ComponentModel.DataAnnotations;

namespace Bcc.Models
{
    public class Actor
    {
        public int Id { get; set; }
        
        [StringLength(60, MinimumLength = 3), Required]
        public string Name { get; set; }
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
    }
}