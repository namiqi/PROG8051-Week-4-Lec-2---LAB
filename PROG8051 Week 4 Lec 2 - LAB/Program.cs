using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
             Password Validation

             */

            while (true)
            {
                Console.WriteLine("Give me your name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Give me a password: ");
                string password = Console.ReadLine();


                // make sure it has more than 8 characters

                int errors = 0;
                string errormessages = "";

                if (password.Length < 8)
                {
                    errormessages += $"{errors+1}.Password is too short \n";
                    errors++;
                }

                // if it starts with capital letter
                if (!Char.IsUpper(password[0]))
                {
                    errormessages += $"{errors+1}.Password should start with Capital letter\n";
                    errors++;
                }

                // if the password contains the name

                if (password.Contains(name))
                {
                    errormessages += $"{errors + 1}.Password should not contain the name\n";
                    errors++;
                }

                if (errors == 0)
                {
                    break;
                }
                Console.WriteLine($"There were {errors} errors");
                Console.WriteLine(errormessages);

            }


            /*
            Character Counter: Create a program that counts the number of occurrences of
             a specific character in a given string entered by the user.Use a for loop to iterate through the string.
            */

            Console.WriteLine("Give me a word: ");
            string sentence = Console.ReadLine();

            // how many letter a is in sentence

            int count = 0;

            for(int j = 0; j < sentence.Length; j++)
            {
                if (sentence[j] == 'a' || sentence[j] == 'i' || sentence[j] == 'e' || sentence[j] == 'o' || sentence[j] == 'u')
                {
                    count += 1; // count = count + 1
                    
                }
                
            }
            Console.WriteLine(count);

            /*
             String Reversal: Write a C# program that takes a string as input from the user
            and then reverses and prints the characters of the string using a for loop.

             Palindrome Checker: Implement a program that checks if a given word or phrase is a
            palindrome (reads the same forwards and backwards). Ask the user for input and use a 
            loop to perform the check.Ignore spaces and consider case-insensitivity.
            */


            Console.WriteLine("Give me a word and I will reverse it: ");
            string word = Console.ReadLine();

            string newword = "";
            for(int i = 0; i < word.Length; i++)
            {
                newword += word[word.Length - i-1];// word[4]
            }

            if (word.ToLower().Equals(newword.ToLower()))
            {
                Console.WriteLine("this is a palindrome");
            }
            else
            {
                Console.WriteLine("this is not a palindrome");
            }


          




            /*
            Word Reversal: Develop a program that takes a sentence as input from
            the user and then reverses the order of the words in the sentence using loops.
            For example, "Hello World" becomes "World Hello."

            String Encryption: Write a program that encrypts a string entered by the user.
            You can implement a simple encryption technique such as shifting each character
            by a fixed number of positions in the alphabet(Caesar cipher). Ask the user for 
            the input string and the shift value, and use a loop to perform the encryption.
            */
        }
    }
}