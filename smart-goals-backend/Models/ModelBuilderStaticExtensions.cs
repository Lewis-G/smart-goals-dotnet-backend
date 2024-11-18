using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_goals_backend.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Username = "AA", Password = "aa" },
                new User { UserId = 2, Username = "BB", Password = "bb" });

            modelBuilder.Entity<GoalsList>().HasData(
                new GoalsList { GoalsListId = 1, UserID = 1, Name = "List 1", ColourID = 0 },
                new GoalsList { GoalsListId = 2, UserID = 1, Name = "List 2", ColourID = 0 },
                new GoalsList { GoalsListId = 3, UserID = 2, Name = "List 1", ColourID = 0 },
                new GoalsList { GoalsListId = 4, UserID = 2, Name = "List 2", ColourID = 0 });
        }
    }
}
