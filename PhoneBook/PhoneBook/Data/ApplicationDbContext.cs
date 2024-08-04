using Microsoft.EntityFrameworkCore;
using PhoneBook.Models;

namespace PhoneBook.Data
{
    public class ApplicationDbContext : DbContext
    {

        // aksini belirtmediğimiz sürece tablo isimi dbset ismi ne ise o olur.. 
        public DbSet<Person> People { get; set; }

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-E55K0K2\\SQLEXPRESS;Database=PhoneBook;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
