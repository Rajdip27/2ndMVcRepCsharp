using _2ndMVcRepository.Models;
using Microsoft.EntityFrameworkCore;

namespace _2ndMVcRepository.AppDbContext
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {


        }
        public DbSet<User> users { get; set; }
    }
}
