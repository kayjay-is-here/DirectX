using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DirectX;    

namespace DirectX.libs.Strings
{
    class TextFunctions
    {
        public static void text(string textMessage)
        {
            Console.WriteLine(textMessage);
        }

        public static void errorText(string errorTextMessage)
        {
            Console.Error.WriteLine(errorTextMessage);
        }

        public static void errorTextAsync(string errorTextMessage)
        {
            Console.Error.WriteLineAsync(errorTextMessage);
        }

    }
    class String1
    {
    [STAThread]
        
        public static void Main() {
            
        }
    }
}
