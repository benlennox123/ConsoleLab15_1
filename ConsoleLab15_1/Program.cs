using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab15_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начальное значение арифметической прогрессии = ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            ArithProgression A = new ArithProgression();
            A.setStart(a1);
            Console.Write("Введите начальное значение геометрической прогрессии = ");
            int b1 = Convert.ToInt32(Console.ReadLine());
            GeomProgression B = new GeomProgression();
            B.setStart(b1);
            int an = A.getNext();               //2-й член А-прогрессии
            Console.Write("{0}, {1}",a1, an);
            an = A.getNext();                   //3-й член А-прогрессии
            Console.Write(", {0}", an);
            an = A.getNext();                   //4-й член А-прогрессии
            Console.Write(", {0}", an);
            Console.WriteLine();
            A.reset();                          //сброс к 1-му А-прогрссии
            Console.WriteLine(a1);
            Console.WriteLine();
            int bn = B.getNext();               //2-й член В-прогрессии
            Console.Write("{0}, {1}", b1, bn);
            bn = B.getNext();                   //3-й член В-прогрессии
            Console.Write(", {0}", bn);
            bn = B.getNext();                   //4-й член В-прогрессии
            Console.Write(", {0}", bn);
            Console.WriteLine();
            B.reset();                          //сброс к 1-му В-прогрссии
            Console.WriteLine(b1);
            Console.WriteLine();
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }

    interface ISeries
    {
        void setStart(int x);   //устанавливает начальное значение

        int getNext();          //возвращает следующее число ряда

        void reset();           //выполняет сброс к начальному значению
    }

    class ArithProgression : ISeries
    {
        int a1;
        int d=10;               //шаг
        int an;
        int t;

        public int getNext()
        {

            an = a1 + d;
            a1 = an;
            return an;
        }

        public void reset()
        {
            setStart(t);
        }

        public void setStart(int x)
        {
            a1 = x;
            t = a1;
        }
    }

    class GeomProgression : ISeries
    {
        int b1;
        int q = 10;               //шаг
        int bn = 0;
        int t;

        public int getNext()
        {
            bn = b1 * q;
            b1 = bn;
            return bn;
        }

        public void reset()
        {
            setStart(t);
        }

        public void setStart(int x)
        {
            b1 = x;
            t = b1;
        }
    }
}
