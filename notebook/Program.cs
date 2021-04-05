using System;

namespace notebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[10];

            names[0] = "Ivan";
            names[1] = "Tolik";
            names[2] = "Alex";
            names[3] = "Mars";
            names[4] = "Mihail";
            names[5] = "Miha";

            Console.WriteLine("Введите ваше имя:");
            names[6] = Console.ReadLine();

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("Вваше имя:" + names[6]);

            byte[] age = new byte[10];

            age[0] = 18;
            age[1] = 19;
            age[2] = 18;
            age[3] = 19;
            age[4] = 28;
            age[5] = 38;

            string strAge;
            byte byteValue;

            Console.WriteLine("Введите ваш возраст:");
            strAge = Console.ReadLine();
            bool success = Byte.TryParse(strAge, out byteValue);

            for (int i = 0; i < age.Length; i++)
            {
                Console.WriteLine(age[i]);
            }

            if (success)
            {
                Console.WriteLine("Ваш возраст:" + strAge, byteValue);
            }

            if (!success)
            {
                Console.WriteLine("Вы ввели не число!");
                strAge = Console.ReadLine();
                Console.WriteLine("Ваш возраст:" + strAge, byteValue);
            }

            string[] phoneNum = new string[10];

            phoneNum[0] = "8 999 999 99 79";
            phoneNum[1] = "8 999 959 92 99";
            phoneNum[2] = "8 999 949 99 29";
            phoneNum[3] = "8 999 939 99 89";
            phoneNum[4] = "8 999 929 91 91";
            phoneNum[5] = "8 999 929 91 91";

            Console.WriteLine("Введите номер телефона:");
            phoneNum[6] = Console.ReadLine();

            for (int i = 0; i < phoneNum.Length; i++)
            {
                Console.WriteLine(phoneNum[i]);
            }

            Console.WriteLine("Вваше имя:" + names[6]);
            Console.WriteLine("Ваш возраст:" + byteValue);
            Console.WriteLine("Ваш номер телефона:" + phoneNum[6]);
            Console.WriteLine("Ваши данные занесены в книгу");
        }
    }
}
