using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationDemo
{
    internal class ValidationClass
    {
        public static void Test()
        {
            Employee empObj = new Employee();
            empObj.Name = "Dhanya";
            empObj.Age = 20;
            empObj.Phone = "1234567889";
            empObj.Email = "asfcsbnsjm@gmail.com";

            ValidationContext context = new ValidationContext(empObj, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(empObj, context, validationResults, true);

            if(!valid)
            {
                foreach(ValidationResult validationResult in validationResults)
                {
                    Console.WriteLine(validationResult);
                }
            }
            Console.WriteLine("Name : " + empObj.Name + "Age : " + empObj.Age + "Phone Number : " + empObj.Phone + "Email : " + empObj.Email);

        }
    }
}
