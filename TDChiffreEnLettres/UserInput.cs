using System;
using System.Collections.Generic;
using System.Text;

namespace TDChiffreEnLettres
{
    class UserInput
    {
        public int Value { get; set; }

        public UserInput()
        {
            getValueFromUser();
        }

        private void getValueFromUser()
        {
            Console.Write("Entrez un nombre entre 0 et 999:");
            string input = Console.ReadLine();
            try
            {
                this.Value = Int32.Parse(input);
                this.checkInputValidity();
            }
            catch (FormatException)
            {
                Console.WriteLine($"Impossible de caster '{input}' en int !");
                this.getValueFromUser();
            }
        }

        private void checkInputValidity()
        {
            if (this.Value < 0)
            {
                Console.WriteLine("Le nombre est inférieur à 0 !");
                this.getValueFromUser();
            }
            else if (this.Value > 999)
            {
                Console.WriteLine("Le nombre est supérieur à 999 !");
                this.getValueFromUser();
            }
        }
    }
}
