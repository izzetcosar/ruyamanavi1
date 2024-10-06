Console.WriteLine("Rüya Manavına Hoş Geldiniz!");
Console.WriteLine("Elma = 2 TL");
Console.WriteLine("Armut = 3 TL");
Console.WriteLine("Çilek = 2 TL");
Console.WriteLine("Muz = 3 TL");
Console.WriteLine("Diğer = 4TL");

Console.Write("Hangi meyveyi satin almak istersiniz! (Elma/Armut/Çilek/Muz/Diğer):");

string giris = Console.ReadLine().ToLower();//burada tolower metodunu kullanarak girisde yazılan girdinin büyük yazılsa bile küçük harfe çevirilmesini sagladık.

//if else yöntemiyle yaptığımız kısım
#region ifelse


if (giris == "elma") 

{
    Console.WriteLine("2TL");
}

else if (giris == "armut")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı 3TL");
}

else if (giris == "çilek")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı 2TL");
}

else if (giris == "muz")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı 3TL");
}

else if (giris == "diğer")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı 4TL");
}

else
{

    Console.WriteLine("Yanlıs Meyve Girdiniz");
}
#endregion
//switch ile yaptığımız kısım
#region switch

switch (giris)

{
    case "elma":
        Console.WriteLine("2TL");
        break;
    case "armut":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı 3TL");
        break;
    case "çilek":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı 2TL");
        break;
    case "muz":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı 3TL");
        break;
    case "diğer":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı 4TL");
        break;
    default:
        Console.WriteLine("Yanlıs Meyve Girdiniz");
        break;
}


        #endregion
   
Console.ReadKey();
        