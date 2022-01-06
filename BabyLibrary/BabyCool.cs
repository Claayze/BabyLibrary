using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyLibrary
{
   public class BabyCool
    {
        public static string AlarmBreath(int breath)
        {
            if (breath > 18)
            {
                return "Critical High";
            }

            if (breath < 12)
            {
                return "Critical Low";
            }
            return "Normal";
        }
        public static bool AlarmCry(int cry)
        {
            return cry == 1;
            // Ovejelse af exception hvis input er andet end 1 eller 0...

            //if(cry == 1) -- Dette virker på samme måde som linje 26
            //{
            //    return true;
            //}
            //return false;
        }
        
    }
}
