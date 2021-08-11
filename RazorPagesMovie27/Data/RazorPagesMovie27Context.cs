using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie27.Data
{
    public class RazorPagesMovie27Context : DbContext
    {
        public RazorPagesMovie27Context (DbContextOptions<RazorPagesMovie27Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie27.Models.Movie> Movie { get; set; }
    }
}
