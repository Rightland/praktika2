using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace calculate
{
   class TwoArgumentsFactory 
    {
        
         public static ITwoArgumentsCalculator Creator(string calculatorName) {
            switch (calculatorName) {
                case "Plus":
                    return new Plus();
                case "Multi":
                    return new Multy();
                case "minus":
                    return new minus();
                case "Div":
                    return new Div();
          
                case "Remainder":
                    return  new Remainder();
                case "Sinus":
                    return new Sinus();

                case "average":
                    return new average();

                case "Square":
                    return new Square();

                default:
                    throw new Exception("Неизвестная операция");
            }

        }

       
    }

}
