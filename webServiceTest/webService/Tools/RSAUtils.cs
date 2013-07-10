using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Configuration;
using System.IO;

namespace RSAService.Tools
{
    class RSAUtils
    {
        private static CspParameters cspParams = new CspParameters();

        static RSAUtils()
        {
            cspParams.Flags = CspProviderFlags.UseMachineKeyStore;
        }

        public static String GetKeyFunction()
        {
            string keyFileName = System.Web.HttpContext.Current.Server.MapPath("~/MyXml/");
            const int keySize = 1024;

            RSACryptoServiceProvider sp = new RSACryptoServiceProvider(keySize);

            string str = sp.ToXmlString(true);
            string KeyXml = Guid.NewGuid().ToString();
            //System.Web.HttpContext.Current.Session["key"] = KeyXml;
            TextWriter writer = new StreamWriter(keyFileName + KeyXml + ".xml");
            writer.Write(str);
            writer.Close();

            str = sp.ToXmlString(false);
            writer = new StreamWriter(keyFileName + KeyXml + "public.xml");
            writer.Write(str);
            writer.Close();
            return KeyXml;
        }

        public static String getRSA_E(String keyFileName)
        {
            RSACryptoServiceProvider _sp = new RSACryptoServiceProvider(cspParams);
            _sp.FromXmlString(readKeyFile(keyFileName));

            RSAParameters param = _sp.ExportParameters(true);
            return StringHelper.BytesToHexString(param.Exponent);
        }

        public static String getRSA_M(String keyFileName)
        {
            RSACryptoServiceProvider _sp = new RSACryptoServiceProvider(cspParams);
            _sp.FromXmlString(readKeyFile(keyFileName));

            RSAParameters param = _sp.ExportParameters(true);
            return StringHelper.BytesToHexString(param.Modulus);
        }

        public static String Decrypt(String content,String  keyFileName)
        {
            RSACryptoServiceProvider _sp = new RSACryptoServiceProvider(cspParams);
            _sp.FromXmlString(readKeyFile(keyFileName));
            _sp = new RSACryptoServiceProvider(cspParams);
            string path = keyFileName;
            System.IO.StreamReader reader = new StreamReader(path + ".xml");
            string data = reader.ReadToEnd();
            _sp.FromXmlString(data);


            byte[] result;
            result = _sp.Decrypt(StringHelper.HexStringToBytes(content), false);
            return StringHelper.ASCIIBytesToString(result);

        }

        private static String readKeyFile(String keyFileName)
        {
            string path = keyFileName;
            System.IO.StreamReader reader = new StreamReader(path + ".xml");
            string data = reader.ReadToEnd();
            return data;
        }

    }
}
