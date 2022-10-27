using System;
namespace laba3_ex2 
{
     public class Book
     {
        static void Main(){

        Titel t = new Titel();
        Author a = new Author();
        Content c = new Content();

        System.Console.WriteLine("Введи заголовок");
        string titel = Console.ReadLine();  
        t.add_titel(titel);


        System.Console.WriteLine("Введи автора");
        string author = Console.ReadLine();  
        a.add_author(author);


        System.Console.WriteLine("Введи содержание");
        string content = Console.ReadLine();  
        c.add_content(content);

        Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
        System.Console.WriteLine(t.Show);
        Console.ForegroundColor = ConsoleColor.Blue; // устанавливаем цвет
        System.Console.WriteLine(a.Show);
        Console.ForegroundColor = ConsoleColor.Yellow; // устанавливаем цвет
        System.Console.WriteLine(c.Show);

        /*
        Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
        Console.WriteLine("Hallo, world!");
        Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
        Console.WriteLine("Hallo, world!");
        Console.ForegroundColor = ConsoleColor.Blue; // устанавливаем цвет
        Console.WriteLine("Hallo, world!");
        Console.ForegroundColor = ConsoleColor.Yellow; // устанавливаем цвет
        Console.WriteLine("Hallo, world!");
        Console.ResetColor(); // сбрасываем в стандартный
        */
     }
  }
}
