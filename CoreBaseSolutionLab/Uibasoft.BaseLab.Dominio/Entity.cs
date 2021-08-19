using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uibasoft.BaseLab.Abstractions;

namespace Uibasoft.BaseLab.Dominio
{
    public abstract class Entity : IEntity
    {
        public long Id { get; set; }
    }
}
