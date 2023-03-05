internal class Program
{
    private static void Main(string[] args)
    {
        Add();
        Add2(7, 8);
        Console.WriteLine(Add(7, 8, 9, 11, 15, 16, 17));
    }
    static void Add()
    {
        Console.WriteLine("Method çağrıldı");
    }
    static int Add2(int number1,int number2)
    {
       
           int result= number1+number2;
        
        return result;
    }
    static int Add(params int[] numbers)
    {
        return numbers.Sum();
    }
}
