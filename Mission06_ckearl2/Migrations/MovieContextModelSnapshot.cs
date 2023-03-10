// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_ckearl2.Models;

namespace Mission06_ckearl2.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission06_ckearl2.Models.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MovieID");

                    b.ToTable("movies");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            Edited = false,
                            LentTo = "-",
                            Notes = "This movie is based in Chicago",
                            Rating = "PG-13",
                            Title = "Ferris Bueller's Day Off"
                        },
                        new
                        {
                            MovieID = 2,
                            Edited = false,
                            LentTo = "-",
                            Notes = "Jack Black is my hero",
                            Rating = "PG-13",
                            Title = "School of Rock"
                        },
                        new
                        {
                            MovieID = 3,
                            Edited = false,
                            LentTo = "Scotty Smalls",
                            Notes = "A cult classic",
                            Rating = "PG",
                            Title = "The Sandlot"
                        },
                        new
                        {
                            MovieID = 4,
                            Edited = true,
                            LentTo = "J.K. Simmons",
                            Notes = "GOAT movie",
                            Rating = "R",
                            Title = "Whiplash"
                        },
                        new
                        {
                            MovieID = 5,
                            Edited = true,
                            LentTo = "Matt Damon",
                            Notes = "The most stacked cast of all time",
                            Rating = "R",
                            Title = "Good Will Hunting"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
