using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    

    class ObservableList1<T>
    {
        public event EventHandler OnNewItemAdded;
        public ObservableList1()
        {
            OnNewItemAdded += ItemAdded;
        }
        

       // ListAdded<T> delegat = Program.Cwres<T>;
        //public delegate void ItemAddedEventHandler<T>(object src, EventArgs args);
        //ListAdded LAD = new ListAdded();
        private List<T> ObList1 = new List<T>();
        
        public void ItemAdded(object src, EventArgs e)
        {

            Console.WriteLine("dodano");
        }

        

        public int Length
        {
            get { return ObList1.Count; }

        }
        public T this[int i]      //https://docs.microsoft.com/pl-pl/dotnet/csharp/programming-guide/indexers/
        {

            get { return ObList1[i]; }
            set { ObList1[i] = value; }
        }
        
        public void Ob1Add(T item)
        {     
            ObList1.Add(item);
            
            
            OnNewItemAdded?.Invoke(this,EventArgs.Empty);
            //OnItemAdded?.Invoke(this, EventArgs.Empty);           
        }
        
        public void Ob1RemoveAt(int index)
        { 
            ObList1.RemoveAt(index);
        }
        public T Ob1Get(int index)
        {
            return ObList1[index];
        }
        public void Ob1Set(T value, int index)
        {
            ObList1[index] = value;
        }
        // public event EventHandler<string> Addedevent

        

    }
}
