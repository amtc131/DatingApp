using DatingApp.api.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.api.Data
{
    // ":" se ignifica que es clase Heredada
    public class DataContext : DbContext
    {
        //constructor de base de datos
       public DataContext(DbContextOptions<DataContext>options):base(options){} 

        //entidades de tipo DB
        public DbSet<Value> Values{get; set;}

        public DbSet<User> Users {get; set;}
    }
}