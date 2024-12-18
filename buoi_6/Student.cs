using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace buoi_6
{
    public partial class Student : DbContext
    {
        public Student()
            : base("name=Student")
        {
        }

        public virtual DbSet<CLass> CLass { get; set; }
        public virtual DbSet<Student_IF> Student_IF { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CLass>()
                .Property(e => e.Class_Name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Student_IF>()
                .Property(e => e.Student_Name)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
