using System;

namespace homework1.calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            do
            {
                try
                {  // n pozitif sayısını atamayı unutma!atandı
                   // mevsimleri ekleyeceğini unutma!eklendi
                    int day1, day2, year1, year2;
                    string month1, month2, result;
                    int x = 1;
                    do
                    {
                        x = 1;
                        Console.Write("D1=");
                        day1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("M1=");
                        month1 = Console.ReadLine();
                        // month1 için küçük harf büyük harf sorunu çözüldü:)
                        result = month1.ToLower();
                        month1 = result;

                        Console.Write("Y1=");
                        year1 = Convert.ToInt32(Console.ReadLine());
                        while (year1 < 2015)//tarih 01.01.2015'ten başlamalı
                        {
                            Console.WriteLine("Year is wrong");
                            Console.Write("Y1=");
                            year1 = Convert.ToInt32(Console.ReadLine());
                        }

                        //day1 ve month1  değerlerinin doğru girilmesi için verilmesi gereken error kısmı
                        if (month1 == "january" || month1 == "march" || month1 == "may" || month1 == "july" || month1 == "august" || month1 == "october" || month1 == "december")
                        {
                            while (day1 < 0 || day1 > 31)
                            {
                                Console.WriteLine("day is wrong");
                                Console.Write("D1 =");
                                day1 = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                        else if (month1 == "april" || month1 == "june" || month1 == "september" || month1 == "november")
                        {
                            while (day1 < 0 || day1 > 30)
                            {
                                Console.WriteLine("day is wrong");
                                Console.Write("D1 =");
                                day1 = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                        else if (month1 == "february")
                        {
                            if (day1 > 0 && day1 <= 28)
                                Console.WriteLine("D1=" + day1);
                            else if (year1 % 4 == 0 && day1 > 0 && day1 <= 29 && year1 % 100 != 0 && year1 % 400 == 0)
                                Console.WriteLine("D1=" + day1);
                            else


                                do
                                {
                                    Console.WriteLine("day is wrong");
                                    Console.Write("D1 =");
                                    day1 = Convert.ToInt32(Console.ReadLine());
                                } while (day1 < 0 || day1 > 29 || (year1 % 4 != 0 && day1 == 29) || (day1 == 29 && year1 % 100 == 0) || (day1 == 29 && year1 % 400 != 0));
                        }
                        else
                        {
                            Console.WriteLine("month is wrong so please try to re-enter the day and month as well");

                            x = 2;// girilen ay yani month1 yanlışsa döngünün çalışması için

                        }
                    } while (x == 2);








                    int xx = 1;//döngü  için
                    do
                    {
                        xx = 1;
                        //ikinci tarihleri belirler!!!!!!!!!!!!!!!!!!!!
                        Console.Write("D2=");
                        day2 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("M2=");
                        month2 = Console.ReadLine();
                        // month2 için küçük harf büyük harf sorunu çözüldü:)
                        String result2 = month2.ToLower();
                        month2 = result2;

                        Console.Write("Y2=");
                        year2 = Convert.ToInt32(Console.ReadLine());
                        while (year2 < 2015)//yıl için error verdirme
                        {
                            Console.WriteLine("Year is wrong");
                            Console.Write("Y2=");
                            year2 = Convert.ToInt32(Console.ReadLine());
                        }



                        //day2 ve month2 için değerlerin doğru girilmesi için verilmesi gereken error kısmı
                        if (month2 == "january" || month2 == "march" || month2 == "may" || month2 == "july" || month2 == "august" || month2 == "october" || month2 == "december")
                        {
                            while (day2 < 0 || day2 > 31)
                            {
                                Console.WriteLine("day is wrong");
                                Console.Write("D2 =");
                                day2 = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                        else if (month2 == "april" || month2 == "june" || month2 == "september" || month2 == "november")
                        {
                            while (day2 < 0 || day2 > 30)
                            {
                                Console.WriteLine("day is wrong");
                                Console.Write("D2 =");
                                day2 = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                        else if (month2 == "february")
                        {
                            if (day2 > 0 && day2 <= 28)
                                Console.WriteLine("D2=" + day2);
                            else if (year2 % 4 == 0 && day2 > 0 && day2 <= 29 && year2 % 100 != 0 && year2 % 400 == 0)
                                Console.WriteLine("D2=" + day2);
                            else
                                do
                                {
                                    Console.WriteLine("day is wrong");
                                    Console.Write("D2=");
                                    day2 = Convert.ToInt32(Console.ReadLine());
                                } while (day2 < 0 || day2 > 29 || (year2 % 4 != 0 && day2 == 29) || (day2 == 29 && year2 % 100 == 0) || (day2 == 29 && year2 % 400 != 0));
                        }
                        else
                        {
                            Console.WriteLine("month is wrong so please try to re-enter the day and month as well");
                            xx = 2;
                        }
                    } while (xx == 2);






                    if (year1 > year2)//eğer ilk girilen yıl ikinciden büyükse atana değerleri gün ay yıl olarak karşılıklı değiştirmek için
                    {
                        int temp1, temp3;
                        string temp2;
                        temp1 = year1;
                        year1 = year2;
                        year2 = temp1;

                        temp2 = month1;
                        month1 = month2;
                        month2 = temp2;

                        temp3 = day1;
                        day1 = day2;
                        day2 = temp3;
                    }

                    if (year1 == year2)//aynı yılın içinde iki gün verilirse ay sıralamasındaki problem için
                    {
                        if ((month1 == "february") && (month2 == "january"))
                        {
                            string temp;
                            temp = month2;
                            month2 = month1;
                            month1 = temp;

                            int temp2;
                            temp2 = day2;
                            day2 = day1;
                            day1 = temp2;
                        }
                        else if ((month1 == "march") && ((month2 == "january") || (month2 == "february")))
                        {
                            string temp;
                            temp = month2;
                            month2 = month1;
                            month1 = temp;

                            int temp2;
                            temp2 = day2;
                            day2 = day1;
                            day1 = temp2;
                        }
                        else if ((month1 == "april") && (month2 == "january" || (month2 == "february") || (month2 == "march")))
                        {
                            string temp;
                            temp = month2;
                            month2 = month1;
                            month1 = temp;

                            int temp2;
                            temp2 = day2;
                            day2 = day1;
                            day1 = temp2;
                        }
                        else if ((month1 == "may") && (month2 == "january" || (month2 == "february") || (month2 == "march") || (month2 == "april")))
                        {
                            string temp;
                            temp = month2;
                            month2 = month1;
                            month1 = temp;

                            int temp2;
                            temp2 = day2;
                            day2 = day1;
                            day1 = temp2;
                        }
                        else if ((month1 == "june") && (month2 == "january" || (month2 == "february") || (month2 == "march") || (month2 == "april") || (month2 == "may")))
                        {
                            string temp;
                            temp = month2;
                            month2 = month1;
                            month1 = temp;

                            int temp2;
                            temp2 = day2;
                            day2 = day1;
                            day1 = temp2;
                        }
                        else if ((month1 == "july") && (month2 == "january" || (month2 == "february") || (month2 == "march") || (month2 == "april") || (month2 == "may") || (month2 == "june")))
                        {
                            string temp;
                            temp = month2;
                            month2 = month1;
                            month1 = temp;

                            int temp2;
                            temp2 = day2;
                            day2 = day1;
                            day1 = temp2;
                        }
                        else if ((month1 == "august") && (month2 == "january" || (month2 == "february") || (month2 == "march") || (month2 == "april") || (month2 == "may") || (month2 == "june") || (month2 == "july")))
                        {
                            string temp;
                            temp = month2;
                            month2 = month1;
                            month1 = temp;

                            int temp2;
                            temp2 = day2;
                            day2 = day1;
                            day1 = temp2;
                        }
                        else if ((month1 == "september") && (month2 == "january" || (month2 == "february") || (month2 == "march") || (month2 == "april") || (month2 == "may") || (month2 == "june") || (month2 == "july") || (month2 == "august")))
                        {
                            string temp;
                            temp = month2;
                            month2 = month1;
                            month1 = temp;

                            int temp2;
                            temp2 = day2;
                            day2 = day1;
                            day1 = temp2;
                        }
                        else if ((month1 == "october") && (month2 == "january" || (month2 == "february") || (month2 == "march") || (month2 == "april") || (month2 == "may") || (month2 == "june") || (month2 == "july") || (month2 == "august") || (month2 == "september")))
                        {
                            string temp;
                            temp = month2;
                            month2 = month1;
                            month1 = temp;

                            int temp2;
                            temp2 = day2;
                            day2 = day1;
                            day1 = temp2;
                        }
                        else if ((month1 == "november") && (month2 == "january" || (month2 == "february") || (month2 == "march") || (month2 == "april") || (month2 == "may") || (month2 == "june") || (month2 == "july") || (month2 == "august") || (month2 == "september") || (month2 == "october")))
                        {
                            string temp;
                            temp = month2;
                            month2 = month1;
                            month1 = temp;

                            int temp2;
                            temp2 = day2;
                            day2 = day1;
                            day1 = temp2;
                        }
                        else if ((month1 == "december") && (month2 == "january" || (month2 == "february") || (month2 == "march") || (month2 == "april") || (month2 == "may") || (month2 == "june") || (month2 == "july") || (month2 == "august") || (month2 == "september") || (month2 == "october") || (month2 == "november")))
                        {
                            string temp;
                            temp = month2;
                            month2 = month1;
                            month1 = temp;

                            int temp2;
                            temp2 = day2;
                            day2 = day1;
                            day1 = temp2;

                        }
                        if ((year1 == year2) && (month1 == month2) && (day1 > day2))//aynı yılda aynı ayın içinde iki gün verilirse gün sıralamasındaki problem için
                        {
                            int temp2;
                            temp2 = day2;
                            day2 = day1;
                            day1 = temp2;
                        }

                    }




                    Console.Write("n=");
                    int N = Convert.ToInt32(Console.ReadLine());//n değeri için error kısmı
                    while (N <= 0)
                    {
                        Console.WriteLine("the value you entered incorrect. Please try again.");
                        Console.WriteLine("n=");
                        N = Convert.ToInt32(Console.ReadLine());
                    }
                    //bu kısım kullanıcının girdiği kronolojik olarak daha önce olan tarihteki ay ile başlar,
                    // şubatın 28-29 olma durumundan dolayı(artık yıl) ikiye ayrılır,
                    //kendisinden önce gelen ay ile biter.
                    // year2 değişkeni year1 den büyükse aralık ayından sonra yıl 1 artırılır ve yıllara bağllı olarak döngü çalışır

                    switch (month1)
                    {   //girilen ilk tarih ocaksa
                        case "january":
                            Console.WriteLine("\nWinter");
                            while (year1 <= year2)
                            {
                                int monthjan = 1;

                                for (int i = day1; i <= 31; i = i + N)
                                {

                                    if ((year1 == year2) && (month1 == month2) && (i >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(i + "  january  " + year1 + " ");
                                        zeller(i, monthjan, year1);

                                    }
                                }
                                if ((year1 == year2) && (month2 == "janurary"))
                                    break; int kalan = (31 - day1) % N;//bu kısımlar bir sonraki ayın başlayacağı günü belirlemeye yardımcı olacak!!! for kısmında kullanılır

                                //tüm şubat kısımları için artık yıl durumunu göz önünde bulundur!!!!!

                                if ((year1 % 4 == 0) && (year1 % 100 != 0))
                                {
                                    for (int j = N - kalan; j <= 29; j = j + N)
                                    {
                                        int monthf = 2;
                                        if ((year1 == year2) && (month2 == "february") && (j >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(j + "  february  " + year1 + " ");
                                            zeller(j, monthf, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "february"))

                                        break; int kalan3 = (29 - (N - (31 - day1) % N)) % N;//sonraki ayın başlayacağı günü bulmak için yardımcı olur for kısmında kullanılır!!!!!
                                    //MARCH
                                    Console.WriteLine("\nSpring");
                                    for (int k = N - kalan3; k <= 31; k = k + N)
                                    {
                                        int monthmarc = 3;
                                        if ((year1 == year2) && (month2 == "march") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  march  " + year1 + " ");
                                            zeller(k, monthmarc, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "march"))
                                        break; int kalan4 = (31 - (N - (29 - (N - (31 - day1) % N)) % N)) % N;
                                    //APRİL
                                    for (int k = N - kalan4; k <= 30; k = k + N)
                                    {
                                        int monthapr = 4;
                                        if ((year1 == year2) && (month2 == "april") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  april  " + year1 + " ");
                                            zeller(k, monthapr, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "april"))
                                        break; int kalan5 = (30 - (N - (31 - (N - (29 - (N - (31 - day1) % N)) % N)) % N)) % N;
                                    //MAY
                                    for (int k = N - kalan5; k <= 31; k = k + N)

                                    {
                                        int monthmayx = 5;
                                        if ((year1 == year2) && (month2 == "may") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  may  " + year1 + " ");
                                            zeller(k, monthmayx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "may"))
                                        break; int kalan6 = (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N;
                                    //JUNE
                                    Console.WriteLine("\nSummer");
                                    for (int k = N - kalan6; k <= 30; k = k + N)

                                    {
                                        int monthjunex = 6;
                                        if ((year1 == year2) && (month2 == "june") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  june  " + year1 + " ");
                                            zeller(k, monthjunex, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "june"))
                                        break; int kalan7 = (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N;
                                    //JULY
                                    for (int k = N - kalan7; k <= 31; k = k + N)

                                    {
                                        int monthjulyx = 7;
                                        if ((year1 == year2) && (month2 == "july") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  july  " + year1 + " ");
                                            zeller(k, monthjulyx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "july"))
                                        break; int kalan8 = (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //AUGUST
                                    for (int k = N - kalan8; k <= 31; k = k + N)

                                    {
                                        int monthaux = 8;
                                        if ((year1 == year2) && (month2 == "august") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  august  " + year1 + " ");
                                            zeller(k, monthaux, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "august"))
                                        break; int kalan9 = (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //SEPTEMBER
                                    Console.WriteLine("\nAutumn");
                                    for (int k = N - kalan9; k <= 30; k = k + N)

                                    {
                                        int monthsepx = 9;
                                        if ((year1 == year2) && (month2 == "september") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  september  " + year1 + " ");
                                            zeller(k, monthsepx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "september"))
                                        break; int kalan10 = (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //OCTOBER
                                    for (int k = N - kalan10; k <= 31; k = k + N)

                                    {
                                        int monthoctx = 10;
                                        if ((year1 == year2) && (month2 == "october") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  october  " + year1 + " ");
                                            zeller(k, monthoctx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "october"))
                                        break; int kalan11 = (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //NOVEMBER
                                    for (int k = N - kalan11; k <= 30; k = k + N)

                                    {
                                        int monthnovx = 11;
                                        if ((year1 == year2) && (month2 == "november") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  november  " + year1 + " ");
                                            zeller(k, monthnovx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "november"))
                                        break; int kalan12 = (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //DECEMBER
                                    Console.WriteLine("\nWinter");
                                    for (int k = N - kalan12; k <= 31; k = k + N)

                                    {
                                        int monthdecx = 12;
                                        if ((year1 == year2) && (month2 == "december") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  december  " + year1 + " ");
                                            zeller(k, monthdecx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "december"))
                                        break; int kalan13x = (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;

                                    day1 = N - kalan13x;


                                }


                                else
                                {//şubatın özel durumundan iki farklı işleyiş
                                    for (int j = N - kalan; j <= 28; j = j + N)
                                    {
                                        int monthf = 2;
                                        if ((year1 == year2) && (month2 == "february") && (j >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(j + "  february  " + year1 + " ");
                                            zeller(j, monthf, year1);
                                            // yalnızca döngüde ikinci tarihte nasıl duracağını hatırlatmak için yazıldı!!SİLİNECEK
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "february"))
                                        break;

                                    int kalan3 = (28 - (N - (31 - day1) % N)) % N;


                                    //MARCH
                                    Console.WriteLine("\nSpring");
                                    for (int k = N - kalan3; k <= 31; k = k + N)
                                    {
                                        int monthmarc = 3;
                                        if ((year1 == year2) && (month2 == "march") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {
                                            Console.Write(k + "  march  " + year1 + " ");
                                            zeller(k, monthmarc, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "march"))
                                        break; int kalan4 = (31 - (N - (28 - (N - (31 - day1) % N)) % N)) % N;
                                    //APRİL
                                    for (int k = N - kalan4; k <= 30; k = k + N)
                                    {
                                        int monthapr = 4;
                                        if ((year1 == year2) && (month2 == "april") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  april  " + year1 + " ");
                                            zeller(k, monthapr, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "april"))
                                        break; int kalan5 = (30 - (N - (31 - (N - (28 - (N - (31 - day1) % N)) % N)) % N)) % N;
                                    //MAY
                                    for (int k = N - kalan5; k <= 31; k = k + N)

                                    {
                                        int monthmayx = 5;
                                        if ((year1 == year2) && (month2 == "may") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  may  " + year1 + " ");
                                            zeller(k, monthmayx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "may"))
                                        break; int kalan6 = (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N;
                                    //JUNE
                                    Console.WriteLine("\nSummer");
                                    for (int k = N - kalan6; k <= 30; k = k + N)

                                    {
                                        int monthjunex = 7;
                                        if ((year1 == year2) && (month2 == "june") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  june  " + year1 + " ");
                                            zeller(k, monthjunex, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "june"))
                                        break; int kalan7 = (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N;
                                    //JULY
                                    for (int k = N - kalan7; k <= 31; k = k + N)

                                    {
                                        int monthjulyx = 7;
                                        if ((year1 == year2) && (month2 == "july") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  july  " + year1 + " ");
                                            zeller(k, monthjulyx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "july"))
                                        break; int kalan8 = (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //AUGUST
                                    for (int k = N - kalan8; k <= 31; k = k + N)

                                    {
                                        int monthaux = 8;
                                        if ((year1 == year2) && (month2 == "august") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  august  " + year1 + " ");
                                            zeller(k, monthaux, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "august"))
                                        break; int kalan9 = (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //SEPTEMBER
                                    Console.WriteLine("\nAutumn");
                                    for (int k = N - kalan9; k <= 30; k = k + N)

                                    {
                                        int monthsepx = 9;
                                        if ((year1 == year2) && (month2 == "september") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  september  " + year1 + " ");
                                            zeller(k, monthsepx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "september"))
                                        break; int kalan10 = (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //OCTOBER
                                    for (int k = N - kalan10; k <= 31; k = k + N)

                                    {
                                        int monthoctx = 10;
                                        if ((year1 == year2) && (month2 == "october") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  october  " + year1 + " ");
                                            zeller(k, monthoctx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "october"))
                                        break; int kalan11 = (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //NOVEMBER
                                    for (int k = N - kalan11; k <= 30; k = k + N)

                                    {
                                        int monthnovx = 11;
                                        if ((year1 == year2) && (month2 == "november") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  november  " + year1 + " ");
                                            zeller(k, monthnovx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "november"))
                                        break; int kalan12 = (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //DECEMBER
                                    Console.WriteLine("\nWinter");
                                    for (int k = N - kalan12; k <= 31; k = k + N)

                                    {
                                        int monthdecx = 12;
                                        if ((year1 == year2) && (month2 == "december") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  december  " + year1 + " ");
                                            zeller(k, monthdecx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "december"))
                                        break; int kalan13 = (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;

                                    day1 = N - kalan13;


                                }

                                year1++;
                            }
                            break;


                        case "february"://CASELERİ HATIRLAMAK BULMAK İÇİN11111111111111111111111111111111111
                            while (year1 <= year2)
                            {
                                if ((year1 % 4 == 0) && (year1 % 100 != 0))
                                {
                                    for (int j = day1; j <= 29; j = j + N)
                                    {
                                        int monthf = 2;
                                        if ((year1 == year2) && (month2 == "february") && (j >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(j + "  february  " + year1 + " ");
                                            zeller(j, monthf, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "february"))

                                        break; int kalan3 = (29 - day1) % N;
                                    //MARCH
                                    Console.WriteLine("\nSpring");
                                    for (int k = N - kalan3; k <= 31; k = k + N)
                                    {
                                        int monthmarc = 3;
                                        if ((year1 == year2) && (month2 == "march") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  march  " + year1 + " ");
                                            zeller(k, monthmarc, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "march"))
                                        break; int kalan4 = (31 - (N - (29 - day1) % N)) % N;
                                    //APRİL
                                    for (int k = N - kalan4; k <= 30; k = k + N)
                                    {
                                        int monthapr = 4;
                                        if ((year1 == year2) && (month2 == "april") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  april  " + year1 + " ");
                                            zeller(k, monthapr, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "april"))
                                        break; int kalan5 = (30 - (N - (31 - (N - (29 - day1) % N)) % N)) % N;
                                    //MAY
                                    for (int k = N - kalan5; k <= 31; k = k + N)

                                    {
                                        int monthmayx = 5;
                                        if ((year1 == year2) && (month2 == "may") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  may  " + year1 + " ");
                                            zeller(k, monthmayx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "may"))
                                        break; int kalan6 = (31 - (N - (30 - (N - (31 - (N - (29 - day1) % N)) % N)) % N)) % N;
                                    //JUNE
                                    Console.WriteLine("\nSummer");
                                    for (int k = N - kalan6; k <= 30; k = k + N)

                                    {
                                        int monthjunex = 6;
                                        if ((year1 == year2) && (month2 == "june") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  june  " + year1 + " ");
                                            zeller(k, monthjunex, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "june"))
                                        break; int kalan7 = (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - day1) % N)) % N)) % N)) % N)) % N;
                                    //JULY
                                    for (int k = N - kalan7; k <= 31; k = k + N)

                                    {
                                        int monthjulyx = 7;
                                        if ((year1 == year2) && (month2 == "july") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  july  " + year1 + " ");
                                            zeller(k, monthjulyx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "july"))
                                        break; int kalan8 = (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - day1) % N)) % N)) % N)) % N)) % N)) % N;
                                    //AUGUST
                                    for (int k = N - kalan8; k <= 31; k = k + N)

                                    {
                                        int monthaux = 8;
                                        if ((year1 == year2) && (month2 == "august") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  august  " + year1 + " ");
                                            zeller(k, monthaux, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "august"))
                                        break; int kalan9 = (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //SEPTEMBER
                                    Console.WriteLine("\nAutumn");
                                    for (int k = N - kalan9; k <= 30; k = k + N)

                                    {
                                        int monthsepx = 9;
                                        if ((year1 == year2) && (month2 == "september") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  september  " + year1 + " ");
                                            zeller(k, monthsepx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "september"))
                                        break; int kalan10 = (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //OCTOBER
                                    for (int k = N - kalan10; k <= 31; k = k + N)

                                    {
                                        int monthoctx = 10;
                                        if ((year1 == year2) && (month2 == "october") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  october  " + year1 + " ");
                                            zeller(k, monthoctx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "october"))
                                        break; int kalan11 = (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //NOVEMBER
                                    for (int k = N - kalan11; k <= 30; k = k + N)

                                    {
                                        int monthnovx = 11;
                                        if ((year1 == year2) && (month2 == "november") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  november  " + year1 + " ");
                                            zeller(k, monthnovx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "november"))
                                        break; int kalan12 = (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //DECEMBER
                                    Console.WriteLine("\nWinter");
                                    for (int k = N - kalan12; k <= 31; k = k + N)

                                    {
                                        int monthdecx = 12;
                                        if ((year1 == year2) && (month2 == "december") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  december  " + year1 + " ");
                                            zeller(k, monthdecx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "december"))
                                        break; int kalan13x = (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    int monthjan = 1;
                                    year1++;

                                    for (int i = N - kalan13x; i <= 31; i = i + N)
                                    {

                                        if ((year1 == year2) && (month1 == month2) && (i >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(i + "  january  " + year1 + " ");
                                            zeller(i, monthjan, year1);
                                        }

                                        if ((year1 == year2) && (month2 == "janurary"))
                                            break; int kalan = (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;

                                        day1 = N - kalan;


                                    }

                                }

                                else
                                {//şubatın özel durumundan iki farklı işleyiş
                                    for (int j = day1; j <= 28; j = j + N)
                                    {
                                        int monthf = 2;
                                        if ((year1 == year2) && (month2 == "february") && (j >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(j + "  february  " + year1 + " ");
                                            zeller(j, monthf, year1);
                                            // yalnızca döngüde ikinci tarihte nasıl duracağını hatırlatmak için yazıldı!!SİLİNECEK
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "february"))
                                        break;

                                    int kalan3 = (28 - day1) % N;


                                    //MARCH
                                    Console.WriteLine("\nSpring");
                                    for (int k = N - kalan3; k <= 31; k = k + N)
                                    {
                                        int monthmarc = 3;
                                        if ((year1 == year2) && (month2 == "march") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {
                                            Console.Write(k + "  march  " + year1 + " ");
                                            zeller(k, monthmarc, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "march"))
                                        break; int kalan4 = (31 - (N - (28 - day1) % N)) % N;
                                    //APRİL
                                    for (int k = N - kalan4; k <= 30; k = k + N)
                                    {
                                        int monthapr = 4;
                                        if ((year1 == year2) && (month2 == "april") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  april  " + year1 + " ");
                                            zeller(k, monthapr, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "april"))
                                        break; int kalan5 = (30 - (N - (31 - (N - (28 - day1) % N)) % N)) % N;
                                    //MAY
                                    for (int k = N - kalan5; k <= 31; k = k + N)

                                    {
                                        int monthmayx = 5;
                                        if ((year1 == year2) && (month2 == "may") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  may  " + year1 + " ");
                                            zeller(k, monthmayx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "may"))
                                        break; int kalan6 = (31 - (N - (30 - (N - (31 - (N - (28 - day1) % N)) % N)) % N)) % N;
                                    //JUNE
                                    Console.WriteLine("\nSummer");
                                    for (int k = N - kalan6; k <= 30; k = k + N)

                                    {
                                        int monthjunex = 7;
                                        if ((year1 == year2) && (month2 == "june") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  june  " + year1 + " ");
                                            zeller(k, monthjunex, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "june"))
                                        break; int kalan7 = (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - day1) % N)) % N)) % N)) % N)) % N;
                                    //JULY
                                    for (int k = N - kalan7; k <= 31; k = k + N)

                                    {
                                        int monthjulyx = 7;
                                        if ((year1 == year2) && (month2 == "july") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  july  " + year1 + " ");
                                            zeller(k, monthjulyx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "july"))
                                        break; int kalan8 = (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - day1) % N)) % N)) % N)) % N)) % N)) % N;
                                    //AUGUST
                                    for (int k = N - kalan8; k <= 31; k = k + N)

                                    {
                                        int monthaux = 8;
                                        if ((year1 == year2) && (month2 == "august") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  august  " + year1 + " ");
                                            zeller(k, monthaux, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "august"))
                                        break; int kalan9 = (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //SEPTEMBER
                                    Console.WriteLine("\nAutumn");
                                    for (int k = N - kalan9; k <= 30; k = k + N)

                                    {
                                        int monthsepx = 9;
                                        if ((year1 == year2) && (month2 == "september") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  september  " + year1 + " ");
                                            zeller(k, monthsepx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "september"))
                                        break; int kalan10 = (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //OCTOBER
                                    for (int k = N - kalan10; k <= 31; k = k + N)

                                    {
                                        int monthoctx = 10;
                                        if ((year1 == year2) && (month2 == "october") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  october  " + year1 + " ");
                                            zeller(k, monthoctx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "october"))
                                        break; int kalan11 = (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //NOVEMBER
                                    for (int k = N - kalan11; k <= 30; k = k + N)

                                    {
                                        int monthnovx = 11;
                                        if ((year1 == year2) && (month2 == "november") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  november  " + year1 + " ");
                                            zeller(k, monthnovx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "november"))
                                        break; int kalan12 = (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //DECEMBER
                                    Console.WriteLine("\nWinter");
                                    for (int k = N - kalan12; k <= 31; k = k + N)

                                    {
                                        int monthdecx = 12;
                                        if ((year1 == year2) && (month2 == "december") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  december  " + year1 + " ");
                                            zeller(k, monthdecx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "december"))
                                        break; int kalan13 = (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;

                                    int monthjan = 1;
                                    year1++;

                                    for (int i = N - kalan13; i <= 31; i = i + N)
                                    {

                                        if ((year1 == year2) && (month1 == month2) && (i >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(i + "  january  " + year1 + " ");
                                            zeller(i, monthjan, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "janurary"))
                                        break; int kalan = (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;

                                    day1 = N - kalan;


                                }


                            }
                            break;

                        case "march"://CASELERİ HATIRLAMAK BULMAK İÇİN11111111111111111111111111111111111
                            Console.WriteLine("\nSpring");
                            while (year1 <= year2)
                            {    //MARCH
                                Console.WriteLine("\nSpring");
                                for (int k = day1; k <= 31; k = k + N)
                                {
                                    int monthmarc = 3;
                                    if ((year1 == year2) && (month2 == "march") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  march  " + year1 + " ");
                                        zeller(k, monthmarc, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "march"))
                                    break; int kalan4 = (31 - day1) % N;
                                //APRİL
                                for (int k = N - kalan4; k <= 30; k = k + N)
                                {
                                    int monthapr = 4;
                                    if ((year1 == year2) && (month2 == "april") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  april  " + year1 + " ");
                                        zeller(k, monthapr, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "april"))
                                    break; int kalan5 = (30 - (N - (31 - day1) % N)) % N;

                                //MAY
                                for (int k = N - kalan5; k <= 31; k = k + N)

                                {
                                    int monthmayx = 5;
                                    if ((year1 == year2) && (month2 == "may") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  may  " + year1 + " ");
                                        zeller(k, monthmayx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "may"))
                                    break; int kalan6 = (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N;
                                //JUNE
                                Console.WriteLine("\nSummer");
                                for (int k = N - kalan6; k <= 30; k = k + N)

                                {
                                    int monthjunex = 6;
                                    if ((year1 == year2) && (month2 == "june") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  june  " + year1 + " ");
                                        zeller(k, monthjunex, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "june"))
                                    break; int kalan7 = (30 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N;
                                //JULY
                                for (int k = N - kalan7; k <= 31; k = k + N)

                                {
                                    int monthjulyx = 7;
                                    if ((year1 == year2) && (month2 == "july") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  july  " + year1 + " ");
                                        zeller(k, monthjulyx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "july"))
                                    break; int kalan8 = (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N;
                                //AUGUST
                                for (int k = N - kalan8; k <= 31; k = k + N)

                                {
                                    int monthaux = 8;
                                    if ((year1 == year2) && (month2 == "august") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  august  " + year1 + " ");
                                        zeller(k, monthaux, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "august"))
                                    break; int kalan9 = (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N;
                                //SEPTEMBER
                                Console.WriteLine("\nAutumn");
                                for (int k = N - kalan9; k <= 30; k = k + N)

                                {
                                    int monthsepx = 9;
                                    if ((year1 == year2) && (month2 == "september") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  september  " + year1 + " ");
                                        zeller(k, monthsepx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "september"))
                                    break; int kalan10 = (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                //OCTOBER
                                for (int k = N - kalan10; k <= 31; k = k + N)

                                {
                                    int monthoctx = 10;
                                    if ((year1 == year2) && (month2 == "october") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  october  " + year1 + " ");
                                        zeller(k, monthoctx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "october"))
                                    break; int kalan11 = (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                //NOVEMBER
                                for (int k = N - kalan11; k <= 30; k = k + N)

                                {
                                    int monthnovx = 11;
                                    if ((year1 == year2) && (month2 == "november") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  november  " + year1 + " ");
                                        zeller(k, monthnovx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "november"))
                                    break; int kalan12 = (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                //DECEMBER
                                Console.WriteLine("\nWinter");
                                for (int k = N - kalan12; k <= 31; k = k + N)

                                {
                                    int monthdecx = 12;
                                    if ((year1 == year2) && (month2 == "december") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  december  " + year1 + " ");
                                        zeller(k, monthdecx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "december"))
                                    break; int kalan13x = (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;

                                year1++;
                                //JANUARY
                                for (int i = N - kalan13x; i <= 31; i = i + N)
                                {
                                    int monthjan = 1;

                                    if ((year1 == year2) && (month2 == "january") && (i >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(i + "  january  " + year1 + " ");
                                        zeller(i, monthjan, year1);

                                    }
                                }
                                if ((year1 == year2) && (month2 == "january"))
                                    break; int kalan = (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;

                                //tüm şubat kısımları için artık yıl durumunu göz önünde bulundur!!!!!

                                if ((year1 % 4 == 0) && (year1 % 100 != 0))
                                {
                                    for (int j = N - kalan; j <= 29; j = j + N)
                                    {
                                        int monthf = 2;
                                        if ((year1 == year2) && (month2 == "february") && (j >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(j + "  february  " + year1 + " ");
                                            zeller(j, monthf, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "february"))

                                        break; int kalan3 = (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;


                                    day1 = N - kalan3;
                                }


                                else
                                {//şubatın özel durumundan iki farklı işleyiş
                                    for (int j = N - kalan; j <= 28; j = j + N)
                                    {
                                        int monthf = 2;
                                        if ((year1 == year2) && (month2 == "february") && (j >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(j + "  february  " + year1 + " ");
                                            zeller(j, monthf, year1);
                                            // yalnızca döngüde ikinci tarihte nasıl duracağını hatırlatmak için yazıldı!!SİLİNECEK
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "february"))
                                        break; int kalan3 = (28 - (N- (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    day1 = N - kalan3;
                                }
                            }
                            break;

                        case "april"://CASELERİ HATIRLAMAK BULMAK İÇİN11111111111111111111111111111111111
                            Console.WriteLine("\nSpring");
                            while (year1 <= year2)
                            {    //APRİL
                                for (int k = day1; k <= 30; k = k + N)
                                {
                                    int monthapr = 4;
                                    if ((year1 == year2) && (month2 == "april") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  april  " + year1 + " ");
                                        zeller(k, monthapr, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "april"))
                                    break; int kalan5 = (30 - day1) % N;

                                //MAY
                                for (int k = N - kalan5; k <= 31; k = k + N)

                                {
                                    int monthmayx = 5;
                                    if ((year1 == year2) && (month2 == "may") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  may  " + year1 + " ");
                                        zeller(k, monthmayx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "may"))
                                    break; int kalan6 = (31 - (N - (30 - day1) % N)) % N;
                                //JUNE
                                Console.WriteLine("\nSummer");
                                for (int k = N - kalan6; k <= 30; k = k + N)

                                {
                                    int monthjunex = 6;
                                    if ((year1 == year2) && (month2 == "june") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  june  " + year1 + " ");
                                        zeller(k, monthjunex, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "june"))
                                    break; int kalan7 = (30 - (N - (31 - (N - (30 - day1) % N)) % N)) % N;
                                //JULY
                                for (int k = N - kalan7; k <= 31; k = k + N)

                                {
                                    int monthjulyx = 7;
                                    if ((year1 == year2) && (month2 == "july") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  july  " + year1 + " ");
                                        zeller(k, monthjulyx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "july"))
                                    break; int kalan8 = (31 - (N - (30 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N;
                                //AUGUST
                                for (int k = N - kalan8; k <= 31; k = k + N)

                                {
                                    int monthaux = 8;
                                    if ((year1 == year2) && (month2 == "august") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  august  " + year1 + " ");
                                        zeller(k, monthaux, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "august"))
                                    break; int kalan9 = (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N;
                                //SEPTEMBER
                                Console.WriteLine("\nAutumn");
                                for (int k = N - kalan9; k <= 30; k = k + N)

                                {
                                    int monthsepx = 9;
                                    if ((year1 == year2) && (month2 == "september") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  september  " + year1 + " ");
                                        zeller(k, monthsepx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "september"))
                                    break; int kalan10 = (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N;
                                //OCTOBER
                                for (int k = N - kalan10; k <= 31; k = k + N)

                                {
                                    int monthoctx = 10;
                                    if ((year1 == year2) && (month2 == "october") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  october  " + year1 + " ");
                                        zeller(k, monthoctx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "october"))
                                    break; int kalan11 = (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                //NOVEMBER
                                for (int k = N - kalan11; k <= 30; k = k + N)

                                {
                                    int monthnovx = 11;
                                    if ((year1 == year2) && (month2 == "november") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  november  " + year1 + " ");
                                        zeller(k, monthnovx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "november"))
                                    break; int kalan12 = (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                //DECEMBER
                                Console.WriteLine("\nWinter");
                                for (int k = N - kalan12; k <= 31; k = k + N)

                                {
                                    int monthdecx = 12;
                                    if ((year1 == year2) && (month2 == "december") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  december  " + year1 + " ");
                                        zeller(k, monthdecx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "december"))
                                    break; int kalan13x = (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;

                                year1++;
                                //JANUARY
                                for (int i = N - kalan13x; i <= 31; i = i + N)
                                {
                                    int monthjan = 1;

                                    if ((year1 == year2) && (month2 == "january") && (i >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(i + "  january  " + year1 + " ");
                                        zeller(i, monthjan, year1);

                                    }
                                }
                                if ((year1 == year2) && (month2 == "january"))
                                    break; int kalan = (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;

                                //tüm şubat kısımları için artık yıl durumunu göz önünde bulundur!!!!!

                                if ((year1 % 4 == 0) && (year1 % 100 != 0))
                                {
                                    for (int j = N - kalan; j <= 29; j = j + N)
                                    {
                                        int monthf = 2;
                                        if ((year1 == year2) && (month2 == "february") && (j >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(j + "  february  " + year1 + " ");
                                            zeller(j, monthf, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "february"))

                                        break; int kalan3 = (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //MARCH
                                    Console.WriteLine("\nSpring");
                                    for (int k = N - kalan3; k <= 31; k = k + N)
                                    {
                                        int monthmarc = 3;
                                        if ((year1 == year2) && (month2 == "march") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  march  " + year1 + " ");
                                            zeller(k, monthmarc, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "march"))
                                        break; int kalan4 = (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;

                                    day1 = N - kalan4;
                                }


                                else
                                {//şubatın özel durumundan iki farklı işleyiş
                                    for (int j = N - kalan; j <= 28; j = j + N)
                                    {
                                        int monthf = 2;
                                        if ((year1 == year2) && (month2 == "february") && (j >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(j + "  february  " + year1 + " ");
                                            zeller(j, monthf, year1);
                                            // yalnızca döngüde ikinci tarihte nasıl duracağını hatırlatmak için yazıldı!!SİLİNECEK
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "february"))
                                        break;

                                    int kalan3 = (28 - (N- (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;


                                    //MARCH
                                    Console.WriteLine("\nSpring");
                                    for (int k = N - kalan3; k <= 31; k = k + N)
                                    {
                                        int monthmarc = 3;
                                        if ((year1 == year2) && (month2 == "march") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {
                                            Console.Write(k + "  march  " + year1 + " ");
                                            zeller(k, monthmarc, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "march"))
                                        break; int kalan4 = (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;

                                    day1 = N - kalan4;
                                }


                            }

                            break;

                        case "may"://CASELERİ HATIRLAMAK BULMAK İÇİN11111111111111111111111111111111111
                            Console.WriteLine("\nSpring");
                            while (year1 <= year2)
                            {

                                //MAY
                                for (int k = day1; k <= 31; k = k + N)

                                {
                                    int monthmayx = 5;
                                    if ((year1 == year2) && (month2 == "may") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  may  " + year1 + " ");
                                        zeller(k, monthmayx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "may"))
                                    break; int kalan6 = (31 - day1) % N;
                                //JUNE
                                Console.WriteLine("\nSummer");
                                for (int k = N - kalan6; k <= 30; k = k + N)

                                {
                                    int monthjunex = 6;
                                    if ((year1 == year2) && (month2 == "june") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  june  " + year1 + " ");
                                        zeller(k, monthjunex, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "june"))
                                    break; int kalan7 = (30 - (N - (31 - day1) % N)) % N;
                                //JULY
                                for (int k = N - kalan7; k <= 31; k = k + N)

                                {
                                    int monthjulyx = 7;
                                    if ((year1 == year2) && (month2 == "july") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  july  " + year1 + " ");
                                        zeller(k, monthjulyx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "july"))
                                    break; int kalan8 = (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N;
                                //AUGUST
                                for (int k = N - kalan8; k <= 31; k = k + N)

                                {
                                    int monthaux = 8;
                                    if ((year1 == year2) && (month2 == "august") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  august  " + year1 + " ");
                                        zeller(k, monthaux, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "august"))
                                    break; int kalan9 = (31 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N;
                                //SEPTEMBER
                                Console.WriteLine("\nAutumn");
                                for (int k = N - kalan9; k <= 30; k = k + N)

                                {
                                    int monthsepx = 9;
                                    if ((year1 == year2) && (month2 == "september") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  september  " + year1 + " ");
                                        zeller(k, monthsepx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "september"))
                                    break; int kalan10 = (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N;
                                //OCTOBER
                                for (int k = N - kalan10; k <= 31; k = k + N)

                                {
                                    int monthoctx = 10;
                                    if ((year1 == year2) && (month2 == "october") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  october  " + year1 + " ");
                                        zeller(k, monthoctx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "october"))
                                    break; int kalan11 = (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N;
                                //NOVEMBER
                                for (int k = N - kalan11; k <= 30; k = k + N)

                                {
                                    int monthnovx = 11;
                                    if ((year1 == year2) && (month2 == "november") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  november  " + year1 + " ");
                                        zeller(k, monthnovx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "november"))
                                    break; int kalan12 = (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                //DECEMBER
                                Console.WriteLine("\nWinter");
                                for (int k = N - kalan12; k <= 31; k = k + N)

                                {
                                    int monthdecx = 12;
                                    if ((year1 == year2) && (month2 == "december") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  december  " + year1 + " ");
                                        zeller(k, monthdecx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "december"))
                                    break; int kalan13x = (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;

                                year1++;
                                //JANUARY
                                for (int i = N - kalan13x; i <= 31; i = i + N)
                                {
                                    int monthjan = 1;

                                    if ((year1 == year2) && (month2 == "january") && (i >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(i + "  january  " + year1 + " ");
                                        zeller(i, monthjan, year1);

                                    }
                                }
                                if ((year1 == year2) && (month2 == "january"))
                                    break; int kalan = (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;

                                //tüm şubat kısımları için artık yıl durumunu göz önünde bulundur!!!!!

                                if ((year1 % 4 == 0) && (year1 % 100 != 0))
                                {
                                    for (int j = N - kalan; j <= 29; j = j + N)
                                    {
                                        int monthf = 2;
                                        if ((year1 == year2) && (month2 == "february") && (j >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(j + "  february  " + year1 + " ");
                                            zeller(j, monthf, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "february"))

                                        break; int kalan3 = (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //MARCH
                                    Console.WriteLine("\nSpring");
                                    for (int k = N - kalan3; k <= 31; k = k + N)
                                    {
                                        int monthmarc = 3;
                                        if ((year1 == year2) && (month2 == "march") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  march  " + year1 + " ");
                                            zeller(k, monthmarc, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "march"))
                                        break; int kalan4 = (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //APRİL
                                    for (int k = N - kalan4; k <= 30; k = k + N)
                                    {
                                        int monthapr = 4;
                                        if ((year1 == year2) && (month2 == "april") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  april  " + year1 + " ");
                                            zeller(k, monthapr, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "april"))
                                        break; int kalan5 = (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    day1 = N - kalan5;
                                }


                                else
                                {//şubatın özel durumundan iki farklı işleyiş
                                    for (int j = N - kalan; j <= 28; j = j + N)
                                    {
                                        int monthf = 2;
                                        if ((year1 == year2) && (month2 == "february") && (j >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(j + "  february  " + year1 + " ");
                                            zeller(j, monthf, year1);
                                            // yalnızca döngüde ikinci tarihte nasıl duracağını hatırlatmak için yazıldı!!SİLİNECEK
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "february"))
                                        break;

                                    int kalan3 = (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;


                                    //MARCH
                                    Console.WriteLine("\nSpring");
                                    for (int k = N - kalan3; k <= 31; k = k + N)
                                    {
                                        int monthmarc = 3;
                                        if ((year1 == year2) && (month2 == "march") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {
                                            Console.Write(k + "  march  " + year1 + " ");
                                            zeller(k, monthmarc, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "march"))
                                        break; int kalan4 = (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //APRİL
                                    for (int k = N - kalan4; k <= 30; k = k + N)
                                    {
                                        int monthapr = 4;
                                        if ((year1 == year2) && (month2 == "april") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  april  " + year1 + " ");
                                            zeller(k, monthapr, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "april"))
                                        break; int kalan5 = (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    day1 = N - kalan5;
                                }


                            }

                            break;

                        case "june"://CASELERİ HATIRLAMAK BULMAK İÇİN11111111111111111111111111111111111

                            while (year1 <= year2)
                            {  //JUNE
                                Console.WriteLine("\nSummer");
                                for (int k = day1; k <= 30; k = k + N)

                                {
                                    int monthjunex = 6;
                                    if ((year1 == year2) && (month2 == "june") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  june  " + year1 + " ");
                                        zeller(k, monthjunex, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "june"))
                                    break; int kalan7 = (30 - day1) % N;

                                //JULY
                                for (int k = N - kalan7; k <= 31; k = k + N)

                                {
                                    int monthjulyx = 7;
                                    if ((year1 == year2) && (month2 == "july") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  july  " + year1 + " ");
                                        zeller(k, monthjulyx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "july"))
                                    break; int kalan8 = (31 - (N - (30 - day1) % N)) % N;
                                //AUGUST
                                for (int k = N - kalan8; k <= 31; k = k + N)

                                {
                                    int monthaux = 8;
                                    if ((year1 == year2) && (month2 == "august") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  august  " + year1 + " ");
                                        zeller(k, monthaux, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "august"))
                                    break; int kalan9 = (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N;
                                //SEPTEMBER
                                Console.WriteLine("\nAutumn");
                                for (int k = N - kalan9; k <= 30; k = k + N)

                                {
                                    int monthsepx = 9;
                                    if ((year1 == year2) && (month2 == "september") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  september  " + year1 + " ");
                                        zeller(k, monthsepx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "september"))
                                    break; int kalan10 = (30 - (N - (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N;

                                //OCTOBER
                                for (int k = N - kalan10; k <= 31; k = k + N)

                                {
                                    int monthoctx = 10;
                                    if ((year1 == year2) && (month2 == "october") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  october  " + year1 + " ");
                                        zeller(k, monthoctx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "october"))
                                    break; int kalan11 = (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N;

                                //NOVEMBER
                                for (int k = N - kalan11; k <= 30; k = k + N)

                                {
                                    int monthnovx = 11;
                                    if ((year1 == year2) && (month2 == "november") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  november  " + year1 + " ");
                                        zeller(k, monthnovx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "november"))
                                    break; int kalan12 = (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N;
                                //DECEMBER
                                Console.WriteLine("\nWinter");
                                for (int k = N - kalan12; k <= 31; k = k + N)

                                {
                                    int monthdecx = 12;
                                    if ((year1 == year2) && (month2 == "december") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  december  " + year1 + " ");
                                        zeller(k, monthdecx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "december"))
                                    break; int kalan13 = (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                year1++;

                                int monthjan = 1;

                                for (int i = N - kalan13; i <= 31; i = i + N)
                                {

                                    if ((year1 == year2) && (month1 == month2) && (i >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(i + "  january  " + year1 + " ");
                                        zeller(i, monthjan, year1);

                                    }
                                }
                                if ((year1 == year2) && (month2 == "janurary"))
                                    break; int kalan = (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;//bu kısımlar bir sonraki ayın başlayacağı günü belirlemeye yardımcı olacak!!!

                                //tüm şubat kısımları için artık yıl durumunu göz önünde bulundur!!!!!

                                if ((year1 % 4 == 0) && (year1 % 100 != 0))
                                {
                                    for (int j = N - kalan; j <= 29; j = j + N)
                                    {
                                        int monthf = 2;
                                        if ((year1 == year2) && (month2 == "february") && (j >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(j + "  february  " + year1 + " ");
                                            zeller(j, monthf, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "february"))

                                        break; int kalan3 = (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //MARCH
                                    Console.WriteLine("\nSpring");
                                    for (int k = N - kalan3; k <= 31; k = k + N)
                                    {
                                        int monthmarc = 3;
                                        if ((year1 == year2) && (month2 == "march") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  march  " + year1 + " ");
                                            zeller(k, monthmarc, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "march"))
                                        break; int kalan4 = (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //APRİL
                                    for (int k = N - kalan4; k <= 30; k = k + N)
                                    {
                                        int monthapr = 4;
                                        if ((year1 == year2) && (month2 == "april") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  april  " + year1 + " ");
                                            zeller(k, monthapr, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "april"))
                                        break; int kalan5 = (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //MAY
                                    for (int k = N - kalan5; k <= 31; k = k + N)

                                    {
                                        int monthmayx = 5;
                                        if ((year1 == year2) && (month2 == "may") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  may  " + year1 + " ");
                                            zeller(k, monthmayx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "may"))
                                        break; int kalan6 = (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    day1 = N - kalan6;


                                }


                                else
                                {//şubatın özel durumundan iki farklı işleyiş
                                    for (int j = N - kalan; j <= 28; j = j + N)
                                    {
                                        int monthf = 2;
                                        if ((year1 == year2) && (month2 == "february") && (j >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(j + "  february  " + year1 + " ");
                                            zeller(j, monthf, year1);
                                            // yalnızca döngüde ikinci tarihte nasıl duracağını hatırlatmak için yazıldı!!SİLİNECEK
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "february"))
                                        break;

                                    int kalan3 = (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;


                                    //MARCH
                                    Console.WriteLine("\nSpring");
                                    for (int k = N - kalan3; k <= 31; k = k + N)
                                    {
                                        int monthmarc = 3;
                                        if ((year1 == year2) && (month2 == "march") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {
                                            Console.Write(k + "  march  " + year1 + " ");
                                            zeller(k, monthmarc, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "march"))
                                        break; int kalan4 = (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //APRİL
                                    for (int k = N - kalan4; k <= 30; k = k + N)
                                    {
                                        int monthapr = 4;
                                        if ((year1 == year2) && (month2 == "april") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  april  " + year1 + " ");
                                            zeller(k, monthapr, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "april"))
                                        break; int kalan5 = (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //MAY
                                    for (int k = N - kalan5; k <= 31; k = k + N)

                                    {
                                        int monthmayx = 5;
                                        if ((year1 == year2) && (month2 == "may") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  may  " + year1 + " ");
                                            zeller(k, monthmayx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "may"))
                                        break; int kalan6 = (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;

                                    day1 = N - kalan6;


                                }


                            }
                            break;

                        case "july"://CASELERİ HATIRLAMAK BULMAK İÇİN11111111111111111111111111111111111
                            Console.WriteLine("\nSummer");

                            while (year1 <= year2)
                            { //JULY
                                for (int k = day1; k <= 31; k = k + N)

                                {
                                    int monthjulyx = 7;
                                    if ((year1 == year2) && (month2 == "july") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  july  " + year1 + " ");
                                        zeller(k, monthjulyx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "july"))
                                    break; int kalan8 = (31 - day1) % N;
                                //AUGUST
                                for (int k = N - kalan8; k <= 31; k = k + N)

                                {
                                    int monthaux = 8;
                                    if ((year1 == year2) && (month2 == "august") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  august  " + year1 + " ");
                                        zeller(k, monthaux, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "august"))
                                    break; int kalan9 = (31 - (N - (31 - day1) % N)) % N;
                                //SEPTEMBER
                                Console.WriteLine("\nAutumn");
                                for (int k = N - kalan9; k <= 30; k = k + N)

                                {
                                    int monthsepx = 9;
                                    if ((year1 == year2) && (month2 == "september") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  september  " + year1 + " ");
                                        zeller(k, monthsepx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "september"))
                                    break; int kalan10 = (30 - (N - (31 - (N - (31 - day1) % N)) % N)) % N;

                                //OCTOBER
                                for (int k = N - kalan10; k <= 31; k = k + N)

                                {
                                    int monthoctx = 10;
                                    if ((year1 == year2) && (month2 == "october") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  october  " + year1 + " ");
                                        zeller(k, monthoctx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "october"))
                                    break; int kalan11 = (31 - (N - (30 - (N - (31 - (N - (31 - day1) % N)) % N)) % N)) % N;

                                //NOVEMBER
                                for (int k = N - kalan11; k <= 30; k = k + N)

                                {
                                    int monthnovx = 11;
                                    if ((year1 == year2) && (month2 == "november") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  november  " + year1 + " ");
                                        zeller(k, monthnovx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "november"))
                                    break; int kalan12 = (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N;
                                //DECEMBER
                                Console.WriteLine("\nWinter");
                                for (int k = N - kalan12; k <= 31; k = k + N)

                                {
                                    int monthdecx = 12;
                                    if ((year1 == year2) && (month2 == "december") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  december  " + year1 + " ");
                                        zeller(k, monthdecx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "december"))
                                    break; int kalan13 = (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N;
                                year1++;

                                int monthjan = 1;

                                for (int i = N - kalan13; i <= 31; i = i + N)
                                {

                                    if ((year1 == year2) && (month1 == month2) && (i >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(i + "  january  " + year1 + " ");
                                        zeller(i, monthjan, year1);

                                    }
                                }
                                if ((year1 == year2) && (month2 == "janurary"))
                                    break; int kalan = (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N;//bu kısımlar bir sonraki ayın başlayacağı günü belirlemeye yardımcı olacak!!!

                                //tüm şubat kısımları için artık yıl durumunu göz önünde bulundur!!!!!

                                if ((year1 % 4 == 0) && (year1 % 100 != 0))
                                {
                                    for (int j = N - kalan; j <= 29; j = j + N)
                                    {
                                        int monthf = 2;
                                        if ((year1 == year2) && (month2 == "february") && (j >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(j + "  february  " + year1 + " ");
                                            zeller(j, monthf, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "february"))

                                        break; int kalan3 = (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //MARCH
                                    Console.WriteLine("\nSpring");
                                    for (int k = N - kalan3; k <= 31; k = k + N)
                                    {
                                        int monthmarc = 3;
                                        if ((year1 == year2) && (month2 == "march") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  march  " + year1 + " ");
                                            zeller(k, monthmarc, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "march"))
                                        break; int kalan4 = (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //APRİL
                                    for (int k = N - kalan4; k <= 30; k = k + N)
                                    {
                                        int monthapr = 4;
                                        if ((year1 == year2) && (month2 == "april") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  april  " + year1 + " ");
                                            zeller(k, monthapr, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "april"))
                                        break; int kalan5 = (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //MAY
                                    for (int k = N - kalan5; k <= 31; k = k + N)

                                    {
                                        int monthmayx = 5;
                                        if ((year1 == year2) && (month2 == "may") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  may  " + year1 + " ");
                                            zeller(k, monthmayx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "may"))
                                        break; int kalan6 = (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //JUNE
                                    Console.WriteLine("\nSummer");
                                    for (int k = N - kalan6; k <= 30; k = k + N)

                                    {
                                        int monthjunex = 6;
                                        if ((year1 == year2) && (month2 == "june") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  june  " + year1 + " ");
                                            zeller(k, monthjunex, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "june"))
                                        break; int kalan7 = (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    day1 = N - kalan7;


                                }


                                else
                                {//şubatın özel durumundan iki farklı işleyiş
                                    for (int j = N - kalan; j <= 28; j = j + N)
                                    {
                                        int monthf = 2;
                                        if ((year1 == year2) && (month2 == "february") && (j >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(j + "  february  " + year1 + " ");
                                            zeller(j, monthf, year1);
                                            // yalnızca döngüde ikinci tarihte nasıl duracağını hatırlatmak için yazıldı!!SİLİNECEK
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "february"))
                                        break;

                                    int kalan3 = (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;


                                    //MARCH
                                    Console.WriteLine("\nSpring");
                                    for (int k = N - kalan3; k <= 31; k = k + N)
                                    {
                                        int monthmarc = 3;
                                        if ((year1 == year2) && (month2 == "march") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {
                                            Console.Write(k + "  march  " + year1 + " ");
                                            zeller(k, monthmarc, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "march"))
                                        break; int kalan4 = (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //APRİL
                                    for (int k = N - kalan4; k <= 30; k = k + N)
                                    {
                                        int monthapr = 4;
                                        if ((year1 == year2) && (month2 == "april") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  april  " + year1 + " ");
                                            zeller(k, monthapr, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "april"))
                                        break; int kalan5 = (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //MAY
                                    for (int k = N - kalan5; k <= 31; k = k + N)

                                    {
                                        int monthmayx = 5;
                                        if ((year1 == year2) && (month2 == "may") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  may  " + year1 + " ");
                                            zeller(k, monthmayx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "may"))
                                        break; int kalan6 = (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //JUNE
                                    Console.WriteLine("\nSummer");
                                    for (int k = N - kalan6; k <= 30; k = k + N)

                                    {
                                        int monthjunex = 7;
                                        if ((year1 == year2) && (month2 == "june") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  june  " + year1 + " ");
                                            zeller(k, monthjunex, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "june"))
                                        break; int kalan7 = (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;

                                    day1 = N - kalan7;


                                }


                            }
                            break;

                        case "august"://CASELERİ HATIRLAMAK BULMAK İÇİN11111111111111111111111111111111111
                            Console.WriteLine("\nSummer");
                            while (year1 <= year2)
                            { //AUGUST
                                for (int k = day1; k <= 31; k = k + N)

                                {
                                    int monthaux = 8;
                                    if ((year1 == year2) && (month2 == "august") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  august  " + year1 + " ");
                                        zeller(k, monthaux, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "august"))
                                    break; int kalan9 = (31 - day1) % N;
                                //SEPTEMBER
                                Console.WriteLine("\nAutumn");
                                for (int k = N - kalan9; k <= 30; k = k + N)

                                {
                                    int monthsepx = 9;
                                    if ((year1 == year2) && (month2 == "september") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  september  " + year1 + " ");
                                        zeller(k, monthsepx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "september"))
                                    break; int kalan10 = (30 - (N - (31 - day1) % N)) % N;

                                //OCTOBER
                                for (int k = N - kalan10; k <= 31; k = k + N)

                                {
                                    int monthoctx = 10;
                                    if ((year1 == year2) && (month2 == "october") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  october  " + year1 + " ");
                                        zeller(k, monthoctx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "october"))
                                    break; int kalan11 = (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N;

                                //NOVEMBER
                                for (int k = N - kalan11; k <= 30; k = k + N)

                                {
                                    int monthnovx = 11;
                                    if ((year1 == year2) && (month2 == "november") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  november  " + year1 + " ");
                                        zeller(k, monthnovx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "november"))
                                    break; int kalan12 = (30 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N;
                                //DECEMBER
                                Console.WriteLine("\nWinter");
                                for (int k = N - kalan12; k <= 31; k = k + N)

                                {
                                    int monthdecx = 12;
                                    if ((year1 == year2) && (month2 == "december") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  december  " + year1 + " ");
                                        zeller(k, monthdecx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "december"))
                                    break; int kalan13 = (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N;
                                year1++;

                                int monthjan = 1;

                                for (int i = N - kalan13; i <= 31; i = i + N)
                                {

                                    if ((year1 == year2) && (month1 == month2) && (i >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(i + "  january  " + year1 + " ");
                                        zeller(i, monthjan, year1);

                                    }
                                }
                                if ((year1 == year2) && (month2 == "janurary"))
                                    break; int kalan = (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N;//bu kısımlar bir sonraki ayın başlayacağı günü belirlemeye yardımcı olacak!!!

                                //tüm şubat kısımları için artık yıl durumunu göz önünde bulundur!!!!!

                                if ((year1 % 4 == 0) && (year1 % 100 != 0))
                                {
                                    for (int j = N - kalan; j <= 29; j = j + N)
                                    {
                                        int monthf = 2;
                                        if ((year1 == year2) && (month2 == "february") && (j >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(j + "  february  " + year1 + " ");
                                            zeller(j, monthf, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "february"))

                                        break; int kalan3 = (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //MARCH
                                    Console.WriteLine("\nSpring");
                                    for (int k = N - kalan3; k <= 31; k = k + N)
                                    {
                                        int monthmarc = 3;
                                        if ((year1 == year2) && (month2 == "march") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  march  " + year1 + " ");
                                            zeller(k, monthmarc, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "march"))
                                        break; int kalan4 = (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //APRİL
                                    for (int k = N - kalan4; k <= 30; k = k + N)
                                    {
                                        int monthapr = 4;
                                        if ((year1 == year2) && (month2 == "april") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  april  " + year1 + " ");
                                            zeller(k, monthapr, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "april"))
                                        break; int kalan5 = (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //MAY
                                    for (int k = N - kalan5; k <= 31; k = k + N)

                                    {
                                        int monthmayx = 5;
                                        if ((year1 == year2) && (month2 == "may") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  may  " + year1 + " ");
                                            zeller(k, monthmayx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "may"))
                                        break; int kalan6 = (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //JUNE
                                    Console.WriteLine("\nSummer");
                                    for (int k = N - kalan6; k <= 30; k = k + N)

                                    {
                                        int monthjunex = 6;
                                        if ((year1 == year2) && (month2 == "june") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  june  " + year1 + " ");
                                            zeller(k, monthjunex, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "june"))
                                        break; int kalan7 = (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //JULY
                                    for (int k = N - kalan7; k <= 31; k = k + N)

                                    {
                                        int monthjulyx = 7;
                                        if ((year1 == year2) && (month2 == "july") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  july  " + year1 + " ");
                                            zeller(k, monthjulyx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "july"))
                                        break; int kalan8 = (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    day1 = N - kalan8;


                                }


                                else
                                {//şubatın özel durumundan iki farklı işleyiş
                                    for (int j = N - kalan; j <= 28; j = j + N)
                                    {
                                        int monthf = 2;
                                        if ((year1 == year2) && (month2 == "february") && (j >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(j + "  february  " + year1 + " ");
                                            zeller(j, monthf, year1);
                                            // yalnızca döngüde ikinci tarihte nasıl duracağını hatırlatmak için yazıldı!!SİLİNECEK
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "february"))
                                        break;

                                    int kalan3 = (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N;


                                    //MARCH
                                    Console.WriteLine("\nSpring");
                                    for (int k = N - kalan3; k <= 31; k = k + N)
                                    {
                                        int monthmarc = 3;
                                        if ((year1 == year2) && (month2 == "march") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {
                                            Console.Write(k + "  march  " + year1 + " ");
                                            zeller(k, monthmarc, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "march"))
                                        break; int kalan4 = (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //APRİL
                                    for (int k = N - kalan4; k <= 30; k = k + N)
                                    {
                                        int monthapr = 4;
                                        if ((year1 == year2) && (month2 == "april") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  april  " + year1 + " ");
                                            zeller(k, monthapr, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "april"))
                                        break; int kalan5 = (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //MAY
                                    for (int k = N - kalan5; k <= 31; k = k + N)

                                    {
                                        int monthmayx = 5;
                                        if ((year1 == year2) && (month2 == "may") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  may  " + year1 + " ");
                                            zeller(k, monthmayx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "may"))
                                        break; int kalan6 = (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //JUNE
                                    Console.WriteLine("\nSummer");
                                    for (int k = N - kalan6; k <= 30; k = k + N)

                                    {
                                        int monthjunex = 7;
                                        if ((year1 == year2) && (month2 == "june") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  june  " + year1 + " ");
                                            zeller(k, monthjunex, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "june"))
                                        break; int kalan7 = (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //JULY
                                    for (int k = N - kalan7; k <= 31; k = k + N)

                                    {
                                        int monthjulyx = 7;
                                        if ((year1 == year2) && (month2 == "july") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  july  " + year1 + " ");
                                            zeller(k, monthjulyx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "july"))
                                        break; int kalan8 = (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;

                                    day1 = N - kalan8;


                                }


                            }
                            break;


                        case "september"://CASELERİ HATIRLAMAK BULMAK İÇİN11111111111111111111111111111111111

                            while (year1 <= year2)
                            {  //SEPTEMBER
                                Console.WriteLine("\nAutumn");
                                for (int k = day1; k <= 30; k = k + N)

                                {
                                    int monthsepx = 9;
                                    if ((year1 == year2) && (month2 == "september") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  september  " + year1 + " ");
                                        zeller(k, monthsepx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "september"))
                                    break; int kalan10 = (30 - day1) % N;

                                //OCTOBER
                                for (int k = N - kalan10; k <= 31; k = k + N)

                                {
                                    int monthoctx = 10;
                                    if ((year1 == year2) && (month2 == "october") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  october  " + year1 + " ");
                                        zeller(k, monthoctx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "october"))
                                    break; int kalan11 = (31 - (N - (30 - day1) % N)) % N;

                                //NOVEMBER
                                for (int k = N - kalan11; k <= 30; k = k + N)

                                {
                                    int monthnovx = 11;
                                    if ((year1 == year2) && (month2 == "november") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  november  " + year1 + " ");
                                        zeller(k, monthnovx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "november"))
                                    break; int kalan12 = (30 - (N - (31 - (N - (30 - day1) % N)) % N)) % N;
                                //DECEMBER
                                Console.WriteLine("\nWinter");
                                for (int k = N - kalan12; k <= 31; k = k + N)

                                {
                                    int monthdecx = 12;
                                    if ((year1 == year2) && (month2 == "december") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  december  " + year1 + " ");
                                        zeller(k, monthdecx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "december"))
                                    break; int kalan13 = (31 - (N - (30 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N;
                                year1++;

                                int monthjan = 1;

                                for (int i = N - kalan13; i <= 31; i = i + N)
                                {

                                    if ((year1 == year2) && (month1 == month2) && (i >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(i + "  january  " + year1 + " ");
                                        zeller(i, monthjan, year1);

                                    }
                                }
                                if ((year1 == year2) && (month2 == "janurary"))
                                    break; int kalan = (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N;//bu kısımlar bir sonraki ayın başlayacağı günü belirlemeye yardımcı olacak!!!

                                //tüm şubat kısımları için artık yıl durumunu göz önünde bulundur!!!!!

                                if ((year1 % 4 == 0) && (year1 % 100 != 0))
                                {
                                    for (int j = N - kalan; j <= 29; j = j + N)
                                    {
                                        int monthf = 2;
                                        if ((year1 == year2) && (month2 == "february") && (j >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(j + "  february  " + year1 + " ");
                                            zeller(j, monthf, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "february"))

                                        break; int kalan3 = (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N;
                                    //MARCH
                                    Console.WriteLine("\nSpring");
                                    for (int k = N - kalan3; k <= 31; k = k + N)
                                    {
                                        int monthmarc = 3;
                                        if ((year1 == year2) && (month2 == "march") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  march  " + year1 + " ");
                                            zeller(k, monthmarc, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "march"))
                                        break; int kalan4 = (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //APRİL
                                    for (int k = N - kalan4; k <= 30; k = k + N)
                                    {
                                        int monthapr = 4;
                                        if ((year1 == year2) && (month2 == "april") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  april  " + year1 + " ");
                                            zeller(k, monthapr, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "april"))
                                        break; int kalan5 = (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //MAY
                                    for (int k = N - kalan5; k <= 31; k = k + N)

                                    {
                                        int monthmayx = 5;
                                        if ((year1 == year2) && (month2 == "may") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  may  " + year1 + " ");
                                            zeller(k, monthmayx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "may"))
                                        break; int kalan6 = (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //JUNE
                                    Console.WriteLine("\nSummer");
                                    for (int k = N - kalan6; k <= 30; k = k + N)

                                    {
                                        int monthjunex = 6;
                                        if ((year1 == year2) && (month2 == "june") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  june  " + year1 + " ");
                                            zeller(k, monthjunex, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "june"))
                                        break; int kalan7 = (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //JULY
                                    for (int k = N - kalan7; k <= 31; k = k + N)

                                    {
                                        int monthjulyx = 7;
                                        if ((year1 == year2) && (month2 == "july") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  july  " + year1 + " ");
                                            zeller(k, monthjulyx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "july"))
                                        break; int kalan8 = (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //AUGUST
                                    for (int k = N - kalan8; k <= 31; k = k + N)

                                    {
                                        int monthaux = 8;
                                        if ((year1 == year2) && (month2 == "august") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  august  " + year1 + " ");
                                            zeller(k, monthaux, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "august"))
                                        break; int kalan9 = (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    day1 = N - kalan9;


                                }


                                else
                                {//şubatın özel durumundan iki farklı işleyiş
                                    for (int j = N - kalan; j <= 28; j = j + N)
                                    {
                                        int monthf = 2;
                                        if ((year1 == year2) && (month2 == "february") && (j >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(j + "  february  " + year1 + " ");
                                            zeller(j, monthf, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "february"))
                                        break;

                                    int kalan3 = (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N;


                                    //MARCH
                                    Console.WriteLine("\nSpring");
                                    for (int k = N - kalan3; k <= 31; k = k + N)
                                    {
                                        int monthmarc = 3;
                                        if ((year1 == year2) && (month2 == "march") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {
                                            Console.Write(k + "  march  " + year1 + " ");
                                            zeller(k, monthmarc, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "march"))
                                        break; int kalan4 = (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //APRİL
                                    for (int k = N - kalan4; k <= 30; k = k + N)
                                    {
                                        int monthapr = 4;
                                        if ((year1 == year2) && (month2 == "april") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  april  " + year1 + " ");
                                            zeller(k, monthapr, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "april"))
                                        break; int kalan5 = (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //MAY
                                    for (int k = N - kalan5; k <= 31; k = k + N)

                                    {
                                        int monthmayx = 5;
                                        if ((year1 == year2) && (month2 == "may") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  may  " + year1 + " ");
                                            zeller(k, monthmayx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "may"))
                                        break; int kalan6 = (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //JUNE
                                    Console.WriteLine("\nSummer");
                                    for (int k = N - kalan6; k <= 30; k = k + N)

                                    {
                                        int monthjunex = 7;
                                        if ((year1 == year2) && (month2 == "june") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  june  " + year1 + " ");
                                            zeller(k, monthjunex, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "june"))
                                        break; int kalan7 = (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //JULY
                                    for (int k = N - kalan7; k <= 31; k = k + N)

                                    {
                                        int monthjulyx = 7;
                                        if ((year1 == year2) && (month2 == "july") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  july  " + year1 + " ");
                                            zeller(k, monthjulyx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "july"))
                                        break; int kalan8 = (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //AUGUST
                                    for (int k = N - kalan8; k <= 31; k = k + N)

                                    {
                                        int monthaux = 8;
                                        if ((year1 == year2) && (month2 == "august") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  august  " + year1 + " ");
                                            zeller(k, monthaux, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "august"))
                                        break; int kalan9 = (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;

                                    day1 = N - kalan9;


                                }


                            }
                            break;

                        case "october"://CASELERİ HATIRLAMAK BULMAK İÇİN11111111111111111111111111111111111
                            Console.WriteLine("Autumn");
                            while (year1 <= year2)
                            { //OCTOBER
                                for (int k = day1; k <= 31; k = k + N)

                                {
                                    int monthoctx = 10;
                                    if ((year1 == year2) && (month2 == "october") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  october  " + year1 + " ");
                                        zeller(k, monthoctx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "october"))
                                    break; int kalan11 = (31 - day1) % N;

                                //NOVEMBER
                                for (int k = N - kalan11; k <= 30; k = k + N)

                                {
                                    int monthnovx = 11;
                                    if ((year1 == year2) && (month2 == "november") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  november  " + year1 + " ");
                                        zeller(k, monthnovx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "november"))
                                    break; int kalan12 = (30 - (N - (31 - day1) % N)) % N;
                                //DECEMBER
                                Console.WriteLine("\nWinter");
                                for (int k = N - kalan12; k <= 31; k = k + N)

                                {
                                    int monthdecx = 12;
                                    if ((year1 == year2) && (month2 == "december") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  december  " + year1 + " ");
                                        zeller(k, monthdecx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "december"))
                                    break; int kalan13 = (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N;
                                year1++;

                                int monthjan = 1;

                                for (int i = N - kalan13; i <= 31; i = i + N)
                                {

                                    if ((year1 == year2) && (month1 == month2) && (i >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(i + "  january  " + year1 + " ");
                                        zeller(i, monthjan, year1);

                                    }
                                }
                                if ((year1 == year2) && (month2 == "janurary"))
                                    break; int kalan = (31 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N;//bu kısımlar bir sonraki ayın başlayacağı günü belirlemeye yardımcı olacak!!!

                                //tüm şubat kısımları için artık yıl durumunu göz önünde bulundur!!!!!

                                if ((year1 % 4 == 0) && (year1 % 100 != 0))
                                {
                                    for (int j = N - kalan; j <= 29; j = j + N)
                                    {
                                        int monthf = 2;
                                        if ((year1 == year2) && (month2 == "february") && (j >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(j + "  february  " + year1 + " ");
                                            zeller(j, monthf, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "february"))

                                        break; int kalan3 = (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N;
                                    //MARCH
                                    Console.WriteLine("\nSpring");
                                    for (int k = N - kalan3; k <= 31; k = k + N)
                                    {
                                        int monthmarc = 3;
                                        if ((year1 == year2) && (month2 == "march") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  march  " + year1 + " ");
                                            zeller(k, monthmarc, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "march"))
                                        break; int kalan4 = (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N;
                                    //APRİL
                                    for (int k = N - kalan4; k <= 30; k = k + N)
                                    {
                                        int monthapr = 4;
                                        if ((year1 == year2) && (month2 == "april") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  april  " + year1 + " ");
                                            zeller(k, monthapr, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "april"))
                                        break; int kalan5 = (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //MAY
                                    for (int k = N - kalan5; k <= 31; k = k + N)

                                    {
                                        int monthmayx = 5;
                                        if ((year1 == year2) && (month2 == "may") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  may  " + year1 + " ");
                                            zeller(k, monthmayx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "may"))
                                        break; int kalan6 = (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //JUNE
                                    Console.WriteLine("\nSummer");
                                    for (int k = N - kalan6; k <= 30; k = k + N)

                                    {
                                        int monthjunex = 6;
                                        if ((year1 == year2) && (month2 == "june") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  june  " + year1 + " ");
                                            zeller(k, monthjunex, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "june"))
                                        break; int kalan7 = (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //JULY
                                    for (int k = N - kalan7; k <= 31; k = k + N)

                                    {
                                        int monthjulyx = 7;
                                        if ((year1 == year2) && (month2 == "july") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  july  " + year1 + " ");
                                            zeller(k, monthjulyx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "july"))
                                        break; int kalan8 = (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //AUGUST
                                    for (int k = N - kalan8; k <= 31; k = k + N)

                                    {
                                        int monthaux = 8;
                                        if ((year1 == year2) && (month2 == "august") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  august  " + year1 + " ");
                                            zeller(k, monthaux, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "august"))
                                        break; int kalan9 = (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //SEPTEMBER
                                    Console.WriteLine("\nAutumn");
                                    for (int k = N - kalan9; k <= 30; k = k + N)

                                    {
                                        int monthsepx = 9;
                                        if ((year1 == year2) && (month2 == "september") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  september  " + year1 + " ");
                                            zeller(k, monthsepx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "september"))
                                        break; int kalan10 = (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    day1 = N - kalan10;


                                }


                                else
                                {//şubatın özel durumundan iki farklı işleyiş
                                    for (int j = N - kalan; j <= 28; j = j + N)
                                    {
                                        int monthf = 2;
                                        if ((year1 == year2) && (month2 == "february") && (j >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(j + "  february  " + year1 + " ");
                                            zeller(j, monthf, year1);
                                            // yalnızca döngüde ikinci tarihte nasıl duracağını hatırlatmak için yazıldı!!SİLİNECEK
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "february"))
                                        break;

                                    int kalan3 = (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N;


                                    //MARCH
                                    Console.WriteLine("\nSpring");
                                    for (int k = N - kalan3; k <= 31; k = k + N)
                                    {
                                        int monthmarc = 3;
                                        if ((year1 == year2) && (month2 == "march") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {
                                            Console.Write(k + "  march  " + year1 + " ");
                                            zeller(k, monthmarc, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "march"))
                                        break; int kalan4 = (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N;
                                    //APRİL
                                    for (int k = N - kalan4; k <= 30; k = k + N)
                                    {
                                        int monthapr = 4;
                                        if ((year1 == year2) && (month2 == "april") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  april  " + year1 + " ");
                                            zeller(k, monthapr, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "april"))
                                        break; int kalan5 = (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //MAY
                                    for (int k = N - kalan5; k <= 31; k = k + N)

                                    {
                                        int monthmayx = 5;
                                        if ((year1 == year2) && (month2 == "may") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  may  " + year1 + " ");
                                            zeller(k, monthmayx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "may"))
                                        break; int kalan6 = (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //JUNE
                                    Console.WriteLine("\nSummer");
                                    for (int k = N - kalan6; k <= 30; k = k + N)

                                    {
                                        int monthjunex = 7;
                                        if ((year1 == year2) && (month2 == "june") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  june  " + year1 + " ");
                                            zeller(k, monthjunex, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "june"))
                                        break; int kalan7 = (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //JULY
                                    for (int k = N - kalan7; k <= 31; k = k + N)

                                    {
                                        int monthjulyx = 7;
                                        if ((year1 == year2) && (month2 == "july") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  july  " + year1 + " ");
                                            zeller(k, monthjulyx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "july"))
                                        break; int kalan8 = (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //AUGUST
                                    for (int k = N - kalan8; k <= 31; k = k + N)

                                    {
                                        int monthaux = 8;
                                        if ((year1 == year2) && (month2 == "august") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  august  " + year1 + " ");
                                            zeller(k, monthaux, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "august"))
                                        break; int kalan9 = (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //SEPTEMBER
                                    Console.WriteLine("\nAutumn");
                                    for (int k = N - kalan9; k <= 30; k = k + N)

                                    {
                                        int monthsepx = 9;
                                        if ((year1 == year2) && (month2 == "september") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  september  " + year1 + " ");
                                            zeller(k, monthsepx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "september"))
                                        break; int kalan10 = (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;

                                    day1 = N - kalan10;


                                }


                            }
                            break;
                        case "november"://CASELERİ HATIRLAMAK BULMAK İÇİN11111111111111111111111111111111111
                            Console.WriteLine("Autumn");
                            while (year1 <= year2)
                            {
                                //NOVEMBER
                                for (int k = day1; k <= 30; k = k + N)

                                {
                                    int monthnovx = 11;
                                    if ((year1 == year2) && (month2 == "november") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  november  " + year1 + " ");
                                        zeller(k, monthnovx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "november"))
                                    break; int kalan12 = (30 - day1) % N;
                                //DECEMBER
                                Console.WriteLine("\nWinter");
                                for (int k = N - kalan12; k <= 31; k = k + N)

                                {
                                    int monthdecx = 12;
                                    if ((year1 == year2) && (month2 == "december") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  december  " + year1 + " ");
                                        zeller(k, monthdecx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "december"))
                                    break; int kalan13 = (31 - (N - (30 - day1) % N)) % N;
                                year1++;

                                int monthjan = 1;

                                for (int i = N - kalan13; i <= 31; i = i + N)
                                {

                                    if ((year1 == year2) && (month1 == month2) && (i >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(i + "  january  " + year1 + " ");
                                        zeller(i, monthjan, year1);

                                    }
                                }
                                if ((year1 == year2) && (month2 == "janurary"))
                                    break; int kalan = (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N;//bu kısımlar bir sonraki ayın başlayacağı günü belirlemeye yardımcı olacak!!!

                                //tüm şubat kısımları için artık yıl durumunu göz önünde bulundur!!!!!

                                if ((year1 % 4 == 0) && (year1 % 100 != 0))
                                {
                                    for (int j = N - kalan; j <= 29; j = j + N)
                                    {
                                        int monthf = 2;
                                        if ((year1 == year2) && (month2 == "february") && (j >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(j + "  february  " + year1 + " ");
                                            zeller(j, monthf, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "february"))

                                        break; int kalan3 = (29 - (N - (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N;
                                    //MARCH
                                    Console.WriteLine("\nSpring");
                                    for (int k = N - kalan3; k <= 31; k = k + N)
                                    {
                                        int monthmarc = 3;
                                        if ((year1 == year2) && (month2 == "march") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  march  " + year1 + " ");
                                            zeller(k, monthmarc, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "march"))
                                        break; int kalan4 = (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N;
                                    //APRİL
                                    for (int k = N - kalan4; k <= 30; k = k + N)
                                    {
                                        int monthapr = 4;
                                        if ((year1 == year2) && (month2 == "april") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  april  " + year1 + " ");
                                            zeller(k, monthapr, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "april"))
                                        break; int kalan5 = (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N;
                                    //MAY
                                    for (int k = N - kalan5; k <= 31; k = k + N)

                                    {
                                        int monthmayx = 5;
                                        if ((year1 == year2) && (month2 == "may") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  may  " + year1 + " ");
                                            zeller(k, monthmayx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "may"))
                                        break; int kalan6 = (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //JUNE
                                    Console.WriteLine("\nSummer");
                                    for (int k = N - kalan6; k <= 30; k = k + N)

                                    {
                                        int monthjunex = 6;
                                        if ((year1 == year2) && (month2 == "june") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  june  " + year1 + " ");
                                            zeller(k, monthjunex, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "june"))
                                        break; int kalan7 = (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //JULY
                                    for (int k = N - kalan7; k <= 31; k = k + N)

                                    {
                                        int monthjulyx = 7;
                                        if ((year1 == year2) && (month2 == "july") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  july  " + year1 + " ");
                                            zeller(k, monthjulyx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "july"))
                                        break; int kalan8 = (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //AUGUST
                                    for (int k = N - kalan8; k <= 31; k = k + N)

                                    {
                                        int monthaux = 8;
                                        if ((year1 == year2) && (month2 == "august") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  august  " + year1 + " ");
                                            zeller(k, monthaux, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "august"))
                                        break; int kalan9 = (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //SEPTEMBER
                                    Console.WriteLine("\nAutumn");
                                    for (int k = N - kalan9; k <= 30; k = k + N)

                                    {
                                        int monthsepx = 9;
                                        if ((year1 == year2) && (month2 == "september") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  september  " + year1 + " ");
                                            zeller(k, monthsepx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "september"))
                                        break; int kalan10 = (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //OCTOBER
                                    for (int k = N - kalan10; k <= 31; k = k + N)

                                    {
                                        int monthoctx = 10;
                                        if ((year1 == year2) && (month2 == "october") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  october  " + year1 + " ");
                                            zeller(k, monthoctx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "october"))
                                        break; int kalan11 = (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    day1 = N - kalan11;


                                }


                                else
                                {//şubatın özel durumundan iki farklı işleyiş
                                    for (int j = N - kalan; j <= 28; j = j + N)
                                    {
                                        int monthf = 2;
                                        if ((year1 == year2) && (month2 == "february") && (j >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(j + "  february  " + year1 + " ");
                                            zeller(j, monthf, year1);
                                            // yalnızca döngüde ikinci tarihte nasıl duracağını hatırlatmak için yazıldı!!SİLİNECEK
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "february"))
                                        break;

                                    int kalan3 = (28 - (N - (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N;


                                    //MARCH
                                    Console.WriteLine("\nSpring");
                                    for (int k = N - kalan3; k <= 31; k = k + N)
                                    {
                                        int monthmarc = 3;
                                        if ((year1 == year2) && (month2 == "march") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {
                                            Console.Write(k + "  march  " + year1 + " ");
                                            zeller(k, monthmarc, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "march"))
                                        break; int kalan4 = (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N;
                                    //APRİL
                                    for (int k = N - kalan4; k <= 30; k = k + N)
                                    {
                                        int monthapr = 4;
                                        if ((year1 == year2) && (month2 == "april") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  april  " + year1 + " ");
                                            zeller(k, monthapr, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "april"))
                                        break; int kalan5 = (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N;
                                    //MAY
                                    for (int k = N - kalan5; k <= 31; k = k + N)

                                    {
                                        int monthmayx = 5;
                                        if ((year1 == year2) && (month2 == "may") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  may  " + year1 + " ");
                                            zeller(k, monthmayx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "may"))
                                        break; int kalan6 = (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //JUNE
                                    Console.WriteLine("\nSummer");
                                    for (int k = N - kalan6; k <= 30; k = k + N)

                                    {
                                        int monthjunex = 7;
                                        if ((year1 == year2) && (month2 == "june") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  june  " + year1 + " ");
                                            zeller(k, monthjunex, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "june"))
                                        break; int kalan7 = (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //JULY
                                    for (int k = N - kalan7; k <= 31; k = k + N)

                                    {
                                        int monthjulyx = 7;
                                        if ((year1 == year2) && (month2 == "july") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  july  " + year1 + " ");
                                            zeller(k, monthjulyx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "july"))
                                        break; int kalan8 = (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //AUGUST
                                    for (int k = N - kalan8; k <= 31; k = k + N)

                                    {
                                        int monthaux = 8;
                                        if ((year1 == year2) && (month2 == "august") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  august  " + year1 + " ");
                                            zeller(k, monthaux, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "august"))
                                        break; int kalan9 = (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //SEPTEMBER
                                    Console.WriteLine("\nAutumn");
                                    for (int k = N - kalan9; k <= 30; k = k + N)

                                    {
                                        int monthsepx = 9;
                                        if ((year1 == year2) && (month2 == "september") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  september  " + year1 + " ");
                                            zeller(k, monthsepx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "september"))
                                        break; int kalan10 = (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //OCTOBER
                                    for (int k = N - kalan10; k <= 31; k = k + N)

                                    {
                                        int monthoctx = 10;
                                        if ((year1 == year2) && (month2 == "october") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  october  " + year1 + " ");
                                            zeller(k, monthoctx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "october"))
                                        break; int kalan11 = (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - (N - (30 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;

                                    day1 = N - kalan11;


                                }


                            }
                            break;
                        //girilen ilk tarih aralıksa
                        case "december"://CASELERİ HATIRLAMAK BULMAK İÇİN11111111111111111111111111111111111

                            while (year1 <= year2)
                            {    //DECEMBER
                                Console.WriteLine("\nWinter");
                                for (int k = day1; k <= 31; k = k + N)

                                {
                                    int monthdecx = 12;
                                    if ((year1 == year2) && (month2 == "december") && (k >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(k + "  december  " + year1 + " ");
                                        zeller(k, monthdecx, year1);
                                    }
                                }
                                if ((year1 == year2) && (month2 == "december"))
                                    break; int kalan13 = (31 - day1) % N;
                                year1++;

                                int monthjan = 1;

                                for (int i = N - kalan13; i <= 31; i = i + N)
                                {

                                    if ((year1 == year2) && (month1 == month2) && (i >= day2 + 1))
                                    {
                                        Console.WriteLine(".");
                                        break;
                                    }
                                    else
                                    {

                                        Console.Write(i + "  january  " + year1 + " ");
                                        zeller(i, monthjan, year1);

                                    }
                                }
                                if ((year1 == year2) && (month2 == "janurary"))
                                    break; int kalan = (31 - (N - (31 - day1) % N)) % N;//bu kısımlar bir sonraki ayın başlayacağı günü belirlemeye yardımcı olacak!!!

                                //tüm şubat kısımları için artık yıl durumunu göz önünde bulundur!!!!!

                                if ((year1 % 4 == 0) && (year1 % 100 != 0))
                                {
                                    for (int j = N - kalan; j <= 29; j = j + N)
                                    {
                                        int monthf = 2;
                                        if ((year1 == year2) && (month2 == "february") && (j >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(j + "  february  " + year1 + " ");
                                            zeller(j, monthf, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "february"))

                                        break; int kalan3 = (29 - (N - (31 - (N - (31 - day1) % N)) % N)) % N;
                                    //MARCH
                                    Console.WriteLine("\nSpring");
                                    for (int k = N - kalan3; k <= 31; k = k + N)
                                    {
                                        int monthmarc = 3;
                                        if ((year1 == year2) && (month2 == "march") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  march  " + year1 + " ");
                                            zeller(k, monthmarc, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "march"))
                                        break; int kalan4 = (31 - (N - (29 - (N - (31 - (N - (31 - day1) % N)) % N)) % N)) % N;
                                    //APRİL
                                    for (int k = N - kalan4; k <= 30; k = k + N)
                                    {
                                        int monthapr = 4;
                                        if ((year1 == year2) && (month2 == "april") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  april  " + year1 + " ");
                                            zeller(k, monthapr, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "april"))
                                        break; int kalan5 = (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N;
                                    //MAY
                                    for (int k = N - kalan5; k <= 31; k = k + N)

                                    {
                                        int monthmayx = 5;
                                        if ((year1 == year2) && (month2 == "may") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  may  " + year1 + " ");
                                            zeller(k, monthmayx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "may"))
                                        break; int kalan6 = (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N;
                                    //JUNE
                                    Console.WriteLine("\nSummer");
                                    for (int k = N - kalan6; k <= 30; k = k + N)

                                    {
                                        int monthjunex = 6;
                                        if ((year1 == year2) && (month2 == "june") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  june  " + year1 + " ");
                                            zeller(k, monthjunex, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "june"))
                                        break; int kalan7 = (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //JULY
                                    for (int k = N - kalan7; k <= 31; k = k + N)

                                    {
                                        int monthjulyx = 7;
                                        if ((year1 == year2) && (month2 == "july") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  july  " + year1 + " ");
                                            zeller(k, monthjulyx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "july"))
                                        break; int kalan8 = (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //AUGUST
                                    for (int k = N - kalan8; k <= 31; k = k + N)

                                    {
                                        int monthaux = 8;
                                        if ((year1 == year2) && (month2 == "august") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  august  " + year1 + " ");
                                            zeller(k, monthaux, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "august"))
                                        break; int kalan9 = (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //SEPTEMBER
                                    Console.WriteLine("\nAutumn");
                                    for (int k = N - kalan9; k <= 30; k = k + N)

                                    {
                                        int monthsepx = 9;
                                        if ((year1 == year2) && (month2 == "september") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  september  " + year1 + " ");
                                            zeller(k, monthsepx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "september"))
                                        break; int kalan10 = (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //OCTOBER
                                    for (int k = N - kalan10; k <= 31; k = k + N)

                                    {
                                        int monthoctx = 10;
                                        if ((year1 == year2) && (month2 == "october") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  october  " + year1 + " ");
                                            zeller(k, monthoctx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "october"))
                                        break; int kalan11 = (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //NOVEMBER
                                    for (int k = N - kalan11; k <= 30; k = k + N)

                                    {
                                        int monthnovx = 11;
                                        if ((year1 == year2) && (month2 == "november") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  november  " + year1 + " ");
                                            zeller(k, monthnovx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "november"))
                                        break; int kalan12 = (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (29 - (N - (31 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    day1 = N - kalan12;


                                }


                                else
                                {//şubatın özel durumundan iki farklı işleyiş
                                    for (int j = N - kalan; j <= 28; j = j + N)
                                    {
                                        int monthf = 2;
                                        if ((year1 == year2) && (month2 == "february") && (j >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(j + "  february  " + year1 + " ");
                                            zeller(j, monthf, year1);
                                            // yalnızca döngüde ikinci tarihte nasıl duracağını hatırlatmak için yazıldı!!SİLİNECEK
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "february"))
                                        break;

                                    int kalan3 = (28 - (N - (31 - (N - (31 - day1) % N)) % N)) % N;


                                    //MARCH
                                    Console.WriteLine("\nSpring");
                                    for (int k = N - kalan3; k <= 31; k = k + N)
                                    {
                                        int monthmarc = 3;
                                        if ((year1 == year2) && (month2 == "march") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {
                                            Console.Write(k + "  march  " + year1 + " ");
                                            zeller(k, monthmarc, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "march"))
                                        break; int kalan4 = (31 - (N - (28 - (N - (31 - (N - (31 - day1) % N)) % N)) % N)) % N;
                                    //APRİL
                                    for (int k = N - kalan4; k <= 30; k = k + N)
                                    {
                                        int monthapr = 4;
                                        if ((year1 == year2) && (month2 == "april") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  april  " + year1 + " ");
                                            zeller(k, monthapr, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "april"))
                                        break; int kalan5 = (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N;
                                    //MAY
                                    for (int k = N - kalan5; k <= 31; k = k + N)

                                    {
                                        int monthmayx = 5;
                                        if ((year1 == year2) && (month2 == "may") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  may  " + year1 + " ");
                                            zeller(k, monthmayx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "may"))
                                        break; int kalan6 = (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N;
                                    //JUNE
                                    Console.WriteLine("\nSummer");
                                    for (int k = N - kalan6; k <= 30; k = k + N)

                                    {
                                        int monthjunex = 7;
                                        if ((year1 == year2) && (month2 == "june") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  june  " + year1 + " ");
                                            zeller(k, monthjunex, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "june"))
                                        break; int kalan7 = (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //JULY
                                    for (int k = N - kalan7; k <= 31; k = k + N)

                                    {
                                        int monthjulyx = 7;
                                        if ((year1 == year2) && (month2 == "july") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  july  " + year1 + " ");
                                            zeller(k, monthjulyx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "july"))
                                        break; int kalan8 = (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //AUGUST
                                    for (int k = N - kalan8; k <= 31; k = k + N)

                                    {
                                        int monthaux = 8;
                                        if ((year1 == year2) && (month2 == "august") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  august  " + year1 + " ");
                                            zeller(k, monthaux, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "august"))
                                        break; int kalan9 = (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //SEPTEMBER
                                    Console.WriteLine("\nAutumn");
                                    for (int k = N - kalan9; k <= 30; k = k + N)

                                    {
                                        int monthsepx = 9;
                                        if ((year1 == year2) && (month2 == "september") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  september  " + year1 + " ");
                                            zeller(k, monthsepx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "september"))
                                        break; int kalan10 = (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //OCTOBER
                                    for (int k = N - kalan10; k <= 31; k = k + N)

                                    {
                                        int monthoctx = 10;
                                        if ((year1 == year2) && (month2 == "october") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  october  " + year1 + " ");
                                            zeller(k, monthoctx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "october"))
                                        break; int kalan11 = (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;
                                    //NOVEMBER
                                    for (int k = N - kalan11; k <= 30; k = k + N)

                                    {
                                        int monthnovx = 11;
                                        if ((year1 == year2) && (month2 == "november") && (k >= day2 + 1))
                                        {
                                            Console.WriteLine(".");
                                            break;
                                        }
                                        else
                                        {

                                            Console.Write(k + "  november  " + year1 + " ");
                                            zeller(k, monthnovx, year1);
                                        }
                                    }
                                    if ((year1 == year2) && (month2 == "november"))
                                        break; int kalan12 = (30 - (N - (31 - (N - (30 - (N - (31 - (N - (31 - (N - (30 - (N - (31 - (N - (30 - (N - (31 - (N - (28 - (N - (31 - (N - (31 - day1) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N)) % N;

                                    day1 = N - kalan12;


                                }


                            }
                            break;
                    }



                    } catch
                {
                    Console.WriteLine("wrong format");
                    flag = true;
                }
            } while (flag == true);


        } 
                public static void zeller(int day, int month, int year)//haftanın gününü hesaplamak için fonksiyon!!formülde aylar 3'ten 14 'e
        {
            if (month == 1)//zellerde ocak; önceki yılın 13. ayı gibi. yıl-1
            {
                year --;
                month = 13;

            }
            if (month == 2)//zellerde şubat; önceki yılın 14.ayı gibi. yıl -1
            {
                year --;
                month = 14;

            }
            int q = day;
            int m = month;
            int k = year % 100;
            int j = year / 100;
            int h = q + 13 * (m + 1) / 5 + k + k / 4
                                     + j / 4 + 5 * j;
            h = h % 7;
            switch (h)
            {
                case 0:
                    Console.WriteLine("Saturday");
                    break;
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
            }
        }
    }
}
    

