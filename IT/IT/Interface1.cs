using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT
{
    interface Interface1
    {
        string Encryp(string str);
        string Decryp(string str);
        void CreateKey();

        int GlobalKey { get; set; }
        int PrivateKey { get; set; }
        int PublicKey { get; set; }

    }
}
