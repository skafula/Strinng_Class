using System;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        #region System.String class basics

        //String is interesting as CLR knows if the object with the same value already exists so below 'a' and 'b' variables refer to the same object.
        //String is an object with indexer from 0-stringObjectVariable.Length-1. It's a collection of Unicode characters (every possible character in the world exists).
        //"Hello World" -> char array: Hello World - 0123456789
        //However string is immutable type so it can't be modified in the same object. With every modification it creates a new object as you can see below:
        string a = "Hello World";
        string b = "Hello World"; //Both point the same object, however any modificaton makes a new string objects with the reference to the equaled variable
        b = "Another world"; //b now refers to "Another world while a refers "Hello World".

        string c = a.ToUpper(); //a.ToUpper() makes an other object of string refers by 'c', but a still points to "Hello World!"
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);

        #endregion

        #region Methods of System.String class

            #region Converting Methods

        //stringVariable.ToUpper() / ToLower() -> makes a new object with the original characters but in full of Upper or Lower case.
        Console.WriteLine("Upper: " + a.ToUpper());
        Console.WriteLine("Lower: " + a.ToLower());

        //Substring(int), Substring(int,int) -> first int for the startng position and second for the length (neither could be point for longer than the original Length.
        Console.WriteLine("Substring 3: " + a.Substring(3));
        Console.WriteLine("Substring 3,2: " + a.Substring(3, 2));

        Console.WriteLine("Replace (o,x): " + a.Replace("o", "x")); //in single quotes char can be replaced, but with double quets words are also possible

        string[] stringArray = a.Split(' '); //Split returns a string array depends on the separator character

        for (int i = 0; i < stringArray.Length; i++)
        {
            Console.Write(i+1 + ". element: " +  stringArray[i] + "; ");
        }
        Console.WriteLine();

        Console.WriteLine("   S p a c e   ".Trim()); //Trim removes " " characters fromt the very left and very right

        char[] charArray = a.ToCharArray(); //returns a new object of char[]
        foreach (char ch in charArray)
        {
            Console.WriteLine(ch);
        }

        string strJoin = string.Join("--", stringArray); //Static method returns a string by the elements of a string array (or some other arrays/collections) connected with a char or string (it has a lot of overload)

        Console.WriteLine(strJoin);

        #endregion

        Console.WriteLine("___________________________________________________");
        Console.WriteLine();

            #region Checking Methods

        Console.WriteLine("Equals is same as '==': " + a.Equals("Hello World")); //Equals checks the value of the string object. With strings Equal and '==' operator is the same.
        Console.WriteLine("StartsWith(): " + a.StartsWith("He")); //Checks if the string starts with a special character or string
        Console.WriteLine("EndsWith: " + a.EndsWith("ld")); //Works same as StartsWith but checks the end of the string
        Console.WriteLine("Contains(): " + a.Contains("llo "));
        Console.WriteLine("IndexOf('o'), IndexOf('c'), IndexOf('o',5): " + a.IndexOf('o') + ", " + a.IndexOf('c') + ", " + a.IndexOf('o', 5)); //If char or string doesn't exist in the string it returns -1, and it returns the first match's index
        //LastIndexOf -> Pretty much the same but iterates the string reverse order.
        //IsNullOrEmpty -> Statc! Checks if the string is empty or null: "" - true, null - true, " " - false, "a" - false.
        //IsNullOrWhiteSpace -> Static! Same as IsNullOrEmpty, but returns true if string has only space(s) character(s).

            #endregion

        Console.WriteLine("___________________________________________________");
        Console.WriteLine();

            #region Formatting Methods

        //The old format was "{n} is a variable. {n+1} is an ather variable."
        //From C# 6.0 theres a new format: $"{variable} ... {otherVariable} and so on"
        int var1 = 1;
        string var2 = "Random";

        string oldFormat = string.Format("{0} is a {1} number.", var1, var2);
        Console.WriteLine(oldFormat);
        string newFormat = $"{var1} is a {var2} number";
        Console.WriteLine(newFormat);

        #endregion

        Console.WriteLine("___________________________________________________");
        Console.WriteLine();

            #region Modifying strings

        //Inser(int startindex, string value) -> insert a char or string from the int. index.
        Console.WriteLine("Insert: " + a.Insert(2, " INSERTED "));

        //Remove(int startindex, int length) starting index and length.
        Console.WriteLine("Remove: " + a.Remove(2, 3));

        #endregion

        Console.WriteLine("___________________________________________________");
        Console.WriteLine();

            #region Strings with for loop

        //I only use the shortest expression to Count exact characters in a string
        char[] wowels = new char[] { 'a', 'b', 'c', 'd', 'e', 'A', 'B', 'C', 'D', 'E' };
        string example = "bestdeveloper@example.com";

        Console.WriteLine("Counted result: " + example.Count(ch => Array.IndexOf(wowels, ch) >= 0));

            #endregion

        #endregion



    }
}