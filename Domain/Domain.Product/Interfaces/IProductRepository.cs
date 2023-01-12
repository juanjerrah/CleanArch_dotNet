namespace Domain.Product.Interfaces;
using ProductDomain = Entities.Product;
public interface IProductDomainRepository
{
    Task<IEnumerable<ProductDomain?>> GetProductDomains();
    Task<ProductDomain> GetProductDomainById(Guid? id);
    Task<ProductDomain> GetProductDomainByCategory(Guid? id);
    Task<ProductDomain?> CreateProductDomain(ProductDomain? productDomain);
    Task<ProductDomain?> UpdateProductDomain(ProductDomain? productDomain);
    Task<ProductDomain?> DeleteProductDomain(ProductDomain? productDomain);
}