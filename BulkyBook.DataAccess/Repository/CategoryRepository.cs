using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BulkyBook.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public new IEnumerable<Category> GetAll()
        {
            IQueryable<Category> query = _db.Categories.Where(x => x.IsActive == true);
            return query.ToList();
        }

        public void Update(Category category)
        {
            _db.Categories.Update(category);
        }
    }
}
