<Query Kind="Program" />

void Main()
{
	
	var people = new Person[]{new Person("Jane","jane@gmail.com"),new Person("John","john@gmail.com"),new Person("Chris","chris@gmail.com")};
	var records = new Record[]{new Record("jane@gmail.com","JaneAtFoo"),new Record("jane@gmail.com","JaneAtFoos"),new Record("john@gmail.com","John1980")};
	
	var query = from p in people join r in records on p.Email equals r.Mail select new {Name=p.Name,SkypeId=r.SkypeId}; 
	Console.WriteLine(query);
}

// You can define other methods, fields, classes and namespaces here

public class Person 
{

   public string Name,Email;
   
   public Person(string name,string email)
   {
   Name = name;
   Email = email;
   }

}

class Record 
{

public string Mail , SkypeId;


public Record(string mail,string skypeId)
{

this.Mail = mail;

this.SkypeId = skypeId;

}



}