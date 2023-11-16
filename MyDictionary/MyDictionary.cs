using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryGeneric
{
    internal class MyDictionary<K, V>
    {
        K[] keys, tempArray1;
        V[] values, tempArray2;


        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }

        public void Add(K key, V value)
        {
            K[] tempArray1 = keys;
            V[] tempArray2 = values;

            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < tempArray1.Length; i++)
            {
                keys[i] = tempArray1[i];
                values[i] = tempArray2[i];

            }
   
             keys[keys.Length - 1] = key ;
             values[values.Length - 1] = value;


        }

        public int Length
        {
            get { return keys.Length; }

        }

        public K[] _Keys 
        {
            get { return keys; }
        }

        public V[] _Values
        {
            get { return values; }
        }








    }
}
