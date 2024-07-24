using System;
namespace MyApplication
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            while (true)//infinte loop that runs the program until the user types "exit"
            {
                Console.WriteLine("Lütfen sınav puanınızı girin (Çıkmak için 'çık' yazın):");

                var Input = Console.ReadLine();//Get input

                if (Input.ToLower() == "çık")
                {
                    break;
                }

                if (int.TryParse(Input, out int Point))//Check if the input is a valid integer
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
        public static string CalculateGrade(int point)// This methot provides calculate the letter grade for point
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
}

