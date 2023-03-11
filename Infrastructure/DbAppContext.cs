using MVVMLearn.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;

namespace MVVMLearn.Infrastructure
{
    public class DbAppContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Company> Company { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Host=localhost;Username=postgres;Password=root;Database=PhonesDatabase");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Phone>().HasOne(p => p.CompanyEntity)
                                        .WithMany(p => p.PhoneEntities);
            
        }
    }

    public static class DatabaseControl
    {
        public static List<Phone> GetPhonesForView()
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                return ctx.Phones.Include(p => p.CompanyEntity).ToList();
            }
        }

        public static void AddPhone(Phone phone)
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                ctx.Phones.Add(phone);
                ctx.SaveChanges();
            }
        }

        public static void UpdatePhone(Phone phone)
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                Phone _phone = ctx.Phones.FirstOrDefault(p => p.Id == phone.Id);

                _phone.Title = phone.Title;
                _phone.Price = phone.Price;
                _phone.CompanyId = phone.CompanyId;

                ctx.SaveChanges();
            }
        }

        public static void DeletePhone(Phone phone)
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                ctx.Phones.Remove(phone);
                ctx.SaveChanges();
            }
        }

        public static List<Company> GetCompanies()
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                return ctx.Company.ToList();
            }
        }
    }
}
