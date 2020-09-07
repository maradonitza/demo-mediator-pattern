using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRDemo.Data
{
    public class MyDatabaseContext : DbContext
    {
        public MyDatabaseContext(DbContextOptions<MyDatabaseContext> options) : base(options)
        {
        }
        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person { Id = 1, Nickname = "Max Amini" },
                new Person { Id = 2, Nickname = "Maz Jobrani" });
        }
    }
    public class Person
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
    }
}
