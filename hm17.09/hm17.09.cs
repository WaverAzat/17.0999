using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1 про пьющих студентов");
            Console.WriteLine("Студент 1 Хакимов Инсаф №1 29.03.2004");
            Console.WriteLine("Введите категорию алкоголизма студента №1");
            string k1 = Console.ReadLine();
            switch (k1)
            {
                case "a":
                    Console.WriteLine("Он почти не стоит на ногах!!!");
                    break;
                case "b":
                    Console.WriteLine("Он пьяный!");
                    break;
                case "c":
                    Console.WriteLine("Он слегка пьян");
                    break;
                case "d":
                    Console.WriteLine("Пусть не врет!!!");
                    break;
            }
            Console.WriteLine("Студент 2 Садрутдинов Нияз №2 25.04.2004");
            Console.WriteLine("Введите категорию алкоголизма студента №2");
            string k2 = Console.ReadLine();
            switch (k2)
            {
                case "a":
                    Console.WriteLine("Он почти не стоит на ногах!!!");
                    break;
                case "b":
                    Console.WriteLine("Он пьяный!");
                    break;
                case "c":
                    Console.WriteLine("Он слегка пьян");
                    break;
                case "d":
                    Console.WriteLine("Пусть не врет!!!");
                    break;
            }
            Console.WriteLine("Студент 3 Латипов Зиннат №3 21.09.2004");
            Console.WriteLine("Введите категорию алкоголизма студента №3");
            string k3 = Console.ReadLine();
            switch (k3)
            {
                case "a":
                    Console.WriteLine("Он почти не стоит на ногах!!!");
                    break;
                case "b":
                    Console.WriteLine("Он пьяный!");
                    break;
                case "c":
                    Console.WriteLine("Он слегка пьян");
                    break;
                case "d":
                    Console.WriteLine("Пусть не врет!!!");
                    break;
            }
            Console.WriteLine("Студент 4 Каюмов Инсаф №4 22.03.2003");
            Console.WriteLine("Введите категорию алкоголизма студента №4");
            string k4 = Console.ReadLine();
            switch (k4)
            {
                case "a":
                    Console.WriteLine("Он почти не стоит на ногах!!!");
                    break;
                case "b":
                    Console.WriteLine("Он пьяный!");
                    break;
                case "c":
                    Console.WriteLine("Он слегка пьян");
                    break;
                case "d":
                    Console.WriteLine("Пусть не врет!!!");
                    break;
            }
            Console.WriteLine("Студент 5 Галявиев Риназ №5 10.11.2004");
            Console.WriteLine("Введите категорию алкоголизма студента №5");
            string k5 = Console.ReadLine();
            switch (k5)
            {
                case "a":
                    Console.WriteLine("Он почти не стоит на ногах!!!");
                    break;
                case "b":
                    Console.WriteLine("Он пьяный!");
                    break;
                case "c":
                    Console.WriteLine("Он слегка пьян");
                    break;
                case "d":
                    Console.WriteLine("Пусть не врет!!!");
                    break;
            }
            Console.WriteLine("А теперь честно сколько литров выпил студент №1?");
            string k11 = Console.ReadLine();
            int k111 = Convert.ToInt32(k11);
            Console.WriteLine("А теперь честно сколькол итров выпил студент №2?");
            string k22 = Console.ReadLine();
            int k222 = Convert.ToInt32(k22);
            Console.WriteLine("А теперь честно сколько литров выпил студент №3?");
            string k33 = Console.ReadLine();
            int k333 = Convert.ToInt32(k33);
            Console.WriteLine("А теперь честно сколько литров выпил студент №4?");
            string k44 = Console.ReadLine();
            int k444 = Convert.ToInt32(k44);
            Console.WriteLine("А теперь честно сколько литров выпил студент №5?");
            string k55 = Console.ReadLine();
            Console.WriteLine("Сколько всего литров выпили влкашки?");
            int k555 = Convert.ToInt32(k55);
            int alkashka = k111 + k222 + k333 + k444 + k555;
            Console.WriteLine(alkashka);
            Console.WriteLine("Список по процентам выпитого алкоголя по порядку идентификатора");
            var k1111 = ((double)k111 / alkashka) * 100;
            Console.WriteLine($"студент 1 {Math.Round(k1111, 2)}");
            var k2222 = ((double)k222 / alkashka) * 100;
            Console.WriteLine($"студент 2 {Math.Round(k2222, 2)}");
            var k3333 = ((double)k333 / alkashka) * 100;
            Console.WriteLine($"студент 3 {Math.Round(k3333, 2)}");
            var k4444 = ((double)k444 / alkashka) * 100;
            Console.WriteLine($"студент 4 {Math.Round(k4444, 2)}");
            var k5555 = ((double)k555 / alkashka) * 100;
            Console.WriteLine($"студент 5 {Math.Round(k5555, 2)}");
            Console.ReadKey();
            Console.WriteLine("Задание 2 Информация о типе данных");
            Console.WriteLine("byte  от 0 до 255 и занимает 1 байт");
            Console.WriteLine("sbyte от -128 до 127 и занимает 1 байт");
            Console.WriteLine("short от -32768 до 32767 и занимает 2 байта");
            Console.WriteLine("ushort от 0 до 65535 и занимает 2 байта.");
            Console.WriteLine("int от -2147483648 до 2147483647 и занимает 4 байта");
            Console.WriteLine("unit от 0 до 4294967295 и занимает 4 байта");
            Console.WriteLine("long –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт");
            Console.WriteLine("ulong от 0 до 18 446 744 073 709 551 615 и занимает 8 байт");
            Console.WriteLine("float число с плавающей точкой от -3.4*1038 до 3.4*1038 и занимает 4 байта");
            Console.WriteLine("double число с плавающей точкой от ±5.0*10-324 до ±1.7*10308 и занимает 8 байта");
            Console.WriteLine("decimal десятичное дробное число. Если употребляется без десятичной запятой, имеет значение от ±1.0*10-28 до ±7.9228*1028, может хранить 28 знаков после запятой и занимает 16 байт");
            Console.WriteLine("char одиночный символ в кодировке Unicode и занимает 2 байта");
            Console.WriteLine("string набор символов Unicode");
            Console.WriteLine("object значение любого типа данных и занимает 4 байта на 32-разрядной платформе и 8 байт на 64-разрядной платформе");
            Console.WriteLine("bool значение true или false (логические литералы)");
            Console.ReadKey();
            Console.WriteLine("Задание 3 Данные пользователя");
            Console.WriteLine("Введите имя пользователя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите название города");
            string city = Console.ReadLine();
            Console.WriteLine("Введите возраст пользователя");
            string age = Console.ReadLine();
            int age1 = Convert.ToInt32(age);
            Console.WriteLine("Введите PIN-код пользователя");
            string pin = Console.ReadLine();
            int pin1 = Convert.ToInt32(pin);
            Console.WriteLine($"Имя: {name} Город: {city} Возраст: {age1} Pin: {pin1}");
            Console.ReadKey();
            Console.WriteLine("Задание 4 Инициалы");
            Console.WriteLine("Введите ваше имя и фамилию");
            string[] inisial = Console.ReadLine().Split(' ');
            Console.WriteLine($"{inisial[0][0].ToString().ToUpper()}.{inisial[1][0].ToString().ToUpper()}");//Toupper с строчных в прописные
            Console.ReadKey();
            Console.WriteLine("Задание 5 Бухлишко");
            Console.WriteLine("Какова стандартная цена виски в КБ в фунтах стерлинга?");
            string normprice = Console.ReadLine();
            int normprice1 = Convert.ToInt32(normprice);
            Console.WriteLine("Какова скидка в Duty Free?");
            string saleprice = Console.ReadLine();
            int saleprice1 = Convert.ToInt32(saleprice);
            Console.WriteLine("Какова стоимость отпуска в фунтах стерлинга?");
            string holidayPrice = Console.ReadLine();
            int holidayPrice1 = Convert.ToInt32(holidayPrice);
            var kupili = ((double)saleprice1 / 100) * normprice1;
            var bottle = (double)holidayPrice1 / kupili;
            Console.WriteLine($"потребуется купить бутылок - {Math.Floor(bottle)}");//math.floor округление в меньшую сторону
            Console.ReadKey();
            Console.WriteLine("Задание 6 Перевод таракана");
            Console.WriteLine("Введите скорость таракана в км/ч");
            var v = Console.ReadLine();
            double v1 = Convert.ToDouble(v);
            double v2 = 27.78;
            double v3 = v1 * v2;
            Console.WriteLine($"{Math.Floor(v3)}");
            Console.ReadKey();
            Console.WriteLine("Задание 7 Преобразование букв");
            string stroka = Console.ReadLine();
            StringBuilder konsym = new StringBuilder();//<имя_класса> <имя_переменной> = new <конструктор_класса>
            foreach (Char c in stroka.ToCharArray())// foreach выполняет для каждого элемента
            {
                if (Char.IsLower(c))
                {
                    konsym.Append(Char.ToUpper(c));//append добавляет подстроку в обьект StringBuilder
                }
                else
                {
                    konsym.Append(Char.ToLower(c));
                }
            }
            Console.WriteLine(konsym);
            Console.ReadKey();
        }
    }
}