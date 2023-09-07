using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace S4_1._35.Models
{
    public class GenericDBContext : DbContext
    {
        public GenericDBContext()
           : base("School1Entities")
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }

}