using System;
namespace laba3_ex2
{
   public class Content
   {
     private string content = "Content not found!";
     
     public string Show{
        get {
          return content; 
        }
        set {
           content = value;
        }  
      }

        public void add_content(string content) {
          if(content == "")   
            content = "ERROR! \n Author not found";
          Show = content;
        }
     }
   }    
