using System;

namespace TDChiffreEnLettres
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                UserInput userInput = new UserInput();
                Parser parser = new Parser();
                parser.parseIntToString(userInput.Value);
            }
        }
    }
}
