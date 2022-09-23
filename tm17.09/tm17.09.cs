struct Bank
{
    public string type;
    public int number;
    public string balance;
    public Bank(int Number, string Type, string Balance)
    {
        this.number = Number;
        this.type = Type;
        this.balance = Balance;
    }
    public void Print()
    {
        Console.WriteLine($"Номер: {number}, Тип: {type}, Баланс: {balance}");
    }
}
enum Types
{
    Текущий,
    Сберегательный
}
struct Student
{
    public string name;
    public int vuz;

    public Student(string Name, int Vuz)
    {
        this.name = Name;
        this.vuz = Vuz;
    }
    public void Print1()
    {
        Console.WriteLine($"Имя: {name}, Вуз: {vuz}");
    }
}
enum Sharaga
{
    kai,
    kgu,
    khti
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Задание 3.1");
        foreach (Types credit in Enum.GetValues(typeof(Types)))//
        {
            Console.WriteLine("Кредит - {0}, Номер - {1}", credit, (int)credit);
        }
        Console.WriteLine("Задание 3.2");
        Bank info = new Bank(345557, "Сберегательный", "100$");
        info.Print();

        Console.WriteLine("ДЗ 3.1");
        Student st1 = new Student("Федор Достоевский", (int)Sharaga.kgu);
        st1.Print1();
        Student st2 = new Student("Максим Горький", (int)Sharaga.khti);
        st2.Print1();
        Student st3 = new Student("Александр Пушкин", (int)Sharaga.kai);
        st3.Print1();
        Console.WriteLine("0 - КАИ,1 = КГУ,2 - КХТИ");
        Console.ReadKey();
    }
}