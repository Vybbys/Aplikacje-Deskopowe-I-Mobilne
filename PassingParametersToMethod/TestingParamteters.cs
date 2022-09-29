using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingParametersToMethod
{
    class TestingParamteters
    {
        public void Test1()
        {
            byte number = 15;

            Console.WriteLine("Zmienna numer = " + number);
            //ChangeValue(number);
            //ChangeValue(6);
            ChangeValuev2(ref number);
            Console.WriteLine("Zmienna numer = " + number);
            int random = GetRandomNumber();
            GetRandomNumber(out random);
            Console.WriteLine(random);

        }


        private void ChangeValue(byte value)
        {
            Console.WriteLine("Parametr value = " + value);
            value = (byte)(value + 10);
            Console.WriteLine("Parametr value = " + value);
        }

        private void ChangeValuev2(ref byte value)
        {
            Console.WriteLine("Parametr value = " + value);
            value = (byte)(value + 10);
            Console.WriteLine("Parametr value = " + value);
        }

        private void GetRandomNumber(out int value)
        {
             value = new Random().Next(10, 101);
        }
        
        private int GetRandomNumber()
        {
              return new Random().Next(10, 100);
        }
    }
}
