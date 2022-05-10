using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public delegate void ListAdded<T>(T dval);
    
    class Program
    {
        
        static void Main(string[] args)
        {
            
            ObservableList1<char> L1 = new Lab_5.ObservableList1<char>();
            
            L1.Ob1Add('a');
            L1.Ob1Add('x');
            L1.Ob1Add('b');
            L1.Ob1Add('w');
            L1.Ob1Add('d');
            L1.Ob1Set('z', 1);
            L1.Ob1RemoveAt(2);
            for (int i = 0; i < L1.Length; i++)
            {
                Console.WriteLine(L1.Ob1Get(i));
            }
            
        }
        static void NewItemAddedHandle(object sender, EventArgs e)
        {
            Console.WriteLine($"New value {e} added from{sender.ToString()}");
        }
        public static void Cwres<T>(T inp)
        {
            Console.WriteLine(inp.ToString());
        }
    }
}
