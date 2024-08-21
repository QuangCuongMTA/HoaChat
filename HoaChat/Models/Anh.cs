using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HoaChat.Models
{
    [Table("Anh")]
    public class Anh
    {
        [Key]
        public int idAnh { get; set; }
        public string tieuDe { get; set; }
        [Required]
        public string tenAnh { get; set;}
     
        [ForeignKey("HoaChat")]
        public int idHoaChat { get; set; }

        public HoaChat HoaChat { get; set; }
    }
}
