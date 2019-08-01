using System;

public class Palindrome
{
    public static bool IsPalindrome(string word)
    {
        word = word.ToLower();
        string newWord = word;
        char[] newArr = newWord.ToCharArray();

        Array.Reverse(newArr);

        Console.WriteLine(newArr);

        string tempWord = new string (newArr);
                
        if (tempWord == word)
        {
            return true;
        }
        
        
        throw new NotImplementedException("Waiting to be implemented.");
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));
        Console.ReadLine();
    }
}