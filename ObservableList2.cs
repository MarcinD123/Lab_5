using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    //public delegate void ListAdded<T>(T dval);
    class ObservableList2<T>
    {
        //public ListAdded<T> added;
        public ObservableList2()
        {

        }
        //public delegate void Added(T val);
        
        
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
        //public ListAdded<T> ItemAdded;
        public  void Ob2Add(T item)
        {
            //added(item);
            ObList2.Add(item);
            
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
