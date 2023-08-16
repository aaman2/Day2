//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Serialization;

//namespace ConsoleAppIntro
//{
//    internal class EmployeeProgram
//    {
//       static void Main()
//        {
//            Employee e1 = new Employee();
            
//            e1.Id = 1001;
//            e1.Name = "Anil";
//            e1.Job = "Programmer";
//            e1.Salary = 10000;
//            e1.HireDate = Convert.ToDateTime("2020-01-04"); // year-MM-date
//            e1.Department = "Software";

//            Employee e2 = new Employee() {Id=1002,Name="Vijay", Job="Manager",Salary=25000, HireDate=DateTime.Now, Department="HR" };
            
//            List<Employee> employees = new List<Employee>() { e1, e2 };

//            employees.Add(new Employee() { Id = 1003, Name = "Lalita", Job = "UI Expert", Salary = 15000, HireDate = DateTime.Now, Department = "Designing" });
//            int choice=1;
//            do
//            {
//                Console.WriteLine("Press 1  to display all employees \n Press 2 to Add New Employee" +
//                    "\n Press 3 to display Employee Detail \n Press 4 to exit");
//                choice = Convert.ToInt32(Console.ReadLine());
//                if(choice == 1)
//                {
//                    Console.WriteLine("Id\t\tName\t\tJob\t\tSalary\t\tHireDate\t\tDepartment");
//                    foreach (Employee e in employees)
//                    {
//                        Console.WriteLine ($"{e.Id}\t\t{e.Name}\t\t{e.Job}\t\t{e.Salary}\t\t{e.HireDate}\t\t{e.Department}");
//                    }
//                }
//                else if(choice==2)
//                {
//                    Employee employee = new Employee();
//                    Console.WriteLine("Enter Employee Id");
//                    employee.Id = Convert.ToInt32(Console.ReadLine());
//                    Console.WriteLine("Enter Employee Name");
//                    employee.Name = Console.ReadLine();
//                    Console.WriteLine("Enter Employee Job");
//                    employee.Job = Console.ReadLine();
//                    Console.WriteLine("Enter Employee Salary");
//                    employee.Salary = Convert.ToDecimal(Console.ReadLine());
//                    Console.WriteLine("Enter Employee Hire Date");
//                    employee.HireDate = Convert.ToDateTime(Console.ReadLine());
//                    Console.WriteLine("Enter Employee Department");
//                    employee.Department = Console.ReadLine();
                    
//                    // logic to add employee

//                    employees.Add(employee);    

//                }
//                else if(choice==3)
//                {
//                    int eid;
//                    Console.WriteLine("enter employee id");
//                    eid = Convert.ToInt32(Console.ReadLine());
//                    Employee? e=employees.Find(e => e.Id == eid);
//                    if (e != null)
//                    {
//                        Console.WriteLine("Id\t\tName\t\tJob\t\tSalary\t\tHireDate\t\tDepartment");
//                        Console.WriteLine($"{e.Id}\t\t{e.Name}\t\t{e.Job}\t\t{e.Salary}\t\t{e.HireDate}\t\t{e.Department}");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Employee not found");
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Invalid Choice Try again");
//                }
//            } while (choice!=4);

//        }
//    }
//}
