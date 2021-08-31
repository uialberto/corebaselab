using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uibasoft.BaseLab.Abstractions
{
    public interface ITokenParameters
    {
        string Id { get; set; }
        string UserName { get; set; }
        string PasswordHash { get; set; }        
    }
}
