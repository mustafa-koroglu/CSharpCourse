internal class Program
{
    private static void Main(string[] args)
    {
         // Intro();
        String sentence = "My name is mustafa Köroğlu";
       var result= sentence.Length;
        var result2=sentence.Clone();
        sentence = "My name is Mustafa";
        Console.WriteLine(result);
        Console.WriteLine(result2);

        // Ğ ile mi bitiyor kontrol eder.
        bool result3=sentence.EndsWith("ğ");
        //M ile başlıyor mu diye kontrol eder.
        bool result4 = sentence.StartsWith("m");
        // Indexof bulamadığı zaman -1 döndürür.Ve bulduğu ilkini sayar.
        var result5 = sentence.IndexOf("name");
        var result6 = sentence.IndexOf(" ");
        //Sondan başlar.
        var result7 = sentence.LastIndexOf(" ");
        //başka bir metni eklemek için kullanır. Baştaki (0) o karakterden sonra ekle.
        var result8 = sentence.Insert(0, "Hello");
        //3. karakterden itibaren al
        var result9 = sentence.Substring(3);
        //3. karakterden itibaren 4 tane karakter al.
        var result10 = sentence.Substring(3,4);
        //bütün karakterleri küçük harfe çevirir.
        var result11 = sentence.ToLower();
        // bütün karakterleri büyük harfe çevirir.
        var result12 = sentence.ToUpper();
        // ilk yazılan karakterleri 2. yazılan karakterle değiştir.
        var result13 = sentence.Replace(" ", "-");
        //2. karakterden itibaren atar.Eğer 2. değer girilirse o karakter kadar siler.
        var result14 = sentence.Remove(2);

        
    }

    private static void Intro()
    {
        string city = "Ankara";
        Console.WriteLine(city[0]);

        foreach (var item in city)
        {
            Console.WriteLine(item);
        }
        string city2 = "İstanbul";

        string result = city + " " + city2;
        Console.WriteLine(String.Format("{0} {1}", city, city2));
        Console.WriteLine(result);
    }
}