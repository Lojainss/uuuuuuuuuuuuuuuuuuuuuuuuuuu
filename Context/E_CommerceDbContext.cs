namespace E_Commerce.Context {
    public class E_CommerceDbContext : DbContext {
        public E_CommerceDbContext(DbContextOptions<E_CommerceDbContext> options) : base(options) {}
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Order> Orders => Set<Order>();
    }
}