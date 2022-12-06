using System;

namespace Anonymous
{
    public class AnonymousObj
    {
        int? number = null; // Nullable<int> number = null;
        public void Test()
        {
            var obj = new { Name = "Hello", Age = 20 };
            Console.WriteLine(obj.Name + " " + obj.Age);
        }
        public void Test2()
        {
            if (this.number.HasValue)
            {
                Console.WriteLine(this.number.Value);
            }
            else
            {
                Console.WriteLine("Number is null");
            }
        }

        public string Number
        {
            get
            {
                return this.number.HasValue ? this.number.Value.ToString() : "Number is null";
            }
            set
            {
                int number;
                if (int.TryParse(value, out number))
                {
                    this.number = number;
                }
                else
                {
                    this.number = null;
                }
            }
        }
    }
}