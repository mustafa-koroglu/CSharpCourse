internal class Program
{
    private static void Main(string[] args)
    {
       SqlServer sqlServer= new SqlServer();
        MySql mySql= new MySql();
        sqlServer.Add();
        mySql.Add();
    }
}
class Database
{
    // virtual override edeilmeye yarar.
    public virtual void Add()
    {
        Console.WriteLine("Added by default");
    }
    public virtual void Delete()
    {
        Console.WriteLine("Deleted by default");
    }
}
class SqlServer:Database
{
    public override void Add()
    {
        Console.WriteLine("Added by Sql");
       // base.Add();
    }
}
class MySql:Database
{

}