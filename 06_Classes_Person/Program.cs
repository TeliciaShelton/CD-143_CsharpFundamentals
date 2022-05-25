//! Person Class 

Person person = new Person();
person.LastName = "Parker";
person.FirstName = "Peter";
person.DateofBirth = new DateTime(1962, 6, 5);
System.Console.WriteLine($"{person.FullName} is {person.Age} years old.");

Person person2 = new Person("Bruce", "Wayne", new DateTime(1939, 5, 1));
System.Console.WriteLine($"{person2.FullName} is {person2.Age} years old.");

Person person3 = new Person(1963, "Charles", "Xavier");
System.Console.WriteLine(person3.ID);
// person3.ID = 10;
// System.Console.WriteLine(person3.ID);

//!-----------------------------Class Object --------------------------------------

public class Person {
        // Properties
    public string FirstName {get; set;}

    //Field
    private string _lastname; // fields are private //private fields are always noted with the underscore first.

     public string LastName {
        /* 
            -We have a method to get the persons lastname and set the persons last name. 
            We can customize how our get/set are detailed.
            -Setting just a "get; set;" is just a shorthand for what this property is doing.  
        */

        get {return _lastname; }
        set {_lastname = value; } // value is a keyword specific to this situation and equals whatever value was provided when creating the person. 
    }
    
    public string FullName {
            get { return $"{FirstName} {LastName}";}
    }

    public DateTime DateofBirth {get; set;}

public int Age {
        get{
            TimeSpan exactAge = DateTime.Now - DateofBirth;
            double totalDays = exactAge.TotalDays;
            double yearsUnrounded = totalDays / 365.24; 
            int years = (int) Math.Round(yearsUnrounded); // Math will provide us a double datetime, so we will cast it as an int that Rounds up/ 
            return years;
        }
    }
    


//! Constructors 
/*
    -Invoked automatically when object is created. 
    -Initializes the date members of a new object. 

    Has two types: 
        -Default constructor
        -Parameterized constructor 
*/

    public Person (){} // we have created a blank constructor default
    //* ctor- emmet for constructor boilerplate

    public Person(string firstName, string lastName, DateTime dateofBirth)
    {
        FirstName = firstName; 
            /*
                1.Property name
                2. value to be set to property.            
            */
            _lastname = lastName; 
            DateofBirth = dateofBirth;
    }

    public Person(int id,string Firstname, string Lastname)
    {
        _idNumber = id;
        FirstName = Firstname;
        _lastname = Lastname;
     }
     
    private int _idNumber; 
    public int  ID
    {
        get {return _idNumber;}
        // When we assign the ID of the person up creation (in the 3rd constructor), we cannot alter it because it is a Read Only. 
    }
}