using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSoftware.Class
{
    public static class passwordEncryption
    {
        //Create your random salt here
        //public static string GetSalt()
        //{
        //    //Pre: Needs no incoming variable
        //    //Post: Returns a random salt string to the user
        //    //Purpose: To create a random salt and then return it

        //    //Create New RNGCryptoServiceProvider
        //    var Random = new RNGCryptoServiceProvider();
        //    //Set max length variable and set it to 32
        //    int maxLength = 32;

        //    //Create a new byte array and set its length to 32
        //    Byte[] salt = new byte[maxLength];

        //    //Fill the byte array with random non zero bytes from the 
        //    //RNGCryptoServiceProvider
        //    Random.GetNonZeroBytes(salt);

        //    //Retrun the salt as a base 64 string
        //    return Convert.ToBase64String(salt);
        //}

        //Create a hashed password
        public static string HashedPassword(string password)
        {
            //Pre: Needs variable password to be initialized
            //Post: Returns a hashed password to the user
            //Purpose: To take a incoming string and then return it to the program

            //Create a new string for password
            string newPass = "";

            //Create a byte array data setting it to Bytes endcoded from incomming string password
            Byte[] data = Encoding.UTF8.GetBytes(password); //Convert to an array of bytes

            //Create a byte array called hash setting it to an encrypted SHA256 of byte array data
            Byte[] hash = new SHA256CryptoServiceProvider().ComputeHash(data);

            //Set newPass string to converted base 64 string of byte array hash
            newPass = Convert.ToBase64String(hash);

            //return newPass string
            return newPass;
        }
    }
}
