﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainTicketSystem;

namespace TrainTicketSystem
{
    internal class UserDbContext : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to mysql with connection string from app settings
            options.UseSqlServer(@"Data Source=.\SQLEXPRESS00;Initial Catalog=TrainTicketSystem;Integrated Security=True");
        }
        public DbSet<User> Users { get; set; }
    }
}

