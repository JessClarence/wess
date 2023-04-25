using Microsoft.EntityFrameworkCore;
using wess.Models;

namespace wess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }

        public DbSet<Rfid> RFIDs { get; set; }
    }
}
