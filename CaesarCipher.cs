using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipherApp
{
    static public class CaesarCipher
    {

        static char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        /// <summary>
        ///  Encrypts the message using the specified shift 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="shift"></param>
        /// <returns>Encrypted Message</returns>
        static public string EncryptMessage(string message, int shift)
        {
            string encryptedMessage = "";

            //loop through message
            for (int i = 0; i < message.Length; i++)
            {
                if (Array.IndexOf(alphabet, message[i]) > -1)
                {
                    int newIndex = Array.IndexOf(alphabet, message[i]) + shift;
                    if (newIndex > (alphabet.Length - 1))
                        newIndex = newIndex - alphabet.Length;
                    encryptedMessage += alphabet[newIndex];
                }
                else if (Char.IsUpper(message[i]))
                {
                    char lowerCaseLetter = Char.ToLower(message[i]);
                    int newIndex = Array.IndexOf(alphabet, lowerCaseLetter) + shift;
                    if (newIndex > (alphabet.Length - 1))
                        newIndex = newIndex - alphabet.Length;
                    encryptedMessage += Char.ToUpper(alphabet[newIndex]);
                }
                else
                {
                    encryptedMessage += message[i];
                }
            }
            return encryptedMessage;
        }

        /// <summary>
        /// Decrypts the message using the specified shift
        /// </summary>
        /// <param name="message"></param>
        /// <param name="shift"></param>
        /// <returns>Decrypted Message</returns>
        static public string DecryptMessage(string message, int shift)
        {
            string decryptedMessage = "";

            //loop through message
            for (int i = 0; i < message.Length; i++)
            {
                if (Array.IndexOf(alphabet, message[i]) > -1)
                {
                    int newIndex = Array.IndexOf(alphabet, message[i]) - shift;
                    if (newIndex < 0)
                        newIndex = newIndex + alphabet.Length;
                    decryptedMessage += alphabet[newIndex];
                }
                else if (Char.IsUpper(message[i]))
                {
                    char lowerCaseLetter = Char.ToLower(message[i]);
                    int newIndex = Array.IndexOf(alphabet, lowerCaseLetter) - shift;
                    if (newIndex < 0)
                        newIndex = newIndex + alphabet.Length;
                    decryptedMessage += Char.ToUpper(alphabet[newIndex]);
                }
                else
                {
                    decryptedMessage += message[i];
                }
            }
            return decryptedMessage;
        }
    }
}

