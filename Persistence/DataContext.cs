using System;
using Microsoft.EntityFrameworkCore;
namespace Persistence
{
    public class DataContext: DbContext 
    {
        public DataContext(DbContextOptions options): base(options){ }
         public  DbSet<value> values {get; set;}
         protected override void OnModelCreating(ModelBuilder builder){
             builder.Entity<value>()
             .HasData(
                 new value{Id =1, Name ="Value 01"},
                 new value{Id =2, Name ="Value 02"},
                 new value{Id =3, Name ="Value 03"}
             );

         }
    }
 
}
