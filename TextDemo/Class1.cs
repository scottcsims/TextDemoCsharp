using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TextDemo
{
    public class TextFunctions
    {
        public string PalindromeReverseStrings(string sentence)
        {
            var tokens = sentence.Split();
            var result = "";
            foreach (string word in tokens)
            {
                for (var wordPointer = word.Length - 1; wordPointer >= 0; wordPointer--)
                {
                    result += word[wordPointer];
                }
                if (word != tokens.Last())
                {
                    result += " ";
                }
            }
            return result;
        }

        public string PalindromeSwap(string sentence)
        {
            var tokens = sentence.Split();
            var result = "";
            foreach (string word in tokens)
            {
                var swaps = word.Length/2;
                var lastCharacterIndex = word.Length - 1;
                char[] characters = word.ToCharArray();
                for (var swapCount = 0; swapCount < swaps; swapCount++)
                {
                    var leftSwapIndex = 0 + swapCount;
                    var rightSwapIndex = lastCharacterIndex - swapCount;

                    var leftSwapCharacter = characters[leftSwapIndex];
                    var rightSwapCharacter = characters[rightSwapIndex];

                    characters[leftSwapIndex] = rightSwapCharacter;
                    characters[rightSwapIndex] = leftSwapCharacter;
                }
                result += new string(characters);
                if (word != tokens.Last())
                {
                    result += " ";
                }
            }
            return result;
        }
    }
}