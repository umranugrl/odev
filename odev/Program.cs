soru7();

/* 1----------
 * 1- Switch case ile müşteriden alınan sipariş numarasına göre hangi ürünün sipariş edildiğini belirleyen algoritma yazınız.
 * Input için Scanner kullanınız
 * 
 *"Switch-case" ifadesi,Özellikle birden fazla koşula göre farklı işlemlerin yapılması gereken durumlarda tercih edilir.
 *Bu kontrol yapısı, programın bir değeri kontrol ederek, o değere göre belirli kod bloklarını çalıştırmasını sağlar.
*/
static void soru1()
{
    while (true)
    {
        Console.Write("Sipariş numarasını giriniz (101,102,..): ");
        string siparisNumarasi = Console.ReadLine();

        if (!int.TryParse(siparisNumarasi, out int num) || siparisNumarasi.Length != 3)
        //Kullanıcının girdisi bir tamsayı olup olmadığını kontrol ediyorum ve 3 basamaklı bir sayı olup olmadığını kontrol ediyorum. 
        //Eğer kullanıcının girdisi bir tamsayı değilse veya 3 basamaklı bir sayı değilse, if bloğunun içine girmesini sağlıyorum.
        {
            Console.WriteLine("Hatalı giriş! Lütfen 3 basamaklı bir sayı giriniz.");
            continue;
        }

        switch (num)
        {
            case 101:
                Console.WriteLine("Sipariş edilen ürün: Ayakkabı");
                break;
            case 102:
                Console.WriteLine("Sipariş edilen ürün: Bluz");
                break;
            case 103:
                Console.WriteLine("Sipariş edilen ürün: Ceket");
                break;
            case 104:
                Console.WriteLine("Sipariş edilen ürün: Bilgisayar");
                break;
            // Diğer ürünler için gerekli case'ler buradan eklenebilir.
            default:
                Console.WriteLine("Geçersiz sipariş numarası!");
                break;
        }
        break;
    }
}

/* 2----------
 * 2- kullanıcıdan kaç ürün almak istediğini soran,her ürünün fiyatını alarak toplam alışveriş tutarını 
 * hesaplayan bir algoritma yazınız.(Input için Scanner ve döngü için for döngüsü kullanınız)
 * 
 */
static void soru2()
{
    int urunSayisi;
    bool gecerliGiris = false;
    //Kullanıcının geçerli bir giriş yapması durumunda döngüyü sonlandırmak için bir bayrak tanımlıyorum. 
    //Başlangıçta geçerli giriş olmadığı için false değeri atadım.
    do
    {
        Console.Write("Kaç ürün almak istiyorsunuz? ");
        string giris = Console.ReadLine();

        if (int.TryParse(giris, out urunSayisi) && urunSayisi > 0)
        //Kullanıcının girdiği değerin bir tam sayı olup olmadığını kontrol ediyorum. 
        //Eğer geçerli bir tam sayı ise ve bu sayı 0'dan büyükse: gecerliGiris bayrağı true olarak atıyorum.
        {
            gecerliGiris = true;
        }
        else //değilse geçerli bir giriş yapılmasını istiyorum.
        {
            Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir tamsayı girin.");
        }
    } while (!gecerliGiris);//geçerli girişi kontrol eden döngüyü oluşturudum

    double toplamTutar = 0;

    for (int i = 1; i <= urunSayisi; i++)//Ürün fiyatlarını almak için bir döngü başlattım. 
                                         //Bu döngü, kullanıcının girdiği ürün sayısı kadar dönecek.
    {
        double urunFiyati;
        bool gecerliFiyatGirisi = false;
        //Her ürün fiyatı için kullanıcının geçerli bir giriş yapması durumunda döngüyü sonlandırmak için bir bayrak tanımladım.

        do
        {
            Console.Write($"Ürün {i} fiyatı (ÖrFiyat = 12,5...): ");
            string fiyatGirisi = Console.ReadLine();

            if (double.TryParse(fiyatGirisi, out urunFiyati) && urunFiyati > 0)
            //Kullanıcının girdiği değerin bir ondalık sayı olup olmadığını kontrol ediyorum. 
            //Eğer geçerli bir ondalık sayı ise ve bu sayı 0'dan büyükse: if bloğuna değilse, else bloğuna girecek
            {
                gecerliFiyatGirisi = true;
            }
            else
            {
                Console.WriteLine("Geçersiz fiyat girişi. Lütfen pozitif bir sayı girin.");
            }
        } while (!gecerliFiyatGirisi);

        toplamTutar += urunFiyati; //Geçerli bir fiyat girişi yapıldığında, bu fiyatı toplam tutara ekliyorum.
    }
    Console.WriteLine($"Toplam alışveriş tutarı: {toplamTutar} TL");//- Toplam alışveriş tutarını ekrana yazdırıyorum.
}

/* 3----------
 * 3- Do-While ve While döngüsü nedir? Bununla ilgili örnek yapınız.
 * 
//Do-While ve While döngüleri, programlarda tekrarlı işlemleri gerçekleştirmek için kullanılan kontrol yapılarıdır.

//Do-While döngüsü, döngü bloğunu en az bir kez çalıştıracak şekilde tasarlanmıştır. Döngü koşulu en son kontrol edilir. 
//Yani, koşul yanlış olsa bile döngü bloğu en az bir kez çalıştırılır.

//While döngüsü ise döngü bloğunu sadece koşul doğru olduğu sürece çalıştırır. Koşul her döngü başında kontrol edilir ve 
//koşul yanlış olduğunda döngü sonlanır.
*/
static void soru3()
{
    int i = 0;
    // While döngüsü
    Console.WriteLine("While döngüsü:");
    while (i < 5)
    {
        Console.WriteLine(i);
        i++;
    }

    i = 6; // bu döngüce en az bir kere döngüye giriyor
           // Do-While döngüsü
    Console.WriteLine("\nDo-While döngüsü:");
    do
    {
        Console.WriteLine(i);
        i++;
    } while (i < 5);
}

/* 4----------
 * 4-Kullanıcının 1 ile 10 arasında rastgele bir sayıyı tahmin etmesini isteyen ve doğru tahmin edene 
 * kadar devam eden bir program yazınız.(While döngüsü ile yapınız ve rastgele sayı üretmek için Random sınıfını kullanınız)
*/
static void soru4()
{
    Random random = new Random();// Random sınıfından bir nesne oluşturur. Bu nesne, rastgele sayılar üretmek için kullanılır.
    int hedefSayı = random.Next(1, 11); // 1 ile 10 arasında rastgele bir sayı seçelim
                                        //random nesnesi üzerinden Next metodunu çağırarak, 1 ile 10 arasında rastgele bir tamsayı seçer ve seçilen bu sayıyı hedefSayı değişkenine atar.
    int tahminSayısı = 0;

    while (true)//Kullanıcı doğru tahmini yapana kadar program bu döngü döner.
    {
        Console.Write("1 ile 10 arasında bir sayı tahmin edin: ");
        string tahminStr = Console.ReadLine();

        if (!int.TryParse(tahminStr, out int tahmin) || tahmin < 1 || tahmin > 10)
        //kullanıcının girişini doğrular. Eğer giriş bir tamsayı değilse veya girilen sayı 1 ile 10 arasında değilse, kullanıcıya geçersiz giriş yaptığını belirten bir mesaj gösterir ve döngünün başına geri döner.
        {
            Console.WriteLine("Geçersiz bir değer girdiniz. Lütfen 1 ile 10 arasında bir sayı girin.");
            continue;
        }

        tahminSayısı++;
        //doğru bir tahmin yapıldığında tahminSayısı değişkenini bir artırır. Bu, kaçıncı tahminde doğru tahmini yaptığımızı takip eder.

        if (tahmin == hedefSayı)
        //kullanıcının tahmininin hedef sayıya eşit olup olmadığını kontrol eder. Eğer doğru tahmin yapılmışsa, kullanıcıyı tebrik eder ve kaçıncı tahminde doğru tahmini yaptığını gösterir.
        {
            Console.WriteLine($"Tebrikler! {tahminSayısı}. tahminde doğru tahmin ettiniz!");
            break;
        }
        else
        {
            Console.WriteLine("Yanlış tahmin ettiniz. Tekrar deneyin.");
        }
    }
}

/* 5----------
 * 5- Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.
 * 
//Bir sayı, kendisi hariç pozitif tam bölenlerinin toplamına eşit olduğunda "mükemmel sayı" olarak adlandırılır. 
//Başka bir deyişle, bir sayının tüm pozitif bölenlerinin (kendisi hariç) toplamı, o sayıya eşitse, o sayı mükemmel sayıdır.

//Örneğin, 6 sayısı mükemmel bir sayıdır çünkü 6'nın bölenleri (1, 2, 3) toplamı 6'ya eşittir:
//1 + 2 + 3 = 6

//Ancak, örneğin 28 sayısı da mükemmel bir sayıdır:
//1 + 2 + 4 + 7 + 14 = 28
*/
static void soru5()
{
    bool gecerliGiris = false;
    int sayi = 0;

    while (!gecerliGiris)
    {
        Console.WriteLine("Bir sayı girin: ");
        string giris = Console.ReadLine();

        // Girdinin geçerli bir tam sayı olup olmadığını kontrol etme
        if (!int.TryParse(giris, out sayi) || sayi <= 0)
        {
            Console.WriteLine("Geçersiz giriş! Lütfen pozitif bir tam sayı girin.");
        }
        else
        {
            gecerliGiris = true;
        }
    }

    if (MukemmelSayiMi(sayi))
    {
        Console.WriteLine(sayi + " mükemmel bir sayıdır.");
    }
    else
    {
        Console.WriteLine(sayi + " mükemmel bir sayı değildir.");
    }

    // Mükemmel sayıyı kontrol eden fonksiyon
    static bool MukemmelSayiMi(int numara)
    { // MukemmelSayiMi fonksiyonu 
        int toplam = 0; //numara parametresinin pozitif bölenlerinin toplamını 
        for (int i = 1; i <= numara / 2; i++) //1'den numara / 2'ye kadar olan sayıları döngüyle kontrol eder. Çünkü bir sayının pozitif bölenleri en fazla kendisinin yarısına kadar
        {
            if (numara % i == 0) // numara'nın i'ye bölümünden kalan sıfır ise, i sayısının numara'nın bir böleni olduğu kontrol 
            {
                toplam += i; //Eğer i, numara'nın bir böleniyse, toplam değişkenine i eklenir. Böylece, toplam değişkeni numara'nın pozitif bölenlerinin toplamını tutmuş olur
            }
        }
        return toplam == numara;
        //numara'nın pozitif bölenlerinin toplamı numara'ya eşitse, fonksiyon true döndürür; aksi halde false döndürür.
    }
}

/* 6----------
 * 6- String metotlarını araştırınız. Her bir metot için örnek yapınız.
 * 
 * String sınıfı, .NET platformunda metin işleme işlevselliği sağlar. Bir dizi karakterin (Unicode karakterler dahil) sıralı bir 
 * koleksiyonunu temsil eder.
 * Bazı yaygın kullanılanları şunlardır:
*/
static void soru6()
{
    //Length: Bir dizenin uzunluğunu(karakter sayısını) alır.
    string str = "Hello";
    int length = str.Length; // length = 5
    Console.WriteLine(length);

    //IndexOf(): Belirli bir karakter veya alt dizenin dizindeki ilk konumunu döndürür.
    string str2 = "Hello World";
    int index = str2.IndexOf('W'); // index = 6
    Console.WriteLine(index);

    //Substring(): Dizeden belirli bir alt dizeyi alır.
    string str3 = "Hello World";
    string substr = str3.Substring(6); // substr = "World"
    Console.WriteLine(substr);

    //ToUpper() ve ToLower(): Dizideki tüm karakterleri büyük harfe veya küçük harfe dönüştürür.
    string str4 = "Hello";
    string upper = str4.ToUpper(); // upper = "HELLO"
    string lower = str4.ToLower(); // lower = "hello"
    Console.WriteLine(upper);
    Console.WriteLine(lower);

    //Replace(): Belirli bir alt dizeyi başka bir alt dizeyle değiştirir.
    string str5 = "Hello World";
    string replaced = str5.Replace("World", "Universe"); // replaced = "Hello Universe"
    Console.WriteLine(replaced);

    //Split(): Diziyi belirli bir ayraç veya karakterlerle bölerek alt dizelerin bir dizisini döndürür.
    string str6 = "apple,banana,orange";
    string[] fruits = str6.Split(','); // fruits = ["apple", "banana", "orange"]

    //Concat(): Birden çok dizeyi birleştirir.
    string str7 = "Hello";
    string str8 = "World";
    string result = string.Concat(str7, " ", str8); // result = "Hello World"
    Console.WriteLine(result);
}

/* 7----------
 * - kullanıcıdan öğrenci sayısını isteyen her öğrenci için öğrenci adı,öğrenci soyadı,1.sınav notu,
 * 2.sınav notu,3.sınav notu isteyen ve daha sonra not ortalamasını hesaplayıp ekrana yazdıran algoritma yapınız.(For döngüsü kullanınız)
 * 
*/
static void soru7()
{
    int ogrenciSayisi;
    while (true)
    { //Sonsuz bir döngü başlatılır. Bu döngü, kullanıcı geçerli bir öğrenci sayısı girene kadar devam eder.
        Console.WriteLine("Öğrenci sayısını giriniz:");
        string ogrenciSayisiStr = Console.ReadLine();

        if (!int.TryParse(ogrenciSayisiStr, out ogrenciSayisi) || ogrenciSayisi <= 0)
        {
            Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir tamsayı girin.");
        }
        else
        {
            break; //Doğru bir öğrenci sayısı girildiğinde sonsuz döngüden çıkılır.
        }
    }

    for (int i = 1; i <= ogrenciSayisi; i++)
    {//Öğrenci sayısına göre bir döngü başlatılır. Her döngü iterasyonunda bir öğrencinin bilgileri alınacaktır.
        string adSoyad;
        while (true)
        {
            Console.WriteLine($"\n{i}. öğrencinin adını ve soyadını giriniz (örn: Ahmet Yılmaz):");
            adSoyad = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(adSoyad) || !adSoyad.Contains(" "))
            {
                //Kullanıcının girdiği ad ve soyad, boş olup olmadığı veya bir boşluk içerip içermediği kontrol edilir.
                Console.WriteLine("Geçersiz giriş. Lütfen adınızı ve soyadınızı boşlukla ayırarak girin.");
            }
            else
            {
                string[] adSoyadParts = adSoyad.Split(' ');
                //Kullanıcının girdiği ad ve soyad boşluk karakterine göre ayrılır ve iki parçaya ayrılan ad ve soyad bilgisi bir diziye atanır.
                if (adSoyadParts.Length != 2 || adSoyadParts.Any(s => s.Any(char.IsDigit)))
                {
                    // Dizi uzunluğu kontrol edilir ve ad veya soyadın herhangi birinin rakam içerip içermediği kontrol edilir.
                    Console.WriteLine("Geçersiz giriş. Lütfen geçerli bir ad ve soyad girin.");
                }
                else
                {
                    break;
                }
            }
        }

        double not1 = 0, not2 = 0, not3 = 0;
        bool validGrades = false; //Geçerli sınav notlarını almak için bir bayrak değişkeni tanımlanır.
        while (!validGrades)
        { //Geçerli sınav notları alınana kadar sonsuz bir döngü başlatılır.
            Console.WriteLine($"{i}. öğrencinin 1. sınav notunu giriniz:");
            string not1Str = Console.ReadLine();

            if (!double.TryParse(not1Str, out not1))
            {
                // Kullanıcının girdiği metin, double türüne dönüştürülmeye çalışılır. Eğer dönüşüm başarısız olursa, hata mesajı verilir ve 
                //döngü tekrar başlar. İkinci ve üçüncü sınav notları için aynı işlemler tekrarlanır.
                            Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin.");
                continue;
            }

            while (true)
            {
                Console.WriteLine($"{i}. öğrencinin 2. sınav notunu giriniz:");
                string not2Str = Console.ReadLine();
                if (!double.TryParse(not2Str, out not2))
                {
                    Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin.");
                    continue;
                }
                else
                {
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine($"{i}. öğrencinin 3. sınav notunu giriniz:");
                string not3Str = Console.ReadLine();

                if (!double.TryParse(not3Str, out not3))
                {
                    Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin.");
                    continue;
                }
                else
                {
                    break;
                }
            }
            validGrades = true;
        }

        double ortalama = (not1 + not2 + not3) / 3;
        Console.WriteLine($"{i}. öğrencinin not ortalaması: {ortalama.ToString("F3")}");
        // Öğrencinin not ortalaması ekrana yazdırılır. Ondalık kısmı üç basamakla sınırlamak için ToString("F3") metodu kullanılır.
    }
}