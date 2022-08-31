using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AttributeTask.Attributes
{
    public class ValidEmail:ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value == null) return false;
            if (value.GetType() != typeof(string)) return false;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return regex.IsMatch((string)value);
        }
    }
}
