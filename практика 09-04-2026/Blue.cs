using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public abstract class Blue : Object
    {
        private string _input;
        public string Input => _input;

        protected static char[] _punc;

        static Blue()
        {
            _punc = new char[] { '.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/' };
        }

        protected Blue(string input)
        {
            _input = input;
        }
        public abstract void Review();
        public virtual void ChangeText(string input)
        {
            _input = input;
            Review();
        }
        protected string[] Getwords(string text)
        {
            // .Select(x => x.Trim(_punc))
            // .Where(x => !String.IsNullOrEmprty(x))
            // .ToArray()
            string[] dirtyWords = text.Split(' ');
            return null;
        }
    }
}
