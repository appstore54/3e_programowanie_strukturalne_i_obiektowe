using System;

class Program
{
    static void Main()
    {
        //1
        {
            Console.WriteLine("Podaj współrzędną x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj współrzędną y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            if (x < 0 && y > 0)
                Console.WriteLine("Punkt znajduje się w pierwszej ćwiartce.");
            else if (x > 0 && y > 0)
                Console.WriteLine("Punkt znajduje się w drugiej ćwiartce.");
            else if (x < 0 && y < 0)
                Console.WriteLine("Punkt znajduje się w trzeciej ćwiartce.");
            else if (x > 0 && y < 0)
                Console.WriteLine("Punkt znajduje się w czwartej ćwiartce.");
            else if (x == 0 && y != 0)
                Console.WriteLine("Punkt znajduje się na osi Y.");
            else if (y == 0 && x != 0)
                Console.WriteLine("Punkt znajduje się na osi X.");
            else
                Console.WriteLine("Punkt znajduje się na początku układu współrzędnych.");
        }
        //2
        static void Zadanie2()
        {
            Console.WriteLine("Podaj długość boku a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj długość boku b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj długość boku c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Można skonstruować trójkąt.");
            }
            else
            {
                Console.WriteLine("Nie można skonstruować trójkąta.");
            }
        }

        //3

        {
            Console.WriteLine("Podaj numer PESEL: ");
            string pesel = Console.ReadLine();

            if (pesel.Length != 11)
            {
                Console.WriteLine("Niepoprawny numer PESEL.");
                return;
            }

            int year = int.Parse(pesel.Substring(0, 2));
            int month = int.Parse(pesel.Substring(2, 2));
            int day = int.Parse(pesel.Substring(4, 2));

            if (month > 20)
            {
                year += 2000;
                month -= 20;
            }
            else
            {
                year += 1900;
            }

            Console.WriteLine($"Data urodzenia: {day}-{month}-{year}");

            int genderDigit = int.Parse(pesel.Substring(9, 1));
            string gender = (genderDigit % 2 == 0) ? "Kobieta" : "Mężczyzna";
            Console.WriteLine($"Płeć: {gender}");
        }

        //4

        {
            Console.WriteLine("Podaj pierwszą liczbę: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wybierz operację: 1 - dodawanie, 2 - odejmowanie, 3 - mnożenie, 4 - dzielenie");
            int operacja = Convert.ToInt32(Console.ReadLine());

            switch (operacja)
            {
                case 1:
                    Console.WriteLine($"Wynik dodawania: {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"Wynik odejmowania: {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"Wynik mnożenia: {num1 * num2}");
                    break;
                case 4:
                    if (num2 != 0)
                        Console.WriteLine($"Wynik dzielenia: {num1 / num2}");
                    else
                        Console.WriteLine("Nie można dzielić przez zero.");
                    break;
                default:
                    Console.WriteLine("Niepoprawny wybór.");
                    break;
            }
        }

    }



}