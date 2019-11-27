using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachine.Models
{
    class Parameter
    {

        public string Direction { get; set; } //> = RIGHT / < = LEFT

        public char newSymbol { get; set; }

        public int newState { get; set; }

        public Parameter(string[] parameters)
        {

            this.newSymbol = parameters[0][0];

            if (parameters[1][0] == '<')
                this.Direction = "Left";
            else if (parameters[1][0] == '>')
                this.Direction = "Right";

            this.newState = Convert.ToInt32(parameters[2]);

        }

    }
}
