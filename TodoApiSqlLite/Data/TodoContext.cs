using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApiSqlLite.Models;

namespace TodoApiSqlLite.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>().HasData(
                new TodoItem
                {
                    Id = 1,
                    Name = "Write Backend",
                    IsComplete = true
                },
                new TodoItem
                {
                    Id = 2,
                    Name = "Write Xamarin app",
                    IsComplete = false
                },
                new TodoItem
                {
                    Id = 3,
                    Name = "Unit Testing",
                    IsComplete = false
                },
                new TodoItem
                {
                    Id = 4,
                    Name = "Prepare demo",
                    IsComplete = false
                },
                new TodoItem
                {
                    Id = 5,
                    Name = "Study for examination",
                    IsComplete = false
                }
            );
        }
    }
}
