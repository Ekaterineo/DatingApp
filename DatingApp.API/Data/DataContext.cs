using DatinApp.API.Controllers.Models;
using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatinApp.API.Properties.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>  options)  :  base  (options){ }
        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users {get; set; } 
    }
}