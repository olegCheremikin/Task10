using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10___
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите параметры угла!");
            Console.WriteLine("Градусы: ");
            int gradus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Минуты: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Секунды: ");
            int sec = Convert.ToInt32(Console.ReadLine());
            Angle angle = new Angle(gradus, min, sec);
            angle.AngleRad();
            Console.ReadKey();
        }
    }
    public class Angle
    {
        public int gradus;
        public int min;
        public int sec;
        public Angle(int gradus, int min, int sec)
        {
            this.gradus = gradus;
            this.min = min;
            this.sec = sec;
        }
        public void AngleRad()
        {
            var Radians = (gradus + min / 60 + sec / 3600) * (Math.PI) / 180;
            if (gradus < 0)
                Radians = -Radians;
            Console.WriteLine("Значение в радианах = " + Radians);
        }
    }
}
