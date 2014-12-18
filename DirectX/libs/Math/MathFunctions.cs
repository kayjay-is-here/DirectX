using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using DirectX;

namespace DirectX.libs.Math {
     class MathFunctions
    {
             
         static long Factorial(long number)
         {              

             if (number <= 1)
                 return 1;
             else
                 return number * Factorial(number - 1);
         }

        public static void Main()
        {
            
        }
    }
}


    

   