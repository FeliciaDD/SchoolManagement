using System;
namespace _Homework
{
    public class Student
    {
		public string name;
		public int creditLimited;

		public Student(string name, int creditLimited)
		{
			this.name = name;
			this.creditLimited = creditLimited;
		}

        public override string ToString(){
            return name + ": " + creditLimited;
        }
    }
}
