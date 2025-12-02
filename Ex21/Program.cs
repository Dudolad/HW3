namespace Ex21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //21.Дано рядок, що складається зі слів, розділених символами,
            //которі перераховані в дргому рядку. Показати всі слова.
            string text = "hello,world;this.is:test";
            string separators = ",;.:";
            char[] sepArr = separators.ToCharArray();
            char[] arr = text.ToCharArray();

            List<string> words = new List<string>();
            List<char> currentWord = new List<char>();

            foreach (char c in arr)
            {
                bool isSeparator = false;

                foreach (char s in sepArr)
                {
                    if (c == s)
                    {
                        isSeparator = true;
                        break;
                    }
                }

                if (isSeparator)
                {
                    if (currentWord.Count > 0)
                    {
                        words.Add(new string(currentWord.ToArray()));
                        currentWord.Clear();
                    }
                }
                else
                {
                    currentWord.Add(c);
                }
            }

            if (currentWord.Count > 0)
                words.Add(new string(currentWord.ToArray()));

            foreach (string w in words)
            {
                Console.WriteLine(w);
            }
            Console.ReadKey();
        }
    }
}
