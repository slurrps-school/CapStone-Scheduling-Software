using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchedulingSoftware.Class;
using System;
using System.Data;

namespace LoginTest
{
    [TestClass]
    public class LoginTests
    {
        //Used to test if the user exists
        [TestMethod]
        public void VerifyUser()
        {
            //String of the Test user test
            string user = "test";

            //Test if user exists which it should work
            Assert.IsTrue(dataProcedures.VerifyUser(user) == true, "Expect user to exist");
        }

        //Testing the Hashing method
        [TestMethod]
        public void ValidateHash()
        {
            string user = "test"; //Test user from the db
            string password = "test"; //Test user password
            string hashedPassword = passwordEncryption.HashedPassword(password); //Hash of the Test user password

            //DataTable to get the stored hash from the db of the user test
            DataTable result = dataProcedures.GetDataTableSQL($"Select password from user where userName = '{user}'");

            //Set the result to the userPassword
            string userPassword = result.Rows[0][0].ToString();

            //Test wheather the hashedPassword and userPassword grabbed from the db are equal
            Assert.AreEqual(hashedPassword,userPassword, "Expected test Hash to equal user hash in server");
        }
    }
}
