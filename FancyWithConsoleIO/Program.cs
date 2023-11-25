// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;

Console.Clear();

string? userName = null;
string? userChoise = null;

while (userChoise != "/exit")
{
    if (userName == null)
    {
        Console.WriteLine("Welcome to Americana. Please make your selection " +
                          "Followed by the backslash sign now: /start, /help, /info, /exit");
    }
    else
    {
        Console.WriteLine($"Welcome " + userName + " to Americana. Please make your selection " +
                          "Followed by the backslash sign now: /start, /help, /info, /echo, /exit");
    }
    userChoise = Console.ReadLine();
    var switchOrder = userChoise.Substring(0, int.Min(userChoise.Length,6));
    switch (switchOrder.Trim())
    {
        case "/start":
            Console.WriteLine("Введите Ваше имя");
            userName = Console.ReadLine();
            break;
        case "/help":
            Console.WriteLine("Краткая справочная информация о том, как пользоваться программой.");
            break;
        case "/info":
            Console.WriteLine($"Версия ПО: 0.1"  + "\nДата создания: 25.11.2023");
            break;
        case "/echo":
            if ((userName != null)&&(userChoise.IndexOf(' ') > -1))
            {
                Console.WriteLine(userChoise.Substring(userChoise.IndexOf(' ')+1));
            }
            break;
        case "/exit":
            Console.WriteLine("C U");
            break;
        default:
            Console.WriteLine("Неизвестная команда");
            break;
    }
}

                  