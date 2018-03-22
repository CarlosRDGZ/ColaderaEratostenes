namespace Eratosthenes
{
    public class Sieve
    {
        private static int limit;
        private static int[] numbers;

        public static string FindPrimes(int limitNumber)
        {
            string num = "";
            int endl = 1;
            limit = limitNumber;
            numbers = new int[limit];
            for (int i = 0; i < limit; i++)
                numbers[i] = 1;
            
            int prime = 2;

            while (prime > -1)
            {
                int index = NextOne(prime);
                while(index != -1)
                {
                    if (index % prime == 0)
                        numbers[index] = 0;
                    index = NextOne(index);
                }
                num += (endl < 10) ? prime + ", " : prime + "," + System.Environment.NewLine;
                endl = (endl < 10) ? endl + 1 : 1;
                prime = NextOne(prime);
            }

            return num;
        }

        private static int NextOne(int from)
        {
            for (int next = from + 1; next < limit; next++)
                if (numbers[next] == 1)
                    return next;
            return -1;
        }
    }
}