﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Academy.Models;

namespace Academy.Data
{
    public class AcademyContext : DbContext
    {
        public AcademyContext (DbContextOptions<AcademyContext> options)
            : base(options)
        {
        }

        public DbSet<Academy.Models.Discipline> Disciplines { get; set; } = default!;
        public DbSet<Academy.Models.Student> Students { get; set; } = default!;
        public DbSet<Academy.Models.Group> Groups { get; set; } = default!;
        public DbSet<Academy.Models.Teacher> Teachers { get; set; } = default!;
        public DbSet<Academy.Models.Direction> Directions { get; set; } = default!;
		protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Direction>()
                .HasMany(d=>d.Groups)
                .WithOne(g=>g.Direction)
                .HasForeignKey(g=>g.direction);

            modelBuilder.Entity<Group>()
                .HasOne(g => g.Direction)
                .WithMany(d=>d.Groups)
                //.HasForeignKey(g=>g.direction)
                ;
		}
	}
}
