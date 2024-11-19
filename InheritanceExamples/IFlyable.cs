using System;
/*4. 
1.Write a C# program to create an interface Flyable with a method called FlyObj(). 
Create three classes Spacecraft, Airplane, and 
Helicopter that implement the Flyable interface. 
Implement the FlyObj() method for each of the three classes.
*/

namespace InheritanceExamples
{
    public interface IFlyable
    {
        void FlyObj();
    }
    public class Spacecraft : IFlyable 
    {
        public void FlyObj()
        {
            Console.WriteLine("Spacecraft Class");
        }
    }
    public class Airplane : IFlyable
    {
        public void FlyObj()
        {
            Console.WriteLine("Airplane Class");
        }
    }
    public class Helicopter : IFlyable
    {
        public void FlyObj()
        {
            Console.WriteLine("Helicopter Class");
        }
    }
}
