using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class gods
    {
        public static void Main()
        {
            Console.WriteLine("---------------------FOREACH LOOP-----------------------");

            string[] god = { "Ganesh", "Hanuman", "Bhojling", "Sidhanath", "Mhasoba", "Pandurang", "Dariling", "Krishna" };
            
            foreach(string gods in god)
            {
                Console.WriteLine(gods);

            }
            Console.WriteLine("---------------------FOR LOOP---------------------------");
            for(int i=1;i<god.Length;i++)
            {
                Console.WriteLine(i+"."+god[i]);
            }
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Types of operators in c#.");

            string[] opr={"Arithmetic","Relational","Logical","Bitwise","Assignment","Unary","Ternary","Conditional"};
            int j;
            for(j = 1; j < opr.Length; j++)
            {
                Console.WriteLine(j + "." + opr[j]+" Operator");
            }

        
        }
        
    }
}
