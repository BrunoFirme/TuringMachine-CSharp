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

        public State(int Id, IDictionary<char, Parameter> Parameter)
        {

            this.Id = Id;

            this.Parameter = Parameter;

        }

        public State(int Id)
        {

            this.Id = Id;

        }

    }
}
