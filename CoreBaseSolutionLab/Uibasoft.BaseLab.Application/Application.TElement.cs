using System;
using System.Collections.Generic;
using Uibasoft.BaseLab.Abstractions;
using Uibasoft.BaseLab.Repository;

namespace Uibasoft.BaseLab.Application
{
    // Patron Adapter
    public class Application<TElement> : IApplication<TElement> where TElement : IEntity
    {
        IRepository<TElement> _repo;
        public Application(IRepository<TElement> repo)
        {
            _repo = repo;
        }
        public void Delete(long id)
        {
            _repo.Delete(id); 
        }

        public IList<TElement> GetAll()
        {
            return _repo.GetAll();
        }

        public TElement GetById(long id)
        {
            return _repo.GetById(id);
        }

        public TElement Save(TElement entity)
        {
            return _repo.Save(entity);
        }
    }
}
