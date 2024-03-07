using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolepracticalfinal
{
    public class encap
    {
        private int[] arr;
        public encap(int[] arr)
        {
            this.arr = arr; 
        }

        public int[] getArr()
        {
            return arr; 
        }

        public void display()
        {
            Console.Write("Array Elements: "); 
            foreach(int i in getArr())
            {
                Console.Write(" "+i);
            }
        }

        public void odddisplay()
        {
            Console.Write("Odd Array Elements: "); 
            for(int i = 0; i < getArr().Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.Write(" " + i); 
                }
            }
            int sum = 0;
            Console.WriteLine(); 
            Console.Write("Odd Array Sum: ");
            for (int i = 0; i < getArr().Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum += i;
                    
                }
            }
            Console.Write(" " + sum);
        }

        public void evendisplay()
        {
            Console.Write("Even Array Elements: ");
            for (int i = 0; i < getArr().Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.Write(" " + i);
                }
            }
            int sum = 0;
            Console.WriteLine();
            Console.Write("Even Array Sum: ");
            for (int i = 0; i < getArr().Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    sum += i;
                    
                }
            }
            Console.Write(" " + sum);
        }
    }
}
