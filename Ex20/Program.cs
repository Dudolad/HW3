namespace Ex20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //20.Видалити в рядку всі зайві пробіли,
            //тобто серії підряд проставлених пробілів замінити на поодинокі пробіли.
            //Крайні пробіли в рядку видалити.
            string text = "  Привіт   це   тест   ";

            text = text.Trim();

            string result = "";
            bool lastWasSpace = false;

            foreach (char c in text)
            {
                if (c == ' ')
                {
                    if (!lastWasSpace)
                    {
                        result += c;
                        lastWasSpace = true;
                    }
                }
                else
                {
                    result += c;
                    lastWasSpace = false;
                }
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
