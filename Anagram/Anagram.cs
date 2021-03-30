using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    public class AnagramTool
    {
        public bool AnagramStrStr(string input, string sample)
        {
            bool result = false;

            result = sample.ToLower().Contains(input.ToLower());

            if (!result)
                result = sample.ToLower().Contains(new string(input.ToLower().Reverse().ToArray()));

            return result;
        }
    }
}
