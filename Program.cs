using System;

class Calculator
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Lütfen sınav puanınızı girin (Çıkmak için 'çık' yazın):");

            var input = Console.ReadLine();

            if (input.ToLower() == "çık")
            {
                break;
            }

            if (int.TryParse(input, out int Point))
            {
                if (Point >= 0 && Point <= 100)
                {
                    var Grade = CalculateGrade(Point);
                    Console.WriteLine($"Sınav puanınız: {Point}, Harf notunuz: {Grade}");
                }
                else
                {
                    Console.WriteLine("Lütfen 0 ile 100 arasında bir değer girin.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz bir değer girdiniz. Lütfen bir sayı girin.");
            }
        }
    }
    static string CalculateGrade(int point)
    {
        if (point >= 90 && point <= 100)
        {
            return "A";
        }
        else if (point >= 80 && point <= 89)
        {
            return "B";
        }
        else if (point >= 70 && point <= 79)
        {
            return "C";
        }
        else if (point >= 60 && point <= 69)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }
}
