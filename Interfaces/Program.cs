using Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        // InterfacesIntro();
        // Demo();
        ICustomerDal[] customerDals= {new OracleCustomerDal(),new SqlServerCustomerDal(),new MySqlCustomerDal()};

        foreach (var customerDal in customerDals)
        {
            customerDal.Add();
        }
    }

    private static void Demo()
    {
        CustomerManager manager = new CustomerManager();
        manager.Add(new SqlServerCustomerDal());
    }

    private static void InterfacesIntro()
    {
        PersonManager personManager = new PersonManager();
        personManager.Add(new Customer { Id = 1, FirstName = "Mustafa", LastName = "Köroğlu", Adress = "İstanbul" });
    }
}
interface IPerson
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
}
class Customer:IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Adress { get; set; }
}
class Student:IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}
class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}