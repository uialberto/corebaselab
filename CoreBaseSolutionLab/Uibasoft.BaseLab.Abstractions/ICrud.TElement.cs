using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uibasoft.BaseLab.Abstractions
{
    public interface ICrud<TElement>
    {
        TElement Save(TElement entity);
        IList<TElement> GetAll();
        TElement GetById(long id);
        void Delete(long id);
    }
}
