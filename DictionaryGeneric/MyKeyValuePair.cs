using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryGeneric
{
    class MyKeyValuePair<T,V>
    {
        public T Key { get; set; }
        public V Value { get; set; }
    }
}
