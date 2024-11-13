using System;

public class Program
{
    public static string CaesarCipher(string str, int num)
    {
        char[] buffer = str.ToCharArray();

        //iterate through each character in the string
        for(int i=0;i<buffer.Length;i++)
        {
            char letter = buffer[i];
            //check if character is a letter
            if(char.IsLetter(letter))
            {
                //Determine if letter is uppercase or lowercase
                char offset = char.IsUpper(letter)? 'A':'a';

                //shift character and wrap around using modulo operation
                letter = (char)(((letter+num - offset)% 26)+ offset);
            }
            //store the shifted character back in the array
            buffer[i]= letter;
        }
        //convert char array back to a string
        return new string(buffer);
    }

    public static void Main()
    {
        string text = "Caesar Cipher";
        int shift = 2;

        string result = CaesarCipher(text, shift);
        console.WriteLine(result;)
    }
}