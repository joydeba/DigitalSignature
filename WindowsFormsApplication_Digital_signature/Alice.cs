using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace WindowsFormsApplication_Digital_signature
{
    class Alice
    {
        RSAParameters rsaPubParams;
        RSAParameters rsaPrivateParams;

        public Alice()
        {
            RSACryptoServiceProvider rsaCSP = new RSACryptoServiceProvider();
            rsaPrivateParams = rsaCSP.ExportParameters(true);
            rsaPubParams = rsaCSP.ExportParameters(false);
        }

        public RSAParameters PublicParameters()
        {
            return rsaPubParams;
        }

        public bool VerifyHash(RSAParameters rsaParams, byte[] signedData, byte[] signature)
        {
            RSACryptoServiceProvider rsaCSP = new RSACryptoServiceProvider();
            SHA1Managed hash = new SHA1Managed();
            Byte[] hashedData;
            rsaCSP.ImportParameters(rsaParams);
            hashedData = hash.ComputeHash(signedData);
            return rsaCSP.VerifyHash(hashedData, CryptoConfig.MapNameToOID("SHA1"), signature);

        }

        public string DecryptData(byte[] encrypted)
        {
            byte[] fromEncrypt;
            string roundTrip;
            RSACryptoServiceProvider rsaCSP=new RSACryptoServiceProvider();
            rsaCSP.ImportParameters(rsaPrivateParams);
            fromEncrypt = rsaCSP.Decrypt(encrypted, false);
            roundTrip = Encoding.Unicode.GetString(fromEncrypt);
            return roundTrip;
        }

    
    }
}
