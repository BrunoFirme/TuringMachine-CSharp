using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachine.Models
{
    class Parameter
    {

        public string Direction { get; set; } //R = RIGHT / L = LEFT

        public char newSymbol { get; set; }

        public int newState { get; set; }

        public Parameter(string Direction, char newSymbol, int newState)
        {

            this.Direction = Direction;

            this.newState = newState;

            this.newSymbol = newSymbol;

        }

        public Parameter(string[] parameters)
        {

            this.newSymbol = parameters[0][0];

            if (parameters[1][0] == '<')
                this.Direction = "Left";
            else if (parameters[1][0] == '>')
                this.Direction = "Right";

            this.newState = Convert.ToInt32(parameters[2]);

            if (parameters[1][0] == '<')
                this.Direction = "Left";
            else if (parameters[1][0] == '>')
                this.Direction = "Right";

        }

    }
}
