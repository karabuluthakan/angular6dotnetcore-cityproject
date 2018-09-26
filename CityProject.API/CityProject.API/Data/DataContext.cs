﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityProject.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CityProject.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<User> Users { get; set; }


    }
}
