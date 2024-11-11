using System;

class MainClass
{
    public static string LetterChanges(string str)
    {
        char[] chars = str.ToCharArray();

        // Iterate over each character
        for (int i = 0; i < chars.Length; i++)
        {
            char c = chars[i];

            // Check if the character is a letter
            if (char.IsLetter(c))
            {
                // Replace the letter with the next one in the alphabet
                if (c == 'z')
                {
                    chars[i] = 'a';
                }
                else if (c == 'Z')
                {
                    chars[i] = 'A';
                }
                else
                {
                    chars[i] = (char)(c + 1);
                }

                // Check if the new letter is a vowel and capitalize it
                if ("aeiou".IndexOf(chars[i]) >= 0)
                {
                    chars[i] = char.ToUpper(chars[i]);
                }
            }
        }

        // Return the modified string
        return new string(chars);
    }

    static void Main()
    {
        // Keep this function call here
        Console.WriteLine(LetterChanges(Console.ReadLine()));
    }
}
