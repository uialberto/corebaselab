using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uibasoft.BaseLab.Repository
{
    public class Repository<TElement> : IRepository<TElement>
    {
        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public IList<TElement> GetAll()
        {
            throw new NotImplementedException();
        }

        public TElement GetById(long id)
        {
            throw new NotImplementedException();
        }

        public TElement Save(TElement entity)
        {
            throw new NotImplementedException();
        }
    }
}
