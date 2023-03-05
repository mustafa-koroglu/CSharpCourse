internal class Program
{
    private static void Main(string[] args)
    {
        Database database= new Oracle();
        database.Delete();
        database.Add();

    }
}
abstract class Database
{
    public void Add()
    {
        Console.WriteLine("Added by default");
    }
    public abstract void Delete();
}
class SqlServer : Database
{
    public override void Delete()
    {
        Console.WriteLine("Deleted by sql");
    }
}
class Oracle : Database
{
    public override void Delete()
    {
        Console.WriteLine("Deleted by oracle");
    }
}
