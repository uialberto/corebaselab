using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uibasoft.BaseLab.Abstractions;

namespace Uibasoft.BaseLab.DataAccess
{
    // Cuando se quiera cambiar el contexto de Base de Datos de EF Propiamente Dicho (LabDBContext) Se crea un nuevo contexto por uno diferente.
    public class DbContext<TElement> : IDbContext<TElement> where TElement : class, IEntity
    {
        DbSet<TElement> _elements;
        LabDbContext _context;
        public DbContext(LabDbContext context)
        {
            _context = context;
            _elements = _context.Set<TElement>();
        }
        public void Delete(long id)
        {
            var entity = GetById(id);
            if (entity != null)
            {
                _elements.Remove(entity);
                _context.SaveChanges();
            }
        }

        public IList<TElement> GetAll()
        {
            return _elements.ToList();
        }

        public TElement GetById(long id)
        {
            return _elements.Where(ele => ele.Id.Equals(id)).FirstOrDefault();
        }

        public TElement Save(TElement element)
        {
            _elements.Add(element);
            _context.SaveChanges();
            return element;
        }
    }
}
