int month=DateTime.Now.Month;

switch(month)
{
    case 1:
        Console.WriteLine("Ocak");
        break;
    case 2:
        Console.WriteLine("Şubat");
        break;
    case 3:
        Console.WriteLine("Mart");
        break;
    case 4:
        Console.WriteLine("Nisan");
        break;
    case 5:
        Console.WriteLine("Mayıs");
        break;
    case 6:
        Console.WriteLine("Haziran");
        break;
    case 10:
        Console.WriteLine("Ekim");
        break;
    default:
        Console.WriteLine("Yanlış giriş yaptınız.");
        break;
}
switch(month)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Kış mevsimindesiniz.");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("İlkbahar mevsimindesiniz.");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Yaz mevsimindesiniz.");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Sonbahar mevsimindesiniz.");
        break;
    default:
    break;
        
}