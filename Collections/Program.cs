using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        // ArrayList();
       // List();

        Dictionary<string,string> dictionary= new Dictionary<string,string>();
        dictionary.Add("book", "Kitap");
        dictionary.Add("Computer", "Bilgisayar");
        dictionary.Add("Table", "Tablo");

        Console.WriteLine(dictionary["Table"]);

        
    }

    private static void List()
    {
        List<string> cities = new List<string>();
        cities.Add("Ankara");



        List<Customer> customers2 = new List<Customer>
        {   new Customer { Id = 1, Name = "Mustafa" },
            new Customer { Id = 2, Name = "Köroğlu" }

        };

        List<Customer> customers = new List<Customer>();
        customers.Add(new Customer { Id = 1, Name = "Mustafa" });
        customers.Add(new Customer { Id = 2, Name = "Köroğlu" });

        //Listede ki eleman sayısını gösterir.
        var count = customers.Count;
        var customer3 = new Customer
        {
            Id = 3,
            Name = "Mustafa"
        };
        //ekleme yapar.
        customers.Add(customer3);

        // Listeye liste olarak ekleme yapar (toplu).
        customers.AddRange(new Customer[2]
        {
            new Customer{Id=4,Name="Mustafaaa"},
            new Customer{Id=5,Name="Mustafaaaaaaaaaa"}
        });
        // bütün elemanları siler
        customers.Clear();

        // Listede ki elemanın kaçıncı sırada olduğunu gösterir.
        customers.IndexOf(customer3);

        // listede ki aramaya en sondan başlar
        customers.LastIndexOf(customer3);

        // Kaçıncı sıraya eklemek istediğmizi belirler.
        customers.Insert(0, customer3);

        //customer3 siler.Bulduğu ilk değeri siler!!
        customers.Remove(customer3);
        // bu da aynı değerlerin hepsini siler
        customers.RemoveAll(customer3 => customer3.Id == 3);




        foreach (Customer customer in customers)
        {
            Console.WriteLine(customer.Name);
        }

        foreach (string city in cities)
        {
            Console.WriteLine(city);
        }
    }

    private static void ArrayList()
    {
        ArrayList cities = new ArrayList();
        cities.Add("Ankara");
        cities.Add("Adana");

        cities.Add("İstanbul");

        cities.Add(1);
        cities.Add('a');

        foreach (var city in cities)
        {
            Console.WriteLine(city);
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}