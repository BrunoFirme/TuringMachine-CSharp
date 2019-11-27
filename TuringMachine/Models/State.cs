using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachine.Models
{
    class State
    {

        public IDictionary<char, Parameter> Parameters;

        public State()
        {

        }

        public void SetDictionary(IDictionary<char, Parameter> Parameter)
        {

            this.Parameters = Parameter;

        }

    }
}
