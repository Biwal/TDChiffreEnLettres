using System;
using System.Collections.Generic;
using System.Text;

namespace TDChiffreEnLettres
{
    class Parser
    {
        public void parseIntToString(int value)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Le nombre ").Append(value.ToString()).Append(" s'écrit : ").AppendLine();
            detectZero(value, builder);
            parseHundreds(value,builder);
            parseDozen(value, builder);
            Console.WriteLine(builder);
        }

        private void detectZero(int value, StringBuilder builder)
        {
            if (value == 0) builder.Append("zéro");
        }

        private void parseHundreds(int value, StringBuilder builder) {
            int divHundreds = value / 100;
            int modHundreds = value % 100;

            if (divHundreds == 0) return;
            else if (divHundreds == 1) builder.Append("cent");
            else builder.Append(getDigitToString(divHundreds)).Append("-cent");

            if (modHundreds == 0 && divHundreds != 1) builder.Append("s");
            else if (modHundreds != 0) builder.Append("-");
        }

        private void parseDozen(int value, StringBuilder builder)
        {
            int divHundreds = value / 100;
            int dozenNumber = value % 100;
            int divDozens = dozenNumber / 10;
            int modDozens = dozenNumber % 10;

            if (dozenNumber == 0) return;
            else if (divDozens == 1) builder.Append(get11To19ToString(modDozens));
            else
            {
                builder.Append(getDozenToString(divDozens));

                if (modDozens == 0 ) {
                    if ((divDozens == 2 || divDozens == 8)&& divHundreds>0) builder.Append("s");
                    else if (divDozens == 9) builder.Append("-dix");
                    return;
                }

                if (divHundreds > 0 || divDozens > 0)
                {
                    if (modDozens == 1 && (divDozens != 8 && divDozens != 9)) builder.Append("-et-");
                    else builder.Append("-");
                }
                
                
                if (divDozens == 7 || divDozens == 9)
                {
                    builder.Append(get11To19ToString(modDozens));
                }
                else builder.Append(getDigitToString(modDozens));
            }
 
        }

        private string getDigitToString(int value)
        {
            string digit = "";
            switch (value)
            {
                case 1:
                    digit = "un";
                    break;
                case 2:
                    digit = "deux";
                    break;
                case 3:
                    digit = "trois";
                    break;
                case 4:
                    digit = "quatre";
                    break;
                case 5:
                    digit = "cinq";
                    break;
                case 6:
                    digit = "six";
                    break;
                case 7:
                    digit = "sept";
                    break;
                case 8:
                    digit = "huit";
                    break;
                case 9:
                    digit = "neuf";
                    break;
            }
            return digit;
        }

        private string get11To19ToString(int value)
        {
            string digit = "";
            switch (value)
            {
                case 0:
                    digit = "dix";
                    break;
                case 1:
                    digit = "onze";
                    break;
                case 2:
                    digit = "douze";
                    break;
                case 3:
                    digit = "treize";
                    break;
                case 4:
                    digit = "quatorze";
                    break;
                case 5:
                    digit = "quinze";
                    break;
                case 6:
                    digit = "seize";
                    break;
                case 7:
                    digit = "dix-sept";
                    break;
                case 8:
                    digit = "dix-huit";
                    break;
                case 9:
                    digit = "dix-neuf";
                    break;
            }
            return digit;
        }
    
        private string getDozenToString(int value)
        {
            string dozen = "";
            switch (value)
            {
           
                case 2:
                    dozen = "vingt";
                    break;
                case 3:
                    dozen = "trente";
                    break;
                case 4:
                    dozen = "quarante";
                    break;
                case 5:
                    dozen = "cinquante";
                    break;
                case 6:
                case 7:
                    dozen = "soixante";
                    break;
                case 8:
                case 9:
                    dozen = "quatre-vingt";
                    break;
               
            }
            return dozen;
        }
    }
}
