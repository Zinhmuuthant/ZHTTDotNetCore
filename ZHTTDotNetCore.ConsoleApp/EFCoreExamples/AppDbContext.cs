﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZHTTDotNetCore.ConsoleApp.Dtos;
using ZHTTDotNetCore.ConsoleApp.Setting;

namespace ZHTTDotNetCore.ConsoleApp.EFCoreExamples
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString.SqlConnectionStringBuilder.ConnectionString);

        }
        public DbSet<BlogDto> Blogs { get; set; }
    }
}
