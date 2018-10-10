using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace AdvancedFeatures
{
    class Using_Statement
    {
        public static void Demo()
        {

            ICryptoTransform decryptor = DecryptString();

            using (var fs = File.Open("encrypted.txt", FileMode.Open)) 
                using ( var cs= new CryptoStream(fs, decryptor, CryptoStreamMode.Read))
                    using(var sr = new StreamReader(cs))
                    {
                        Console.WriteLine(sr.ReadToEnd());
                    }
                
            
             
        }

        

        public static ICryptoTransform DecryptString()
        {
            RijndaelManaged rMan = new RijndaelManaged();
            byte[] salt = Encoding.ASCII.GetBytes("my test salt");
            Rfc2898DeriveBytes passMan = new Rfc2898DeriveBytes("test", salt);
            rMan.Key = passMan.GetBytes(rMan.KeySize / 8);
            rMan.IV = passMan.GetBytes(rMan.BlockSize / 8);

            return  rMan.CreateEncryptor();

       
        }
    }
}
