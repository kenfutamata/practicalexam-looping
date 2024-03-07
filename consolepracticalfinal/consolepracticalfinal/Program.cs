using consolepracticalfinal;
using System; 

public class Program
{
    public static void Main(String[] args)
    {
        int size;
        Console.Write("Enter the size of an array: ");
        size = Convert.ToInt32(Console.ReadLine()); 
        int[] arr = new int[size];
        Console.WriteLine("Enter the " + size + " elements of an array: "); 
        for(int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine()); 
        }

        encap es = new encap(arr);
        es.display();
        Console.WriteLine();
        es.odddisplay(); 
        Console.WriteLine();
        es.evendisplay(); 
    }
}