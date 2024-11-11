using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MainClass
{
    public string LetterChanges(string str)
    {
        char[] chars = str.ToCharArray();

        //iterator for each character
        for(int i=0;i<chars.Length;i++)
        {
            char c = chars[i];

            //check if the character is a letter
            if(char.IsLetter(c))
            {
                //replace the letter with the next one in alphabet
                if(c == 'Z')
                {
                    chars[i] = 'a';
                }
                else if(c == 'Z')
                {
                    chars[i] = 'Z';
                }
                else
                {
                    chars[i] = (char)(c + 1);
                }
                if ("aeiou".IndexOf(chars[i])>=0)
                {
                    chars[i] = char.ToUpper(chars[i]);
                }

            }
        }
        return new string(chars);
    }
    static void Main()
    {
        Console.WriteLine(LetterChanges(Console.ReadLine));
    }
}
