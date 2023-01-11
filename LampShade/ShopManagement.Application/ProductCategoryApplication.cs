using _0_Framework.Application;
using _0_FrameWork.Application;
using ShopManagement.Application.Contract.ProductCategory;
using ShopManagement.Domain.ProductCategoryAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Application
{
    public class ProductCategoryApplication : IProductCategoryApplication
    {
        private readonly IProductCategoryRepository _productCategoryRepository;

        public ProductCategoryApplication(IProductCategoryRepository productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
        }

        public OperationResult Create(CreatProductCategory Command)
        {
            var Operationresult = new OperationResult();

            if (_productCategoryRepository.Exist(x => x.Name == Command.Name))
                return Operationresult.Failed("رکورد با اطلاعات داده شده تکراری  می باشد. لطفا مجدد تلاش نمایید.");

            var slug = Command.Slug.Slugify();

            var productCategory = new ProductCategory(Command.Name, Command.Description, Command.Picture,
                Command.PictureTitle, Command.PictureAlt, slug, Command.KeyWord, Command.MetaDescription);

            _productCategoryRepository.Create(productCategory);

            _productCategoryRepository.SaveChange();
            return Operationresult.Succeded();
        }

        public OperationResult Edit(EditProductCategory Command)
        {
            var Operationresult = new OperationResult();

            if (_productCategoryRepository.Get(Command.Id) == null)
                return Operationresult.Failed(" رکورد مورد نظر موجود تیست");

            if (_productCategoryRepository.Exist(x => x.Name == Command.Name && x.Id != Command.Id))
                return Operationresult.Failed("رکورد با اطلاعات داده شده تکراری  می باشد. لطفا مجدد تلاش نمایید");

            var slug = Command.Slug.Slugify();

            var productCategory = _productCategoryRepository.Get(Command.Id);
            productCategory.Edit(Command.Name, Command.Description, Command.Picture,
            Command.PictureTitle, Command.PictureAlt, slug, Command.KeyWord, Command.MetaDescription);

            _productCategoryRepository.SaveChange();
            return Operationresult.Succeded();
        }

        public EditProductCategory GetDetaile(long Id)
        {
            return _productCategoryRepository.GetDetails(Id);
        }

        public List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel)
        {
            return _productCategoryRepository.Search(searchModel);
        }
    }
}
