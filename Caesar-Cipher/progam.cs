using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      
      Console.WriteLine("Enter your message:");
      string messageFirst = Console.ReadLine();
      string message = messageFirst.ToLower();

      char[] secretMessage = message.ToCharArray();

      char[] encryptedMessage = new char[secretMessage.Length];

      for(int i = 0; i < secretMessage.Length; i++)
      {
        char letter = secretMessage[i];
        int index = Array.IndexOf(alphabet, letter);

        index = (index + 3) % 26;
        char encryptedLetter = alphabet[index];
        encryptedMessage[i] = encryptedLetter;
      }
      
      string encryptedString = String.Join("", encryptedMessage);
      Console.WriteLine($"Encrypted message: {encryptedString}");


    }
  }
}
