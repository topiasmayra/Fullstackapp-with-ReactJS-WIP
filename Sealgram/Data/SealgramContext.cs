﻿using Microsoft.EntityFrameworkCore;
using Sealgram.Models;

namespace Sealgram.Data
{
    public class SealgramDbContext : DbContext
    {
        
        public SealgramDbContext(DbContextOptions<SealgramDbContext> options)
            : base(options)
        {
        }

        // DbSet for the "users" table
        public DbSet<User> Users { get; set; }

        // DbSet for the "posts" table
        public DbSet<Post> Posts { get; set; }

        //Dbset for the "likes" table 
        public DbSet<Likes> Likes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Likes>()
                .HasKey(l => l.likeid);
            modelBuilder.Entity<Comments>()
                .HasKey(l => l.comment_id);
            modelBuilder.Entity<Post>()
                .HasKey(l => l.postid);


        }


        public DbSet<Sealgram.Models.Comments> Comments { get; set; } = default!;
    }
    }