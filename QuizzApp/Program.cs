using System.Net.Http.Headers;
using Models2;

namespace QuizzAppHW
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student s1 = new Student("Ana", "Bogdanovska", "anab", "pass1");
            Student s2 = new Student("Bob", "Bobski", "bobb", "pass2");
            Student s3 = new Student("John", "Doe", "johnd", "pass3");

            Teacher t1 = new Teacher("Teacher1", "Teacher11", "teacher1", "pass4");
            Teacher t2 = new Teacher("Teacher2", "Teacher22", "teacher2", "pass5");

            List<Student> Students = new List<Student>() { s1, s2, s3 };
            List<Teacher> Teachers = new List<Teacher>() { t1, t2 };

            while (true)
            {
                Console.WriteLine("Please choose: \n\t1. Student\n\t2. Teacher");
                string inputOption = Console.ReadLine();

                if (!int.TryParse(inputOption, out int selectedOption))
                {
                    Console.WriteLine("Wrong option selected");
                    continue;
                }
                if (selectedOption < 1 || selectedOption > 2)
                {
                    Console.WriteLine("Wrong option selected");
                    continue;
                }
                if (selectedOption == 1)
                {
                    Student foundStudent = null;
                    int studentNotFound = 0;

                    while (true)
                    {
                        if (studentNotFound >= 3)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Username: ");
                            string inputUserName = Console.ReadLine();

                            Console.WriteLine("Password: ");
                            string inputPassword = Console.ReadLine();

                            foreach (Student s in Students)
                            {
                                if (s.UserName == inputUserName && s.CorrectPassword(inputPassword))
                                {
                                    foundStudent = s;
                                    int points = 0;
                                    if (s.Grades > 0)
                                    {
                                        Console.WriteLine("You have already made the test");
                                        break;
                                    }
                                    else
                                    {
                                        while (true)
                                        {
                                            Console.WriteLine("1Q. What is the capital of Tasmania?\n\t1. Dodoma\n\t2. Hobart\n\t3. Launceston\n\t4. Wellington");
                                            string answer1 = Console.ReadLine();
                                            if (!int.TryParse(answer1, out int studentAnswer))
                                            {
                                                Console.WriteLine("Wrong option selected");
                                                continue;
                                            }
                                            if (studentAnswer < 1 || studentAnswer > 4)
                                            {
                                                Console.WriteLine("Wrong option selected");
                                                continue;
                                            }
                                            if (studentAnswer == 2)
                                            {
                                                points++;
                                                break;
                                            }
                                            else  //ako e 1, 3 ili 4
                                            {
                                                break;
                                            }
                                        }
                                        while (true)
                                        {
                                            Console.WriteLine("2Q. What is the tallest building in the Republic of the Congo?\n\t1. Kinshasa Democratic Republic of the Congo Temple\n\t" +
                                             "2. Palais de la Nation\n\t3. Kongo Trade Centre\n\t4. Nabemba Tower");
                                            string answer2 = Console.ReadLine();
                                            if (!int.TryParse(answer2, out int studentAnswer2))
                                            {
                                                Console.WriteLine("Wrong option selected");
                                                continue;
                                            }
                                            if (studentAnswer2 < 1 || studentAnswer2 > 4)
                                            {
                                                Console.WriteLine("Wrong option selected");
                                                continue;
                                            }
                                            if (studentAnswer2 == 4)
                                            {
                                                points++;
                                                break;
                                            }
                                            else  //ako e broj pomegju 1, 2 ili 3
                                            {
                                                break;
                                            }
                                        }
                                        while (true)
                                        {
                                            Console.WriteLine("3Q. Which of these is not one of Pluto's moons?\n\t1. Styx\n\t" +
                                             "2. Hydra\n\t3. Nix\n\t4. Lugia");
                                            string answer3 = Console.ReadLine();
                                            if (!int.TryParse(answer3, out int studentAnswer3))
                                            {
                                                Console.WriteLine("Wrong option selected");
                                                continue;
                                            }
                                            if (studentAnswer3 < 1 || studentAnswer3 > 4)
                                            {
                                                Console.WriteLine("Wrong option selected");
                                                continue;
                                            }
                                            if (studentAnswer3 == 3)
                                            {
                                                points++;
                                                break;
                                            }
                                            else  //ako e broj pomegju 1, 2 ili 4
                                            {
                                                break;
                                            }
                                        }
                                        while (true)
                                        {
                                            Console.WriteLine("4Q. What is the smallest lake in the world?\n\t1. Onega Lake\n\t" +
                                             "2. Benxi Lake\n\t3. Kivu Lake\n\t4. Wakatipu Lake");
                                            string answer4 = Console.ReadLine();
                                            if (!int.TryParse(answer4, out int studentAnswer4))
                                            {
                                                Console.WriteLine("Wrong option selected");
                                                continue;
                                            }
                                            if (studentAnswer4 < 1 || studentAnswer4 > 4)
                                            {
                                                Console.WriteLine("Wrong option selected");
                                                continue;
                                            }
                                            if (studentAnswer4 == 2)
                                            {
                                                points++;
                                                break;
                                            }
                                            else  //ako e broj pomegju 1, 3 ili 4
                                            {
                                                break;
                                            }
                                        }
                                        while (true)
                                        {
                                            Console.WriteLine("5Q. What country has the largest population of alpacas?\n\t1. Chad\n\t" +
                                             "2. Peru \n\t3. Australia\n\t4. Niger");
                                            string answer5 = Console.ReadLine();
                                            if (!int.TryParse(answer5, out int studentAnswer5))
                                            {
                                                Console.WriteLine("Wrong option selected");
                                                continue;
                                            }
                                            if (studentAnswer5 < 1 || studentAnswer5 > 4)
                                            {
                                                Console.WriteLine("Wrong option selected");
                                                continue;
                                            }
                                            if (studentAnswer5 == 2)
                                            {
                                                points++;
                                                break;
                                            }
                                            else  //ako e broj pomegju 1, 3 ili 4
                                            {
                                                break;
                                            }
                                        }
                                        Console.WriteLine($"Grade: {s.CalculateGrade(points)}");
                                        Console.WriteLine(s.Grades);
                                        break;
                                    }

                                }
                            }
                            if (foundStudent == null)
                            {
                                studentNotFound++;
                                Console.WriteLine("Username and password do not match! PLease try again.");
                                continue;
                            }
                            break;
                        }
                    }
                }
                if (selectedOption == 2)
                {
                    Teacher foundTeacher = null;
                    int teacherNotFound = 0;

                    while (true)
                    {
                        if (teacherNotFound >= 3)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Username: ");
                            string inputUserName = Console.ReadLine();
                            Console.WriteLine("Password: ");
                            string inputPassword = Console.ReadLine();

                            foreach (Teacher t in Teachers)
                            {
                                if (t.UserName == inputUserName && t.CorrectPassword(inputPassword))
                                {
                                    foundTeacher = t;
                                    Console.WriteLine("Here are the grades for all students: ");
                                    foreach (Student s in Students)
                                    {
                                        Console.WriteLine(s.PrintStudent());
                                    }
                                    Console.WriteLine("To close the app enter X");
                                    var key = System.Console.ReadKey(true);
                                    if (key.Key == ConsoleKey.X)
                                    {
                                        break;
                                    }
                                }
                                break;
                            }

                            if (foundTeacher == null)
                            {
                                teacherNotFound++;
                                Console.WriteLine("Username and password do not match! PLease try again.");
                                continue;
                            }
                            break;

                        }
                    }


                }

            }

        }
    }
}
    

