



using AttributeTask.Attributes;
using AttributeTask.Models;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

User user = new User("Sabir", "sabir@gmail.com", "S123456aa");
CheckValidation(user,new ValidEmail());
CheckValidation(user, new ValidPassword());


void CheckValidation<T,A>(T entity,A type) where A:ValidationAttribute
{
   PropertyInfo property= entity.GetType().GetProperties().FirstOrDefault(x => x.IsDefined(typeof(A)));
    if (property == null) 
    {
        Console.WriteLine($"There is no property in {entity.GetType().Name} with {typeof(A).Name} attribute");
        return;
    }
    if (type.IsValid(property.GetValue(entity)))
    {
        Console.WriteLine($"Value of {property.Name} property is valid according to {typeof(A).Name} validation attribute");
    }
    else
    {
        Console.WriteLine($"Value of {property.Name} property is NOT valid according to {typeof(A).Name} validation attribute");
    }

}