﻿using Microsoft.EntityFrameworkCore;

namespace LinqQueryExecution
{
    class PersonContext : DbContext
    {
        public PersonContext() { }

        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Persons.db");
        }
    }
}
