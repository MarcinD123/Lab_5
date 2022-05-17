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
            /////////////////////////////////////////////////////////////// 1
            ObservableList1<char> L1 = new Lab_5.ObservableList1<char>();
            L1.OnNewItemAdded += L1_OnNewItemAdded;
            L1.Ob1Add('a');
            L1.Ob1Add('x');
            L1.Ob1Add('b');
            L1.Ob1Add('w');
            L1.Ob1Add('d');
            L1.Ob1Set('z', 1);
            L1.Ob1RemoveAt(2);
            
            for (int i = 0; i < L1.Length; i++)
            {
                Console.WriteLine(L1.Ob1Get(i/2));    
            }
            //////////////////////////////////////////////////////////////// 2
            Console.WriteLine();
            Console.WriteLine("L2:");
            ObservableList2<string> L2 = new ObservableList2<string>();
            L2.Ob2Add("xd",Receive);
            L2.Ob2Add("asd",Receive);
            L2.Ob2Add("Wtc",Receive);


            Console.WriteLine(L2.Ob2Get(1));
            ////////////////////////////////////////////////////////////////////////////////////

        }
        private static void L1_OnNewItemAdded(object sender, EventArgs e)//1
        {
            Console.WriteLine("New item");
        }
        static void Receive(object i) //2
        {
            Console.WriteLine("Added: "+i);
        }


    }
    
}
