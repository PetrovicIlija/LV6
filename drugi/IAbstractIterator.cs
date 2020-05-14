using System;
using System.Collections.Generic;
using System.Text;

namespace drugi
{
    interface IAbstractIterator
    {
        Product First();
        Product Next();
        bool IsDone { get; }
        Product Current { get; }

    }
}
