using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Tkey, Tvalue>
    {
        Tkey[] keys;
        Tvalue[] values;

        public MyDictionary()
        {
            keys = new Tkey[0];
            values = new Tvalue[0];
        }

        public void Add(Tkey keyItem, Tvalue valueItem)
        {
            Tkey[] tempKeys = keys;
            Tvalue[] tempValues = values;

            keys = new Tkey[keys.Length + 1];
            values = new Tvalue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = keyItem;
            values[values.Length - 1] = valueItem;

        }

        public void ListValueByKey(Tkey keyItem)
        {
            for (int i = 0; i <keys.Length; i++)
            {
                if (keys[i].Equals(keyItem))
                {
                    Console.WriteLine("bulundu: "+ keys[i]+ " "+values[i]);
                }
               
            }
        }

        public void ListAllValue()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + " " + values[i]);
            }
            

        }

    }
}
