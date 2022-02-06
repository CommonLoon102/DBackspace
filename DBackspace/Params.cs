using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBackspace
{
    internal class Params
    {
        public string Source { get; }
        public string Stage { get; }

        public Params(string source, string stage)
        {
            Source = source;
            Stage = stage;
        }
    }
}
