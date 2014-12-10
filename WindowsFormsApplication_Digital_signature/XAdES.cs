using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using SBXMLSig;
using SBXMLAdESIntf;
using SBXMLSec;
using SBXMLTransform;
using SBXMLCore;


namespace WindowsFormsApplication_Digital_signature
{
    class XAdES
    {

        void test_Method()
        {

            // Creating an instance of XML-DSig signer.
            TElXMLSigner Signer = new TElXMLSigner();
            // Creating an instance of XAdES signer.
            TElXAdESSigner XAdESSigner = new TElXAdESSigner();
            // Setup XAdES processor
            Signer.XAdESProcessor = XAdESSigner;
            try
            {
                // adding a references. For example, adding a reference for a document element.
                TElXMLReference Ref = new TElXMLReference();
                TElXMLDOMDocument Doc = new TElXMLDOMDocument();
                Ref.TransformChain.Add(new TElXMLEnvelopedSignatureTransform());
                Ref.URI = "";
                Ref.URINode = Doc.DocumentElement;
                Signer.References.Add(Ref);

                // Setup Signer options. 
                // For example, using default ones: enveloped signature, RSA-SHA1 signature method and etc.

                // Setup signer key data
                Signer.KeyData = X509Data;

                // calculate digest value for references
                Signer.UpdateReferencesDigest();

                // Filling XAdES info
                // Setting XAdES version
                XAdESSigner.XAdESVersion = SBXMLAdES.Unit.XAdES_v1_4_1;

                // Place a code to setup Signed properties and Timestamp client
                // [XAdES PLACE #1]

                // Generating XAdES structure, specify desired XAdES form as parameter
                XAdESSigner.Generate(SBXMLAdES.Unit.XAdES_BES);

                // Generating signature structure
                Signer.GenerateSignature();

                // Selecting a target node for the signature
                TElXMLDOMNode SigNode = Doc.DocumentElement;
                // Signing and saving signature
                Signer.Save(ref SigNode);

                // Place a code to extend XAdES form immediately after signing.
                // Used, for example, if you want to specify own revocation info not auto collected one.
                // [XAdES PLACE #2]
            }
            finally
            {
                Signer.Dispose();
                XAdESSigner.Dispose();
            }
        }

        public TElXMLKeyInfoData X509Data { get; set; }
    }
}
