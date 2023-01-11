using _0_FrameWork.Domain;
using ShopManagement.Application.Contract.ProductCategory;
using System.Collections.Generic;



namespace ShopManagement.Domain.ProductCategoryAgg
{
    public interface IProductCategoryRepository:IRepository<long,ProductCategory>
    {
        EditProductCategory GetDetails(long Id);
        List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchmodel); 
    }
}
