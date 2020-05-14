using System;
using System.Collections.Generic;
using System.Text;

namespace drugi
{
    interface IAbstractCollection
    {
        IAbstractIterator GetIterator();
    }
}
