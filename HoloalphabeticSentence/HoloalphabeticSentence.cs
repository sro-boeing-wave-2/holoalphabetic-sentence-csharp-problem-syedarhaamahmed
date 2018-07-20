using System;
using System.Linq;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        // Write the logic to determine whether the input string is a HoloalphabeticSentence or not
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
            input = input.ToLower();
            int count = 0;
            for (int i=0; i < alphabets.Length; i++){

                char letter = alphabets[i];
                if (input.IndexOf(letter)==-1)
                    break;
                else {
                    count++;
                     }
                }

            if (count == 26)
                {return true;}
            else
            return false;
        }
    }
}
