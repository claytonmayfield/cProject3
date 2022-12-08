using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Cracker
{
    internal class password
    {
        private string _raw;
        private string _hash;


        public password(string raw,string hash)
        {
            _raw = raw;
            _hash = hash;
        }
        public string GetRaw()
            { return _raw; }
        public string GetHash()
            { return _hash; }

    }
}
