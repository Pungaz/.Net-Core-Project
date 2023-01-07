using FragranceWebShop.DataAccess.Repository.IRepository;
using FragranceWebShop.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FragranceWebShop.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

/*        public void Update(CoverType obj)
        {
            _db.CoverTypes.Update(obj);
        }*/

        public void Update(CoverType obj)
        {
            var objFromDb = _db.CoverTypes.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Name= obj.Name;
            }
        }
    }
}
