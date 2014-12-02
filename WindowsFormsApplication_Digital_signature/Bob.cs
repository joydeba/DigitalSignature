using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace WindowsFormsApplication_Digital_signature
{
    class Bob
    {
        RSAParameters rsaPubParams;
        RSAParameters rsaPrivateParams;

        public Bob()
        {
            RSACryptoServiceProvider rsaCSP = new RSACryptoServiceProvider();
            rsaPrivateParams = rsaCSP.ExportParameters(true);
            rsaPubParams = rsaCSP.ExportParameters(false);
        }

        public RSAParameters PublicParameters()
        {
            return rsaPubParams;
        }


        public byte[] EncryptData(RSAParameters rsaParams, byte[] toEncrypt)
        {
            RSACryptoServiceProvider rsaCSP = new RSACryptoServiceProvider();
            rsaCSP.ImportParameters(rsaParams);
            return rsaCSP.Encrypt(toEncrypt, false);
        }

    }
}
