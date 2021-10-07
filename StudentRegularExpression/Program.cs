using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegularExpression
{

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            try
            {
                student.FIO = "Фоменко никита";
            }catch(Exception ex) { Console.WriteLine(ex.Message + "\n"); }
            student.FIO = "Фоменко Никита Александрович";
            Console.WriteLine(student + "\n");

            try
            {
                student.PhoneNumber = "+7 56 4";
            }
            catch (Exception ex) { Console.WriteLine(ex.Message + "\n"); }
            student.PhoneNumber = "+75437548995";
            Console.WriteLine(student + "\n");
            student.PhoneNumber = "+725437548995";
            Console.WriteLine(student + "\n");

            try
            {
                student.AvgMark = "13";
            }
            catch (Exception ex) { Console.WriteLine(ex.Message + "\n"); }
            student.AvgMark = "9";
            Console.WriteLine(student + "\n");
            student.AvgMark = "5";
            Console.WriteLine(student + "\n");
            student.AvgMark = "2";
            Console.WriteLine(student + "\n");
            Console.ReadKey();
        }
    }
}
