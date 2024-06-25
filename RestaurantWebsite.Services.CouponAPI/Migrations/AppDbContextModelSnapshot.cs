﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantWebsite.Services.CouponAPI.Data;

#nullable disable

namespace RestaurantWebsite.Services.CouponAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RestaurantWebsite.Services.CouponAPI.Models.Coupon", b =>
                {
                    b.Property<int>("CouponId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CouponId"));

                    b.Property<string>("CouponCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DiscountAmount")
                        .HasColumnType("float");

                    b.Property<int>("MinAmt")
                        .HasColumnType("int");

                    b.HasKey("CouponId");

                    b.ToTable("Coupons", (string)null);

                    b.HasData(
                        new
                        {
                            CouponId = 1,
                            CouponCode = "BF200",
                            DiscountAmount = 20.0,
                            MinAmt = 60
                        },
                        new
                        {
                            CouponId = 2,
                            CouponCode = "AF200",
                            DiscountAmount = 10.0,
                            MinAmt = 60
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
