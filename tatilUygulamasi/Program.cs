using System;

namespace TatilPlanUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuePlanning = true; //burada tekrar planlama yapmak isterse devreye girecek bir değişken tanımlıyoruz.

            while (continuePlanning) //bu döngü kullanıcı başka tatil planı yapmak istediği sürece çalışacak.
            {
                Console.WriteLine("Tatil Planlayıcısına hoş geldiniz!");
                Console.Write("Lütfen seyahat etmek istediğiniz lokasyonu seçiniz. (Bodrum / Marmaris / Çeşme): ");
                string destination = Console.ReadLine().Trim().ToLower();
                
                int basePrice = 0;

                //lokasyon seçimi
                while (destination != "bodrum" && destination != "marmaris" && destination != "çeşme" && destination != "cesme")
                {
                    Console.WriteLine("Yanlış bir lokasyon girdiniz. Lütfen Marmaris, Çeşme ya da Bodrum lokasyonlarından birini giriniz.");
                    Console.Write("Tekrar seçim yapınız: ");
                    destination = Console.ReadLine().Trim().ToLower();
                }

                if (destination == "bodrum")
                {
                    basePrice = 4000;
                    Console.WriteLine("Bdorum'un şahane plajları ve gece hayatı sizi bekliyor.");
                }
                else if (destination == "marmaris")
                {
                    basePrice = 3000;
                    Console.WriteLine("Marmaris'te doğa, deniz ve kamp alanları sizi bekliyor.");
                }
                else if (destination == "çeşme" || destination == "cesme")
                {
                    basePrice = 5000;
                    Console.WriteLine("Lüks plajlar, eğlenceli gece hayatı ve tarihi mekanlar sizi bekliyor.");
                }

                //Kişi sayısı seçeceğiz.
                Console.Write("Kaç kişi için tatil planlamak istiyorsunuz?: ");
                int numberOfPeople = int.Parse(Console.ReadLine());

                Console.WriteLine("Lütfen ulaşım tercihinizi seçin;");
                Console.WriteLine("1- Kara yolu (Gidiş-dönüş kişi başı 1500 TL)");
                Console.WriteLine("2- Hava yolu (Gidiş-dönüş kişi başı 4000 TL)");
                Console.WriteLine("1 ya da 2 yazarak seçiminizi tamamlayabilirsiniz.");
                string transportChoice = Console.ReadLine();

                //ulaşım aracı kontrolü

                while (transportChoice != "1" && transportChoice != "2")
                {
                    Console.WriteLine("Hatalı seçim. Lütfen sadece 1 ya da 2 yazınız: ");
                    transportChoice = Console.ReadLine();
                }

                int transportCost = 0;

                if (transportChoice == "1")
                {
                    transportCost = 1500;
                }
                else if (transportChoice == "2")
                {
                    transportCost = 4000;
                }

                int totalPrice = (basePrice * numberOfPeople) + (transportCost * numberOfPeople);
                Console.WriteLine($"\n{numberOfPeople} kişilik {destination.ToUpper()} seyahatinizin özeti: ");
                Console.WriteLine($"Tatil paketinizin toplam  tutarı: {basePrice * numberOfPeople} TL.");
                Console.WriteLine($"Ulaşım paketi toplam tutarı: {transportCost * numberOfPeople} TL.");
                Console.WriteLine($"Toplam Tutar: {totalPrice} TL.");
                
                Console.WriteLine("\nYeni bir tatil planlamak ister misiniz? (Evet ya da Hayır): ");
                string userAnswer = Console.ReadLine().Trim().ToLower();

                if (userAnswer == "hayır")
                {
                    continuePlanning = false;
                    Console.WriteLine("Teşekkür ederiz. İyi günler dileriz.");
                }
            }
        }
    }
}