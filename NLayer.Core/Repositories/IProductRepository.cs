using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {

        Task<List<Product>> GetProductsWithCategory();

    }
}
