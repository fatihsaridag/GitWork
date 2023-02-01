using Microsoft.EntityFrameworkCore;

namespace GitWork.Models
{
    public class GitWorkContext : DbContext
    {
        public GitWorkContext(DbContextOptions options) : base(options)
        {
        }
        public  DbSet<UserRegister> UserRegisters { get; set; }
    }
}
