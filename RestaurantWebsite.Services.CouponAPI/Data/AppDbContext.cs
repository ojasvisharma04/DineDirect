using Microsoft.EntityFrameworkCore;

namespace RestaurantWebsite.Services.CouponAPI.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Models.Coupon> Coupons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Models.Coupon>().HasData(new Models.Coupon
            {
                CouponId = 1,
                CouponCode = "BF200",
                DiscountAmount = 20,
                MinAmt = 60
            });

            modelBuilder.Entity<Models.Coupon>().HasData(new Models.Coupon
            {
                CouponId = 2,
                CouponCode = "AF200",
                DiscountAmount = 10,
                MinAmt = 60
            });

        }
        }

    }

