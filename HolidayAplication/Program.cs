
string answer2 = "evet";


while (answer2.ToLower() == "evet")
{

    Console.WriteLine("Bodrum (Paket başlangıç fiyatı 4000 TL)");
    Console.WriteLine("Marmaris (Paket başlangıç fiyatı 3000 TL)");
    Console.WriteLine("Cesme (Paket başlangıç fiyatı 5000 TL)");

    Console.WriteLine("");

    Console.Write("Lütfen gitmek istediğiniz tatil yerini giriniz: ");

    string HolidayLocation = Console.ReadLine();

    string lHolidayLocation = HolidayLocation.ToLower();

    Console.WriteLine("");

    switch (lHolidayLocation)
    {
        case "bodrum":
            Console.WriteLine("Bodrum'a hoş geldiniz!");
            break;
        case "marmaris":
            Console.WriteLine("Marmaris'e hoş geldiniz!");
            break;
        case "cesme":
            Console.WriteLine("Çeşme'ye hoş geldiniz!");
            break;
        default:
            Console.WriteLine("Sadece Bodrum, Marmaris ve Çeşmeden birini giriniz.");
            break;
    }

    Console.WriteLine("");

    Console.Write("Kaç kişi için tatil planı yapmak istiyorsunuz: ");

    int numberOfPeople = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("");

    switch (lHolidayLocation)
    {
        case "bodrum":
            Console.WriteLine("Bodrum, Ege'nin incisi olarak hem doğal güzellikleri hem de sosyal yaşamıyla tatilcilere çok sayıda seçenek sunar. İşte Bodrum'da tatilde yapılabilecek en keyifli aktiviteler:");
            Console.WriteLine("Bodrum'un en ünlü plajlarında güneşlenip denize girebilirsin:");
            Console.WriteLine("Bodrum Kalesi ve Sualtı Arkeoloji Müzesi");
            Console.WriteLine("");
            break;
        case "marmaris":
            Console.WriteLine("Marmaris, doğal güzellikleri ve hareketli gece hayatıyla ünlü bir tatil beldesidir. İşte Marmaris'te tatilde yapılabilecek en keyifli aktiviteler:");
            Console.WriteLine("Marmaris Plajları");
            Console.WriteLine("Marmaris Kalesi ve Müzesi");
            Console.WriteLine("");
            break;
        case "cesme":
            Console.WriteLine("Çeşme, güzel plajları ve tarihi dokusuyla ünlü bir tatil beldesidir. İşte Çeşme'de tatilde yapılabilecek en keyifli aktiviteler:");
            Console.WriteLine("Çeşme Plajları");
            Console.WriteLine("Çeşme Kalesi ve Müzesi");
            Console.WriteLine("");
            break;
        default:
            Console.WriteLine("Sadece Bodrum, Marmaris ve Çeşmeden birini giriniz.");
            break;
    }

    Console.WriteLine("1- Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL ) ");
    Console.WriteLine("2- Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");

    Console.WriteLine("");

    Console.Write("Ne şekilde tatile gitmek istersiniz: ");


    int travelType = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("");

    while (travelType != 1 && travelType != 2)
    {
        Console.WriteLine("Lütfen geçerli bir ulaşım türü seçiniz.");
        travelType = Convert.ToInt32(Console.ReadLine());
    }

    int holidayLocationCost = 0;

    switch (lHolidayLocation)
    {
        case "bodrum":
            holidayLocationCost = 4000;
            break;
        case "marmaris":
            holidayLocationCost = 3000;
            break;
        case "cesme":
            holidayLocationCost = 5000;
            break;
    }

    int travelTypeCost = 0;

    switch (travelType)
    {
            case 1:
                travelTypeCost = 1500;
                break;
            case 2:
                travelTypeCost = 4000;
                 break;
    }

    int totalCost = (holidayLocationCost + travelTypeCost) * numberOfPeople;

    Console.WriteLine("Ödemeniz gereken tutar: " + totalCost);

    Console.WriteLine("Başka bir tatil planı yapmak istiyor musunuz?");

    string answer = Console.ReadLine();

    answer2 = answer;


    
}

Console.WriteLine("İyi günler.");
