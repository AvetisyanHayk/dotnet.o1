using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening1
{
    class Faculteit
    {
        public Faculteit(int number)
        {
            this.Number = number;
        }

        public int Number { get; set; }

        public int Bereken()
        {
            return Bereken(this.Number);
        }

        private int Bereken(int number)
        {
            if (number < 2)
            {
                return 1;
            }
            return number * Bereken(number - 1);
        }
    }
}
