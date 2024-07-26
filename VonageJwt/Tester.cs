// Sample by Beejay Urzo
// Vonage CSE
// July 25, 2024
// Add your AppID in line 15
// Add you Privatekey inside privatekey.pem

using System;
using System.IO;
namespace VonageJwt
{
    internal class Tester
    {
        static void Main(string[] args)
        {
            string appID = "YOUR APP ID";
            string privatekeyPath = "privatekey.pem";
            StreamReader sr = new StreamReader(privatekeyPath);
            //Read the first line of text
            string privatekey = sr.ReadToEnd();
            string token = Jwt.CreateToken(appID, privatekey);  //add a fourth param for expiry in seconds         
            Console.WriteLine("Your Token with default expiry of 24 hours:");
            Console.WriteLine(token);
            Console.WriteLine("\nYou can put it inside https://jwt.io/ to decode and validate");

            //expires in 3 hours
            token = Jwt.CreateToken(appID, privatekey, 10800);
            Console.WriteLine("\n\n------------------\nYour Token with expiry of 3 hours:");
            Console.WriteLine(token);
            Console.WriteLine("\nYou can put it inside https://jwt.io/ to decode and validate");

            //Creates an Admin token with all ACL 3 Hours Expiry
            token = Jwt.CreateAdminToken(appID, privatekey, 10800);
            Console.WriteLine("\n\n------------------\nYour Admin Token with expiry of 3 hours:");
            Console.WriteLine(token);
            Console.WriteLine("\nYou can put it inside https://jwt.io/ to decode and validate");

            //Creates a User token with default 24 hour Expiry 
            token = Jwt.CreateUserToken(appID, privatekey, "bob"); //add a fourth param for expiry in seconds
            Console.WriteLine("\n\n------------------\nYour user Token for 'bob' with expiry of 24 hours:");
            Console.WriteLine(token);
            Console.WriteLine("\nYou can put it inside https://jwt.io/ to decode and validate");

            Console.WriteLine("\n\nPress Enter/Return to end.");
            Console.ReadLine();
        }
    }
}
