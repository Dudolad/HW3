namespace Ex21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //21.Дано рядок, що складається зі слів, розділених символами,
            //которі перераховані в дргому рядку. Показати всі слова.
            string text = "привіт,як-справи?";

            string separators = ",-?";

            List<string> words = new List<string>();
            string current = "";

            foreach (char c in text)
            {
                if (separators.Contains(c))
                {
                    if (current.Length > 0)
                    {
                        words.Add(current);
                        current = "";
                    }
                }
                else
                {
                    current += c;
                }
            }

            if (current.Length > 0)
                words.Add(current);

            foreach (string w in words)
                Console.WriteLine(w);
            Console.ReadKey();
        }
    }
}
