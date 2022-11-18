using System;
using System.Collections.Generic;

namespace GenericsHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionary< Key_Tipi , Value_Tipi > Referans_Adi = new Dictionary< Key_Tipi , Value_Tipi >();

            Dictionary<int, string> Employees = new Dictionary<int, string>();
            Employees.Add(1, "Sayit Sami");
            Employees.Add(2, "Brendan Eich");
            Employees.Add(3, "Rasmus Lerdorf");

            //Console.WriteLine(Employees.Count); // get
            //Console.WriteLine(Employees[1]);
            //Console.WriteLine(Employees[2]); 


            // MyDictionary

            MyDictionary<int, string> Customers = new MyDictionary<int, string>();
            Customers.Add(101, "Amazon");
            Customers.Add(102, "İkas");
            Customers.Add(103, "Ebay");
            Customers.Add(104, "Trendyol");

            Console.WriteLine($"Customers Count: {Customers.Count}"); 

            for (int i = 0; i < Customers.Count; i++)
            {
                Console.WriteLine($"Customers Number: {Customers.Keys[i]}  -  Customers Name: {Customers.Values[i]}");
            }

            Customers.GetList();

        }
    }


    class MyDictionary<TKey, TValue>
    {

        TKey[] keys;
        TKey[] _tempKeys; 

        TValue[] values;
        TValue[] _tempValues;  

        public MyDictionary() // constructor
        {
            keys = new TKey[0]; // 
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            _tempKeys = keys; // keys dizesinin referansını tut.
            _tempValues = values; // values dizesinin referansını tut.

            
            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            
            for (int i = 0; i < _tempKeys.Length; i++)
            {
                keys[i] = _tempKeys[i];
            }

            
            for (int i = 0; i < _tempValues.Length; i++)
            {
                values[i] = _tempValues[i];
            }

            

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        
        public int Count
        {
            get { return keys.Length; }
        }

        public TKey[] Keys
        {
            get { return keys; }
        }

        public TValue[] Values
        {
            get { return values; }
        }

        public void GetList()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine($"{ keys[i] } - { values[i] }");
            }
        }
    }
}
