using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public IEnumerable<Product> GetAll()
        {
            IQueryable<Product> query = _db.Products.Where(x => x.IsActive == true);
            return query.ToList();
        }
        public void Update(Product product)
        {
            var objFromDB = _db.Products.FirstOrDefault(u => u.Id == product.Id);
            if(objFromDB != null)
            {
                objFromDB.IsActive = product.IsActive;
                objFromDB.Title = product.Title;
                objFromDB.ISBN = product.ISBN;
                objFromDB.Description = product.Description;
                objFromDB.Author = product.Author;
                objFromDB.ListPrice = product.ListPrice;
                objFromDB.Price100 = product.Price100;
                objFromDB.CategoryId = product.CategoryId;
                objFromDB.CoverTypeId = product.CoverTypeId;
                if(product.ImageUrl != null)
                {
                    objFromDB.ImageUrl = product.ImageUrl;
                }

            }
        }
    }
}
