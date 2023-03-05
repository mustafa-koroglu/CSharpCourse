internal class Program
{
    private static void Main(string[] args)
    {
        Person[] persons=new
    }

}
class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
}
class Customer:Person
{
    public string City { get; set; }
}
class Student:Person
{

}