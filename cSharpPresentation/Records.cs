

using System.Net;

namespace cSharpPresentation;

internal static class RecordExample
{
    internal static void Run()
    {
        //var person = new Person("John", "Doe");

        //var personClass = new PersonClass
        //{
        //    FirstName = "John",
        //    LastName = "Doe"
        //};

        //Console.WriteLine($"person class: {personClass}");
        //Console.WriteLine(person);


        ////comparing objects
        //var personClass2 = new PersonClass
        //{
        //    FirstName = "John",
        //    LastName = "Doe"
        //};

        //Console.WriteLine(personClass == personClass2);

        //var person2 = new Person("John", "Doe");
        //Console.WriteLine(person == person2);

        ////use ReferenceEquals to compare reference
        //Console.WriteLine(ReferenceEquals(person, person2));

        ////creating new record base on another one
        //var person3 = person with { FirstName = "Jane" };

        ////deconstructing person
        //var (firstName, lastName) = person;
        //Console.WriteLine($"First Name: {firstName}, Last Name: {lastName}");

/**********************************************************************************************/

        PersonMutable mutablePerson = new PersonMutable("John", "Tel Aviv");
        Console.WriteLine(mutablePerson);

        mutablePerson.FirstName = "other name";
       // mutablePerson.Address = "other address";
        Console.WriteLine(mutablePerson);
    }
}


internal record Person(string FirstName, string LastName);

internal record PersonMutable
{
    public string? FirstName { get; set; }
    private string? LastName { get; set; }
    public string? Address { get; init; }

    public PersonMutable(string firstName, string address)
    {
        LastName = "pepe";
        FirstName = firstName;
        Address = address;
    }
}

internal class PersonClass
{
    public string FirstName { get; init; } = default!;  //init is also a new feature in C# 9
    public string LastName { get; init; } = default!;
    public int? Age { get; set; }
}