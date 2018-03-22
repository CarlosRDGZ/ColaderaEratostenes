namespace Eratosthenes
{
    public class Sieve
    {
        private static int limit;
        private static bool[] numbers;

        public static string FindPrimes(int limitNumber)
        {
            string num = "1, ";
            int endl = 1;
            limit = limitNumber;
            numbers = new bool[limit];
            
            for (int i = 0; i < limit; i++)
                numbers[i] = true;
            
            int prime = 2;

            while (prime > -1)
            {
                int index = NextOne(prime);
                while (index != -1)
                {
                    if (index % prime == 0)
                        numbers[index] = false;
                    index = NextOne(index);
                }
                num += (endl < 10) ? prime + ", " : prime + "," + System.Environment.NewLine;
                endl = (endl < 10) ? endl + 1 : 1;
                prime = NextOne(prime);
            }

            return num;
        }

        /*
            Itera en el vector numbers, desde la posicion que se la pasa en el parametro mas
            uno hasta el fin del vector y retorna la posicion del siguiente elmento cuyo valor
            sea igual a 'true'. Si se llega al final y no se encontro otro 'true; retorna -1.
         */
        private static int NextOne(int from)
        {
            for (int next = from + 1; next < limit; next++)
                if (numbers[next] == true)
                    return next;
            return -1;
        }
    }
}