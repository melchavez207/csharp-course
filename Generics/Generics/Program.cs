using System;

namespace Generics
{
    public class GenericList<T> where T : notnull
    {
        public T Employee;

        public void GenericMethod(T param1, T param2)
        {
            Console.WriteLine($"Employee: {Employee}");
            Console.WriteLine($"Param1: {param1}");
            Console.WriteLine($"Param2: {param2}");
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public string Location { get; set; }

        public override string ToString()
        {
            return $"{Name} {Location}";
        }
    }

    public class Program
    {
        public static void Main()
        {
            var employeeClass = new GenericList<Employee>();
            var emp1 = new Employee() { Name = "Carlos", Location = "Canada" };
            var emp2 = new Employee() { Name = "Alberth", Location = "Bolivia" };
            var emp3 = new Employee() { Name = "Roberto", Location = "Peru" };

            employeeClass.Employee = emp1;

            employeeClass.GenericMethod(emp2, emp3);

            //var test1 = new Test();
            //ExampleClass test = null;
            //var list = new GenericList<ExampleClass>();

            ////list.Add(test1);
            //list.Add(test);
        }
    }

    // USE: Generics allow us to write type-safe and reusable code.
    // CONTEXT: C# allow us to define data types at runtime

    // Open and Closed Generic Types
    // Open Generic Type: An open generic type is a generic type that does not have its type arguments specified.
    // Closed Generic Type: A closed generic type, on the other hand, all parameters are specified.

    // 'where': Help us to define contraints. It restricts the kinds of types that may be used as arguments for a type.

    // Contraints: inform the compiler about the capabilities a type argument must have. Without any constraint, the type argument could be any type.

    // 1. struct
    // 2. class
    // 3. <base class name>
    // 4. <interface name>
    // 5. new()

    //public class GenericList<TType>
    //{
    //    public void Add(TType type)
    //    {
    //        Console.WriteLine(type.ToString());
    //    }
    //}

    //public interface IMyClass
    //{
    //}

    //public class Test : IMyClass
    //{
    //    public override string ToString()
    //    {
    //        return "Hola desde Test";
    //    }
    //}

    //public class ExampleClass : IMyClass
    //{
    //    public override string ToString()
    //    {
    //        return "This is a example";
    //    }
    //}

    //public class GenericList<TValue> where TValue : class
    //{
    //    public void Add(TValue type)
    //    {
    //        Console.WriteLine(type.ToString());
    //    }
    //}
}