// See https://aka.ms/new-console-template for more information

using LEC_07___HW;

Person[] person = new Person[2];
person[0] = new Employee(7000,"Mor","Gan Yavne");
person[1] = new Customer("Mor@gmail.com", "Mor", "Gan Yavne");

Employee a = new Employee(7000, "Mor", "Gan Yavne");
     

foreach (Person p in person)
{
    Console.WriteLine($"{p.PrintInfo()}\n");
}

Console.WriteLine($"Your salary / 10: {a.DivideSalary()}");