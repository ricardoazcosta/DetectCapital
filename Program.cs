// See https://aka.ms/new-console-template for more information
using System;
public class Solution
{
    public bool DetectCapitalUse(string word)
    {
        if (string.IsNullOrEmpty(word)) return false;

        //Caso todas as letras são maiúsculas
        if (word.ToUpper() == word) return true;
        //Caso todas as letras são minúsculas
        if (word.ToLower() == word) return true;
        //Caso a primeira letra é maiúscula e o resto minúscula
        if (char.IsUpper(word[0]) && word.Substring(1).ToLower() == word.Substring(1))
            return true;
        return false;
    }
}
class Program
{
    static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.DetectCapitalUse("USA")); //True
        Console.WriteLine(solution.DetectCapitalUse("FlaG")); //False
        Console.WriteLine(solution.DetectCapitalUse("flag")); //True
        Console.WriteLine(solution.DetectCapitalUse("Flag")); //True
    }
}
