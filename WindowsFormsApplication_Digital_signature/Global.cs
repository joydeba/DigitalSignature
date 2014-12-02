using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication_Digital_signature
{
    class Global
    {
        public byte[] toEncrypt;
        public byte[] encrypted;
        public byte[] signature;
        Bob mySender = new Bob();
        Alice myReceiver = new Alice();
        UTF8Encoding enc = new UTF8Encoding();

    }
}
