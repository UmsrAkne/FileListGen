namespace FileListGen
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please enter the directory path in the argument.");
            }
            else
            {
                var path = args[0];
                if (!Directory.Exists(path))
                {
                    return;
                }

                var paths = Directory.GetFiles(path);
                foreach (string p in paths)
                {
                    Console.WriteLine($"\"{p}\"");
                }
            }
        }
    }
}
