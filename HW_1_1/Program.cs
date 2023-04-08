namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            while (true)
            {
                Console.WriteLine("Please enter name or X for closing the application ");
                string input = Console.ReadLine().ToLower();
                if (input == "X".ToLower())
                {
                    break;
                }
                else
                {
                    if(names.Contains(input))
                    {
                        Console.WriteLine("You can't enter the same name twice!");
                        continue;
                    }
                    names.Add(input);
                    continue;
                }
            }
            Console.WriteLine("Please enter some text");
            string input2 = Console.ReadLine();
            List<string> splittedText = input2.Split(' ', '.', '!', '?',',').ToList();
            Dictionary<string, int> stats = new Dictionary<string, int>();

            foreach(string name in names)
            {
                //int nameFound = 0;
                //foreach(string word in splittedText)
                //{
                //    if(name.ToLower() == word.ToLower())
                //    {
                //        nameFound++;
                //    }
                //}

                int nameFound = splittedText.Count(x => x.ToLower() == name.ToLower());
                stats.Add(name, nameFound);
                Console.WriteLine($"{name} was found {nameFound} times in the text!");
            }
        }
    }
}