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

        public Head(string Strip)
        {

            Position = 0;

            Strip.Replace(" ", "_");

            Strip.PadRight(Properties.Settings.Default.StripLenght, '_');

            this.Strip = Strip;

        }

        public char Read()
        {

            char currentSymbol = Strip[Position];
            return currentSymbol;

        }

        public void Write(char newSymbol)
        {

            StringBuilder strBuilder = new StringBuilder(Strip);
            strBuilder[Position] = newSymbol;
            Strip = strBuilder.ToString();

            return;

        }

        public void Move(string Direction)
        {

            if (Direction == "Right")
                Position++;
            if (Direction == "Left")
                Position--;

            return;

        }

    }

}
