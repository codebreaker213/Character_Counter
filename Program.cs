namespace identifer
{
    static class Program
    {
        static int Main(string[] args)
        {
            string input = Console.ReadLine();
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

            return m;

        }

    }
}
