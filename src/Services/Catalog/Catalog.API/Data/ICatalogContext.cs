using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
