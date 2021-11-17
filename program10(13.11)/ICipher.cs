using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program10_13._11_
{
        public interface ICipher
        {
            string Encode(string text);
            string Decode(string detext);
        }
}
