using System;

namespace LearningCSharp.Day1
{
    class BasicProgramming
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            int firstName;

            //Primitive - Pre-defined in programming language

            //Byte(1), > Short(2), > int(4), > long(8), 

            //float(4), double(8), decimal(16)

            //char(2)

            //bool(1) -- True/False

            //-347853 to 342389

            Console.WriteLine("Min size of Byte " + byte.MinValue);
            Console.WriteLine("Max size of Byte " + byte.MaxValue);
            Console.WriteLine("Max size of Int " + int.MaxValue);

            Console.WriteLine("Max size of double " + double.MaxValue);

            long lgVar;

            lgVar = 37897; //Data loss

            int intVar = (int) 265934589l;  //Explict Typecasting -- Dataloss happens

            long lVar = 3257346578234L;

            double dobVar = 6.74234;

            float fVar = 374.3246f;

            decimal dVar = 734.74395m;

            char cVar = '$';

            string str = "My name is Saurabh";

            double dobVar2 = 65.78;

            int intVar2 = (int) dobVar2;
        }
    }

    
}
