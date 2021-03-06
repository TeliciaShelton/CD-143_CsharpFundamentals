//! Comments 
/*
    -Clarify code 
        -detailing different concepts 
        -Reference 
    -Communicate to other developers/ future you 
    -Track History
*/

// Single Line 
/*
Multi-Line 
*/

/*
! Solution File
    When we create a solution file, the basic implementation of the command twill greab the name of the parent directiory and assign it to the new solution that it is generating. 
        In our case: dotnet new sln = Csharpfundamentals.sln
            -Two ways to start it:
                -dotnet new sln -n [name.sln]
                -dotnet new sln (while inside folder)

    The solution will go on to group together the bulk of our notes

    *   What's in the package?
            -cproject: Csharp project file-  Holds the SDK (software Development Kit) for us to run our projects.
            -obj [folder/directory]: Various packages that help our code run (not a high concern right now)
            -cs: where we write our code \. 
    */




// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
!   Variable

    datatype variableName = value;

        -Must start with datatype and be given a name. 
        -Doesn't need to be assigned a value right away.

    */
    /*
    !Booleans
        -Booleans: 1 byte
            -stores True/False statements/values
    */

    //    Creating a variable
    //  

    bool isDeclared = true; 
    bool isNotDeclared;

    // Console.WriteLine(isNotDeclared);

    isNotDeclared = false;

    // cw 
    System.Console.WriteLine(isNotDeclared);
    /*
    !Characters
        -char: 2 bytes
            -Stores single character/letter, surrounded by a single quote ' '

            char character = 'a';
            char symbol = '?';
            char number = '8'; 
            char whitespace = ' '; 
            char specialCharacter = '\n';
    */
    /*
    !String
        -String: 2 bytes per character 
        -Stores a sequence of characters, surrond by double quotes " ".
    */
    /*
    !Numbers
        -int: 4 bytes (int-Integers)
        -long: 8 bytes
    */
byte byteExample = 255; //anything between 0- 255 due to binary code 
sbyte sByteMin= -128; // between -128 through 2127  (128 x 2 while accountng for zero)
short shortExample = 32767; // max 
int intMin= -2147483648;
Int32 IntMax= 2147483647; //fits a 32 bit

long longExample = 9223372036854775807; //same as an Int64
Int64 longMin=-9223372036854775808; // same as a long

byte numByte = 25;
System.Console.WriteLine(numByte);

//* casting:
System.Console.WriteLine((char) numByte); // we are translating the byte into a character. This changes the value into the list of characters. 
System.Console.WriteLine((long) numByte);

/*
!Decimals
    -float; 4 bytes
        -stores fractional numbers.Sufficient for storing 6 to 7 decimal digtis.(add f to the end of figure to identity float)
    -double: 8 bytes
        -stores fractional numbers. Sufficient for storing 15 decimal digits. 
*/

float floatExample = 1.0443534f; // The digits are represented in binary except for the period. We use the "f" at the end to detail that we are storing a float value. 
double doubleExample = 1.73245463456345d; // like float but double the space.
double defaultDouble = 198271; // When referring decimal numbers, this is the default expectation and doesn't require a "d". For consistancy \, it is best to place it. 
decimal decimalExample = 1.248372628472727484927328m; //Highest for of number. Typically used for currency \. We us a "m" to detail that this vaule is meant for a decimal.

 System.Console.WriteLine("Float: " + 1.248372628472727484927328f);
 System.Console.WriteLine("Double: " + 1.248372628472727484927328d);
 System.Console.WriteLine ("Decimal: " + 1.248372628472727484927328m);

 /*
 !Struts
    Data Structures
 */
 
 int age = 42;
 DateTime today = DateTime.Today;
 System.Console.WriteLine(today);

 DateTimeOffset todayUTC = DateTimeOffset.Now; 
 System.Console.WriteLine(todayUTC);

DateTime birthday = new DateTime (2015, 1, 7);
System.Console.WriteLine(birthday);