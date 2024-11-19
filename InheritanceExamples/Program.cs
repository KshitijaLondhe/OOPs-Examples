using System;


namespace InheritanceExamples
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*SalesManager1 sm1 = new SalesManager1(101, "Raj", 45000, 1500, 700);
            sm1.CalculateSalary();
            Console.WriteLine(sm1);
            //want to print sm1 object info-toString()

            Employee1 e1 = new SalesManager1(102, "Swati", 55000, 1000, 900);
            e1.CalculateSalary();
            Console.WriteLine(e1);
            Console.WriteLine();

            Ceo1 c1 = new Ceo1(103, "Karan", 30000,"Pune","ab@gmail.com",15000);
            c1.CalculateSalary();
            Console.WriteLine(c1);
            //want to print sm1 object info-toString()

            Employee1 e2 = new Ceo1(104, "Pooja", 65000,"Mumbai","ac@gmail.com",900);
            e2.CalculateSalary();
            Console.WriteLine(e2);
            */

            //code for abstract class shape
            Circle c1 = new Circle(5);
            c1.calArea();
            c1.calPerimeter();
            Console.WriteLine(c1);
            Console.WriteLine();
            Triangle t1 = new Triangle(10, 20,30);
            t1.calArea();
            c1.calPerimeter();
            Console.WriteLine(t1);
            Console.WriteLine();
            Rectangle r1 = new Rectangle(10,20);
            r1.calArea();
            c1.calPerimeter();
            Console.WriteLine(r1);
            

            //Code for abstract class BankAccount
            /* SavingsAccount s1 = new SavingsAccount();
             s1.deposit(1000);
             Console.WriteLine("After Depostit "+s1);
             s1.withdraw(500);
             Console.WriteLine("After Withdrawl "+s1);
             Console.WriteLine();
             CurrentAccount c1 = new CurrentAccount();
             c1.deposit(700);
             Console.WriteLine("After Depostit " + c1);
             c1.withdraw(300);
             Console.WriteLine("After Withdrawl " + c1);
            */

            //code for interface Employee
            /*IEmployee e1 = new PartTime(101,"Raj",12);
            e1.GetSalary();
            Console.WriteLine(e1);
            Console.WriteLine();
            IEmployee e2 = new FullTime(102, "Pooja", 10);
            e2.GetSalary();
            Console.WriteLine(e2);
            Console.WriteLine();
            */

            //code for Flyable interface
           /* IFlyable i1 = new Spacecraft();
            i1.FlyObj();
            Console.WriteLine();
            IFlyable i2 = new Airplane();
            i2.FlyObj();
            Console.WriteLine();
            IFlyable i3 = new Helicopter();
            i3.FlyObj();
            Console.WriteLine();
           */
        }
    }
}
