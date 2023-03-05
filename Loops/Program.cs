internal class Program
{
    private static void Main(string[] args)
    {
        for (int i = 0; i <= 100; i++)
        {
            Console.WriteLine(i);
        }

        int number = 100;
        while (number>=0)
        {
            Console.WriteLine(number);
            number--;
        }

        int number2 = 100;
        do
        {
           Console.WriteLine(number2);
            number2--;

        } while (number2>=100);

        string[] students3 = { "Mustafa", "Öznur", "Engin" };
        foreach (string student in students3) 
        { 
            Console.WriteLine(student);
        
        }

    }
}