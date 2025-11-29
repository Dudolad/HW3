namespace Ex22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //22.Даний текст.Знайдіть найбільшу кіькість ідучих підряд цифр.
            // Текст, у якому потрібно знайти максимальну серію цифр
            string text = "aaa1234bbb99cc5";

            int max = 0;      
            int current = 0;  

            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    current++;              
                    if (current > max)
                        max = current;      
                }
                else
                {
                    current = 0;            
                }
            }

            Console.WriteLine($"Максимальна кількість цифр підряд: {max} ");
            Console.ReadKey();
        }
    }
}
