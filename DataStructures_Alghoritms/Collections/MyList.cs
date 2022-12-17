using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Alghoritms.Collections
{
    public class MyList<T>
    {
        #region List
        //var arr = new List<string> {"a","b","c","d" };
        //arr.Add("k");//o(1)
        //arr.Remove("a");//o(n)
        //arr.Insert(0, "z");//o(n)
        //WriteLine(arr[0]);//o(1)
        //contigious memory
        //lists  flexible size 
        //lists contains only same type of data
        #endregion
        T[] arr { get; set; }
        int Length { get; set; } = 0;
        public MyList()
        {
            arr= new T[Length];
        }
        public void Add(T data)
        {
            Length++;
            T[] narr = new T[Length];
            for (int i = 0; i < arr.Length; i++)
            {
                narr[i]=arr[i];
            }
            narr[Length-1] = data;
            arr= narr;
            
        }
        public void Remove(T data)
        {
            
        }
        public int Count
        {
            get
            {
                return Length;
            }
        }
        public T this[int index]
        {
            get
            {
                return arr[index];
            }
        }
        public T[] Data
        {
            get
            {
                return arr;
            }
        }
    }
}
