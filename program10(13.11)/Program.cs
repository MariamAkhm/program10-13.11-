using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program10_13._11_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10.1");
            ACipher aCipher = new ACipher();
            Console.WriteLine("Введите букву, которую нужно изменить на следующую");
            string letter = Console.ReadLine().ToLower();
            letter=aCipher.Encode(letter);
            Console.WriteLine("Результат:" + letter);
            letter=aCipher.Decode(letter);
            Console.WriteLine("Изначальное значение:" + letter);

            BCipher bCipher = new BCipher();
            Console.WriteLine("Введите букву, которую нужно закодировать");
            letter = Console.ReadLine().ToLower();
            letter = bCipher.Encode(letter);
            Console.WriteLine("Результат:" + letter);
            letter = bCipher.Decode(letter);
            Console.WriteLine("Изначальное значение:" + letter);
        }
    }
}
