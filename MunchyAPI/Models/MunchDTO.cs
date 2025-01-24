using System.ComponentModel.DataAnnotations;

namespace MunchyAPI.Models
{
    public class MunchDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public int Price { get; set; }

        public int Rating { get; set; }

        public string Location { get; set; }

        public string ImgUrl { get; set; }

    }
}
