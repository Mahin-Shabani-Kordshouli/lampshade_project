using _0_FrameWork.Application;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Application.Contract.ProductCategory
{
    public class CreatProductCategory
    {
        [Required(ErrorMessage =ValidationMassages.IsRequierd)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string PictureTitle { get; set; }
        public string PictureAlt { get; set; }

        [Required(ErrorMessage = ValidationMassages.IsRequierd)]
        public string Slug { get; set; }

        [Required(ErrorMessage = ValidationMassages.IsRequierd)]
        public string KeyWord { get; set; }

        [Required(ErrorMessage = ValidationMassages.IsRequierd)]
        public string MetaDescription { get; set; }
    }

}
