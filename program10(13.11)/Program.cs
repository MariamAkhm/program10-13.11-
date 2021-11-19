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

            Console.WriteLine("10.2");
            Console.WriteLine("Введите изначальную позицию прямоугольника по горизонтали");
            int horizontal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите изначальную позицию прямоугольника по вертикали");
            int vertical = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину стороны прямоугольника");
            double weidth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ширину сторону прямоугольника");
            double height = Convert.ToDouble(Console.ReadLine());
            Color color = Color.white;
            bool isVisible = true;
            Rectangle rectangle = new Rectangle(horizontal, vertical,weidth,height, color, isVisible);
            Console.WriteLine(rectangle);

            Console.WriteLine("Введите изначальную позицию круга по горизонтали");
            horizontal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите изначальную позицию круга по вертикали");
            vertical = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите радиус круга");
            double radius = Convert.ToDouble(Console.ReadLine());
            Color color1 = Color.blue;
            isVisible = true;
            Circle circle = new Circle(horizontal, vertical, radius, color1, isVisible);
            Console.WriteLine(circle);
        }
    }
}
