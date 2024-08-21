using Microsoft.EntityFrameworkCore;

namespace HoaChat.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
           
        }
        public DbSet<HoaChat> HoaChats { get; set; }
        public DbSet<Anh> Anhs { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<LoaiHoaChat> LoaiHoaChats { get; set; }
    }
}
