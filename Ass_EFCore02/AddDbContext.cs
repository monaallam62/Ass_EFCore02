using Ass_EFCore02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_EFCore02
{
    internal class AddDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQL2026;Database=EventHub;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Badge> Badges { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Organizer>()
                .HasOne(O => O.Profilee)
                .WithOne(P => P.Organizer)
                .HasForeignKey<Profile>(P => P.OrganizerId)
                .IsRequired();
            modelBuilder.Entity<Attendee>()
                .HasOne(at=>at.AttBadge)
                .WithOne(B=>B.BadgeAtt)
                .HasForeignKey<Badge>(B=>B.AttendeeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
