namespace lei200409681.Models.ApplicationModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.Customer_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Customer_Name)
                .IsUnicode(false);
        }
    }
}
