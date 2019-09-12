using Microsoft.EntityFrameworkCore;
using PettyCash.API.Models.AuthUser;

namespace PettyCash.API.Models.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<DailyExpense> DailyExpenses { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<AvailableAmount> AvailableAmounts{ get; set; }
        public DbSet<LogEntry> LogEntries { get; set; }

    }
}
