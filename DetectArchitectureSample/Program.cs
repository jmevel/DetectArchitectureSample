using System;

namespace DefineConstantsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            if(Environment.Is64BitOperatingSystem)
            {
                Console.WriteLine("Environment.Is64BitOperatingSystem: 64 bits");
            }
            else
            {
                Console.WriteLine("Environment.Is64BitOperatingSystem: 32 bits");
            }

#if Is64Bit
            Console.WriteLine("Platform DefineConstants: 64 bits");
#else
            Console.WriteLine("Platform DefineConstants: 32 bits");
#endif

            Console.ReadLine();
        }
    }
}
