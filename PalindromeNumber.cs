using System;
		
public class Program
{
	// Méthode 1
	public static bool IsPalindrome(int x) 
	{    
		var xString = x.ToString();
		var length = xString.Length;
		var isPalindrome = false;
	
		if(xString.Length == 1) return true;
	
		for(int i=0; i<(length - (i+1)); i++) 
		{
			    isPalindrome = xString[i] == xString[length - (i+1)];
			    if(!isPalindrome) return false; 
		}
	
		return isPalindrome;
	}
	 
    	/* 
    	// Méthode 2
    	public static bool IsPalindrome(int x) 
    	{
		//Convertir x en string 
    		var xString = x.ToString();
		var xStringTemp = "";
		var isPalindrome = false; 
	
		//Invert xString: xString = 122 then xStringTemp = 221
		for(int i = (xString.Length-1); i>=0 ;i--)
		{
	  		xStringTemp += xString[i];
		}

		if(xStringTemp != xString) isPalindrome = false;
		else isPalindrome = true;
    		return isPalindrome;
	  }
    	*/
}

public static void Main()
{
        var x = 121;
        var y = 22; 
        var z = 1;
        var w = 100021;

        Console.WriteLine($"x is a palindrome : {IsPalindrome(x)}");
        Console.WriteLine($"y is a palindrome : {IsPalindrome(y)}");
        Console.WriteLine($"z is a palindrome : {IsPalindrome(z)}");
        Console.WriteLine($"w is a palindrome : {IsPalindrome(w)}");
}
