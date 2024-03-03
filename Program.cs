Console.WriteLine("Number of Workers is {0}", Employee.EmployeeNumber);

Employee employee = new Employee("Deniz", "Malcom", "IT");
Console.WriteLine("Number of Workers is {0}", Employee.EmployeeNumber);
Employee employeeTwo = new Employee("Derin", "Malça", "IT");
Employee employeeThree = new Employee("Ahmet", "Balca", "IT");
Console.WriteLine("Number of Workers is {0}", Employee.EmployeeNumber);

//You can access this class only using this syntax. New keyword doesn't work.
Console.WriteLine("Sum of two numbers are : {0}", MathOperations.Sum(100, 200));
Console.WriteLine("Extraction of two numbers are : {0}", MathOperations.Subtrac(200, 50));
