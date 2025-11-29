namespace Ex19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //19.Знайдіть кількість входжень 'aba' в рядок.
            string text = "ababaaba";
            string find = "aba";

            int count = 0;

            for (int i = 0; i <= text.Length - find.Length;)
            {
                if (text.Substring(i, find.Length) == find)
                {
                    count++;
                    i += find.Length; 
                }
                else
                {
                    i++; 
                }
            }

            Console.WriteLine($"Кількість входжень 'aba': {count}");
            Console.ReadKey();
        }
    }
}
