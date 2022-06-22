using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> sehirler = new Dictionary<int, string>();
            sehirler.Add(1,"Adana");
            sehirler.Add(2, "Adıyaman");
            Console.WriteLine(sehirler.Count);

            MyDictionary<int, string> sehirler2 = new MyDictionary<int, string>();
            sehirler2.Add(79,"Kilis");
            sehirler2.Add(34, "İstanbul");
            Console.WriteLine(sehirler2.Count);



            Console.ReadKey();
        }
    }
    class MyDictionary<T,Y>
    {
        T[]_array;
        Y[]_array2;
        T[] tempArray;
        Y[] tempArray2;
        public MyDictionary()
        {
            
            _array = new T[0];
            _array2 = new Y[0];
        }   
        public void Add(T item,Y item2)
        {
            tempArray = _array;
            tempArray2 = _array2;
            _array = new T[_array.Length + 1];
            _array2 = new Y[_array2.Length + 1];
            for (int i = 0; i <tempArray.Length; i++)
            {
                _array[i] = tempArray[i];

            }
            _array = new T[_array.Length - 1];
            _array2 = new Y[_array2.Length - 1];
        }

        public int Count
        {
            get{ return _array.Length; }
        }
      


    }
}
