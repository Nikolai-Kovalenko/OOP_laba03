using System;
namespace laba3_ex2
{
   public class Author
   {
     private string author = "Author not found!";
     
     public string Show{
        get {
          return author; 
        }
        set {
           author = value;
        }  
      }

        public void add_author(string author) {
          if(author == "")   
            author = "ERROR! \n Author not found";
          Show = author;
        }
     }
   }    
