namespace Ex20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //20.Видалити в рядку всі зайві пробіли,
            //тобто серії підряд проставлених пробілів замінити на поодинокі пробіли.
            //Крайні пробіли в рядку видалити.
            string s = "  Привіт   це   тест   ";
            char[] arr = s.ToCharArray();

            List<char> result = new List<char>();

            bool wasSpace = true; 

            foreach (char c in arr)
            {
                if (c == ' ')
                {
                    if (!wasSpace) 
                        result.Add(' ');

                    wasSpace = true;
                }
                else
                {
                    result.Add(c);
                    wasSpace = false;
                }
            }

            if (result.Count > 0 && result[^1] == ' ')
                result.RemoveAt(result.Count - 1);

            Console.WriteLine(new string(result.ToArray()));
            Console.ReadKey();
        }
    }
}
