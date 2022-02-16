using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TaskCRUD.Model;

namespace TaskCRUD
{
    public class TasksContext: DbContext
    {
        public TasksContext(DbContextOptions<TasksContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Task>().HasData(new List<Task>
            {
                new Task
                {
                    Id = 1,
                    Title = "Task 1",
                    Description = "description 1"
                },
                new Task
                {
                    Id = 2,
                    Title = "Task 2",
                    Description = "description 2"
                },

                new Task
                {

                    Id = 3,
                    Title = "Task 3",
                    Description = "description 3"
                },
                new Task
                {
                    Id = 4,
                    Title = "Task 4",
                    Description = "description 4"
                }
            });
        }

        public DbSet<Task> Tasks { get; set; }
    }
}
