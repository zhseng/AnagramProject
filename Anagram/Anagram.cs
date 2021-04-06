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
            bool result = true, matchStart = false;
            
            List<char> sampleSplit = sample.ToList<char>();

            foreach (char rowSample in sampleSplit)
            {
                if(string.IsNullOrEmpty(input))
                {
                    break;
                }
                else if(input.Contains(rowSample))
                {
                    if(!matchStart)
                        matchStart = true;

                    input = input.Remove(input.IndexOf(rowSample.ToString()), 1);
                }
                else
                {
                    if(matchStart)
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
