using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachine.Models
{
    class Head
    {

        public string Strip { get; set; }
        public int Position { get; set; }       

        public Head(string Strip, int striplenght)
        {

            Position = 0;

            this.Strip = Strip;

            Strip.PadRight(striplenght, '_');

        }

        public char Read()
        {

            char currentSymbol = Strip[Position];
            return currentSymbol;

        }

        private void Write(char newSymbol)
        {

            StringBuilder strBuilder = new StringBuilder(Strip);
            strBuilder[Position] = newSymbol;
            Strip = strBuilder.ToString();

            return;

        }

    }

}
