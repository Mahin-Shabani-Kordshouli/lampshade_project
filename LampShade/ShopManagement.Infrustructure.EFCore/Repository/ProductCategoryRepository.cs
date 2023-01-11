using _0_FrameWork.Infrustructure;
using ShopManagement.Application.Contract.ProductCategory;
using ShopManagement.Domain.ProductCategoryAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ShopManagement.Infrustructure.EFCore.Repository
{
    public class ProductCategoryRepository : RepositoryBase<long,ProductCategory>,IProductCategoryRepository
    {
        private readonly ShopContext _context;
        public ProductCategoryRepository(ShopContext  context):base(context)
        {
            _context = context;
        }
        public EditProductCategory GetDetails(long Id)
        {

            return _context.ProductCategories.Select(x => new EditProductCategory
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Picture = x.Picture,
                PictureTitle = x.PictureTitle,
                PictureAlt = x.PictureAlt,
                Slug = x.Slug,
                KeyWord = x.KeyWord,
                MetaDescription = x.MetaDescription
            }).FirstOrDefault(x=> x.Id==Id);
           
        }
        public List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchmodel)
        {
            var query = _context.ProductCategories.Select(x => 
            new ProductCategoryViewModel {

                Id = x.Id,
                Name = x.Name,
                CreationDate= x.CreationDate.ToString(),
                Picture=x.Picture

            });

            if (!String.IsNullOrWhiteSpace(searchmodel.Name))
               query = query.Where(x => x.Name.Contains(searchmodel.Name));

            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}
