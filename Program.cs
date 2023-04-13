

using BookApp1.App.Services;

BookService Book = new BookService();


Console.WriteLine("0.Close app Please");
Console.WriteLine("1.Show book Please");
Console.WriteLine("2.Create book Please");

string aplication=Console.ReadLine();


while (aplication != "0")
{
    switch (aplication)
    {
        case "1":
            Book.GetFullInfo();
            break;
            case "2":
            Book.Createbooks();
            break;

        default:
            Console.WriteLine("If you don't mind, please enter right away");
            break;

    }
    Console.WriteLine("0.Close app Please");
    Console.WriteLine("1.Show book Please");
    Console.WriteLine("2.Create book Please");

    aplication = Console.ReadLine();
}
