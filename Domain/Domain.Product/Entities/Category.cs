using Domain.Entities;
using Domain.Product.Validation;
using ProductDomain = Domain.Product.Entities.Product;

namespace Domain.Product.Entities;
public sealed class Category : Entity
{
    public string Name { get; private set; }
    public IEnumerable<ProductDomain> Products { get; private set; }

    public Category(string name)
    {
        ValidateCategoryDomain(name);
    }

    public Category(Guid id, string name)
    {
        DomainExceptionValidation.When(id.GetType() != typeof(Guid),"Invalid Id");
        Id = id;
        ValidateCategoryDomain(name);
    }

    public void UpdateCategory(string name) => ValidateCategoryDomain(name);
    
    private void ValidateCategoryDomain(string name)
    {
        DomainExceptionValidation.When(string.IsNullOrEmpty(name), 
            "Invalid Name: Name is Required");
        DomainExceptionValidation.When(name.Length <= 3,
            "Invalid Name: Name must be at least 3 letters!");
        Name = name;
    }
}