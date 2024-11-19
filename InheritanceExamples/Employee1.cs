using System;
using System.Text.RegularExpressions;


namespace InheritanceExamples
{
    public class Employee1
    {
        protected int id;
        protected string name;
        protected double salary;
        protected double hra, da, pf, gross;

        public Employee1(int eid,string nm,double sal)
        {
            id = eid;
            name = nm;
            salary = sal;
        }

        public virtual void CalculateSalary()
        {
            hra = salary * 0.50; 
            da = salary * 0.20;
            pf = salary * 0.15;
            gross = (salary + hra + da) - pf;
        }
        

        public override string ToString()
        {
            return $"Id:{id} Name:{name} Gross Salary:{gross} ";
        }

    }
}
