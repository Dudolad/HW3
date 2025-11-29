namespace Ex24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //24.Даний текст.Знайти слова, складені з цифр, і суму чисел, котрі утворюють ці слова.
            string text = "abc 123 def 55 x 9z 100";

            string[] parts = text.Split(' ');

            int total = 0;

            foreach (string p in parts)
            {
                bool allDigits = true;

                foreach (char c in p)
                {
                    if (!char.IsDigit(c))
                    {
                        allDigits = false;
                        break;
                    }
                }

                if (allDigits && p.Length > 0)
                {
                    Console.WriteLine($"Число знайдено: {p}");
                    total += int.Parse(p);
                }
            }

            Console.WriteLine($"Сума чисел =  {total}");
            Console.ReadKey();
        }
    }
}
