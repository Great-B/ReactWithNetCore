using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions optons) : base(optons)
        {
            
        }

        public DbSet<Activity> Activities {get;set;}
    }
}