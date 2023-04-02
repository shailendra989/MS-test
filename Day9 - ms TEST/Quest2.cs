using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9___ms_TEST
{
    using System;
    using System.Linq;

    class Program
    {
        static void Run(string[] args)
        {
            Console.Write("Enter the words: ");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');

            bool isAnagram = CheckAnagram(words[0], words[1]);

            if (isAnagram)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        public static bool CheckAnagram(string word1, string word2)
        {
            if (word1.Length != word2.Length)
            {
                return false;
            }

            char[] chars1 = word1.ToLower().ToCharArray();
            char[] chars2 = word2.ToLower().ToCharArray();

            Array.Sort(chars1);
            Array.Sort(chars2);

            return chars1.SequenceEqual(chars2);
        }
    }

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void CheckAnagram_ValidAnagram_ReturnsTrue()
        {
            // Arrange
            string word1 = "part";
            string word2 = "trap";

            // Act
            bool result = Program.CheckAnagram(word1, word2);
           
            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckAnagram_InvalidAnagram_ReturnsFalse()
        {
            // Arrange
            string word1 = "noon";
            string word2 = "moon";

            // Act
            bool result = Program.CheckAnagram(word1, word2);

            // Assert
            Assert.IsFalse(result);
        }
    }

}
