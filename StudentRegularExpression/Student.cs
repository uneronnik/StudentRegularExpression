using System;
using System.Text.RegularExpressions;

namespace StudentRegularExpression
{
    class Student
    {
        string _FIO;
        string _phoneNumber;
        string _avgMark;
        public string FIO
        {
            get => _FIO;
            set
            {
                string FIOPattern = @"^([А-Я][а-я]+\s){2}([А-Я][а-я]+)$";
                if (!Regex.IsMatch(value, FIOPattern))
                    throw new Exception("Incorrect FIO");
                _FIO = value;
            }
        }
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                string PhonePattern = @"^\+\d{1,2}\d{10}$";
                if (!Regex.IsMatch(value, PhonePattern))
                    throw new Exception("Incorrect Number");
                _phoneNumber = value;
            }
        }
        public string AvgMark
        {
            get => _avgMark;
            set
            {
                string MarkPattern = @"^([1-9]|1[0-2])$";
                if (!Regex.IsMatch(value, MarkPattern))
                    throw new Exception("Incorrect Mark");
                _avgMark = value;
            }
        }
        public string Scholarship
        {
            get 
            {
                int avgMark = Convert.ToInt32(AvgMark);
                if (avgMark <= 4)
                    return 0.ToString();
                else if (avgMark <= 8)
                    return 5000.ToString();
                else
                    return 10000.ToString();
            }
        }
        public override string ToString()
        {

            return $"FIO: {FIO}\n" +
                   $"Phone number: {PhoneNumber}\n" +
                   $"Average mark: {AvgMark}\n" +
                   $"Scholarship: {Scholarship}";
        }

    }
}
