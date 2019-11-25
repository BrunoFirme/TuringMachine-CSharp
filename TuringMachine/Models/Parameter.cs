using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachine.Models
{
    class Parameter
    {

        public string Direction { get; set; }

        public char newSymbol { get; set; }

        public int newState { get; set; }

        public Parameter(string Direction, char newSymbol, int newState)
        {

            this.Direction = Direction;

            this.newState = newState;

            this.newSymbol = newSymbol;

        }

    }
}
