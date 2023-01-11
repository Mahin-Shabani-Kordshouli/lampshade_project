
using _0_FrameWork.Application;
using System.Collections.Generic;

namespace ShopManagement.Application.Contract.ProductCategory
{
    public interface IProductCategoryApplication
    {
        OperationResult Create(CreatProductCategory Command);
        OperationResult Edit(EditProductCategory Command);
        EditProductCategory GetDetaile(long Id);
        List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel);

    }
}
