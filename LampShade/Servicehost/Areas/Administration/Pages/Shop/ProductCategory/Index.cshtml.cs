using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contract.ProductCategory;

namespace Servicehost.Areas.Administration.Pages.Shop.ProductCategory
{
    public class IndexModel : PageModel
    {
        public ProductCategorySearchModel SearchModel;
        public List<ProductCategoryViewModel> ProductCategories;
        private readonly IProductCategoryApplication _productCategoryAplication;
        public IndexModel(IProductCategoryApplication productCategoryApplication)
        {
            _productCategoryAplication = productCategoryApplication;
        }
        public void OnGet(ProductCategorySearchModel searchModel)
        {
           ProductCategories = _productCategoryAplication.Search(searchModel);
        }
         
        public IActionResult OnGetCreate()
        {
            return Partial("./Create", new CreatProductCategory());
        }
        public IActionResult OnPostCreate(CreatProductCategory Command)
        {
            var result = _productCategoryAplication.Create(Command);
            return new JsonResult(result);
        }
        public IActionResult OnGetEdit(long id)
        {
            var productCategory = _productCategoryAplication.GetDetaile(id);
            return Partial("./Edit", productCategory);
        }
        public IActionResult OnPostEdit(EditProductCategory Command)
        {
            var result = _productCategoryAplication.Edit(Command);
            return  new JsonResult(result);
        }
    }
}
