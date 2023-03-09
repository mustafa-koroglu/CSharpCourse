using Exceptions;

internal class Program
{
    private static void Main(string[] args)
    {
        // ExceptionIntro();

        try
        {
            Find();
            
        } 
        catch(RecordNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
           
        }


        HandleException(() =>
        {
            Find();
        });
    }

    private static void HandleException(Action action)
    {
        try
        {
            action.Invoke();
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
            

        }
    }

    private static void Find()
    {
        List<string> students = new List<string> { "Mustafa", "Köroğlu", "Salih" };
        if (!students.Contains("ahmet"))
        {
            throw new RecordNotFoundException("Record not found!");
            
        }
        else
        {
            Console.WriteLine("Record Found!");
            
        }
    }

    private static void ExceptionIntro()
    {
        try
        {
            string[] students = new string[3] { "mustafa", "Köroğlu", "Salih" };
            students[3] = "Ahmet";
        }
        catch (IndexOutOfRangeException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
        }
    }
}