using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program10_13._11_
{
    class ACipher : Alphabet, ICipher
    {
        public string Encode(string text)
        {
            string result = "";
            foreach (char letter in text)
            {
                if(Alphabet1.Contains(letter))
                {
                    result += Alphabet1[Alphabet1.IndexOf(letter) + 1];
                }
                else
                {
                    result = "Невозможно преобразовать";
                }
            }
            return result;
        }
        public string Decode(string text)
        {
            string result = "";
            foreach (char letter in text)
            {
                if(Alphabet1.Contains(letter))
                {
                    result += Alphabet1[Alphabet1.IndexOf(letter) - 1];
                }
                else
                {
                    result = "Невозможно преобразовать";
                }
            }
            return result;
        }
    }
}
