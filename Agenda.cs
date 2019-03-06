namespace Agenda_WPF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Agenda : DbContext
    {
        public Agenda()
            : base("name=Agenda")
        {
        }

        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Broker> Brokers { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Broker>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Broker>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Broker>()
                .Property(e => e.Mail)
                .IsUnicode(false);

            modelBuilder.Entity<Broker>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Broker>()
                .HasMany(e => e.Appointments)
                .WithRequired(e => e.Broker)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Mail)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Subject)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Appointments)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);
        }
    }
}
