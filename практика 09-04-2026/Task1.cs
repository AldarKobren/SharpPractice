using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Task1 : Blue
    {
        private int _output;
        public int Output => _output;

        public Task1(string text) : base(text)
        {
            _output = 0;
            Review();
        }

        public override void Review()
        {
            _output = 134;
        }

        public override string ToString()
        {
            return $"{_input}{Environment.NewLine}{_output}";
        }
    }
}
