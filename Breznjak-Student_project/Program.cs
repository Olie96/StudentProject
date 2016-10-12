using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breznjak_Student_project
{
    class Program
    {      
        static void Main(string[] args)
        {
            var validation = new ValidationClass();
            var container = new StudentContainer();
            bool validMessage = false;     
            string returnedOperation = null;     
            string operations;  
            do
            {
                do
                {
                    Console.Write("Operation: ");
                    operations = Console.ReadLine();        // unos operaije "enlist" ili "display"
                    if (!String.IsNullOrEmpty(operations))
                    {
                        if (!validation.EnteredOperationVerifier(operations))
                            Console.WriteLine("WRONG OPERATION!!");
                        returnedOperation = validation.ChosenOperation(operations);   
                        switch (returnedOperation)
                        {
                             case Operations.OperationDisplay:
                                {
                                    validMessage = true;
                                    Console.WriteLine("Students in a system:");
                                    
                                        var students = container.GetOrderedStudents().ToList();
                                        for (var i = 1; i <= students.Count;i++)
                                        {
                                            Console.WriteLine("{0}. {1};{2}-{3}", i, students[i-1].Surname, students[i - 1].Name, students[i - 1].Id);
                                        }
                                    break;
                                }   // u slucaju poruke DISPLAY zovemo primjerenu funkciju


                            case Operations.OperationEnlist:
                                {
                                    validMessage = true;
                                    string firstName;
                                    do
                                    {
                                        Console.WriteLine("Student");
                                        Console.Write("First name: ");
                                        firstName = Console.ReadLine();
                                        if (String.IsNullOrEmpty(firstName))
                                            Console.WriteLine("First name can't be null or empty");
                                    } while (!validation.NameSurnameCheck(firstName));

                                    string lastName;
                                    do
                                    {
                                        Console.Write("Last name: ");
                                        lastName = Console.ReadLine();
                                        if (String.IsNullOrEmpty(lastName))
                                            Console.WriteLine("Last name can't be null or empty");
                                    } while (!validation.NameSurnameCheck(lastName));

                                    Console.WriteLine("enter GPA: ");
                                    float gpa;
                                    while (!float.TryParse(Console.ReadLine(), out gpa))
                                    {
                                        Console.WriteLine("Invalid format, please input again!");
                                    };  
                                    container.AddStudent(firstName, lastName, gpa);
                                    break;
                                }   // u slucaju poruke ENLIST zovemo primjerenu funkciju



                            default:
                                {
                                    Console.WriteLine("Invalid operation!!!\nPlease insert your message again");
                                    validMessage = false;
                                    break;
                                }  // u slucaju pogresne poruke ispisujemo poruku te trazimo ponovan unost poruke 

                        }
                    }
                    else Console.WriteLine("String can't be null or empty");
                } while (!validation.EnteredOperationVerifier(operations) || validMessage == false || operations == "");  
            } while (returnedOperation != Operations.OperationDisplay);    

 //---------------
        }
    }
}