internal class Program
{
    private static void Main(string[] args)
    {
        
        CustomerManager customerManager = new CustomerManager();
        customerManager.Logger=new DatabaseLogger();
        customerManager.Add();
    }
}
class CustomerManager
{
    public ILogger Logger { get; set; }
    public void Add()
    {
        Logger.Log();
        Console.WriteLine(" Customer Added");
    }
}
class DatabaseLogger:ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to database");
    }
}
class FileLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to file");
    }
}
interface ILogger
{
    void Log();
}