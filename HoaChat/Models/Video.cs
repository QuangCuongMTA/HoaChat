using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HoaChat.Models
{
    [Table("Video")]

    public class Video
    {
        [Key]
        public int idVideo { get; set; }
        public string tieuDe { get; set; }
        [Required]
        public string video { get; set; }
    
        [ForeignKey("HoaChat")]
        public int idHoaChat { get; set; }

        public HoaChat HoaChat { get; set; }
    }
}
