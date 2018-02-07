using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace passkeeper
{
    class DesEncrytion
    {
        static TripleDES CreateDes(string key)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            TripleDES des = new TripleDESCryptoServiceProvider();
            des.Key = md5.ComputeHash(Encoding.Unicode.GetBytes(key));
            des.IV = new byte[des.BlockSize / 8];
            return des;
        }

        public string EncryptString(string plainText, string password)
        {
            byte[] plainTextBytes = Encoding.Unicode.GetBytes(plainText);
            MemoryStream myStream = new MemoryStream();

            TripleDES des = CreateDes(password);
            CryptoStream cryptstream = new CryptoStream(myStream, des.CreateEncryptor(), CryptoStreamMode.Write);

            cryptstream.Write(plainTextBytes, 0, plainTextBytes.Length);
            cryptstream.FlushFinalBlock();

            return Convert.ToBase64String(myStream.ToArray());
        }

        public string DecryptString(string encryptedText, string password)
        {
            byte[] encryptedTextBytes = Convert.FromBase64String(encryptedText);
            MemoryStream myStream = new MemoryStream();
            myStream.Position = 0;
            TripleDES des = CreateDes(password);

            CryptoStream decryptStream = new CryptoStream(myStream, des.CreateDecryptor(), CryptoStreamMode.Write);

            decryptStream.Write(encryptedTextBytes, 0, encryptedTextBytes.Length);
            decryptStream.FlushFinalBlock();

            return Encoding.Unicode.GetString(myStream.ToArray());
        }
    }
}
