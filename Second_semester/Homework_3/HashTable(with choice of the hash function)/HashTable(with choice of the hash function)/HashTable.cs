﻿using System;
using ListNamespace;

namespace HashTableNamespace
{
    /// <summary>
    /// a class that represents a hash table
    /// </summary>
    public class HashTable : IHashTable
    {
        /// <summary>
        /// class constructor
        /// </summary>
        public HashTable(IHashFunction function, int size)
        {
            this.Size = size;
            this.function = function;
            hashTable = new List[size];
            for (int i = 0; i < size; ++i)
            {
                hashTable[i] = new List();
            }
        }

        /// <summary>
        /// stores the number of keys in hash table
        /// </summary>
        public int Size { get; }

        public void Add(string word)
        {
            int i = this.function.HashFunction(word) % this.Size;
            if (!this.Contains(word))
            {
                this.hashTable[i].Add(word);
            }
            else
            {
                Console.WriteLine("this item already exists in the hash table");
            }
        }

        public void Remove(string word)
        {
            int i = function.HashFunction(word) % this.Size;
            hashTable[i].Remove(word);
        }

        public bool Contains(string word)
        {
            int i = function.HashFunction(word) % this.Size;
            return hashTable[i].Contains(word);
        }

        public void Print()
        {
            Console.WriteLine("Hash table:");
            int size = hashTable.GetLength(0);
            for (int i = 0; i < size; ++i)
            {
                Console.WriteLine("List number " + i + ":");
                hashTable[i].Print();
                Console.WriteLine();
            }
        }

        private IHashFunction function;

        private List[] hashTable;
    }
}