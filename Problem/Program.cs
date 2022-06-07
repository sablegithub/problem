// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main(String[]args)
    {
        Console.WriteLine("Program form Prime Factor of Number");
        
        Console.WriteLine("Enter a Number");
        int x = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i<= x; i++)
        {
            if (x%i == 0)
            {
                Console.WriteLine(i);
            }
        }

    }
}






