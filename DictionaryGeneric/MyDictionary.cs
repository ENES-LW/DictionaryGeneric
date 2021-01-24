using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryGeneric
{
    class MyDictionary<T,V>
    {
        public List<MyKeyValuePair<T, V>> dictionary = new List<MyKeyValuePair<T, V>>();
        List<T> keys = new List<T>();
        List<V> values = new List<V>();
        public void Add(T key , V value)
        {
            MyKeyValuePair<T,V> temp = dictionary.Find(x => x.Key.ToString().Equals(key.ToString()));
            if (temp==null)
            {
                temp = new MyKeyValuePair<T, V>();
                temp.Key = key;
                temp.Value = value;
                dictionary.Add(temp);
            }
            else
            {
                Console.WriteLine(key + " anahtarına sahip değer vardı. girdiğiniz " + key + "-" + value + " değerleri eklenmedi");
            }
            //if (!keys.Contains(key))
            //{
            //    keys.Add(key);
            //    values.Add(value);
            //}
            //else
            //{
            //    Console.WriteLine(key+" anahtarına sahip değer vardı. girdiğiniz "+key+"-"+value+" değerleri eklenmedi");
            //}
        }

        public V TryGetValue(T key)
        {
            MyKeyValuePair<T, V> temp = dictionary.Find(x => x.Key.ToString().Equals(key.ToString()));

            if (temp!=null)
            {
                return temp.Value;
            }
            else
            {
                return default;  //şurada doğru dönüş değerini bilmiyorum, null döndürebilmek isterdim
            }
           
        }

        public bool Remove(T key)
        {
            MyKeyValuePair<T, V> temp = dictionary.Find(x => x.Key.ToString().Equals(key.ToString()));

            if (temp!=null)
            {
                dictionary.Remove(temp);
                return true;
            }
            else
            {
                return false;
            }
            //if (keys.Contains(key))
            //{
            //    int index = keys.IndexOf(key);
            //    keys.RemoveAt(index);
            //    values.RemoveAt(index);
            //    return true;
            //}
            //else
            //    return false;
        }


        
    }
}
