using System;

namespace TDChiffreEnLettres
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInput userInput = new UserInput();
            Parser parser = new Parser();
            parser.parseIntToString(userInput.Value);
        }
    }
}
