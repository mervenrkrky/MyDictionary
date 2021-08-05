using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] _key;
        TValue[] _value;

        public MyDictionary()
        {
            _key = new TKey[0];
            _value = new TValue[0];

        }
        public void Add(TKey item1,TValue item2)
        {

            TKey[] _temparraykey = _key;
            TValue[] _temparrayvalues = _value;

            _key = new TKey[_key.Length + 1];
            _value = new TValue[_value.Length + 1];
            for (int i = 0; i < _temparraykey.Length; i++)
            {
                _key[i] = _temparraykey[i];
                _value[i] = _temparrayvalues[i];
            }
            _key[_key.Length - 1] = item1;
            _value[_value.Length - 1] = item2;

            Console.WriteLine(item1+ " numaralı  " + item2 + " adlı kullanıcı sisteme eklendi.");
        }
    }
}
