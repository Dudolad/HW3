namespace Ex19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //19.Знайдіть кількість входжень 'aba' в рядок.
            string s = "ababaabaababa";

            char[] arr = s.ToCharArray();

            int count = 0;

            for (int i = 0; i < arr.Length - 2; i++)
            {
                if (arr[i] == 'a' && arr[i + 1] == 'b' && arr[i + 2] == 'a')
                {
                    count++;
                }
            }

            Console.WriteLine("Кількість входжень 'aba': " + count);
            Console.ReadKey();
        }
    }
}
