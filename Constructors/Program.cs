﻿internal class Program
{
    private static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager(10);
        customerManager.List();

        EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
        employeeManager.Add();

        PersonManager personManager = new PersonManager("Product");
        personManager.Add();
        Teacher.Number = 10;

        Utilities.Validate();

    }
}
class CustomerManager
{
    private int _count;
    public CustomerManager(int count)
    {
        _count = count;
    }
    public CustomerManager()
    {

    }
    public void List()
    {
        Console.WriteLine("Listened {0} items",_count);
    }
    public void Add()
    {
        Console.WriteLine("Added");
    }
}
interface ILogger
{
    void Log();
}
class DatabaseLogger:ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to database");
    }
}
class FileLogger:ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to file");
    }
}
class EmployeeManager
{
   private ILogger _logger;

    public EmployeeManager(ILogger logger)
    {
        _logger= logger;
    }
    public void Add()
    {
       _logger.Log();
        Console.WriteLine("Added");
    }
}
class BaseClass
{
    private string _entity;
    public BaseClass(string entity)
    {
        _entity = entity;
    }
    
    public void Message( )
    {
        Console.WriteLine(_entity+" message");
    }
}
class PersonManager:BaseClass
{
    public PersonManager(string entity):base(entity)
    {

    }
    public void Add()
    {
        Console.WriteLine("added");
        Message();
    }
}
 static class Teacher
{
    public static int Number { get; set; }
}
static class Utilities
{
    public static void Validate()
    {
        Console.WriteLine("Validation is done");
    }
}
class Manager
{
    public static void DoSomething()
    {
        Console.WriteLine("Done");
    }
    public void DoSomething2()
    {
        Console.WriteLine("Done2");
    }
}