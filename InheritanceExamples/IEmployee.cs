using System;
using System.Runtime.InteropServices.WindowsRuntime;
/*3. A company has employees and wants to keep a track of their names, id and hours of work. 
 * The employees are specifically categorised into part-time and full-time. 
 * Salary needs to be calculated for both however, 
 * where part-time employees get 200 rs. 
 * Per hour and Full-time employees get 500 rs. per hour. 
 * Write a program which does the same.
*/

namespace InheritanceExamples
{
    public interface IEmployee
    {
        void GetSalary();
    }
    public class PartTime : IEmployee
    {
        double hours,salary;
        int id;
        string name;
        public PartTime(int id, string name, double hours)
        {
            this.id = id;
            this.name = name;
            this.hours = hours;

        }
        public void GetSalary()
        {
            salary = hours * 200;
        }

        public override string ToString()
        {
            return $"Id:{id} Name:{name} Working Hours:{hours} Salary:{salary}";
        }
    }
    public class FullTime : IEmployee
    {
        double hours, salary;
        int id;
        string name;
        public FullTime(int id, string name, double hours)
        {
            this.id = id;
            this.name = name;
            this.hours = hours;

        }
        public void GetSalary()
        {
            salary = hours * 500;
        }

        public override string ToString()
        {
            return $"Id:{id} Name:{name} Working Hours:{hours} Salary:{salary}";
        }
    }
}
