using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApp5.Models;

namespace WebApp5.Context
{
    public class fDatabase : DbContext
    {
        public fDatabase() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\KOSTA\source\repos\Work\Test1\MyDatabase1.mdf"";Integrated Security=True;Connect Timeout=30")
        {}

        public DbSet<Facility> facilities { get; set;  }
    }
}