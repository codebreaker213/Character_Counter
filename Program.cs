// I removed some empty lines, since they did not make scence.
// Empty line are used to separate classes or methods between each other
// or to separate different local parts in big blocks of code.
namespace identifer
{
    static class Program
    {
        static int Main(string[] args)
        {
            string input = Console.ReadLine();
            // No need to convert string to array of chars. String itself is an array of chars.
            // So you can access its elements via syntax input[i] :)
            char[] charArray1 = input.ToCharArray();
            int m = 0;

            for (int j = 0; j < charArray1.Length; j++)
            {

                bool isFirst = charArray1[j] != ' ';
                for (int i = 0; i < j; i++)
                {
                    isFirst = isFirst && charArray1[i] != charArray1[j];
                }
                if (isFirst)
                {
                    int count = 0;
                    for (int i = 0; i < charArray1.Length; i++)
                    {
                        if (charArray1[j] == charArray1[i])
                        {
                            count++;
                        }
                    }
                    m += count;
                    Console.WriteLine(charArray1[j] + " - " + count);
                }
            }
            // Current method 'Main' returns int. And you added 'return m' to satisfy the requirements to return int. It is fine.
            // Alternatively, you can change the return type of method 'Main' to void, since returning valueis not used anywhere
            // and it is not clear what returning value means
            return m;
        }
    }
}
