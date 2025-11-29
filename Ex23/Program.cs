namespace Ex23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //23.Даний текст.Знайти суму наявних в ньому цифр.
            string text = "a1b2c3";
            int sum = 0;

            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    sum += c - '0';
                }
            }

            Console.WriteLine($"Сума всіх цифр: {sum}");
            Console.ReadKey();
        }
    }
}
