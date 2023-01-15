﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WeatherForcastDemo.Entities;

namespace WeatherForcastDemo.DbContexts
{
    public partial class BookShopDbContext : DbContext
    {
        public BookShopDbContext()
        {
        }

        public BookShopDbContext(DbContextOptions<BookShopDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Books { get; set; } = null!;
        public virtual DbSet<BookCategory> BookCategories { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_unicode_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("book");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Author)
                    .HasMaxLength(128)
                    .HasColumnName("author")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IsbnCode)
                    .HasMaxLength(15)
                    .HasColumnName("isbn_code")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Pages)
                    .HasColumnType("int(11)")
                    .HasColumnName("pages")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Publisher)
                    .HasMaxLength(128)
                    .HasColumnName("publisher")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Title)
                    .HasMaxLength(1024)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<BookCategory>(entity =>
            {
                entity.ToTable("book_category");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CategoryDescription)
                    .HasMaxLength(1024)
                    .HasColumnName("category_description");

                entity.Property(e => e.CategoryTitle)
                    .HasMaxLength(100)
                    .HasColumnName("category_title");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("parent_id")
                    .HasDefaultValueSql("'0'")
                    .HasComment("所属的上一级图书分类ID号");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}