namespace Models2
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string UserName { get; set; }
        private string Password { get; set; }
        public int Grades { get; set; }

        public Student(string firstName, string lastName, string userName, string password, int grade = 0)
        {
            if (string.IsNullOrEmpty(userName))
            {
                throw new Exception("UserName must have a value");
            }
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;
            Grades = grade;
        }

        public bool CorrectPassword(string password)
        {
            return Password == password;
        }

        public int CalculateGrade(int points)
        {
            if (points == 1 || points == 0)
            {
                 Grades = 1;
            }
            else if (points == 2)
            {
                 Grades = 2;
            }
            else if (points == 3)
            {
                 Grades = 3;
            }
            else if (points == 4)
            {
                 Grades = 4;
            }
            else if (points == 5)
            {
                 Grades = 5;
            }
            return Grades;
        }
        public string PrintStudent()
        {
            string text = "";
            if(Grades > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                text += $"Student: {FullName} has grade: {Grades}";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                text += $"Student {FullName} didn't do the quizz";
                Console.ResetColor();
            }
            return text;
        }
    }
}