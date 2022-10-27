using System;

namespace laba3_ex1
{
  class Rectangle
  {
     static void Main(){
       Console.WriteLine("Первая сторона прямоугольника:");
       Double side1 = System.Convert.ToDouble(Console.ReadLine());
       Console.WriteLine("Вторая сторона прямоугольника:");
       Double side2 = System.Convert.ToDouble(Console.ReadLine());
       areaCalc(side1, side2);
       perimetrCalc(side1, side2);
     }

    public static void areaCalc(Double side1, Double side2) { // Площадь прямоугольника
      Double areaCalc = side1 *side2;
      System.Console.WriteLine("Площать прямоугольника с такими параметрами: " + areaCalc );
    }

    public static void perimetrCalc(Double side1, Double side2) { // Площадь прямоугольника
      Double perimetrCalc = ((side2 + side1) * 2);
      System.Console.WriteLine("А периметр: " + perimetrCalc);
    }
  }
}
