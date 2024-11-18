using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace smart_goals_backend.Models
{
    public class SiteContext : DbContext
    {
        public SiteContext(DbContextOptions<SiteContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(c => c.GoalsLists)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.GoalsListId);

            modelBuilder.Seed();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<GoalsList> GoalsLists { get; set; }




    }
}
