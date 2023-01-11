using _0_FrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Domain.ProductCategoryAgg
{
    public class ProductCategory : Entitybase
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Picture { get; private set; }
        public string PictureTitle { get; private set; }
        public string PictureAlt { get; private set; }
        public string Slug { get; private set; }
        public string KeyWord { get; private set; }
        public string MetaDescription { get; private set; }

        public ProductCategory(string name, string description, string picture, string pictureTitle,
            string pictureAlt, string slug, string keyWord,string metaDescription)
        {
            Name = name;
            Description = description;
            Picture = picture;
            PictureTitle = pictureTitle;
            PictureAlt = pictureAlt;
            Slug = slug;
            KeyWord = keyWord;
            MetaDescription = metaDescription;
        }
        public void Edit(string name, string description, string picture, string pictureTitle,
            string pictureAlt, string slug, string keyWord,string metaDescription)
        {
            Name = name;
            Description = description;
            Picture = picture;
            PictureTitle = pictureTitle;
            PictureAlt = pictureAlt;
            Slug = slug;
            KeyWord = keyWord;
            MetaDescription = metaDescription;
        }
    }
}
