

class Program
{

    
    static void Main(string[] args)
    {
        Run();
    }


    static private void Run()
    {
        Console.WriteLine("Add your input");
        string rawtxt = Console.ReadLine();
        string txt = string.Concat(rawtxt.Where(Char.IsDigit));

        Console.WriteLine("Choose what number to search between");
        
        char mark;
        char.TryParse(Console.ReadLine(), out mark);

        InputNumbers(txt, mark);

        Console.ReadLine();
        Run();
    }
    static private void InputNumbers(string txt, char mark)
    {
        int start = -1;
        int end = -1;
        long total = 0;
        string tempString;

        for (int i = 0; i < txt.Length; i++)
        {
            if (txt.ElementAt(i) == mark)
            {
                
                if (start == -1)
                {
                    start = i;
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (end == -1)
                {
                    end = i;    
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                if (start != -1 && end != -1)
                {
                    string subString = txt.Substring(start, end - start + 1);
                    Console.WriteLine(subString);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    total += Convert.ToInt64(subString);
                    Console.ForegroundColor = ConsoleColor.White;
                    start = end;
                    end = -1;
                }
            }
        }
        Console.WriteLine(total);
    }
}
