using System;
namespace laba3_ex2
{
   public class Titel
   {
     private string titel = "Titel not found!";
     
     public string Show{
        get {
          return titel; 
        }
        set {
          titel = value;
        }  
      }

        public void add_titel(string titel) {
          if(titel == "")   
            titel = "ERROR! \nTitel not found";
          Show = titel;
        }
     }
   }    
