Console.WriteLine("Введите Ваше имя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша") // позволяет включать все регистры
{
    Console.WriteLine("Ура, это Маша!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}