using System;
//For Polymorphism

namespace InheritanceExamples
{
    public class Ceo1:Employee1
    {
        //extensibility
        private string address;
        private string email;
        private double bonus;
        
        //reusability
        public Ceo1(int eid, string nm, double sal,string address,string email,double bonus):base(eid, nm, sal)
        {
            this.address = address;
            this.email = email;
            this.bonus = bonus;

        }
        //Method Overriding
        public override void CalculateSalary()
        {
            hra = salary * 0.30;
            da = salary * 0.25;
            pf = salary * 0.12;
            gross = (salary + hra + da+bonus) - pf;
        }

        //Method Overriding
        public override string ToString() // overriding method from base class (object)
        {
            return $"Ceo Details : Id:{id} Name:{name} Gross Salary:{gross} Email:{email} Address:{address}";
        }


    }
}
