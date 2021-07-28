 

using System.Net.Mime;
using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace Recipes
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityMaxLeng = 0, nameMaxLeng = 0, typeMaxLeng = 0;
            var json =File.ReadAllText(@"JSON\data.json");
            List<recipes> recipes=JsonConvert.DeserializeObject<List<recipes>>(json);
   
              if(recipes != null)
              {
                  foreach(var item in recipes)
                  {
                      foreach(var x in item.ingredients)
                      {
                          if(x.quantity.Length> quantityMaxLeng) quantityMaxLeng=x.quantity.Length;
                           if(x.name.Length> nameMaxLeng) nameMaxLeng=x.name.Length;
                            if(x.type.Length> typeMaxLeng) typeMaxLeng=x.type.Length;
                      }
                  }
              }
            if(recipes != null)
            {
                foreach( var item in recipes)
                {
                Console.WriteLine("the name of meal : {0}",item.name);
                  Console.WriteLine("");
                   if(item.ingredients!= null)
                   { 
                       Console.ForegroundColor= ConsoleColor.Red;
                       Console.WriteLine("Ingredients : ");
                       Console.WriteLine("");
                       Console.ForegroundColor= ConsoleColor.Magenta;
                       Console.Write("Quantity".ToUpper());
                       for(var i=0;i<( quantityMaxLeng+1 -"Qunatity".Length);i++)
                       {
                           Console.Write(" ");
                       }
                        Console.Write("Name".ToUpper());
                       for(var i=0;i<( nameMaxLeng+1 -"name".Length);i++)
                       {
                           Console.Write(" ");
                       }
                        Console.Write("Type".ToUpper());
                       for(var i=0;i<( typeMaxLeng+1 -"type".Length);i++)
                       {
                           Console.Write(" ");
                       }
                       
                       foreach(var ingre in item.ingredients)
                       {
                             Console.ForegroundColor= ConsoleColor.Cyan;
                       
                        Console.WriteLine("");
                         Console.Write(ingre.quantity);
                       for(var i=0;i<( quantityMaxLeng +1 -ingre.quantity.Length);i++)
                       {
                           Console.Write(" ");
                       }
                        Console.Write(ingre.name);
                       for(var i=0;i<( nameMaxLeng +1 -ingre.name.Length);i++)
                       {
                           Console.Write(" ");
                       }
                        Console.Write(ingre.type);
                       for(var i=0;i<( typeMaxLeng +1 -ingre.type.Length);i++)
                       {
                           Console.Write(" ");
                       }
                       }
                   }
                  Console.WriteLine("");
                  Console.WriteLine("");
                   if(item.steps != null)
                   {
                         Console.ForegroundColor= ConsoleColor.Red;
                         Console.WriteLine("Steps to follow : ");
                         Console.WriteLine("");
                           Console.ForegroundColor= ConsoleColor.DarkMagenta;
                       foreach(var step in item.steps)
                       {
                          
                           Console.WriteLine(step);
                       }
                   }
                     Console.WriteLine("");

                   if(item.timers !=null)
                   {
                       
                         Console.ForegroundColor= ConsoleColor.Red;
                        Console.WriteLine("Timers : ");
                         Console.WriteLine("");
                          Console.ForegroundColor= ConsoleColor.Yellow;
                       for(var i=0; i< item.timers.Count; i++)
                      {
                          
                          Console.WriteLine(item.timers[i]);
                      }
                   }
                    Console.WriteLine("");
                   if(item.imageURL!= null)
                   {
                       Console.ForegroundColor= ConsoleColor.Green;
                       Console.WriteLine("Image URL : {0}",item.imageURL);
                   }
                 Console.WriteLine("");
                   if(item.originalURL!= null)
                   {
                        Console.ForegroundColor= ConsoleColor.Blue;
                       Console.WriteLine("Original URL {0}",item.originalURL);
                   }
                  
                   Console.ForegroundColor= ConsoleColor.DarkYellow;
                   Console.WriteLine("");
                   Console.WriteLine("                           *****************************");
                    Console.ForegroundColor= ConsoleColor.White;
                }
            }
        }
    }
}
