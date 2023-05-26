using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Fiszki.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Fiszkii> Fiszkiii { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fiszkii>().HasData(
                new Fiszkii
                    {
                    id_fiszki=5,
                    Nazwa_fiszki="sdfghj",
                    Opis="sdfghjkljfdsfghjkmhg",
                    Kategoria="ijgfd",
                    Przedmiot="hjgytfrds",
                    Zrobione=true
                    }
                );   
        }
    }
}
