class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hoşgeldiniz almak istediğiniz kahveleri yazar mısınız?");

        List<string> kahveListesi = new List<string>();
        for (int i = 1; i < 6; i++)
        {
            Console.Write($"{i}. Kahve: ");
            string girilenKahve = Console.ReadLine();
            kahveListesi.Add(girilenKahve);
        }
        Console.WriteLine("\nGirdiğiniz kahveler\n-------------------\n");
        foreach (string kahve in kahveListesi)
        {

            Console.WriteLine(kahve);
        }
    }

}

