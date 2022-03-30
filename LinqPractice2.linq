<Query Kind="Program" />

void Main()
{
	
	
	var people = new List<Person>{new Person{name="John",age=60},
	new Person{name="Joe",age=20},
	new Person{name="Kim",age=30},
	new Person{name="Mary",age=30},
	new Person{name="Lindsay",age=45}
	};
	
	var byName = people.GroupBy(p=>p.age,p=>p.name);
	Console.WriteLine(byName);
	
	foreach(var item in byName)
	{
	
	Console.WriteLine($"These People Are {item.Key} years old");
	foreach(var name in item)
	Console.WriteLine($"-{name}");
	}
	
	
}

class Person
{
public string name;
public int age;


}

// You can define other methods, fields, classes and namespaces here