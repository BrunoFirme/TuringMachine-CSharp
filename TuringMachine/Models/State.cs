using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachine.Models
{
    class State
    {

        public int Id { get; set; }

        private IDictionary<char, Parameter> Parameter;

        public State(int Id)
        {

            this.Id = Id;

        }

        public void SetDictionary(IDictionary<char, Parameter> Parameter)
        {

            this.Parameter = Parameter;

        }

    }
}
