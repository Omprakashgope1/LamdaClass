using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpression
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNum { get; set; }
        public string Address {  get; set; }
        public int Age {  get; set; }   
       
        public Student(int Id,string Name,string PhoneNum,string Address,int Age)
        {
            this.Age = Age;
            this.Id = Id;   
            this.Name = Name;
            this.PhoneNum = PhoneNum;
            this.Address = Address;
        }
        public override string ToString() 
        {
            return "Id of the student : " + this.Id
                + "\nName of the student : " + this.Name +
                "\nAge of the student :" + this.Age +
                "\nPhone number of the student :" + this.PhoneNum +
                "\nAddress of the student : " + this.Address +
                "\nPh. number of the student :" + this.PhoneNum;
        }
        
    }
}
