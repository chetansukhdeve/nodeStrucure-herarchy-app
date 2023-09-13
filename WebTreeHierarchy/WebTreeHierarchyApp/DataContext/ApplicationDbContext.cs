using Microsoft.EntityFrameworkCore;
using WebTreeHierarchyApp.Models;

namespace WebTreeHierarchyApp.DataContext
{
    public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        { }

        public DbSet<Node> Nodes { get; set; }
    }
}
