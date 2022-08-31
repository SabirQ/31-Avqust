using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AttributeTask.Attributes
{
    public class ValidPassword: ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value == null) return false;
            if (value.GetType() != typeof(string))  return false;
            string password=(string)value;
            if (password.Length < 8||!Char.IsUpper(password[0])) return false;
            bool valid=false;
            bool valid2 = false;
           
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsDigit(password[i]))
                {
                    valid = true;
                }
                if (Char.IsLower(password[i]))
                {
                    valid2 = true;
                }
            }
            if (valid==true&&valid2==true) return true;

            return false ;
        }
    }
}
