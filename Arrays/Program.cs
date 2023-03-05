internal class Program
{
    private static void Main(string[] args)
    {

       String[] students = new string [3];
        students[0] = "Mustafa";
        students[1] = "Öznur";
        students[2] = "Engin";

        String[] students2 = new string[] {"Mustafa","Öznur","Engin"};
        String[] students3= { "Mustafa", "Öznur", "Engin" };


        foreach (string student in students)
        { 
            Console.WriteLine(student);
        
        }

       

    }
}