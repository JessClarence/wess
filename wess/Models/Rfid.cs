using System.ComponentModel.DataAnnotations;

namespace wess.Models
{
    public class Rfid
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CardId { get; set; }

        [Required]
        public DateTime LogDate { get; set; }
    }
}
