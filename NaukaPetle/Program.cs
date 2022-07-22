//  WHILE    |  FOR  |    DO WHILE


// ctrl e+v duplikacja, ctrl + l usuwanie wiersza, ctrl r+r zmienne seryjnie, ctrl + k + d



//int a = 0;
//while (a < 5)
//{
//    Console.WriteLine(a);
//    Console.WriteLine("Tekst");
//    a++;
//}


//for (int b = 0 ; b < 5 ; b++ )
//{
//    Console.WriteLine(b);
//    Console.WriteLine("Tekst");



//do
//{
//    Console.WriteLine("Tekst");
//} 
//while (false);
//}





//Prostokat
//Console.WriteLine("Podaj szerokość: ");
//string xs = Console.ReadLine();
//Console.WriteLine("Podaj wysokość: ");
//string ys = Console.ReadLine();

//int x = int.Parse(xs);
//int y = int.Parse(ys);

//if (int.TryParse(xs, out var parsedInt))       //to jest zeby nie wywalilo exception gdy wpiszemy litere
//{

//}

//for (int i = 0; i < y; i++)
//{
//    for (int j = 0; j < x; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}




//Zgadnij liczbę
//    Random rnd = new Random();
//int los = rnd.Next(1, 11);

//int userNumber;
//    int howMany = 0;

//Console.WriteLine("Zgadnij liczbę z zakresu 1-10 ");
//do
//{

//    Console.Write("Podaj liczbę: ");
//    if (int.TryParse(Console.ReadLine(), out userNumber))
//    {
//        if (userNumber > 10 || userNumber < 1)

//        {
//            Console.WriteLine("Liczba z poza zakresu");
//        }
//        else
//        {
//            howMany++;
//            if (userNumber > los)
//            {
//                Console.WriteLine("Podałeś zbyt dużą liczbę! ");
//            }
//            else if (userNumber < los)
//            {
//                Console.WriteLine("Podałeś zbyt małą liczbę! ");
//            }
//            else
//            {
//                Console.ForegroundColor = ConsoleColor.Green;
//                Console.WriteLine("Brawo, odgadłeś moją liczbę!!! Za {0} razem ", howMany);
//            }
//        }
//    }
//    else
//    {
//        Console.WriteLine("Wprowadź liczbę, nie literę.");
//    }
//} while (los != userNumber);




// INSTRUKCJE SKOKU

//int a = 0;
//while (true)
//{
//    if(a > 10)
//    {
//        break;
//    }
//    Console.WriteLine(a);
//    a++;
//}


//int a = 0;

//for (int i = 0; i < 10; i++)
//{
//    if(i % 2 == 1)
//    {
//        continue;
//    }
//    Console.WriteLine(i);
//}


//int liczba;
//    liczba = int.Parse(Console.ReadLine());

//if(liczba == 1)
//{
//    Console.WriteLine("Jeden");
//}
//else if(liczba == 2)
//{
//    Console.WriteLine("Dwa");
//}
//else if(liczba == 3)
//    {
//    Console.WriteLine("Trzy");
//}
//else
//{
//    Console.WriteLine("Inna wartość");
//}


//switch(liczba)
//{
//    case 1:
//        Console.WriteLine("Jeden");
//        break;
//    case 2:
//        Console.WriteLine("Dwa");
//        break;
//    case 3:
//        Console.WriteLine("Trzy");
//        break;
//    default:
//        Console.WriteLine("Inna wartość");
//        break;
//}



// KALKULATOR


Console.WriteLine("Wybierz działanie, które chcesz wykonać wpisując odpowiadającą mu cyfre");

Console.WriteLine("1.Dodawanie");

Console.WriteLine("2.Odejmowanie");

Console.WriteLine("3.Mnożenie");

Console.WriteLine("4.Dzielenie");

Console.WriteLine("5.Zamknij aplikację kalkulator");

var x = Console.ReadKey();


switch (x.Key)
{
    case ConsoleKey.D1:
    case ConsoleKey.NumPad1:
        Console.WriteLine("Wybrałeś dodawanie ");
        break;

    case ConsoleKey.D2:
    case ConsoleKey.NumPad2:
        Console.WriteLine("Wybrałeś odejmowanie ");
        break;

    case ConsoleKey.D3:
    case ConsoleKey.NumPad3:
        Console.WriteLine("Wybrałeś mnożenie ");
        break;
    
    case ConsoleKey.D4:
    case ConsoleKey.NumPad4:
        Console.WriteLine("Wybrałeś dzielenie ");
        break; 
    
    case ConsoleKey.D5:
    case ConsoleKey.NumPad5:
        Console.WriteLine("Wybrałeś zamknięcie aplikacji ");
        Environment.Exit(0);
        break;
}

Console.Clear();

while (true)
{
    Console.WriteLine("Wprowadź pierwszą liczbę");
    string input = Console.ReadLine();

    Console.WriteLine("Wprowadź drugą liczbę");
    string input2 = Console.ReadLine();

    if (Int32.TryParse(input, out int pierwsza) && Int32.TryParse(input2, out int druga))
    {
        switch (x.Key)
        {
            case ConsoleKey.D1:
            case ConsoleKey.NumPad1:
                Console.WriteLine($"Wynik dodawania {pierwsza + druga}");
                break;

            case ConsoleKey.D2:
            case ConsoleKey.NumPad2:
                Console.WriteLine($"Wynik odejmowania {pierwsza - druga}");
                break;

            case ConsoleKey.D3:
            case ConsoleKey.NumPad3:
                Console.WriteLine($"Wynik mnożenia {pierwsza * druga}");
                break;

            case ConsoleKey.D4:
            case ConsoleKey.NumPad4:
                if(druga == 0)
                {
                    Console.WriteLine("Nie wolno dzielić przez 0");
                    break;
                }
                Console.WriteLine($"Wynik dzielenia {pierwsza / druga}");
                break;

            case ConsoleKey.D5:
            case ConsoleKey.NumPad5:
                Console.WriteLine("Wybrałeś zamknięcie aplikacji ");
                Environment.Exit(0);
                break;
        }

        break;
    }
    else
        Console.WriteLine("Wprowadź poprawne dane ");
}


















Console.ReadKey();




