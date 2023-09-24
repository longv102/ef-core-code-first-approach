﻿using API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Context
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentHistory> DepartmentHistories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Department>()
            //    .HasMany(d => d.Employees)
            //    .WithOne(e => e.Department)
            //    .HasForeignKey(e => e.DepartmentId);

            modelBuilder.Entity<DepartmentHistory>().HasKey(dh => new { dh.DepartmentHistoryId });
            // Specify that the key should not be generated by the database
            modelBuilder.Entity<DepartmentHistory>()
                .Property(dh => dh.DepartmentId).ValueGeneratedNever();

            modelBuilder.Entity<DepartmentHistory>()
                .HasOne(dh => dh.Department)
                .WithMany(d => d.DepartmentHistory)
                .HasForeignKey(dh => dh.DepartmentId);

            modelBuilder.Entity<DepartmentHistory>()
                .HasOne(dh => dh.Employee)
                .WithMany(e => e.DepartmentHistory)
                .HasForeignKey(dh => dh.EmployeeId);

            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = "D1", DepartmentName = "IT", Description = "Information Technology" },
                new Department { DepartmentId = "D2", DepartmentName = "HR", Description = "Human Resource" },
                new Department { DepartmentId = "D3", DepartmentName = "Sales", Description = "Sales Department" }
            );

            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeId = 1, Name = "John", Designation = "Developer", Address = "New York", CompanyName = "XYZ Inc", Salary = 30000},
                new Employee { EmployeeId = 2, Name = "Chris", Designation = "Manager", Address = "New York", CompanyName = "ABC Inc", Salary = 50000},
                new Employee { EmployeeId = 3, Name = "David", Designation = "Business Analyst", Address = "California", CompanyName = "FPT New York", Salary = 60000}
            );

            modelBuilder.Entity<DepartmentHistory>().HasData(
                new DepartmentHistory { DepartmentHistoryId = 1, EmployeeId = 1, DepartmentId = "D1", Available = true },
                new DepartmentHistory { DepartmentHistoryId = 2, EmployeeId = 2, DepartmentId = "D2", Available = true },
                new DepartmentHistory { DepartmentHistoryId = 3, EmployeeId = 3, DepartmentId = "D1", Available = true }
            );
        }
    }
}