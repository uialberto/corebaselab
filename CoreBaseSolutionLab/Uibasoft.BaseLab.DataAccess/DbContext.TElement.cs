using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uibasoft.BaseLab.Abstractions;

namespace Uibasoft.BaseLab.DataAccess
{
    public class DbContext<TElement> : IDbContext<TElement> where TElement : IEntity
    {
        IList<TElement> _elements;
        public DbContext()
        {
            _elements = new List<TElement>();
        }
        public void Delete(long id)
        {
            var element = _elements.Where(ele => ele.Id.Equals(id)).FirstOrDefault();
            if (element != null)
            {
                _elements.Remove(element);
            }
        }

        public IList<TElement> GetAll()
        {
            return _elements;
        }

        public TElement GetById(long id)
        {
            return _elements.Where(ele => ele.Id.Equals(id)).FirstOrDefault();
        }

        public TElement Save(TElement element)
        {
            if (!element.Id.Equals(0))
            {
                _elements.Add(element);
            }

            return element;            
        }
    }
}
