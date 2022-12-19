using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEditorFinale
{
    internal interface IPrototype<T>
    {
        T CreateDeepCopy();
    }
}
