using System;
using System.Collections;
using System.Collections.Generic;
namespace lab6
{
    class Program
    {
        abstract class CGraphicsObject
        {
            public static int x1, x2, x3, x4, x5, x6, x7, x8, r;
        }
        class Poly : CGraphicsObject
        {
            interface IOcta
            {
                void Per();
            }
            class Octa
            {
                public int P(int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8)
                {
                    return x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8;
                }
                IOcta octa;
                public Octa(IOcta vs)
                {
                    octa = vs;
                }
                public void Start()
                {
                    octa.Per();
                }
            }
            class Perim : IOcta
            {
                public void Per()
                {
                    Console.WriteLine("Enter length x1: ");
                    CGraphicsObject.x1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter length x2: ");
                    CGraphicsObject.x2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter length x3: ");
                    CGraphicsObject.x3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter length x4: ");
                    CGraphicsObject.x4 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter length x5: ");
                    CGraphicsObject.x5 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter length x6: ");
                    CGraphicsObject.x6 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter length x7: ");
                    CGraphicsObject.x7 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter length x8: ");
                    CGraphicsObject.x8 = Convert.ToInt32(Console.ReadLine());
                }
            }
            class Circle : CGraphicsObject
            {
                interface ICircle
                {
                    void Per();
                }
                class Circletr
                {
                    public int P1(int r) { return r * 2 * 3; }
                    ICircle circle;
                    public Circletr(ICircle sc)
                    {
                        circle = sc;
                    }
                    public void Start()
                    {
                        circle.Per();
                    }
                }
                class Perim1 : ICircle
                {
                    public void Per()
                    {
                        Console.WriteLine("Input r: ");
                        CGraphicsObject.r = Convert.ToInt32(Console.ReadLine());
                    }
                }
                delegate int Operation(int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8);
                delegate int Operation2(int r);
                static void Main(string[] args)
                {
                    Octa per = new Octa(new Perim());
                    per.Start();
                    Operation operation1 = per.P;
                    int result = Convert.ToInt32(operation1(CGraphicsObject.x1, CGraphicsObject.x2,
                   CGraphicsObject.x3, CGraphicsObject.x4, CGraphicsObject.x5, CGraphicsObject.x6,
                   CGraphicsObject.x7, CGraphicsObject.x8));
                    Console.WriteLine("Result (perimeter of the triangle):");
                    Console.WriteLine(result);
                    Circletr per1 = new Circletr(new Perim1());
                    per1.Start();
                    Operation2 operation2 = per1.P1;
                    int result2 = operation2(CGraphicsObject.r);
                    Console.WriteLine("Result (perimeter of the rectangle):");
                    Console.WriteLine(result2);
                    Console.Read();
                    ArrayList numbersList = new ArrayList() { CGraphicsObject.x1, CGraphicsObject.x2,
                    CGraphicsObject.x3, CGraphicsObject.x4, CGraphicsObject.x5, CGraphicsObject.x6,
                    CGraphicsObject.x7, CGraphicsObject.x8, CGraphicsObject.r, };
                    object obj = 10;
                    numbersList.Add(obj);
                    numbersList.RemoveAt(10);
                    Console.WriteLine("Collection of octagon sides and radius: ");
                    foreach (object o in numbersList)
                    {
                        Console.Write(o + " ");
                    }
                }
            }
        }
    }
}