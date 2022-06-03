using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    
    
    class Program
    {
        
        static void Main(string[] args)
        {
            /////////////////////////////////////////////////////////////// 1
            ObservableList1<char> L1 = new ObservableList1<char>();
            L1.onItemAdded += L1_OnNewItemAdded;
            L1.Ob1Add('a');
            L1.Ob1Add('x');
            L1.Ob1Add('b');
            L1.onItemAdded -= L1_OnNewItemAdded;
            L1.Ob1Add('w');
            L1.Ob1Add('d');
            L1.Ob1Set('z', 1);
            L1.Ob1RemoveAt(2);
            L1.Ob1Add('k');
            L1.Ob1Add('b');
            for (int i = 0; i < L1.Length; i++)
            {
                Console.WriteLine(L1.Ob1Get(i));    
            }


            /////////////////////////////////// 2
            Console.WriteLine();
            Console.WriteLine("L2:");
            ObservableList2<string> L2 = new ObservableList2<string>();

            L2.Ob2Add("xd");
            L2.Ob2Add("asd");
            L2.Ob2Add("Wtc");

           
            Console.WriteLine(L2.Ob2Get(1));

            
            ///////////////////////////////////
            ////
        }
      

        

        private static void L1_OnNewItemAdded(object sender, EventArgs e)//1
        {
           
            Console.WriteLine("New item!");
            
        }
        
        static void Receive(object i) //2
        {
            Console.WriteLine("Added: "+i);
        }


    }
    
}
