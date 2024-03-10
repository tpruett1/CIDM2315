using System.Data.Common;

class Customer
{
private int id = 0;
public string name = string.Empty;
public int age = 0;
public Customer (int cus_id, string cus_name, int cus_age)
{
    id = cus_id;
    name = cus_name;
    age = cus_age;
}
public void ChangeID(int new_id)
{
    id = new_id;
}
public void PrintCusInfo()
{
    Console.WriteLine("Customer: " + id + " Name: " + name + " Age: " + age );
}
public void CompareAge(Customer objCustomer)
{
    if(this.age >= objCustomer.age)
    {
        Console.WriteLine(this.name + " is older.");
    }
    else
    {
        Console.WriteLine( objCustomer.name + " is older.");
    }

}

}