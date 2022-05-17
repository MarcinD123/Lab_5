using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class ObservableList2<T>
    {
        public ObservableList2()
        {

        }
        public delegate void Added(T val);
        static void test()
        {
            //del(2);
        }
        
        private List<T> ObList2 = new List<T>();



        public int Length
        {
            get { return ObList2.Count; }
        }
        public T this[int i]      //https://docs.microsoft.com/pl-pl/dotnet/csharp/programming-guide/indexers/
        {

            get { return ObList2[i]; }
            set { ObList2[i] = value; }
        }

        public  void Ob2Add(T item,Added del)
            //public void Ob2Add(T item)
        {
            ObList2.Add(item);
            del(item);
        }

        public void Ob2RemoveAt(int index)
        {
            ObList2.RemoveAt(index);
        }
        public T Ob2Get(int index)
        {
            return ObList2[index];
        }
        public void Ob2Set(T value, int index)
        {
            ObList2[index] = value;
        }
        
    }
}
