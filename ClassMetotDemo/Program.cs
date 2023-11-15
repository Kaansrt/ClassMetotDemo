namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Müşteri Takip Sistemi ****");
            Musteri musteri1 = new Musteri();

            musteri1.Id = 1;
            musteri1.FirstName = "Murat Kaan";
            musteri1.Yas = 22;
            musteri1.LastName = "Sert";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.FirstName = "Emirhan";
            musteri2.Yas = 23;
            musteri2.LastName = "Bayir";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.FirstName = "Batuhan";
            musteri3.Yas = 22;
            musteri3.LastName ="Akçay";

            Musteri[] musteriler = new Musteri[] { musteri1,musteri2,musteri3};
            foreach (Musteri msteri in musteriler)
            {
                Console.WriteLine(msteri.FirstName +" "+ msteri.LastName);
            }
            Console.WriteLine();
            foreach (var msteri in musteriler)
            {
                Console.WriteLine(msteri.Yas);
            }
            Console.WriteLine();
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri3);
            musteriManager.Delete(musteri1);
            musteriManager.Update(musteri2);

            Console.ReadKey();
        }
    }
}