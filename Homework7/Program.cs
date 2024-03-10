namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer Alice = new Customer(cus_id:110, cus_name: "Alice", cus_age: 28);
            Customer Bob = new Customer(cus_id:111, cus_name: "Bob", cus_age: 30);
            Alice.PrintCusInfo();
            Bob.PrintCusInfo();
            Alice.ChangeID(220);
            Bob.ChangeID(221);
            Alice.PrintCusInfo();
            Bob.PrintCusInfo();
            Alice.CompareAge(Bob);

        }
    }
}
