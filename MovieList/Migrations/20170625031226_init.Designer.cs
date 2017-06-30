using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MovieList;

namespace MovieList.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20170625031226_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("MovieList.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ReleaseYear");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });
        }
    }
}
