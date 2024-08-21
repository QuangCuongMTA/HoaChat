using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HoaChat.Models
{
    [Table("LoaiHoaChat")]

    public class LoaiHoaChat
    {
        [Key]
        public int iDLoaiHC { get; set; }
        [Required]
        public string loaiHC { get; set; }
        public ICollection<HoaChat> HoaChats { get; set; }

    }
}
