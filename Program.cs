using System;

namespace depsman
{
    class Program
    {
        static int Main(string[] args)
        {
            int n = args.Length;
            
            if(n > 10)
                return;

            Func<int> lambda = (() =>
            {
                Console.WriteLine("LAMDA!");
                return 0;
            });

            try
            {                
                Console.WriteLine("TEST");
                int r = 0;

                if (0 < n)
                {
                    r = lambda();
                }

                return r;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
                return 99;
            }
        }

    }
}
