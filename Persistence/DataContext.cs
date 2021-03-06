﻿using System;
using Application;
using Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace Persistence
{
    public class DataContext: IdentityDbContext<AppUser> 
    {
        public DataContext(DbContextOptions options): base(options){ }
         public  DbSet<value> values {get; set;}
         public DbSet<Meeting> Meetings {get; set;}
         protected override void OnModelCreating(ModelBuilder builder)
         {
             base.OnModelCreating(builder);
             
             builder.Entity<value>()
             .HasData(
                 new value{Id =1, Name ="Value 01"},
                 new value{Id =2, Name ="Value 02"},
                 new value{Id =3, Name ="Value 03"}
             );

         }
    }
 
}
