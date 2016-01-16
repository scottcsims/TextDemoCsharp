using System;
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
        public string Palindrome(string sentence)
        {
            var tokens= sentence.Split();
            var result = "";
            foreach (string word in tokens)
            {
                for (var wordPointer=word.Length-1;wordPointer >= 0 ;wordPointer--)
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
    }
}
