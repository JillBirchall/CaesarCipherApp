using System;
using NUnit.Framework;
using CaesarCipherApp;



namespace CaesarCipherApp.Tests
{
    [TestFixture]
    public class CaesarCipherTests
    {
        [Test]
        [TestCase("abc", "bcd")]
        [TestCase("abc def", "bcd efg")]
        [TestCase("abc-def", "bcd-efg")]
        [TestCase("xyz", "yza")]
        public void EncryptMessage_WhenCalled_ReturnEncryptedMessage(string message, string encryptedMessage)
        {
            var result = CaesarCipher.EncryptMessage(message, 1);
            Assert.That(result, Is.EqualTo(encryptedMessage));
        }

        [Test]
        [TestCase("bcd", "abc")]
        [TestCase("bcd efg", "abc def")]
        [TestCase("bcd-efg", "abc-def")]
        [TestCase("yza", "xyz")]
        public void decryptMessage_WhenCalled_ReturnDecryptedMessage(string encryptedMessage, string decryptedMessage)
        {
            var result = CaesarCipher.DecryptMessage(encryptedMessage, 1);
            Assert.That(result, Is.EqualTo(decryptedMessage));
        }


    }
}