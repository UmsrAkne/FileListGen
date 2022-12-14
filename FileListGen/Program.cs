namespace FileListGen
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please enter the directory path in the argument.");
                Console.WriteLine(string.Empty);
                Console.WriteLine("Usage : ");
                Console.WriteLine(@"./FileListGen.exe DirectoryPath");
                Console.WriteLine(string.Empty);
                Console.WriteLine("Quart option : ");
                Console.WriteLine(@"./FileListGen.exe DirectoryPath -q");
            }
            else
            {
                var path = args[0];
                if (!Directory.Exists(path))
                {
                    return;
                }

                bool addQuart = false;

                if (args.Length >= 2)
                {
                    if (args[1] == @"-q")
                    {
                        addQuart = true;
                    }
                }

                var paths = Directory.GetFiles(path);
                foreach (string p in paths)
                {
                    switch (addQuart)
                    {
                        case true:
                            Console.WriteLine($"\"{p}\"");
                            break;
                        default:
                            Console.WriteLine($"{p}");
                            break;
                    }
                }
            }
        }
    }
}
