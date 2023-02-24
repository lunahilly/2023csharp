using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace ClassOefening //namespaces
{
    internal class ClassStructureExercise //class
    {
        private readonly string accountName;  //access modifier

        internal ClassStructureExercise(string accountName  //funtion arguments
                                                            ) //function 
        {
            this.accountName = accountName;
        }

        internal void ShowGreetingInConsole() //class variables
        {
            string greeting = "hello";
            Console.WriteLine(greeting + " " + accountName);
        }

        internal void Show1To10() //class variables
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i.ToString());
            }
        }

        internal double DistBetweenPoints(int x1, int y1, int x2, int y2)//class variables
        {

            int dx = x2 - x1; //local variable
            int dy = y2 - y1;

            double lengthSquared = (dx * dx) + (dy * dy); 

            double length = Math.Sqrt(lengthSquared);
            return length;

        }
        internal int MultiplyToPower2(int value)//class variables
        {
            int result = value * value;
            return result;
        }

    }
}
