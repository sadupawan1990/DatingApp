using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        // calling the base constructor with the DB context options will establish the database connectivity
        // DBContextoptions will be injected from the startup.cs file inside ConfigureServices method
        public DataContext(DbContextOptions options): base(options){

        }

        // Define the Entities
        public DbSet<AppUser> Users {get;set;}
        
    }
}