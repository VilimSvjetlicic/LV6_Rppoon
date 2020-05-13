using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6_Rppoon
{
    interface IAbstractCollection
    {
        IAbstractIterator GetIterator();
    }
}
