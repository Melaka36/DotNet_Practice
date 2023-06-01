


namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 4;
            float Number = 23.32f;
            Console.WriteLine(Number);

            //format String 
            Console.WriteLine("{0} {1}",byte.MinValue,byte.MaxValue);

            //implycit type conversion
            byte b = 1; // 1 byte
            int i = b;  // 4 bytes
            Console.WriteLine(i);

            //Explicit type conversion

            int j = 3;
            byte c = (byte)j;  // j=3 , 3 can be stored in a byte so we can cast
            Console.WriteLine(c);

            int k = 30230;
            byte d = (byte)k;  // j=300 , 3 cannot be stored in a byte so we can cast
            Console.WriteLine(d); //data loss
        }
    }
}