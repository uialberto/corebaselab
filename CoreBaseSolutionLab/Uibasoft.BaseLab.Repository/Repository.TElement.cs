using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uibasoft.BaseLab.Abstractions;

namespace Uibasoft.BaseLab.Repository
{
    public class Repository<TElement> : IRepository<TElement> where TElement : IEntity
    {
        IDbContext<TElement> _context;
        public Repository(IDbContext<TElement> context)
        {
            _context = context;
        }
        public void Delete(long id)
        {
            _context.Delete(id);
        }

        public IList<TElement> GetAll()
        {
            return _context.GetAll();
        }

        public TElement GetById(long id)
        {
            return _context.GetById(id);
        }

        public TElement Save(TElement entity)
        {
            return _context.Save(entity);
        }
    }
}
