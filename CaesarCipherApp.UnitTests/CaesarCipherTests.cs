using System;
using NUnit.Framework;
using CaesarCipherApp;



namespace CaesarCipherApp.Tests
{
    [TestFixture]
    public class CaesarCipherTests
    {
        [Test]
        [TestCase("abc", "bcd", 1)]
        [TestCase("abc def", "bcd efg", 1)]
        [TestCase("abc-def", "bcd-efg", 1)]
        [TestCase("xyz", "yza", 1)]
        [TestCase("Hello", "Rovvy", 10)]
        public void EncryptMessage_WhenCalled_ReturnEncryptedMessage(string message, string encryptedMessage, int shift)
        {
            var result = CaesarCipher.EncryptMessage(message, shift);
            Assert.That(result, Is.EqualTo(encryptedMessage));
        }

        [Test]
        [TestCase("bcd", "abc", 1)]
        [TestCase("bcd efg", "abc def", 1)]
        [TestCase("bcd-efg", "abc-def", 1)]
        [TestCase("yza", "xyz", 1)]
        [TestCase("Rovvy", "Hello", 10)]
        public void decryptMessage_WhenCalled_ReturnDecryptedMessage(string encryptedMessage, string decryptedMessage, int shift)
        {
            var result = CaesarCipher.DecryptMessage(encryptedMessage, shift);
            Assert.That(result, Is.EqualTo(decryptedMessage));
        }


    }
}