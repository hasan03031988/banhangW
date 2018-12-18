namespace BanHangW.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private BanHangWDbContext dbContext;

        public BanHangWDbContext Init()
        {
            return dbContext ?? (dbContext = new BanHangWDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}