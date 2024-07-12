namespace CislaApp
{
    public class CisloApp
    {
        public void Run(string[] args)
        {
            // Simple console application, which prints out number when you input from to and how much to skip by.

            Console.ForegroundColor = ConsoleColor.Green;
            
            // Needs to purposefuly end when there are no arguments.
            if (args.Length != 0)
            {
                int start = Array.IndexOf(args, "-start");
                int numFrom = SafelyConvertToInt(args[start + 1]);

                int end = Array.IndexOf(args, "-end");
                int numTo = SafelyConvertToInt(args[end + 1]);

                int skip = Array.IndexOf(args, "-by");
                int numSkip = SafelyConvertToInt(args[skip + 1]);

                // int.MinValue is returned by SafelyConvertToInt(string s) if s isn't parseable.
                // Therefore this code is checking if all of them were parseable.
                if (!(numFrom == int.MinValue || numTo == int.MinValue || numSkip == int.MinValue))
                {
                    // This number checks which of the two range numbers are greater
                    // to determine the order of prints.
                    if (numFrom <= numTo)
                    {
                        for (int i = numFrom; i <= numTo; i += numSkip)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    else
                    {
                        for (int i = numFrom; i >= numTo; i -= numSkip)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
        }
        public int SafelyConvertToInt(string s)
        {
            if (int.TryParse(s, out int num))
            {
                return num;
            }

            return int.MinValue;
        }
    }
}
