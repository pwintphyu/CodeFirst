﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    public class BlogDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
    }
}
