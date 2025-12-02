namespace Ex24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //24.Даний текст.Знайти слова, складені з цифр, і суму чисел, котрі утворюють ці слова.
            string s = "abc 123 def 55 x 9z 100";
            char[] arr = s.ToCharArray();

            List<char> current = new List<char>();
            List<int> numbers = new List<int>();

            foreach (char c in arr)
            {
                if (c != ' ')
                {
                    current.Add(c);
                }
                else
                {
                    if (current.Count > 0)
                    {
                        bool isNumber = true;
                        foreach (char ch in current)
                            if (!char.IsDigit(ch))
                                isNumber = false;

                        if (isNumber)
                            numbers.Add(int.Parse(new string(current.ToArray())));

                        current.Clear();
                    }
                }
            }

            if (current.Count > 0)
            {
                bool isNumber = true;
                foreach (char ch in current)
                    if (!char.IsDigit(ch))
                        isNumber = false;

                if (isNumber)
                    numbers.Add(int.Parse(new string(current.ToArray())));
            }

            int total = 0;
            foreach (int n in numbers)
                total += n;

            Console.WriteLine("Числа в тексті:");
            foreach (int n in numbers)
                Console.WriteLine(n);

            Console.WriteLine("Сума чисел: " + total);
            Console.ReadKey();
        }
    }
}
