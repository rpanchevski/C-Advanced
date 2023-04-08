
namespace Models2
{
    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        private string Password { get; set; }
        public List<Student> Students { get; set; }

        public Teacher(string firstName, string lastName, string userName, string password)
        {
            if (string.IsNullOrEmpty(userName))
            {
                throw new Exception("UserName must have a value");
            }
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;
        }

        public bool CorrectPassword(string password)
        {
            return Password == password;
        }
    }
}
