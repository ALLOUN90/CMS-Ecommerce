using Microsoft.EntityFrameworkCore;

namespace CMS_Ecommerce.Infrastructure
{
    public class DataContext(DbContextOptions<DataContext> options):DbContext(options)
    {
        public DbSet<Page> Pages { get; set; }






        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Page>().HasData(
                new Page { Id = 1, Title = "Home", Slug = "home", Body = "This is the home page " },
                new Page { Id = 2, Title = "About", Slug = "about", Body = "This is the about page " },
                new Page { Id = 3, Title = "Services ", Slug = "services", Body = "This is the Services page " },
                new Page { Id = 4, Title = "Contacte", Slug = "contacte", Body = "This is the contacte page " }
                );

        }
    }
}
