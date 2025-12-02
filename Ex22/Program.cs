namespace Ex22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //22.Даний текст.Знайдіть найбільшу кіькість ідучих підряд цифр.
            // Текст, у якому потрібно знайти максимальну серію цифр
            string s = "aaa1234bbb99cc5";
            char[] arr = s.ToCharArray();

            int maxLen = 0;
            int current = 0;

            foreach (char c in arr)
            {
                if (char.IsDigit(c))
                {
                    current++;
                    if (current > maxLen)
                        maxLen = current;
                }
                else
                {
                    current = 0;
                }
            }

            Console.WriteLine("Найбільша кількість цифр підряд: " + maxLen);
            Console.ReadKey();
        }
    }
}
