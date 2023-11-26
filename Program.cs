namespace BM
{
    class App
    {
        public static void Main()
        {
            int n;
            System.Console.WriteLine("kac tane asal sayi uretelim?: ");
            n = int.Parse(Console.ReadLine());
            
            int[] primes;
            primes = Prime.GetPrimes(n); 
            for(int i = 0; i < primes.Length; i++)
                Console.Write("{0} ", primes[i]);
            Console.WriteLine();
            
        }  
    }
    class Prime
    {
        // Kendine gönderilen n  sayısına kadar olan asal sayıları üretecek
        public static int[] GetPrimes(int n)
        {
            int[] a = new int[n];
            int j = 0;

                while(j<n){
                    for(int i = 0; ; i++){
                        if(IsPrime(i) == true){
                            a[j] = i;
                            j++;
                        }
                        if(j==n)
                            break;
                    }
                }
               
            
            return a;
        }
        // Asallık Testi
        public static bool IsPrime(int val)
        {
            if (val < 2)
                return false;

            if (val == 2)
                return true;

            if (val % 2 == 0)
                return false;

            for (int i = 3; i <= Math.Sqrt(val); i += 2)
            {
                if (val % i == 0)
                {
                    return false;
                }
            }
            return true;      

        }

    }
}