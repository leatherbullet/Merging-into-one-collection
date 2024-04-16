using System;
using System.Collections.Generic;

namespace Объединение_в_одну_коллекцию
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = { "1", "2", "1" };
            string[] array2 = { "3", "2" };
            List<string> collection = new List<string>();

            AddItem(array1, collection);
            AddItem(array2, collection);

            Show(collection);
        }

        static void Show(List<string> collection)
        {
            foreach (string number in collection)
            {
                Console.Write($"{number} ");
            }
        }

        static void AddItem(string[] array, List<string> collection)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (collection.Contains(array[i]) == false)
                {
                    collection.Add(array[i]);
                }
            }
        }
    }
}
