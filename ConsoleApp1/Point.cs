using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Point
    {
       
            private int x;
            private int y;

            public int X
            {
                get
                {
                    return x;
                }
                set
                {
                    if (value >= 0) x = value;
                }
            }

            public int Y
            {
                get
                {
                    return y;
                }
                set
                {
                    if (value >= 0) y = value;
                }
            }

            public Point()
            {
                x = 0;
                y = 0;
            }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public void showdata()
            {
                Console.WriteLine(X + " " + Y);
            }


            public override string ToString()
            {
                return $"{X} {Y}";
            }

        
    }
}
