using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Services
{
    public class InputReader
    {
        protected readonly IEnumerable<string> Input;
        private InputReader() { }

        public InputReader(string input) 
        { 
            if (string.IsNullOrEmpty(input)) throw new ArgumentNullException("Invalid input file");

            var fileContent = File.ReadLines(input);

            if (fileContent.Any() == false)
                throw new ArgumentException("Empty file");

            Input = fileContent;
        }
    }
}
