using System;

namespace BanHangW.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        BanHangWDbContext Init();
    }
}