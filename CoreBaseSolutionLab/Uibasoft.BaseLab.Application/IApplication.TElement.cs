using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uibasoft.BaseLab.Abstractions;

namespace Uibasoft.BaseLab.Application
{
    public interface IApplication<TElement> : ICrud<TElement>
    {

    }
}
