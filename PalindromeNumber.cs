using System;
		
public class Program
{
	public static bool IsPalindrome(int x) 
	{
		//Convertir x en string 
        var xString = x.ToString();
		var xStringTemp = "";
		var isPalindrome = false; 
		
		//Inverser xString : xString = 122 alors xStringTemp = 221 
		for(int i = (xString.Length-1); i>=0 ;i--)
		{
            xStringTemp += xString[i];
		}

        if(xStringTemp != xString) isPalindrome = false;
        else isPalindrome = true;
		
		return isPalindrome;
    }
	
	public static void Main()
	{
		var x = 121;
		var y = 122; 
		var z = 1;
		
		Console.WriteLine($"x is a palindrome : {IsPalindrome(x)}");
		Console.WriteLine($"y is a palindrome : {IsPalindrome(y)}");
		Console.WriteLine($"z is a palindrome : {IsPalindrome(z)}");
    }
}