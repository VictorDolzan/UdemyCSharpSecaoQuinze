using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoQuinze.AtividadeDictionary
{
    class AtividadeDictionary
    {
         public static void ExecutarAtividadeDictionary()
         {
             Dictionary<string, string> cookies = new Dictionary<string, string>();

             cookies["user"] = "Maria";
             cookies["email"] = "maria@gmail.com";
             cookies["phone"] = "99712234";
             cookies["phone"] = "83737388";
            
             Console.WriteLine(cookies["email"]);
             Console.WriteLine(cookies["phone"]);

             cookies.Remove("email");

             if(cookies.ContainsKey("email"))
             {
                 Console.WriteLine(cookies["email"]);
             }
             else
             {
                 Console.WriteLine("There is no 'email' key");
             }

             Console.WriteLine("Size: " + cookies.Count); 
                
             Console.WriteLine("All cookies: ");
             foreach(KeyValuePair<string,string> item in cookies)
             {
                 Console.WriteLine(item.Key + ": " + item.Value);
             }
         }
    }
}