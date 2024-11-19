using System;
//For Inheritance

namespace InheritanceExamples
{
    //child class/derived class
    public class SalesManager1:Employee1
    {
        //extensibility
        private double bonus, comm;
        //base keyword will call the base class constructor
        //reusability
        public SalesManager1(int eid,string nm, double sal, double bonus, double comm):base(eid,nm,sal)
        {
            this.bonus = bonus;
            this.comm = comm;
            
        }
        
        //Method Overriding
        //toString()-used to represent object into string format
        public override string ToString()
        {
            return $"Sales Manager Details:Id:{id} Name:{name} Gross Salary:{gross} Bonus:{bonus} Commisiom:{comm}";
        }
    }
}
