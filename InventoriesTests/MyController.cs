using System;

namespace InventoriesTests
{
    internal class MyController<T>
    {
        internal static object Instance(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}