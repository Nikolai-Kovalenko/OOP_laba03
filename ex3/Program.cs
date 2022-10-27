using System;

namespace laba3_ex3
{
  class Point
  {
   static void Main(){
     Figure fig = new  Figure();
     double perimetr = fig.LengthSide(20, 20, 50);
     System.Console.WriteLine(perimetr);
    }
  }
}
