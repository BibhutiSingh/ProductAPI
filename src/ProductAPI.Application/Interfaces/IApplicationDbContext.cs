
using Microsoft.EntityFrameworkCore;
using ProductAPI.Core.Entities;

namespace ProductAPI.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Product> Products { get; }

    }
}
