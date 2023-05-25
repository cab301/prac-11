using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    /// <summary>
    /// Create a hash table using the linear probing collision resolving strategy.
    /// </summary>
    internal class HashtableLinear : IHashtable
    {
        // The inner data structure of the hash table
        private int?[] inner;
        private int count;
        public int Count => count;

        private int capacity;
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("Capacity cannot be 0 or negative");
                capacity = value;
            }
        }

        /// <summary>
        /// The hash function.
        /// </summary>
        /// <param name="key">The key to hash.</param>
        /// <returns>The index of the key in the hash table.</returns>
        private int Hash(int key)
        {
            return key % Capacity;
        }

        public HashtableLinear() : this(17)
        {
        }

        public HashtableLinear(int capacity)
        {
            Capacity = capacity;
            inner = new int?[Capacity];
            count = 0;
        }

        public void Clear()
        {
            inner = new int?[Capacity];
            count = 0;
        }

        public void Delete(int key)
        {
            int j = Hash(key);
            int i = 0;
            int offset = 0;
            // Define empty or deleted as null
            while (i < Capacity
                && inner[(j + offset) % Capacity] != key
                && inner[(j + offset) % Capacity] != null)
            {
                // Linear probing, so
                offset += 1;
                i += 1;
            }
            if (inner[(j + offset) % Capacity]  == key)
            {
                inner[(j + offset) % Capacity] = null;
            }
        }

        public void Insert(int key)
        {
            int j = Hash(key);
            int i = 0;
            int offset = 0;
            // Define empty or deleted as null
            while (i < Capacity 
                && inner[(j + offset) % Capacity] != key 
                && inner[(j + offset) % Capacity] != null)
            {
                // Linear probing, so
                offset += 1;
                i += 1;
            }
            if (inner[(j + offset) % Capacity] == null)
            {
                inner[(j + offset) % Capacity] = key;
            }
        }

        public int Search(int key)
        {
            int j = Hash(key);
            int i = 0;
            int offset = 0;
            // Define empty or deleted as null
            while (i < Capacity
                && inner[(j + offset) % Capacity] != key)
            {
                // Linear probing, so
                offset += 1;
                i += 1;
            }
            if (inner[(j + offset) % Capacity] == key)
            {
                return (j + offset) % Capacity;
            }
            return -1;
        }

        public void Print()
        {
            Console.WriteLine("Index\tKey");
            for (int i = 0; i < Capacity; i++)
            {
                Console.WriteLine("{0}\t{1}", i, inner[i]);
            }
        }
    }
}
