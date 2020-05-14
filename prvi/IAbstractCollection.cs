using System;
using System.Collections.Generic;
using System.Text;

namespace prvi
{
    interface IAbstractCollection
    {
        IAbstractIterator GetIterator();
    }
}
