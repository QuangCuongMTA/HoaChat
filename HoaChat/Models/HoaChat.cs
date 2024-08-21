using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HoaChat.Models
{
    [Table("HoaChat")]

    public class HoaChat
    {

        [Key]
        public int idHoaChat { get; set; }
        [Required]
        public string tenHoaChat { get; set; }
        public string khaiNiem { get; set; }
        public string moTa {  get; set; }
        public string xamNhap { get; set; }
        public string trieuChung {get; set; }
        public string mucDich {  get; set; }
        public string phuongTien { get; set; }
        public string trangThai { get; set; }
        public string phuongPhap { get; set; }
        public ICollection<Anh> Anhs { get; set; }
        public ICollection<Video> Videos { get; set; }


        [ForeignKey("LoaiHoaChat")]
        public int iDLoaiHC { get; set; }

        public LoaiHoaChat LoaiHoaChat { get; set; }
    }
}
