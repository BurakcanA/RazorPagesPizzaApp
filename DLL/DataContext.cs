using System;
using Microsoft.EntityFrameworkCore;
namespace DLL
{
	public class DataContext : DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {//"Server=TheServerAddress; Database=TheDataBase; User Id=TheUsername; Password=ThePassword; TrustServerCertificate=True"


            //Data Source =.; Initial Catalog = InventoryManagement; Integrated Security = true;TrustServerCertificate=true

            optionsBuilder.UseSqlServer("Server=localhost;Database=RazorPizzaDBO;User Id=sa;Password=yourStrong(!)Password; TrustServerCertificate=True;", option =>
            {

            });
        }

        public virtual DbSet<Order> Orders { get; set; }

    }
}

