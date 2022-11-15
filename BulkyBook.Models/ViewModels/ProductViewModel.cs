using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Models.ViewModels
{
    public class ProductViewModel
    {
        public Product product { get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }
        //    = _unitOfWork.Category.GetAll().Select(
        //    u => new SelectListItem
        //    {
        //        Text = u.Name,
        //        Value = u.Id.ToString()
        //    }
        //);
        public IEnumerable<SelectListItem> CoverTypeList { get; set; }
        //    = _unitOfWork.CoverType.GetAll().Select(
        //    u => new SelectListItem
        //    {
        //        Text = u.Name,
        //        Value = u.Id.ToString()
        //    }
        //);
    }
}
