﻿using Microsoft.EntityFrameworkCore;
using MyProjectWinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectWinForms.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Models.Task> Tasks { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
                  : base(options)
        {
        }

    }
}
