namespace Ex23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //23.Даний текст.Знайти суму наявних в ньому цифр.
            string s = "a1b2c3";
            char[] arr = s.ToCharArray();

            int sum = 0;

            foreach (char c in arr)
            {
                if (char.IsDigit(c))
                {
                    sum += c - '0'; 
                }
            }

            Console.WriteLine("Сума цифр: " + sum);
            Console.ReadKey();
        }
    }
}
